
namespace vendas.FingerPrint
{
    partial class FormRegisterBiometric
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioTextFIR = new System.Windows.Forms.RadioButton();
            this.txtEnrollImageQuality = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioBinaryFIR = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonVerify = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonClearEnrollData = new System.Windows.Forms.Button();
            this.UserID = new System.Windows.Forms.Label();
            this.textPayload = new System.Windows.Forms.TextBox();
            this.buttonEnroll = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.comboDevice = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboSecurityLevel = new System.Windows.Forms.ComboBox();
            this.buttonSet = new System.Windows.Forms.Button();
            this.txtTimeout = new System.Windows.Forms.TextBox();
            this.txtVerifyImageQuality = new System.Windows.Forms.TextBox();
            this.buttonGet = new System.Windows.Forms.Button();
            this.StatusBar = new System.Windows.Forms.StatusBar();
            this.labStatus = new System.Windows.Forms.StatusBarPanel();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // radioTextFIR
            // 
            this.radioTextFIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioTextFIR.Location = new System.Drawing.Point(152, 40);
            this.radioTextFIR.Name = "radioTextFIR";
            this.radioTextFIR.Size = new System.Drawing.Size(120, 16);
            this.radioTextFIR.TabIndex = 1;
            this.radioTextFIR.Text = "Text FIR";
            // 
            // txtEnrollImageQuality
            // 
            this.txtEnrollImageQuality.Location = new System.Drawing.Point(160, 24);
            this.txtEnrollImageQuality.Name = "txtEnrollImageQuality";
            this.txtEnrollImageQuality.Size = new System.Drawing.Size(120, 20);
            this.txtEnrollImageQuality.TabIndex = 0;
            this.txtEnrollImageQuality.Text = "50";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioTextFIR);
            this.groupBox4.Controls.Add(this.radioBinaryFIR);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.buttonVerify);
            this.groupBox4.Location = new System.Drawing.Point(0, 384);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(440, 64);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Enroll";
            // 
            // radioBinaryFIR
            // 
            this.radioBinaryFIR.Checked = true;
            this.radioBinaryFIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioBinaryFIR.Location = new System.Drawing.Point(152, 16);
            this.radioBinaryFIR.Name = "radioBinaryFIR";
            this.radioBinaryFIR.Size = new System.Drawing.Size(120, 16);
            this.radioBinaryFIR.TabIndex = 0;
            this.radioBinaryFIR.TabStop = true;
            this.radioBinaryFIR.Text = "Binary FIR";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(24, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Data Type:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonVerify
            // 
            this.buttonVerify.Location = new System.Drawing.Point(312, 24);
            this.buttonVerify.Name = "buttonVerify";
            this.buttonVerify.Size = new System.Drawing.Size(104, 24);
            this.buttonVerify.TabIndex = 2;
            this.buttonVerify.Text = "&Verify";
            this.buttonVerify.Click += new System.EventHandler(this.buttonVerify_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(24, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Device:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonClearEnrollData);
            this.groupBox3.Controls.Add(this.UserID);
            this.groupBox3.Controls.Add(this.textPayload);
            this.groupBox3.Controls.Add(this.buttonEnroll);
            this.groupBox3.Location = new System.Drawing.Point(0, 280);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(440, 96);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Enroll";
            // 
            // buttonClearEnrollData
            // 
            this.buttonClearEnrollData.Location = new System.Drawing.Point(312, 56);
            this.buttonClearEnrollData.Name = "buttonClearEnrollData";
            this.buttonClearEnrollData.Size = new System.Drawing.Size(104, 24);
            this.buttonClearEnrollData.TabIndex = 2;
            this.buttonClearEnrollData.Text = "&Clear enroll data";
            this.buttonClearEnrollData.Click += new System.EventHandler(this.buttonClearEnrollData_Click);
            // 
            // UserID
            // 
            this.UserID.Location = new System.Drawing.Point(24, 24);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(120, 20);
            this.UserID.TabIndex = 15;
            this.UserID.Text = "UserID:";
            this.UserID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textPayload
            // 
            this.textPayload.Location = new System.Drawing.Point(160, 24);
            this.textPayload.Name = "textPayload";
            this.textPayload.Size = new System.Drawing.Size(120, 20);
            this.textPayload.TabIndex = 0;
            // 
            // buttonEnroll
            // 
            this.buttonEnroll.Location = new System.Drawing.Point(312, 24);
            this.buttonEnroll.Name = "buttonEnroll";
            this.buttonEnroll.Size = new System.Drawing.Size(104, 24);
            this.buttonEnroll.TabIndex = 1;
            this.buttonEnroll.Text = "&Enroll";
            this.buttonEnroll.Click += new System.EventHandler(this.buttonEnroll_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.buttonOpen);
            this.groupBox2.Controls.Add(this.comboDevice);
            this.groupBox2.Location = new System.Drawing.Point(0, 208);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(440, 64);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Device function";
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(312, 24);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(104, 24);
            this.buttonOpen.TabIndex = 1;
            this.buttonOpen.Text = "&Open";
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // comboDevice
            // 
            this.comboDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDevice.Location = new System.Drawing.Point(160, 24);
            this.comboDevice.Name = "comboDevice";
            this.comboDevice.Size = new System.Drawing.Size(120, 21);
            this.comboDevice.TabIndex = 0;
            this.comboDevice.SelectedIndexChanged += new System.EventHandler(this.comboDevice_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboSecurityLevel);
            this.groupBox1.Controls.Add(this.buttonSet);
            this.groupBox1.Controls.Add(this.txtTimeout);
            this.groupBox1.Controls.Add(this.txtVerifyImageQuality);
            this.groupBox1.Controls.Add(this.buttonGet);
            this.groupBox1.Controls.Add(this.txtEnrollImageQuality);
            this.groupBox1.Location = new System.Drawing.Point(0, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 152);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BSP Information";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(24, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Security Level:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(24, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Default Timeout:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(24, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Verify Image Quality:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Enroll Image Quality:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboSecurityLevel
            // 
            this.comboSecurityLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSecurityLevel.Items.AddRange(new object[] {
            "Normal"});
            this.comboSecurityLevel.Location = new System.Drawing.Point(160, 120);
            this.comboSecurityLevel.Name = "comboSecurityLevel";
            this.comboSecurityLevel.Size = new System.Drawing.Size(120, 21);
            this.comboSecurityLevel.TabIndex = 5;
            // 
            // buttonSet
            // 
            this.buttonSet.Location = new System.Drawing.Point(312, 56);
            this.buttonSet.Name = "buttonSet";
            this.buttonSet.Size = new System.Drawing.Size(104, 24);
            this.buttonSet.TabIndex = 3;
            this.buttonSet.Text = "&Set";
            this.buttonSet.Click += new System.EventHandler(this.buttonSet_Click);
            // 
            // txtTimeout
            // 
            this.txtTimeout.Location = new System.Drawing.Point(160, 88);
            this.txtTimeout.Name = "txtTimeout";
            this.txtTimeout.Size = new System.Drawing.Size(120, 20);
            this.txtTimeout.TabIndex = 4;
            this.txtTimeout.Text = "5000";
            // 
            // txtVerifyImageQuality
            // 
            this.txtVerifyImageQuality.Location = new System.Drawing.Point(160, 56);
            this.txtVerifyImageQuality.Name = "txtVerifyImageQuality";
            this.txtVerifyImageQuality.Size = new System.Drawing.Size(120, 20);
            this.txtVerifyImageQuality.TabIndex = 2;
            this.txtVerifyImageQuality.Text = "30";
            // 
            // buttonGet
            // 
            this.buttonGet.Location = new System.Drawing.Point(312, 24);
            this.buttonGet.Name = "buttonGet";
            this.buttonGet.Size = new System.Drawing.Size(104, 24);
            this.buttonGet.TabIndex = 1;
            this.buttonGet.Text = "&Get";
            this.buttonGet.Click += new System.EventHandler(this.buttonGet_Click);
            // 
            // StatusBar
            // 
            this.StatusBar.Location = new System.Drawing.Point(0, 460);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.labStatus});
            this.StatusBar.ShowPanels = true;
            this.StatusBar.Size = new System.Drawing.Size(452, 24);
            this.StatusBar.TabIndex = 15;
            // 
            // labStatus
            // 
            this.labStatus.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
            this.labStatus.Name = "labStatus";
            this.labStatus.Width = 435;
            // 
            // FormRegisterBiometric
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 484);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.StatusBar);
            this.Name = "FormRegisterBiometric";
            this.Text = "FormRegisterBiometric";
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioTextFIR;
        private System.Windows.Forms.TextBox txtEnrollImageQuality;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioBinaryFIR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonVerify;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonClearEnrollData;
        private System.Windows.Forms.Label UserID;
        private System.Windows.Forms.TextBox textPayload;
        private System.Windows.Forms.Button buttonEnroll;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.ComboBox comboDevice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboSecurityLevel;
        private System.Windows.Forms.Button buttonSet;
        private System.Windows.Forms.TextBox txtTimeout;
        private System.Windows.Forms.TextBox txtVerifyImageQuality;
        private System.Windows.Forms.Button buttonGet;
        private System.Windows.Forms.StatusBar StatusBar;
        private System.Windows.Forms.StatusBarPanel labStatus;
    }
}