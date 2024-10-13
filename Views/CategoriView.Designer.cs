namespace Supermarket_mvp.Views
{
    partial class CategoriView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoriView));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPageCategoriList = new TabPage();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            DgCategori = new DataGridView();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            label2 = new Label();
            tabPageCategoriDetail = new TabPage();
            TxtCategoriDescription = new TextBox();
            TxtCategoriId = new TextBox();
            TxtCategoriName = new TextBox();
            BtnCancel = new Button();
            BtnSave = new Button();
            LabelObservation = new Label();
            LabelName = new Label();
            LabelID = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageCategoriList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgCategori).BeginInit();
            tabPageCategoriDetail.SuspendLayout();
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
            label1.Size = new Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "Categories";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageCategoriList);
            tabControl1.Controls.Add(tabPageCategoriDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 125);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 349);
            tabControl1.TabIndex = 1;
            // 
            // tabPageCategoriList
            // 
            tabPageCategoriList.Controls.Add(BtnClose);
            tabPageCategoriList.Controls.Add(BtnDelete);
            tabPageCategoriList.Controls.Add(BtnEdit);
            tabPageCategoriList.Controls.Add(BtnNew);
            tabPageCategoriList.Controls.Add(DgCategori);
            tabPageCategoriList.Controls.Add(BtnSearch);
            tabPageCategoriList.Controls.Add(TxtSearch);
            tabPageCategoriList.Controls.Add(label2);
            tabPageCategoriList.Location = new Point(4, 29);
            tabPageCategoriList.Name = "tabPageCategoriList";
            tabPageCategoriList.Padding = new Padding(3);
            tabPageCategoriList.Size = new Size(792, 316);
            tabPageCategoriList.TabIndex = 0;
            tabPageCategoriList.Text = "Category List";
            tabPageCategoriList.UseVisualStyleBackColor = true;
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
            // DgCategori
            // 
            DgCategori.AllowUserToAddRows = false;
            DgCategori.AllowUserToDeleteRows = false;
            DgCategori.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgCategori.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgCategori.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgCategori.Location = new Point(18, 79);
            DgCategori.Name = "DgCategori";
            DgCategori.ReadOnly = true;
            DgCategori.RowHeadersWidth = 51;
            DgCategori.Size = new Size(470, 200);
            DgCategori.TabIndex = 3;
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
            // tabPageCategoriDetail
            // 
            tabPageCategoriDetail.Controls.Add(TxtCategoriDescription);
            tabPageCategoriDetail.Controls.Add(TxtCategoriId);
            tabPageCategoriDetail.Controls.Add(TxtCategoriName);
            tabPageCategoriDetail.Controls.Add(BtnCancel);
            tabPageCategoriDetail.Controls.Add(BtnSave);
            tabPageCategoriDetail.Controls.Add(LabelObservation);
            tabPageCategoriDetail.Controls.Add(LabelName);
            tabPageCategoriDetail.Controls.Add(LabelID);
            tabPageCategoriDetail.Location = new Point(4, 29);
            tabPageCategoriDetail.Name = "tabPageCategoriDetail";
            tabPageCategoriDetail.Padding = new Padding(3);
            tabPageCategoriDetail.Size = new Size(792, 316);
            tabPageCategoriDetail.TabIndex = 1;
            tabPageCategoriDetail.Text = "Categories Detail";
            tabPageCategoriDetail.UseVisualStyleBackColor = true;
            // 
            // TxtCategoriDescription
            // 
            TxtCategoriDescription.Location = new Point(18, 186);
            TxtCategoriDescription.Multiline = true;
            TxtCategoriDescription.Name = "TxtCategoriDescription";
            TxtCategoriDescription.Size = new Size(197, 48);
            TxtCategoriDescription.TabIndex = 13;
            // 
            // TxtCategoriId
            // 
            TxtCategoriId.Location = new Point(18, 39);
            TxtCategoriId.Name = "TxtCategoriId";
            TxtCategoriId.ReadOnly = true;
            TxtCategoriId.Size = new Size(125, 27);
            TxtCategoriId.TabIndex = 12;
            TxtCategoriId.Text = "0";
            // 
            // TxtCategoriName
            // 
            TxtCategoriName.Location = new Point(18, 111);
            TxtCategoriName.Name = "TxtCategoriName";
            TxtCategoriName.Size = new Size(125, 27);
            TxtCategoriName.TabIndex = 11;
            // 
            // BtnCancel
            // 
            BtnCancel.Image = (Image)resources.GetObject("BtnCancel.Image");
            BtnCancel.Location = new Point(136, 252);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(94, 48);
            BtnCancel.TabIndex = 10;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = (Image)resources.GetObject("BtnSave.Image");
            BtnSave.Location = new Point(17, 252);
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
            LabelObservation.Size = new Size(146, 20);
            LabelObservation.TabIndex = 7;
            LabelObservation.Text = "Categori Description";
            // 
            // LabelName
            // 
            LabelName.AutoSize = true;
            LabelName.Location = new Point(18, 88);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(110, 20);
            LabelName.TabIndex = 5;
            LabelName.Text = "Categori Name";
            // 
            // LabelID
            // 
            LabelID.AutoSize = true;
            LabelID.Location = new Point(18, 16);
            LabelID.Name = "LabelID";
            LabelID.Size = new Size(85, 20);
            LabelID.TabIndex = 3;
            LabelID.Text = "Categori ID";
            // 
            // CategoriView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 474);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "CategoriView";
            Text = "CATEGORIES";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageCategoriList.ResumeLayout(false);
            tabPageCategoriList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgCategori).EndInit();
            tabPageCategoriDetail.ResumeLayout(false);
            tabPageCategoriDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPageCategoriList;
        private TabPage tabPageCategoriDetail;
        private TextBox TxtSearch;
        private Label label2;
        private DataGridView DgCategori;
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
        private TextBox TxtCategoriDescription;
        private TextBox TxtCategoriId;
        private TextBox TxtCategoriName;
    }
}