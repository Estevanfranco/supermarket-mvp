namespace Supermarket_mvp.Views
{
    partial class CustomersView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersView));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPageCustomersList = new TabPage();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            DgCustomers = new DataGridView();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            label2 = new Label();
            tabPageCustomersDetail = new TabPage();
            TxtCustomersEmail = new TextBox();
            label7 = new Label();
            TxtCustomersPhoneNumber = new TextBox();
            label6 = new Label();
            TxtCustomersBirthday = new TextBox();
            label5 = new Label();
            TxtCustomersAddress = new TextBox();
            label4 = new Label();
            TxtCustomersLastName = new TextBox();
            label3 = new Label();
            TxtCustomersFirstName = new TextBox();
            TxtCustomersId = new TextBox();
            TxtCustomersDocNum = new TextBox();
            BtnCancel = new Button();
            BtnSave = new Button();
            LabelObservation = new Label();
            LabelName = new Label();
            LabelID = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageCustomersList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgCustomers).BeginInit();
            tabPageCustomersDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 125);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(19, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoEllipsis = true;
            label1.AutoSize = true;
            label1.Location = new Point(171, 55);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 0;
            label1.Text = "Customers";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageCustomersList);
            tabControl1.Controls.Add(tabPageCustomersDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 125);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 681);
            tabControl1.TabIndex = 1;
            // 
            // tabPageCustomersList
            // 
            tabPageCustomersList.Controls.Add(BtnClose);
            tabPageCustomersList.Controls.Add(BtnDelete);
            tabPageCustomersList.Controls.Add(BtnEdit);
            tabPageCustomersList.Controls.Add(BtnNew);
            tabPageCustomersList.Controls.Add(DgCustomers);
            tabPageCustomersList.Controls.Add(BtnSearch);
            tabPageCustomersList.Controls.Add(TxtSearch);
            tabPageCustomersList.Controls.Add(label2);
            tabPageCustomersList.Location = new Point(4, 29);
            tabPageCustomersList.Name = "tabPageCustomersList";
            tabPageCustomersList.Padding = new Padding(3);
            tabPageCustomersList.Size = new Size(792, 648);
            tabPageCustomersList.TabIndex = 0;
            tabPageCustomersList.Text = "Customers List";
            tabPageCustomersList.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = (Image)resources.GetObject("BtnClose.Image");
            BtnClose.Location = new Point(629, 224);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(94, 47);
            BtnClose.TabIndex = 7;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Image = (Image)resources.GetObject("BtnDelete.Image");
            BtnDelete.Location = new Point(629, 156);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(94, 47);
            BtnDelete.TabIndex = 6;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Image = (Image)resources.GetObject("BtnEdit.Image");
            BtnEdit.Location = new Point(629, 79);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(94, 47);
            BtnEdit.TabIndex = 5;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.Image = (Image)resources.GetObject("BtnNew.Image");
            BtnNew.Location = new Point(629, 12);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(94, 45);
            BtnNew.TabIndex = 4;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // DgCustomers
            // 
            DgCustomers.AllowUserToAddRows = false;
            DgCustomers.AllowUserToDeleteRows = false;
            DgCustomers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgCustomers.Location = new Point(18, 79);
            DgCustomers.Name = "DgCustomers";
            DgCustomers.ReadOnly = true;
            DgCustomers.RowHeadersWidth = 51;
            DgCustomers.Size = new Size(470, 532);
            DgCustomers.TabIndex = 3;
            // 
            // BtnSearch
            // 
            BtnSearch.Image = (Image)resources.GetObject("BtnSearch.Image");
            BtnSearch.Location = new Point(308, 32);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(51, 39);
            BtnSearch.TabIndex = 2;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(18, 43);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(284, 27);
            TxtSearch.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 12);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 0;
            label2.Text = "Search Categories";
            // 
            // tabPageCustomersDetail
            // 
            tabPageCustomersDetail.Controls.Add(TxtCustomersEmail);
            tabPageCustomersDetail.Controls.Add(label7);
            tabPageCustomersDetail.Controls.Add(TxtCustomersPhoneNumber);
            tabPageCustomersDetail.Controls.Add(label6);
            tabPageCustomersDetail.Controls.Add(TxtCustomersBirthday);
            tabPageCustomersDetail.Controls.Add(label5);
            tabPageCustomersDetail.Controls.Add(TxtCustomersAddress);
            tabPageCustomersDetail.Controls.Add(label4);
            tabPageCustomersDetail.Controls.Add(TxtCustomersLastName);
            tabPageCustomersDetail.Controls.Add(label3);
            tabPageCustomersDetail.Controls.Add(TxtCustomersFirstName);
            tabPageCustomersDetail.Controls.Add(TxtCustomersId);
            tabPageCustomersDetail.Controls.Add(TxtCustomersDocNum);
            tabPageCustomersDetail.Controls.Add(BtnCancel);
            tabPageCustomersDetail.Controls.Add(BtnSave);
            tabPageCustomersDetail.Controls.Add(LabelObservation);
            tabPageCustomersDetail.Controls.Add(LabelName);
            tabPageCustomersDetail.Controls.Add(LabelID);
            tabPageCustomersDetail.Location = new Point(4, 29);
            tabPageCustomersDetail.Name = "tabPageCustomersDetail";
            tabPageCustomersDetail.Padding = new Padding(3);
            tabPageCustomersDetail.Size = new Size(792, 648);
            tabPageCustomersDetail.TabIndex = 1;
            tabPageCustomersDetail.Text = "Customers Detail";
            tabPageCustomersDetail.UseVisualStyleBackColor = true;
            // 
            // TxtCustomersEmail
            // 
            TxtCustomersEmail.Location = new Point(15, 541);
            TxtCustomersEmail.Multiline = true;
            TxtCustomersEmail.Name = "TxtCustomersEmail";
            TxtCustomersEmail.Size = new Size(130, 27);
            TxtCustomersEmail.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 518);
            label7.Name = "label7";
            label7.Size = new Size(119, 20);
            label7.TabIndex = 22;
            label7.Text = "Customers Email";
            // 
            // TxtCustomersPhoneNumber
            // 
            TxtCustomersPhoneNumber.Location = new Point(18, 473);
            TxtCustomersPhoneNumber.Multiline = true;
            TxtCustomersPhoneNumber.Name = "TxtCustomersPhoneNumber";
            TxtCustomersPhoneNumber.Size = new Size(130, 27);
            TxtCustomersPhoneNumber.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 450);
            label6.Name = "label6";
            label6.Size = new Size(181, 20);
            label6.TabIndex = 20;
            label6.Text = "Customers Phone Number";
            // 
            // TxtCustomersBirthday
            // 
            TxtCustomersBirthday.Location = new Point(18, 404);
            TxtCustomersBirthday.Multiline = true;
            TxtCustomersBirthday.Name = "TxtCustomersBirthday";
            TxtCustomersBirthday.Size = new Size(130, 27);
            TxtCustomersBirthday.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 381);
            label5.Name = "label5";
            label5.Size = new Size(137, 20);
            label5.TabIndex = 18;
            label5.Text = "Customers Birthday";
            // 
            // TxtCustomersAddress
            // 
            TxtCustomersAddress.Location = new Point(18, 337);
            TxtCustomersAddress.Multiline = true;
            TxtCustomersAddress.Name = "TxtCustomersAddress";
            TxtCustomersAddress.Size = new Size(130, 27);
            TxtCustomersAddress.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 314);
            label4.Name = "label4";
            label4.Size = new Size(135, 20);
            label4.TabIndex = 16;
            label4.Text = "Customers Address";
            // 
            // TxtCustomersLastName
            // 
            TxtCustomersLastName.Location = new Point(18, 262);
            TxtCustomersLastName.Multiline = true;
            TxtCustomersLastName.Name = "TxtCustomersLastName";
            TxtCustomersLastName.Size = new Size(130, 27);
            TxtCustomersLastName.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 239);
            label3.Name = "label3";
            label3.Size = new Size(152, 20);
            label3.TabIndex = 14;
            label3.Text = "Customers Last Name";
            // 
            // TxtCustomersFirstName
            // 
            TxtCustomersFirstName.Location = new Point(18, 186);
            TxtCustomersFirstName.Multiline = true;
            TxtCustomersFirstName.Name = "TxtCustomersFirstName";
            TxtCustomersFirstName.Size = new Size(130, 27);
            TxtCustomersFirstName.TabIndex = 13;
            // 
            // TxtCustomersId
            // 
            TxtCustomersId.Location = new Point(18, 39);
            TxtCustomersId.Name = "TxtCustomersId";
            TxtCustomersId.ReadOnly = true;
            TxtCustomersId.Size = new Size(125, 27);
            TxtCustomersId.TabIndex = 12;
            TxtCustomersId.Text = "0";
            // 
            // TxtCustomersDocNum
            // 
            TxtCustomersDocNum.Location = new Point(18, 111);
            TxtCustomersDocNum.Name = "TxtCustomersDocNum";
            TxtCustomersDocNum.Size = new Size(125, 27);
            TxtCustomersDocNum.TabIndex = 11;
            // 
            // BtnCancel
            // 
            BtnCancel.Image = (Image)resources.GetObject("BtnCancel.Image");
            BtnCancel.Location = new Point(134, 592);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(94, 48);
            BtnCancel.TabIndex = 10;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = (Image)resources.GetObject("BtnSave.Image");
            BtnSave.Location = new Point(15, 592);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(94, 48);
            BtnSave.TabIndex = 9;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // LabelObservation
            // 
            LabelObservation.AutoSize = true;
            LabelObservation.Location = new Point(18, 163);
            LabelObservation.Name = "LabelObservation";
            LabelObservation.Size = new Size(153, 20);
            LabelObservation.TabIndex = 7;
            LabelObservation.Text = "Customers First Name";
            // 
            // LabelName
            // 
            LabelName.AutoSize = true;
            LabelName.Location = new Point(18, 88);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(145, 20);
            LabelName.TabIndex = 5;
            LabelName.Text = "Customers Num Doc";
            // 
            // LabelID
            // 
            LabelID.AutoSize = true;
            LabelID.Location = new Point(18, 16);
            LabelID.Name = "LabelID";
            LabelID.Size = new Size(97, 20);
            LabelID.TabIndex = 3;
            LabelID.Text = "Customers ID";
            // 
            // CustomersView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 806);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "CustomersView";
            Text = "CUSTOMERS";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageCustomersList.ResumeLayout(false);
            tabPageCustomersList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgCustomers).EndInit();
            tabPageCustomersDetail.ResumeLayout(false);
            tabPageCustomersDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPageCustomersList;
        private TabPage tabPageCustomersDetail;
        private TextBox TxtSearch;
        private Label label2;
        private DataGridView DgCustomers;
        private Button BtnSearch;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private Label LabelID;
        private Label LabelObservation;
        private Label LabelName;
        private Button BtnCancel;
        private Button BtnSave;
        private TextBox TxtCustomersFirstName;
        private TextBox TxtCustomersId;
        private TextBox TxtCustomersDocNum;
        private TextBox TxtCustomersBirthday;
        private Label label5;
        private TextBox TxtCustomersAddress;
        private Label label4;
        private TextBox TxtCustomersLastName;
        private Label label3;
        private TextBox TxtCustomersPhoneNumber;
        private Label label6;
        private TextBox TxtCustomersEmail;
        private Label label7;
    }
}