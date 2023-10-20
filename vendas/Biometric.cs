using NITGEN.SDK.NBioBSP;
using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using Vendas.Communication;
using Vendas.Entity.Entities;
using Vendas.Management;
using Vendas.View;

namespace vendas
{
    public class Biometric : System.Windows.Forms.Form, IView
    {
        NBioAPI m_NBioAPI;
        NBioAPI.IndexSearch m_IndexSearch;

        FormRegisterUser _formRegisterUser;
        public Form Form { get { return this; } }

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRegist;
        private System.Windows.Forms.ColumnHeader columnUserID;
        private System.Windows.Forms.ColumnHeader columnFpID;
        private System.Windows.Forms.ColumnHeader columnSampleNo;
        private System.Windows.Forms.TextBox textUserID;
        private System.Windows.Forms.ListView listSearchDB;
        private System.Windows.Forms.ListView listResult;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnIdentify;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDBRemove;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.Button btnDBClear;
        private System.Windows.Forms.ProgressBar progressIdentify;

        private System.ComponentModel.Container components = null;

        public Biometric(FormRegisterUser formRegisterUser)
        {

            InitializeComponent();
            _formRegisterUser = formRegisterUser;

            m_NBioAPI = new NBioAPI();
            m_IndexSearch = new NBioAPI.IndexSearch(m_NBioAPI);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegist = new System.Windows.Forms.Button();
            this.textUserID = new System.Windows.Forms.TextBox();
            this.listSearchDB = new System.Windows.Forms.ListView();
            this.columnUserID = new System.Windows.Forms.ColumnHeader();
            this.columnFpID = new System.Windows.Forms.ColumnHeader();
            this.columnSampleNo = new System.Windows.Forms.ColumnHeader();
            this.listResult = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnIdentify = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDBRemove = new System.Windows.Forms.Button();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.btnDBClear = new System.Windows.Forms.Button();
            this.progressIdentify = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnRegist);
            this.groupBox1.Controls.Add(this.textUserID);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 64);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registration";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "UserID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnRegist
            // 
            this.btnRegist.Location = new System.Drawing.Point(168, 24);
            this.btnRegist.Name = "btnRegist";
            this.btnRegist.Size = new System.Drawing.Size(112, 24);
            this.btnRegist.TabIndex = 1;
            this.btnRegist.Text = "Regist FP to DB";
            this.btnRegist.Click += new System.EventHandler(this.btnRegist_Click);
            // 
            // textUserID
            // 
            this.textUserID.Location = new System.Drawing.Point(64, 24);
            this.textUserID.Name = "textUserID";
            this.textUserID.Size = new System.Drawing.Size(88, 20);
            this.textUserID.TabIndex = 0;
            this.textUserID.Text = "";
            // 
            // listSearchDB
            // 
            this.listSearchDB.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                                                                                           this.columnUserID,
                                                                                           this.columnFpID,
                                                                                           this.columnSampleNo});
            this.listSearchDB.FullRowSelect = true;
            this.listSearchDB.GridLines = true;
            this.listSearchDB.Location = new System.Drawing.Point(8, 80);
            this.listSearchDB.Name = "listSearchDB";
            this.listSearchDB.Size = new System.Drawing.Size(296, 232);
            this.listSearchDB.TabIndex = 0;
            this.listSearchDB.View = System.Windows.Forms.View.Details;
            // 
            // columnUserID
            // 
            this.columnUserID.Text = "User ID";
            this.columnUserID.Width = 93;
            // 
            // columnFpID
            // 
            this.columnFpID.Text = "Fp ID";
            this.columnFpID.Width = 101;
            // 
            // columnSampleNo
            // 
            this.columnSampleNo.Text = "Sample No.";
            this.columnSampleNo.Width = 93;
            // 
            // listResult
            // 
            this.listResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                                                                                         this.columnHeader1,
                                                                                         this.columnHeader2,
                                                                                         this.columnHeader3});
            this.listResult.FullRowSelect = true;
            this.listResult.GridLines = true;
            this.listResult.Location = new System.Drawing.Point(312, 80);
            this.listResult.Name = "listResult";
            this.listResult.Size = new System.Drawing.Size(296, 232);
            this.listResult.TabIndex = 5;
            this.listResult.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "User ID";
            this.columnHeader1.Width = 93;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Fp ID";
            this.columnHeader2.Width = 101;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Sample No.";
            this.columnHeader3.Width = 95;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.progressIdentify);
            this.groupBox2.Controls.Add(this.btnIdentify);
            this.groupBox2.Location = new System.Drawing.Point(312, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 64);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // btnIdentify
            // 
            this.btnIdentify.Location = new System.Drawing.Point(88, 16);
            this.btnIdentify.Name = "btnIdentify";
            this.btnIdentify.Size = new System.Drawing.Size(120, 24);
            this.btnIdentify.TabIndex = 1;
            this.btnIdentify.Text = "Identify User";
            this.btnIdentify.Click += new System.EventHandler(this.btnIdentify_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(480, 352);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(128, 24);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "&Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDBRemove
            // 
            this.btnDBRemove.Location = new System.Drawing.Point(8, 320);
            this.btnDBRemove.Name = "btnDBRemove";
            this.btnDBRemove.Size = new System.Drawing.Size(144, 24);
            this.btnDBRemove.TabIndex = 1;
            this.btnDBRemove.Text = "Remove Data";
            this.btnDBRemove.Click += new System.EventHandler(this.btnDBRemove_Click);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(160, 320);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(144, 24);
            this.btnSaveFile.TabIndex = 2;
            this.btnSaveFile.Text = "Save DB to File";
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(160, 352);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(144, 24);
            this.btnLoadFile.TabIndex = 4;
            this.btnLoadFile.Text = "Load DB from File";
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // btnDBClear
            // 
            this.btnDBClear.Location = new System.Drawing.Point(8, 352);
            this.btnDBClear.Name = "btnDBClear";
            this.btnDBClear.Size = new System.Drawing.Size(144, 24);
            this.btnDBClear.TabIndex = 3;
            this.btnDBClear.Text = "Clear DB";
            this.btnDBClear.Click += new System.EventHandler(this.btnDBClear_Click);
            // 
            // progressIdentify
            // 
            this.progressIdentify.Location = new System.Drawing.Point(8, 48);
            this.progressIdentify.Name = "progressIdentify";
            this.progressIdentify.Size = new System.Drawing.Size(280, 8);
            this.progressIdentify.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(616, 381);
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.btnDBClear);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.btnDBRemove);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listResult);
            this.Controls.Add(this.listSearchDB);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "IndexSearch Demo for C#";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Closed += new System.EventHandler(this.Form1_Closed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private void Form1_Load(object sender, System.EventArgs e)
        {
            uint ret = m_IndexSearch.InitEngine();
            if (ret != NBioAPI.Error.NONE)
            {
                DisplayErrorMsg(ret);
            }


            NBioAPI.Type.VERSION version = new NBioAPI.Type.VERSION();
            m_NBioAPI.GetVersion(out version);

            Text = String.Format("IndexSearch Demo for C#.NET using class library (BSP Version : v{0}.{1:D4})", version.Major, version.Minor);

            textUserID.Text = "1";

            listSearchDB.Items.Clear();
            listResult.Items.Clear();
        }

        private void Form1_Closed(object sender, System.EventArgs e)
        {
            m_IndexSearch.ClearDB();
        }

        private void DisplayErrorMsg(uint ret)
        {
            MessageBox.Show(NBioAPI.Error.GetErrorDescription(ret) + " [" + ret.ToString() + "]", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnRegist_Click(object sender, System.EventArgs e)
        {
            NBioAPI.Type.HFIR hNewFIR;
            uint nUserID = 0;

            // Get User ID
            try
            {
                int test = Convert.ToInt32(textUserID.Text, 10);
                if (test == 0)
                    throw (new Exception());
            }
            catch
            {
                MessageBox.Show("User ID must be have numeric type and greater than 0.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            nUserID = Convert.ToUInt32(textUserID.Text, 10);

            // Get FIR data
            m_NBioAPI.OpenDevice(NBioAPI.Type.DEVICE_ID.AUTO);
            uint ret = m_NBioAPI.Enroll(out hNewFIR, null);
            if (ret != NBioAPI.Error.NONE)
            {
                DisplayErrorMsg(ret);
                m_NBioAPI.CloseDevice(NBioAPI.Type.DEVICE_ID.AUTO);
                return;
            }

            m_NBioAPI.CloseDevice(NBioAPI.Type.DEVICE_ID.AUTO);

            // Regist FIR to IndexSearch DB
            NBioAPI.IndexSearch.FP_INFO[] fpInfo;
            ret = m_IndexSearch.AddFIR(hNewFIR, nUserID, out fpInfo);
            if (ret != NBioAPI.Error.NONE)
            {
                DisplayErrorMsg(ret);
                return;
            }

            // Trasnformando em Binario
            NBioAPI.Type.FIR biFIR;
            m_NBioAPI.GetFIRFromHandle(hNewFIR, out biFIR);
            _formRegisterUser.BiometryDataBinary = biFIR.Data;

            // Transformando um Text
            NBioAPI.Type.FIR_TEXTENCODE textFIR;
            m_NBioAPI.GetTextFIRFromHandle(hNewFIR, out textFIR, true);
            _formRegisterUser.BiometryDataText = textFIR.TextFIR;

            // Add item to list of SearchDB
            foreach (NBioAPI.IndexSearch.FP_INFO sampleInfo in fpInfo)
            {
                ListViewItem listItem = new ListViewItem();
                listItem.Text = sampleInfo.ID.ToString();
                listItem.SubItems.Add(sampleInfo.FingerID.ToString());
                listItem.SubItems.Add(sampleInfo.SampleNumber.ToString());
                listSearchDB.Items.Add(listItem);
            }

            textUserID.Text = Convert.ToString(Convert.ToInt32(textUserID.Text) + 1);
        }

        static Image ConvertBytesToImage(byte[] bytes)
        {
            using (MemoryStream stream = new MemoryStream(bytes))
            {
                Image imagem = Image.FromStream(stream);
                return new Bitmap(imagem);
            }
        }

        public uint myCallback(ref NBioAPI.IndexSearch.CALLBACK_PARAM_0 cbParam0, IntPtr userParam)
        {
            progressIdentify.Value = Convert.ToInt32(cbParam0.ProgressPos);
            return NBioAPI.IndexSearch.CALLBACK_RETURN.OK;
        }

        private User Identify()
        {
            NBioAPI.Type.HFIR hCapturedFIR;

            listResult.Items.Clear();

            // Get FIR data
            m_NBioAPI.OpenDevice(NBioAPI.Type.DEVICE_ID.AUTO);
            uint ret = m_NBioAPI.Capture(out hCapturedFIR);
            if (ret != NBioAPI.Error.NONE)
            {
                DisplayErrorMsg(ret);
                m_NBioAPI.CloseDevice(NBioAPI.Type.DEVICE_ID.AUTO);
                return null;
            }

            m_NBioAPI.CloseDevice(NBioAPI.Type.DEVICE_ID.AUTO);


            //NBioAPI.IndexSearch.CALLBACK_INFO_0 cbInfo0 = new NBioAPI.IndexSearch.CALLBACK_INFO_0();
            //cbInfo0.CallBackFunction = new NBioAPI.IndexSearch.INDEXSEARCH_CALLBACK(myCallback);

            //_formRegisterUser.BiometryData = biFIR.Data;
            NBioAPI.Type.FIR_PAYLOAD myPayload = new NBioAPI.Type.FIR_PAYLOAD();

            //string texto = "AQAAABQAAACEAQAAAQASAAMAWQAAAAAAfAEAAEO0*ozqvH22/rIQ1S*hKHZF/eo*yfi6AazK3P5GoKl2wXTt6eo0ZUrHfDBO2xZkmUXXYdYjapejjzlVXE8PYshfm88TcQayhI6V7BUSOJtWMZr48YYMU38M3qbQPGbtK1yut9/1fgYxMkdfeDzIqPCAmbh/bATIGd9jespsfaKLQiS9uvU3iGJiQ1IlzflYBpXJEdRb0i9ZNOXw5XfDxDZLdP1ZKl/XGYxZpnddsLRVXYtAZ6x1MCccJ*wzielhG3Hgh8ag3HaV/h6aTLPzg9TLkECVZ5YQkzB/2jPDrd6OAAMs2Ib2HD4NRVZnGGJ/F81je4Z1rBPmhUxnKaDeCLnmxyKpH4EtLw3RsuvkhKh0lBdkN31RZ7On7YAKqRiOjWXU71p8qeRZYFqbXuUM1diYok8nMdU6X4vL3hkHh/RGKl8gLTVGjKbj5L4Ka5Mmvwl4PuH7ghcWjYuVGC/zXIspVuLx7a/76LHExCc5eDsWQnqnQUEuPLINO9w3Brr2NQ";

            //m_NBioAPI.GetTextFIRFromHandle(hCapturedFIR, out textFIR, true);
            //m_NBioAPI.

            var users = Service.UserController.GetAll();

            //foreach (User user in users)
            //{
            //    NBioAPI.Type.FIR_TEXTENCODE m_textFIR = new NBioAPI.Type.FIR_TEXTENCODE();
            //    m_textFIR.TextFIR = user.BiometricData;
            //    ret = m_NBioAPI.VerifyMatch(hCapturedFIR, m_textFIR, out bool result, myPayload);
            //    if (result == true) return user;
            //}
            return null;
        }

        private void btnIdentify_Click(object sender, System.EventArgs e)
        {
            var user = Identify();
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void btnDBRemove_Click(object sender, System.EventArgs e)
        {
            uint nUserID;
            byte nFingerID, nSampleNumber;

            if (listSearchDB.Items.Count <= 0)
                return;

            if (listSearchDB.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Select item ...", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            uint ret = NBioAPI.Error.NONE;
            bool bIsRemoveAll = true;

            for (int i = listSearchDB.SelectedItems.Count - 1; i >= 0; i--)
            {
                nUserID = Convert.ToUInt32(listSearchDB.SelectedItems[i].Text);
                nFingerID = Convert.ToByte(listSearchDB.SelectedItems[i].SubItems[1].Text);
                nSampleNumber = Convert.ToByte(listSearchDB.SelectedItems[i].SubItems[2].Text);

                ret = m_IndexSearch.RemoveData(nUserID, nFingerID, nSampleNumber);
                if (ret != NBioAPI.Error.NONE)
                {
                    bIsRemoveAll = false;
                    break;
                }
            }

            if (bIsRemoveAll)
            {
                for (int i = listSearchDB.SelectedItems.Count - 1; i >= 0; i--)
                    listSearchDB.SelectedItems[i].Remove();
                MessageBox.Show("Remove data success!");
            }
            else
            {
                DisplayErrorMsg(ret);
            }

        }

        private void btnSaveFile_Click(object sender, System.EventArgs e)
        {
            uint ret = NBioAPI.Error.NONE;

            SaveFileDialog saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();

            string szFileName = "";

            saveFileDialog1.Filter = "ISDB files (*.ISDB)|*.ISDB";

            if (saveFileDialog1.ShowDialog(this) != DialogResult.OK)
                return;

            szFileName = saveFileDialog1.FileName;
            if (szFileName != "")
            {
                // Save SearchDB to File
                ret = m_IndexSearch.SaveDBToFile(szFileName);
                if (ret != NBioAPI.Error.NONE)
                {
                    DisplayErrorMsg(ret);
                    return;
                }

                // Save list to file
                szFileName = Path.ChangeExtension(szFileName, "FID");

                FileStream fs = new FileStream(szFileName, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter fw = new StreamWriter(fs);

                for (int i = 0; i < listSearchDB.Items.Count; i++)
                {
                    fw.WriteLine(listSearchDB.Items[i].Text + "\t" + listSearchDB.Items[i].SubItems[1].Text + "\t" + listSearchDB.Items[i].SubItems[2].Text);
                }

                fw.Close();
                fs.Close();

                MessageBox.Show("Save SearchDB to file success!");
            }
            else
            {
                MessageBox.Show("You must enter filename !", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDBClear_Click(object sender, System.EventArgs e)
        {
            // Clear ListView of SearchDB
            listSearchDB.Items.Clear();

            // Clear IndexSearchDB
            m_IndexSearch.ClearDB();
        }

        private void btnLoadFile_Click(object sender, System.EventArgs e)
        {
            uint ret = NBioAPI.Error.NONE;

            DialogResult dr = MessageBox.Show("If you load database from file, existing memory database will be cleared!\nAre you sure you want to load database?", "IndexSearchDemoCS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr != DialogResult.Yes)
                return;

            OpenFileDialog openFileDialog1 = new System.Windows.Forms.OpenFileDialog();

            string szFileName = "";

            openFileDialog1.Filter = "ISDB files (*.ISDB)|*.ISDB|All files (*.*)|*.*";

            if (openFileDialog1.ShowDialog(this) != DialogResult.OK)
                return;

            szFileName = openFileDialog1.FileName;
            if (szFileName != "")
            {
                // Clear ListView of SearchDB
                listSearchDB.Items.Clear();
                // Clear IndexSearchDB
                m_IndexSearch.ClearDB();

                // Load SearchDB from File
                ret = m_IndexSearch.LoadDBFromFile(szFileName);
                if (ret != NBioAPI.Error.NONE)
                {
                    DisplayErrorMsg(ret);
                    return;
                }

                listSearchDB.Items.Clear();

                // Load list from file
                szFileName = Path.ChangeExtension(szFileName, "FID");

                FileStream fs = new FileStream(szFileName, FileMode.Open, FileAccess.Read);
                StreamReader fr = new StreamReader(fs);

                while (fr.Peek() >= 0)
                {
                    try
                    {
                        string szLine = fr.ReadLine();

                        string[] szSplit = szLine.Split('\t');

                        ListViewItem listItem = new ListViewItem();
                        listItem.Text = szSplit[0];
                        listItem.SubItems.Add(szSplit[1]);
                        listItem.SubItems.Add(szSplit[2]);
                        listSearchDB.Items.Add(listItem);
                    }
                    catch
                    {
                        break;
                    }
                }

                fr.Close();
                fs.Close();

                MessageBox.Show("Load SearchDB to file success!");
            }
            else
            {
                MessageBox.Show("You must enter filename !", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
