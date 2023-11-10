using NITGEN.SDK.NBioBSP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Vendas.Entity.Entities;

namespace Vendas.Communication
{
    public static class Biometry
    { 

        public static void Identify(out User user , NBioAPI.Type.HFIR hCapturedFIR = null, bool login = false, bool confirmLogin= false )
        {
            //listResult.ItemHs.Clear();
            // Get FIR data

            NBioAPI m_NBioAPI = new NBioAPI();
            user = null;
            if (confirmLogin)
            {
                m_NBioAPI.CloseDevice(NBioAPI.Type.DEVICE_ID.AUTO);
                return;
            }             
            uint ret;
            if (hCapturedFIR == null) 
            {
                NBioAPI.Type.WINDOW_OPTION window_option = new NBioAPI.Type.WINDOW_OPTION
                {
                    WindowStyle = 1
                };
                m_NBioAPI.OpenDevice(NBioAPI.Type.DEVICE_ID.AUTO);
                ret = m_NBioAPI.Capture(out hCapturedFIR,10000, window_option);

                if (ret == NBioAPI.Error.CAPTURE_FAKE_SUSPICIOUS)
                {
                    m_NBioAPI.CloseDevice(NBioAPI.Type.DEVICE_ID.AUTO);
                    throw new ArgumentException("Usuário não utilizou da digital");
                }

                if (ret != NBioAPI.Error.NONE)
                {
                    throw new Exception("Certifique-se que o leitor digital está conectado.");
                }

                m_NBioAPI.CloseDevice(NBioAPI.Type.DEVICE_ID.AUTO);
            }
           
            var users = Service.UserController.GetAll().ToList<User>();
            foreach (User use in users)
            {
                if (use.BiometryDataText == null) continue;
                NBioAPI.Type.FIR_PAYLOAD myPayload = new NBioAPI.Type.FIR_PAYLOAD();

                NBioAPI.Type.FIR_TEXTENCODE m_textFIR = new NBioAPI.Type.FIR_TEXTENCODE
                {
                    TextFIR = use.BiometryDataText
                };
                ret = m_NBioAPI.VerifyMatch(hCapturedFIR, m_textFIR, out bool result, myPayload);
                if (result == true)
                {
                    user = use;
                    return;
                }
            }
            if (login) {
                throw new ApplicationException("Usuário não cadastrado no sistema!");
            }
            m_NBioAPI.CloseDevice(NBioAPI.Type.DEVICE_ID.AUTO);
            return;
        }

        public static string RegisterBiometry(ref byte[] biometryDataBinary, ref string biometryDataText)
        {
            //AppManager.Instance.Load<LoaderController, User>(new Biometric(this));
            NBioAPI m_NBioAPI = new NBioAPI();

            // Get FIR data
            m_NBioAPI.OpenDevice(NBioAPI.Type.DEVICE_ID.AUTO);
            uint ret = m_NBioAPI.Enroll(out NBioAPI.Type.HFIR hNewFIR, null);
            if (ret != NBioAPI.Error.NONE)
            {
                //MessageBox.Show("Certifique-se que o leitor digital está conectado.\n " + NBioAPI.Error.GetErrorDescription(ret) + " [" + ret.ToString() + "]", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                m_NBioAPI.CloseDevice(NBioAPI.Type.DEVICE_ID.AUTO);
                return "Certifique-se que o leitor digital está conectado.";
            }
            m_NBioAPI.CloseDevice(NBioAPI.Type.DEVICE_ID.AUTO);

            // Transformando um Text
            m_NBioAPI.GetTextFIRFromHandle(hNewFIR, out NBioAPI.Type.FIR_TEXTENCODE textFIR, true);
            Identify(out User user, hCapturedFIR: hNewFIR);
            if (user  != null) return "Digital já cadastrada no sistema.";

            // Trasnformando em Binario
            m_NBioAPI.GetFIRFromHandle(hNewFIR, out NBioAPI.Type.FIR biFIR);

            biometryDataText = textFIR.TextFIR;
            biometryDataBinary = biFIR.Data;

            return "";
        }
    }
}
