using NITGEN.SDK.NBioBSP;
using System.Windows.Forms;
using Vendas.Entity.Entities;

namespace Vendas.Communication
{
    public static class Biometry
    { 

        public static User Identify(NBioAPI.Type.HFIR hCapturedFIR = null, bool login = false)
        {
            //listResult.ItemHs.Clear();
            // Get FIR data
            NBioAPI m_NBioAPI = new NBioAPI();
            uint ret;

            if (hCapturedFIR == null) 
            {
                m_NBioAPI.OpenDevice(NBioAPI.Type.DEVICE_ID.AUTO);
                ret = m_NBioAPI.Capture(out hCapturedFIR);
                if (ret != NBioAPI.Error.NONE)
                {
                    MessageBox.Show("Certifique-se que o leitor digital está conectado.\n " + NBioAPI.Error.GetErrorDescription(ret) + " [" + ret.ToString() + "]", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    m_NBioAPI.CloseDevice(NBioAPI.Type.DEVICE_ID.AUTO);
                    return null;
                }
                m_NBioAPI.CloseDevice(NBioAPI.Type.DEVICE_ID.AUTO);
            }

            var users = Service.UserController.GetAll();
            foreach (User user in users)
            {
                if (user.BiometryDataText == null) continue;
                NBioAPI.Type.FIR_PAYLOAD myPayload = new NBioAPI.Type.FIR_PAYLOAD();

                NBioAPI.Type.FIR_TEXTENCODE m_textFIR = new NBioAPI.Type.FIR_TEXTENCODE();
                m_textFIR.TextFIR = user.BiometryDataText;
                ret = m_NBioAPI.VerifyMatch(hCapturedFIR, m_textFIR, out bool result, myPayload);
                if (result == true) return user;
            }
            if (login) MessageBox.Show("Certifique-se de que a biometria esteja cadastrada no sistema.", "Biometria não cadastrada! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }

        public static string RegisterBiometry(ref byte[] biometryDataBinary, ref string biometryDataText)
        {
            //AppManager.Instance.Load<LoaderController, User>(new Biometric(this));
            NBioAPI m_NBioAPI = new NBioAPI();
            NBioAPI.Type.HFIR hNewFIR;

            // Get FIR data
            m_NBioAPI.OpenDevice(NBioAPI.Type.DEVICE_ID.AUTO);
            uint ret = m_NBioAPI.Enroll(out hNewFIR, null);
            if (ret != NBioAPI.Error.NONE)
            {
                //MessageBox.Show("Certifique-se que o leitor digital está conectado.\n " + NBioAPI.Error.GetErrorDescription(ret) + " [" + ret.ToString() + "]", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                m_NBioAPI.CloseDevice(NBioAPI.Type.DEVICE_ID.AUTO);
                return "Certifique-se que o leitor digital está conectado.\n " + NBioAPI.Error.GetErrorDescription(ret) + " [" + ret.ToString() + "]";
            }
            m_NBioAPI.CloseDevice(NBioAPI.Type.DEVICE_ID.AUTO);

            // Transformando um Text
            NBioAPI.Type.FIR_TEXTENCODE textFIR;
            m_NBioAPI.GetTextFIRFromHandle(hNewFIR, out textFIR, true);

            if (Identify(hNewFIR)!= null) return "Digital já cadastrada no sistema.";

            // Trasnformando em Binario
            NBioAPI.Type.FIR biFIR;
            m_NBioAPI.GetFIRFromHandle(hNewFIR, out biFIR);

            biometryDataText = textFIR.TextFIR;
            biometryDataBinary = biFIR.Data;

            return "";
        }
    }
}
