using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NITGEN.SDK.NBioBSP;
using Vendas.Management;

namespace vendas.FingerPrint
{
    public partial class FormRegisterBiometric : Form, IView
    {
        public Form Form { get { return this; } }

        NBioAPI m_NBioAPI;

        short m_OpenedDeviceID;
        NBioAPI.Type.HFIR m_hNewFIR;

        NBioAPI.Type.FIR m_biFIR;
        NBioAPI.Type.FIR_TEXTENCODE m_textFIR;
        NBioAPI.Type.DEVICE_INFO_EX[] m_DeviceInfoEx;

        public FormRegisterBiometric()
        {
            InitializeComponent();
            m_NBioAPI = new NBioAPI();

            m_OpenedDeviceID = NBioAPI.Type.DEVICE_ID.NONE;
            m_hNewFIR = null;
            NBioAPI.Type.VERSION version = new NBioAPI.Type.VERSION();
            // Set securitylevel to ComboList
            comboSecurityLevel.Items.Add("Lowest");
            comboSecurityLevel.Items.Add("Lower");
            comboSecurityLevel.Items.Add("Low");
            comboSecurityLevel.Items.Add("Below Normal");
            comboSecurityLevel.Items.Add("Normal");
            comboSecurityLevel.Items.Add("Above Normal");
            comboSecurityLevel.Items.Add("High");
            comboSecurityLevel.Items.Add("Higher");
            comboSecurityLevel.Items.Add("Highest");

            // Enumerate Device
            int i;
            uint nNumDevice;
            short[] nDeviceID;
            uint ret = m_NBioAPI.EnumerateDevice(out nNumDevice, out nDeviceID, out m_DeviceInfoEx);
            DisplayErrorMsg("", ret);

            comboDevice.Items.Add("Auto_Detect");
            for (i = 0; i < nNumDevice; i++)
            {
                comboDevice.Items.Add(m_DeviceInfoEx[i].Name + " (ID:" + m_DeviceInfoEx[i].Instance.ToString("D2") + ")");
            }

            // Set default value
            comboSecurityLevel.SelectedIndex = (int)NBioAPI.Type.FIR_SECURITY_LEVEL.NORMAL - 1;
            comboDevice.SelectedIndex = 0;

            buttonGet_Click("", new System.EventArgs());

            buttonEnroll.Enabled = false;
            buttonVerify.Enabled = false;
            buttonClearEnrollData.Enabled = false;
        }

        private void DisplayErrorMsg(string msg, uint ret)
        {
            labStatus.Text = msg + NBioAPI.Error.GetErrorDescription(ret) + " [" + ret.ToString() + "]";
        }

        private void buttonGet_Click(object sender, System.EventArgs e)
        {
            NBioAPI.Type.INIT_INFO_0 initInfo0;
            uint ret = m_NBioAPI.GetInitInfo(out initInfo0);
            if (ret == NBioAPI.Error.NONE)
            {
                txtEnrollImageQuality.Text = initInfo0.EnrollImageQuality.ToString();
                txtVerifyImageQuality.Text = initInfo0.VerifyImageQuality.ToString();
                txtTimeout.Text = initInfo0.DefaultTimeout.ToString();
                comboSecurityLevel.SelectedIndex = (int)initInfo0.SecurityLevel - 1;

                labStatus.Text = "Get BSP Information Success!";
            }
            else
            {
                labStatus.Text = "Get BSP Information Failed!";
            }
        }

        private void buttonSet_Click(object sender, System.EventArgs e)
        {
            NBioAPI.Type.INIT_INFO_0 initInfo0;
            uint ret = m_NBioAPI.GetInitInfo(out initInfo0);
            if (ret == NBioAPI.Error.NONE)
            {
                try
                {
                    initInfo0.EnrollImageQuality = Convert.ToUInt32(txtEnrollImageQuality.Text);
                    initInfo0.VerifyImageQuality = Convert.ToUInt32(txtVerifyImageQuality.Text);
                    initInfo0.DefaultTimeout = Convert.ToUInt32(txtTimeout.Text);
                    initInfo0.SecurityLevel = (uint)comboSecurityLevel.SelectedIndex + 1;
                }
                catch
                {
                    labStatus.Text = "Invalid parameter value!";
                    MessageBox.Show(labStatus.Text);
                    return;
                }

                ret = m_NBioAPI.SetInitInfo(initInfo0);
                if (ret == NBioAPI.Error.NONE)
                    labStatus.Text = "Set BSP Information Success!";
                else
                    labStatus.Text = "Set BSP Information Failed!";
            }
            else
            {
                labStatus.Text = "Get BSP Information Failed!";
            }
        }

        private void buttonOpen_Click(object sender, System.EventArgs e)
        {
            short iDeviceID = NBioAPI.Type.DEVICE_ID.AUTO;

            // Select device type
            if (comboDevice.SelectedIndex > 0)
                iDeviceID = (short)(m_DeviceInfoEx[comboDevice.SelectedIndex - 1].NameID + (m_DeviceInfoEx[comboDevice.SelectedIndex - 1].Instance << 8));
            else
                iDeviceID = NBioAPI.Type.DEVICE_ID.AUTO;

            // Close Device if before opened
            m_NBioAPI.CloseDevice(m_OpenedDeviceID);

            // Open device
            uint ret = m_NBioAPI.OpenDevice(iDeviceID);
            if (ret == NBioAPI.Error.NONE)
            {
                m_OpenedDeviceID = iDeviceID;
                buttonEnroll.Enabled = true;
                labStatus.Text = "Device Open Success! - ";

                if (comboDevice.SelectedIndex > 0)
                    labStatus.Text += m_DeviceInfoEx[comboDevice.SelectedIndex - 1].Description;
                else
                    labStatus.Text += "Auto Detect Device";
            }
            else
            {
                DisplayErrorMsg("Device Open Failed! - ", ret);
            }
        }

        private void buttonEnroll_Click(object sender, System.EventArgs e)
        {
            NBioAPI.Type.HFIR NewFIR;
            NBioAPI.Type.FIR_PAYLOAD myPayload = new NBioAPI.Type.FIR_PAYLOAD();
            myPayload.Data = textPayload.Text;

            uint ret = m_NBioAPI.Enroll(ref m_hNewFIR, out NewFIR, myPayload, NBioAPI.Type.TIMEOUT.DEFAULT, null, null);

            if (ret == NBioAPI.Error.NONE)
            {
                if (m_hNewFIR != null)
                {
                    // Free native memory
                    m_hNewFIR.Dispose();
                }

                m_hNewFIR = NewFIR;

                // If you want to save fir data then this FIR data write to DB or File.

                // Get binary encoded FIR data
                m_NBioAPI.GetFIRFromHandle(m_hNewFIR, out m_biFIR);

                // Get text encoded FIR data
                m_NBioAPI.GetTextFIRFromHandle(m_hNewFIR, out m_textFIR, true);

                labStatus.Text = "Enroll Function Success!";

                buttonVerify.Enabled = true;
                buttonClearEnrollData.Enabled = true;
            }
            else
            {
                DisplayErrorMsg("Enroll Function Failed! - ", ret);
            }
        }

        private void buttonVerify_Click(object sender, System.EventArgs e)
        {
            // Check exist enrolled fingerprint
            if (m_textFIR.TextFIR.Length == 0)
            {
                MessageBox.Show("Can not find enrolled fingerprint!");
                return;
            }

            uint ret;
            bool result;
            NBioAPI.Type.FIR_PAYLOAD myPayload = new NBioAPI.Type.FIR_PAYLOAD();


            // Verify
            if (radioBinaryFIR.Checked)
                ret = m_NBioAPI.Verify(m_biFIR, out result, myPayload);         // Verify with binary FIR
            else
                ret = m_NBioAPI.Verify(m_textFIR, out result, myPayload);   // Verify with text encoded FIR

            if (ret != NBioAPI.Error.NONE)
            {
                DisplayErrorMsg("Verify Function Failed! - ", ret);
                return;
            }

            // Check result of verify
            if (result)
            {
                // Check payload
                if (myPayload.Data != null)
                {
                    MessageBox.Show("Verify Success! [" + myPayload.Data + "]", "BSP Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textPayload.Text = myPayload.Data;
                }
                else
                {
                    MessageBox.Show("Verify Success!", "BSP Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                labStatus.Text = "Verify Success!";
            }
            else
            {
                // Show fail message.
                MessageBox.Show("Verify Failed!", "BSP Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
                labStatus.Text = "Verify Failed!";
            }
        }

        private void buttonClearEnrollData_Click(object sender, System.EventArgs e)
        {
            m_biFIR = null;
            m_textFIR = null;
            m_hNewFIR.Dispose();
            m_hNewFIR = null;
            buttonVerify.Enabled = false;
            buttonClearEnrollData.Enabled = false;
        }

        private void comboDevice_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (comboDevice.SelectedIndex > 0)
                labStatus.Text = m_DeviceInfoEx[comboDevice.SelectedIndex - 1].Description;
            else
                labStatus.Text = "Auto Detect Device";
        }
    }
}
