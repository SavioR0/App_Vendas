//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//using NITGEN.SDK.NBioBSP;
//using Vendas.Management;

//namespace vendas.FingerPrint
//{
//    public class Form1 : Form, IView
//    {
//        NBioAPI m_NBioAPI;

//        short m_OpenedDeviceID;
//        NBioAPI.Type.HFIR m_hNewFIR;

//        NBioAPI.Type.FIR m_biFIR;
//        NBioAPI.Type.FIR_TEXTENCODE m_textFIR;
//        NBioAPI.Type.DEVICE_INFO_EX[] m_DeviceInfoEx;
//        private IContainer components;
//        private System.Windows.Forms.MenuItem menuFile;
//        private System.Windows.Forms.MenuItem menuExit;
//        private System.Windows.Forms.MenuItem menuSkin;
//        private System.Windows.Forms.MenuItem menuSkinLoad;
//        private System.Windows.Forms.GroupBox groupBox3;
//        private System.Windows.Forms.Button buttonClearEnrollData;
//        private System.Windows.Forms.Label UserID;
//        private System.Windows.Forms.TextBox textPayload;
//        private System.Windows.Forms.Button buttonEnroll;
//        private System.Windows.Forms.GroupBox groupBox4;
//        private System.Windows.Forms.RadioButton radioTextFIR;
//        private System.Windows.Forms.RadioButton radioBinaryFIR;
//        private System.Windows.Forms.Label label6;
//        private System.Windows.Forms.Button buttonVerify;
//        private System.Windows.Forms.OpenFileDialog openFileDialog;
//        private System.Windows.Forms.GroupBox groupBox1;
//        private System.Windows.Forms.Label label4;
//        private System.Windows.Forms.Label label3;
//        private System.Windows.Forms.Label label2;
//        private System.Windows.Forms.Label label1;
//        private System.Windows.Forms.ComboBox comboSecurityLevel;
//        private System.Windows.Forms.Button buttonSet;
//        private System.Windows.Forms.TextBox txtTimeout;
//        private System.Windows.Forms.TextBox txtVerifyImageQuality;
//        private System.Windows.Forms.Button buttonGet;
//        private System.Windows.Forms.TextBox txtEnrollImageQuality;
//        private System.Windows.Forms.StatusBar StatusBar;
//        private System.Windows.Forms.StatusBarPanel labStatus;
//        private System.Windows.Forms.MainMenu mainMenu1;
//        private System.Windows.Forms.GroupBox groupBox2;
//        private System.Windows.Forms.Label label5;
//        private System.Windows.Forms.Button buttonOpen;
//        private System.Windows.Forms.ComboBox comboDevice;

//        public Form Form{get { return this; }}

//        public Form1()
//        {
//            //
//            // Required for Windows Form Designer support
//            //
//            InitializeComponent();

//            //
//            // TODO: Add any constructor code after InitializeComponent call
//            //
//            m_NBioAPI = new NBioAPI();

//            m_OpenedDeviceID = NBioAPI.Type.DEVICE_ID.NONE;
//            m_hNewFIR = null;
//        }

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing)
//            {
//                if (components != null)
//                {
//                    components.Dispose();
//                }
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code
//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.components = new System.ComponentModel.Container();
//            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
//            this.menuFile = new System.Windows.Forms.MenuItem();
//            this.menuExit = new System.Windows.Forms.MenuItem();
//            this.menuSkin = new System.Windows.Forms.MenuItem();
//            this.menuSkinLoad = new System.Windows.Forms.MenuItem();
//            this.StatusBar = new System.Windows.Forms.StatusBar();
//            this.labStatus = new System.Windows.Forms.StatusBarPanel();
//            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
//            this.groupBox1 = new System.Windows.Forms.GroupBox();
//            this.label4 = new System.Windows.Forms.Label();
//            this.label3 = new System.Windows.Forms.Label();
//            this.label2 = new System.Windows.Forms.Label();
//            this.label1 = new System.Windows.Forms.Label();
//            this.comboSecurityLevel = new System.Windows.Forms.ComboBox();
//            this.buttonSet = new System.Windows.Forms.Button();
//            this.txtTimeout = new System.Windows.Forms.TextBox();
//            this.txtVerifyImageQuality = new System.Windows.Forms.TextBox();
//            this.buttonGet = new System.Windows.Forms.Button();
//            this.txtEnrollImageQuality = new System.Windows.Forms.TextBox();
//            this.groupBox2 = new System.Windows.Forms.GroupBox();
//            this.label5 = new System.Windows.Forms.Label();
//            this.buttonOpen = new System.Windows.Forms.Button();
//            this.comboDevice = new System.Windows.Forms.ComboBox();
//            this.groupBox3 = new System.Windows.Forms.GroupBox();
//            this.buttonClearEnrollData = new System.Windows.Forms.Button();
//            this.UserID = new System.Windows.Forms.Label();
//            this.textPayload = new System.Windows.Forms.TextBox();
//            this.buttonEnroll = new System.Windows.Forms.Button();
//            this.groupBox4 = new System.Windows.Forms.GroupBox();
//            this.radioTextFIR = new System.Windows.Forms.RadioButton();
//            this.radioBinaryFIR = new System.Windows.Forms.RadioButton();
//            this.label6 = new System.Windows.Forms.Label();
//            this.buttonVerify = new System.Windows.Forms.Button();
//            this.menuItem1 = new System.Windows.Forms.MenuItem();
//            this.menuItem2 = new System.Windows.Forms.MenuItem();
//            ((System.ComponentModel.ISupportInitialize)(this.labStatus)).BeginInit();
//            this.groupBox1.SuspendLayout();
//            this.groupBox2.SuspendLayout();
//            this.groupBox3.SuspendLayout();
//            this.groupBox4.SuspendLayout();
//            this.SuspendLayout();
//            // 
//            // mainMenu1
//            // 
//            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
//            this.menuFile,
//            this.menuSkin,
//            this.menuItem1});
//            // 
//            // menuFile
//            // 
//            this.menuFile.Index = 0;
//            this.menuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
//            this.menuExit});
//            this.menuFile.Text = "&File";
//            // 
//            // menuExit
//            // 
//            this.menuExit.Index = 0;
//            this.menuExit.Shortcut = System.Windows.Forms.Shortcut.CtrlX;
//            this.menuExit.Text = "E&xit";
//            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
//            // 
//            // menuSkin
//            // 
//            this.menuSkin.Index = 1;
//            this.menuSkin.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
//            this.menuSkinLoad});
//            this.menuSkin.Text = "&Skin";
//            // 
//            // menuSkinLoad
//            // 
//            this.menuSkinLoad.Index = 0;
//            this.menuSkinLoad.Text = "&Load...";
//            this.menuSkinLoad.Click += new System.EventHandler(this.menuSkinLoad_Click);
//            // 
//            // StatusBar
//            // 
//            this.StatusBar.Location = new System.Drawing.Point(0, 419);
//            this.StatusBar.Name = "StatusBar";
//            this.StatusBar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
//            this.labStatus});
//            this.StatusBar.ShowPanels = true;
//            this.StatusBar.Size = new System.Drawing.Size(456, 24);
//            this.StatusBar.TabIndex = 0;
//            // 
//            // labStatus
//            // 
//            this.labStatus.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
//            this.labStatus.Name = "labStatus";
//            this.labStatus.Width = 439;
//            // 
//            // groupBox1
//            // 
//            this.groupBox1.Controls.Add(this.label4);
//            this.groupBox1.Controls.Add(this.label3);
//            this.groupBox1.Controls.Add(this.label2);
//            this.groupBox1.Controls.Add(this.label1);
//            this.groupBox1.Controls.Add(this.comboSecurityLevel);
//            this.groupBox1.Controls.Add(this.buttonSet);
//            this.groupBox1.Controls.Add(this.txtTimeout);
//            this.groupBox1.Controls.Add(this.txtVerifyImageQuality);
//            this.groupBox1.Controls.Add(this.buttonGet);
//            this.groupBox1.Controls.Add(this.txtEnrollImageQuality);
//            this.groupBox1.Location = new System.Drawing.Point(8, 8);
//            this.groupBox1.Name = "groupBox1";
//            this.groupBox1.Size = new System.Drawing.Size(440, 152);
//            this.groupBox1.TabIndex = 11;
//            this.groupBox1.TabStop = false;
//            this.groupBox1.Text = "BSP Information";
//            // 
//            // label4
//            // 
//            this.label4.Location = new System.Drawing.Point(24, 120);
//            this.label4.Name = "label4";
//            this.label4.Size = new System.Drawing.Size(120, 20);
//            this.label4.TabIndex = 14;
//            this.label4.Text = "Security Level:";
//            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
//            // 
//            // label3
//            // 
//            this.label3.Location = new System.Drawing.Point(24, 88);
//            this.label3.Name = "label3";
//            this.label3.Size = new System.Drawing.Size(120, 20);
//            this.label3.TabIndex = 13;
//            this.label3.Text = "Default Timeout:";
//            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
//            // 
//            // label2
//            // 
//            this.label2.Location = new System.Drawing.Point(24, 56);
//            this.label2.Name = "label2";
//            this.label2.Size = new System.Drawing.Size(120, 20);
//            this.label2.TabIndex = 12;
//            this.label2.Text = "Verify Image Quality:";
//            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
//            // 
//            // label1
//            // 
//            this.label1.Location = new System.Drawing.Point(24, 24);
//            this.label1.Name = "label1";
//            this.label1.Size = new System.Drawing.Size(120, 20);
//            this.label1.TabIndex = 11;
//            this.label1.Text = "Enroll Image Quality:";
//            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
//            // 
//            // comboSecurityLevel
//            // 
//            this.comboSecurityLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
//            this.comboSecurityLevel.Location = new System.Drawing.Point(160, 120);
//            this.comboSecurityLevel.Name = "comboSecurityLevel";
//            this.comboSecurityLevel.Size = new System.Drawing.Size(120, 21);
//            this.comboSecurityLevel.TabIndex = 5;
//            // 
//            // buttonSet
//            // 
//            this.buttonSet.Location = new System.Drawing.Point(312, 56);
//            this.buttonSet.Name = "buttonSet";
//            this.buttonSet.Size = new System.Drawing.Size(104, 24);
//            this.buttonSet.TabIndex = 3;
//            this.buttonSet.Text = "&Set";
//            this.buttonSet.Click += new System.EventHandler(this.buttonSet_Click);
//            // 
//            // txtTimeout
//            // 
//            this.txtTimeout.Location = new System.Drawing.Point(160, 88);
//            this.txtTimeout.Name = "txtTimeout";
//            this.txtTimeout.Size = new System.Drawing.Size(120, 20);
//            this.txtTimeout.TabIndex = 4;
//            // 
//            // txtVerifyImageQuality
//            // 
//            this.txtVerifyImageQuality.Location = new System.Drawing.Point(160, 56);
//            this.txtVerifyImageQuality.Name = "txtVerifyImageQuality";
//            this.txtVerifyImageQuality.Size = new System.Drawing.Size(120, 20);
//            this.txtVerifyImageQuality.TabIndex = 2;
//            // 
//            // buttonGet
//            // 
//            this.buttonGet.Location = new System.Drawing.Point(312, 24);
//            this.buttonGet.Name = "buttonGet";
//            this.buttonGet.Size = new System.Drawing.Size(104, 24);
//            this.buttonGet.TabIndex = 1;
//            this.buttonGet.Text = "&Get";
//            this.buttonGet.Click += new System.EventHandler(this.buttonGet_Click);
//            // 
//            // txtEnrollImageQuality
//            // 
//            this.txtEnrollImageQuality.Location = new System.Drawing.Point(160, 24);
//            this.txtEnrollImageQuality.Name = "txtEnrollImageQuality";
//            this.txtEnrollImageQuality.Size = new System.Drawing.Size(120, 20);
//            this.txtEnrollImageQuality.TabIndex = 0;
//            // 
//            // groupBox2
//            // 
//            this.groupBox2.Controls.Add(this.label5);
//            this.groupBox2.Controls.Add(this.buttonOpen);
//            this.groupBox2.Controls.Add(this.comboDevice);
//            this.groupBox2.Location = new System.Drawing.Point(8, 168);
//            this.groupBox2.Name = "groupBox2";
//            this.groupBox2.Size = new System.Drawing.Size(440, 64);
//            this.groupBox2.TabIndex = 12;
//            this.groupBox2.TabStop = false;
//            this.groupBox2.Text = "Device function";
//            // 
//            // label5
//            // 
//            this.label5.Location = new System.Drawing.Point(24, 24);
//            this.label5.Name = "label5";
//            this.label5.Size = new System.Drawing.Size(120, 20);
//            this.label5.TabIndex = 15;
//            this.label5.Text = "Device:";
//            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
//            // 
//            // buttonOpen
//            // 
//            this.buttonOpen.Location = new System.Drawing.Point(312, 24);
//            this.buttonOpen.Name = "buttonOpen";
//            this.buttonOpen.Size = new System.Drawing.Size(104, 24);
//            this.buttonOpen.TabIndex = 1;
//            this.buttonOpen.Text = "&Open";
//            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
//            // 
//            // comboDevice
//            // 
//            this.comboDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
//            this.comboDevice.Location = new System.Drawing.Point(160, 24);
//            this.comboDevice.Name = "comboDevice";
//            this.comboDevice.Size = new System.Drawing.Size(120, 21);
//            this.comboDevice.TabIndex = 0;
//            this.comboDevice.SelectedIndexChanged += new System.EventHandler(this.comboDevice_SelectedIndexChanged);
//            // 
//            // groupBox3
//            // 
//            this.groupBox3.Controls.Add(this.buttonClearEnrollData);
//            this.groupBox3.Controls.Add(this.UserID);
//            this.groupBox3.Controls.Add(this.textPayload);
//            this.groupBox3.Controls.Add(this.buttonEnroll);
//            this.groupBox3.Location = new System.Drawing.Point(8, 240);
//            this.groupBox3.Name = "groupBox3";
//            this.groupBox3.Size = new System.Drawing.Size(440, 96);
//            this.groupBox3.TabIndex = 13;
//            this.groupBox3.TabStop = false;
//            this.groupBox3.Text = "Enroll";
//            // 
//            // buttonClearEnrollData
//            // 
//            this.buttonClearEnrollData.Location = new System.Drawing.Point(312, 56);
//            this.buttonClearEnrollData.Name = "buttonClearEnrollData";
//            this.buttonClearEnrollData.Size = new System.Drawing.Size(104, 24);
//            this.buttonClearEnrollData.TabIndex = 2;
//            this.buttonClearEnrollData.Text = "&Clear enroll data";
//            this.buttonClearEnrollData.Click += new System.EventHandler(this.buttonClearEnrollData_Click);
//            // 
//            // UserID
//            // 
//            this.UserID.Location = new System.Drawing.Point(24, 24);
//            this.UserID.Name = "UserID";
//            this.UserID.Size = new System.Drawing.Size(120, 20);
//            this.UserID.TabIndex = 15;
//            this.UserID.Text = "UserID:";
//            this.UserID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
//            // 
//            // textPayload
//            // 
//            this.textPayload.Location = new System.Drawing.Point(160, 24);
//            this.textPayload.Name = "textPayload";
//            this.textPayload.Size = new System.Drawing.Size(120, 20);
//            this.textPayload.TabIndex = 0;
//            // 
//            // buttonEnroll
//            // 
//            this.buttonEnroll.Location = new System.Drawing.Point(312, 24);
//            this.buttonEnroll.Name = "buttonEnroll";
//            this.buttonEnroll.Size = new System.Drawing.Size(104, 24);
//            this.buttonEnroll.TabIndex = 1;
//            this.buttonEnroll.Text = "&Enroll";
//            this.buttonEnroll.Click += new System.EventHandler(this.buttonEnroll_Click);
//            // 
//            // groupBox4
//            // 
//            this.groupBox4.Controls.Add(this.radioTextFIR);
//            this.groupBox4.Controls.Add(this.radioBinaryFIR);
//            this.groupBox4.Controls.Add(this.label6);
//            this.groupBox4.Controls.Add(this.buttonVerify);
//            this.groupBox4.Location = new System.Drawing.Point(8, 344);
//            this.groupBox4.Name = "groupBox4";
//            this.groupBox4.Size = new System.Drawing.Size(440, 64);
//            this.groupBox4.TabIndex = 14;
//            this.groupBox4.TabStop = false;
//            this.groupBox4.Text = "Enroll";
//            // 
//            // radioTextFIR
//            // 
//            this.radioTextFIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            this.radioTextFIR.Location = new System.Drawing.Point(152, 40);
//            this.radioTextFIR.Name = "radioTextFIR";
//            this.radioTextFIR.Size = new System.Drawing.Size(120, 16);
//            this.radioTextFIR.TabIndex = 1;
//            this.radioTextFIR.Text = "Text FIR";
//            // 
//            // radioBinaryFIR
//            // 
//            this.radioBinaryFIR.Checked = true;
//            this.radioBinaryFIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            this.radioBinaryFIR.Location = new System.Drawing.Point(152, 16);
//            this.radioBinaryFIR.Name = "radioBinaryFIR";
//            this.radioBinaryFIR.Size = new System.Drawing.Size(120, 16);
//            this.radioBinaryFIR.TabIndex = 0;
//            this.radioBinaryFIR.TabStop = true;
//            this.radioBinaryFIR.Text = "Binary FIR";
//            // 
//            // label6
//            // 
//            this.label6.Location = new System.Drawing.Point(24, 24);
//            this.label6.Name = "label6";
//            this.label6.Size = new System.Drawing.Size(120, 20);
//            this.label6.TabIndex = 15;
//            this.label6.Text = "Data Type:";
//            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
//            // 
//            // buttonVerify
//            // 
//            this.buttonVerify.Location = new System.Drawing.Point(312, 24);
//            this.buttonVerify.Name = "buttonVerify";
//            this.buttonVerify.Size = new System.Drawing.Size(104, 24);
//            this.buttonVerify.TabIndex = 2;
//            this.buttonVerify.Text = "&Verify";
//            this.buttonVerify.Click += new System.EventHandler(this.buttonVerify_Click);
//            // 
//            // menuItem1
//            // 
//            this.menuItem1.Index = 2;
//            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
//            this.menuItem2});
//            this.menuItem1.Text = "&Skin";
//            // 
//            // menuItem2
//            // 
//            this.menuItem2.Index = 0;
//            this.menuItem2.Text = "&Load...";
//            // 
//            // Form1
//            // 
//            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
//            this.ClientSize = new System.Drawing.Size(456, 443);
//            this.Controls.Add(this.groupBox4);
//            this.Controls.Add(this.groupBox3);
//            this.Controls.Add(this.groupBox2);
//            this.Controls.Add(this.groupBox1);
//            this.Controls.Add(this.StatusBar);
//            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
//            this.Menu = this.mainMenu1;
//            this.Name = "Form1";
//            this.Text = "BSPDemo for C#";
//            this.Closed += new System.EventHandler(this.Form1_Closed);
//            this.Load += new System.EventHandler(this.Form1_Load);
//            ((System.ComponentModel.ISupportInitialize)(this.labStatus)).EndInit();
//            this.groupBox1.ResumeLayout(false);
//            this.groupBox1.PerformLayout();
//            this.groupBox2.ResumeLayout(false);
//            this.groupBox3.ResumeLayout(false);
//            this.groupBox3.PerformLayout();
//            this.groupBox4.ResumeLayout(false);
//            this.ResumeLayout(false);

//        }
//        #endregion

//        [STAThread]
//        static void Main()
//        {
//            Application.Run(new Form1());
//        }

//        private void DisplayErrorMsg(string msg, uint ret)
//        {
//            labStatus.Text = msg + NBioAPI.Error.GetErrorDescription(ret) + " [" + ret.ToString() + "]";
//        }


//        private void Form1_Load(object sender, System.EventArgs e)
//        {
//            NBioAPI.Type.VERSION version = new NBioAPI.Type.VERSION();
//            m_NBioAPI.GetVersion(out version);

//            Text = String.Format("BSP Demo for C#.NET (BSP Version : v{0}.{1:D4})", version.Major, version.Minor);

//            // Set securitylevel to ComboList
//            comboSecurityLevel.Items.Add("Lowest");
//            comboSecurityLevel.Items.Add("Lower");
//            comboSecurityLevel.Items.Add("Low");
//            comboSecurityLevel.Items.Add("Below Normal");
//            comboSecurityLevel.Items.Add("Normal");
//            comboSecurityLevel.Items.Add("Above Normal");
//            comboSecurityLevel.Items.Add("High");
//            comboSecurityLevel.Items.Add("Higher");
//            comboSecurityLevel.Items.Add("Highest");

//            // Enumerate Device
//            int i;
//            uint nNumDevice;
//            short[] nDeviceID;
//            uint ret = m_NBioAPI.EnumerateDevice(out nNumDevice, out nDeviceID, out m_DeviceInfoEx);
//            DisplayErrorMsg("", ret);

//            comboDevice.Items.Add("Auto_Detect");
//            for (i = 0; i < nNumDevice; i++)
//            {
//                comboDevice.Items.Add(m_DeviceInfoEx[i].Name + " (ID:" + m_DeviceInfoEx[i].Instance.ToString("D2") + ")");
//            }

//            // Set default value
//            comboSecurityLevel.SelectedIndex = (int)NBioAPI.Type.FIR_SECURITY_LEVEL.NORMAL - 1;
//            comboDevice.SelectedIndex = 0;

//            buttonGet_Click("", new System.EventArgs());

//            buttonEnroll.Enabled = false;
//            buttonVerify.Enabled = false;
//            buttonClearEnrollData.Enabled = false;
//        }

//        private void Form1_Closed(object sender, System.EventArgs e)
//        {
//            // Close Device
//            m_NBioAPI.CloseDevice(m_OpenedDeviceID);
//        }

//        private void menuExit_Click(object sender, System.EventArgs e)
//        {
//            Close();
//        }

//        private void menuSkinLoad_Click(object sender, System.EventArgs e)
//        {
//            string szSkinFileName;

//            openFileDialog.Filter = "DLL files (*.dll)|*.dll|All files (*.*)|*.*";

//            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
//            {
//                szSkinFileName = openFileDialog.FileName;

//                if (szSkinFileName.Length != 0)
//                {
//                    // Set skin resource
//                    bool bRet = m_NBioAPI.SetSkinResource(szSkinFileName);
//                    if (bRet)
//                        labStatus.Text = "Set skin resource Success!";
//                    else
//                        labStatus.Text = "Set skin resource failed!";
//                }
//            }
//        }
//        private void buttonGet_Click(object sender, System.EventArgs e)
//        {
//            NBioAPI.Type.INIT_INFO_0 initInfo0;
//            uint ret = m_NBioAPI.GetInitInfo(out initInfo0);
//            if (ret == NBioAPI.Error.NONE)
//            {
//                txtEnrollImageQuality.Text = initInfo0.EnrollImageQuality.ToString();
//                txtVerifyImageQuality.Text = initInfo0.VerifyImageQuality.ToString();
//                txtTimeout.Text = initInfo0.DefaultTimeout.ToString();
//                comboSecurityLevel.SelectedIndex = (int)initInfo0.SecurityLevel - 1;

//                labStatus.Text = "Get BSP Information Success!";
//            }
//            else
//            {
//                labStatus.Text = "Get BSP Information Failed!";
//            }
//        }

//        private void buttonSet_Click(object sender, System.EventArgs e)
//        {
//            NBioAPI.Type.INIT_INFO_0 initInfo0;
//            uint ret = m_NBioAPI.GetInitInfo(out initInfo0);
//            if (ret == NBioAPI.Error.NONE)
//            {
//                try
//                {
//                    initInfo0.EnrollImageQuality = Convert.ToUInt32(txtEnrollImageQuality.Text);
//                    initInfo0.VerifyImageQuality = Convert.ToUInt32(txtVerifyImageQuality.Text);
//                    initInfo0.DefaultTimeout = Convert.ToUInt32(txtTimeout.Text);
//                    initInfo0.SecurityLevel = (uint)comboSecurityLevel.SelectedIndex + 1;
//                }
//                catch
//                {
//                    labStatus.Text = "Invalid parameter value!";
//                    MessageBox.Show(labStatus.Text);
//                    return;
//                }

//                ret = m_NBioAPI.SetInitInfo(initInfo0);
//                if (ret == NBioAPI.Error.NONE)
//                    labStatus.Text = "Set BSP Information Success!";
//                else
//                    labStatus.Text = "Set BSP Information Failed!";
//            }
//            else
//            {
//                labStatus.Text = "Get BSP Information Failed!";
//            }
//        }

//        private void buttonOpen_Click(object sender, System.EventArgs e)
//        {
//            short iDeviceID = NBioAPI.Type.DEVICE_ID.AUTO;

//            // Select device type
//            if (comboDevice.SelectedIndex > 0)
//                iDeviceID = (short)(m_DeviceInfoEx[comboDevice.SelectedIndex - 1].NameID + (m_DeviceInfoEx[comboDevice.SelectedIndex - 1].Instance << 8));
//            else
//                iDeviceID = NBioAPI.Type.DEVICE_ID.AUTO;

//            // Close Device if before opened
//            m_NBioAPI.CloseDevice(m_OpenedDeviceID);

//            // Open device
//            uint ret = m_NBioAPI.OpenDevice(iDeviceID);
//            if (ret == NBioAPI.Error.NONE)
//            {
//                m_OpenedDeviceID = iDeviceID;
//                buttonEnroll.Enabled = true;
//                labStatus.Text = "Device Open Success! - ";

//                if (comboDevice.SelectedIndex > 0)
//                    labStatus.Text += m_DeviceInfoEx[comboDevice.SelectedIndex - 1].Description;
//                else
//                    labStatus.Text += "Auto Detect Device";
//            }
//            else
//            {
//                DisplayErrorMsg("Device Open Failed! - ", ret);
//            }
//        }

//        private void buttonEnroll_Click(object sender, System.EventArgs e)
//        {
//            NBioAPI.Type.HFIR NewFIR;
//            NBioAPI.Type.FIR_PAYLOAD myPayload = new NBioAPI.Type.FIR_PAYLOAD();
//            myPayload.Data = textPayload.Text;

//            uint ret = m_NBioAPI.Enroll(ref m_hNewFIR, out NewFIR, myPayload, NBioAPI.Type.TIMEOUT.DEFAULT, null, null);

//            if (ret == NBioAPI.Error.NONE)
//            {
//                if (m_hNewFIR != null)
//                {
//                    // Free native memory
//                    m_hNewFIR.Dispose();
//                }

//                m_hNewFIR = NewFIR;

//                // If you want to save fir data then this FIR data write to DB or File.

//                // Get binary encoded FIR data
//                m_NBioAPI.GetFIRFromHandle(m_hNewFIR, out m_biFIR);

//                // Get text encoded FIR data
//                m_NBioAPI.GetTextFIRFromHandle(m_hNewFIR, out m_textFIR, true);

//                labStatus.Text = "Enroll Function Success!";

//                buttonVerify.Enabled = true;
//                buttonClearEnrollData.Enabled = true;
//            }
//            else
//            {
//                DisplayErrorMsg("Enroll Function Failed! - ", ret);
//            }
//        }

//        private void buttonVerify_Click(object sender, System.EventArgs e)
//        {
//            // Check exist enrolled fingerprint
//            if (m_textFIR.TextFIR.Length == 0)
//            {
//                MessageBox.Show("Can not find enrolled fingerprint!");
//                return;
//            }

//            uint ret;
//            bool result;
//            NBioAPI.Type.FIR_PAYLOAD myPayload = new NBioAPI.Type.FIR_PAYLOAD();


//            // Verify
//            if (radioBinaryFIR.Checked)
//                ret = m_NBioAPI.Verify(m_biFIR, out result, myPayload);         // Verify with binary FIR
//            else
//                ret = m_NBioAPI.Verify(m_textFIR, out result, myPayload);   // Verify with text encoded FIR

//            if (ret != NBioAPI.Error.NONE)
//            {
//                DisplayErrorMsg("Verify Function Failed! - ", ret);
//                return;
//            }

//            // Check result of verify
//            if (result)
//            {
//                // Check payload
//                if (myPayload.Data != null)
//                {
//                    MessageBox.Show("Verify Success! [" + myPayload.Data + "]", "BSP Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                    textPayload.Text = myPayload.Data;
//                }
//                else
//                {
//                    MessageBox.Show("Verify Success!", "BSP Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                }

//                labStatus.Text = "Verify Success!";
//            }
//            else
//            {
//                // Show fail message.
//                MessageBox.Show("Verify Failed!", "BSP Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                labStatus.Text = "Verify Failed!";
//            }
//        }

//        private void buttonClearEnrollData_Click(object sender, System.EventArgs e)
//        {
//            m_biFIR = null;
//            m_textFIR = null;
//            m_hNewFIR.Dispose();
//            m_hNewFIR = null;
//            buttonVerify.Enabled = false;
//            buttonClearEnrollData.Enabled = false;
//        }

//        private void comboDevice_SelectedIndexChanged(object sender, System.EventArgs e)
//        {
//            if (comboDevice.SelectedIndex > 0)
//                labStatus.Text = m_DeviceInfoEx[comboDevice.SelectedIndex - 1].Description;
//            else
//                labStatus.Text = "Auto Detect Device";
//        }

//        private MenuItem menuItem1;
//        private MenuItem menuItem2;
//    }
//}

