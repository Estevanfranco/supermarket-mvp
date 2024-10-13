namespace Supermarket_mvp.Views
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            panel1 = new Panel();
            BtnProduct = new Button();
            BtnExit = new Button();
            BtnPayMode = new Button();
            pictureBox1 = new PictureBox();
            BtnCategori = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(BtnCategori);
            panel1.Controls.Add(BtnProduct);
            panel1.Controls.Add(BtnExit);
            panel1.Controls.Add(BtnPayMode);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 592);
            panel1.TabIndex = 0;
            // 
            // BtnProduct
            // 
            BtnProduct.BackgroundImage = (Image)resources.GetObject("BtnProduct.BackgroundImage");
            BtnProduct.BackgroundImageLayout = ImageLayout.Zoom;
            BtnProduct.Location = new Point(3, 178);
            BtnProduct.Name = "BtnProduct";
            BtnProduct.Size = new Size(244, 77);
            BtnProduct.TabIndex = 3;
            BtnProduct.UseVisualStyleBackColor = true;
            // 
            // BtnExit
            // 
            BtnExit.BackgroundImage = (Image)resources.GetObject("BtnExit.BackgroundImage");
            BtnExit.BackgroundImageLayout = ImageLayout.Zoom;
            BtnExit.Dock = DockStyle.Bottom;
            BtnExit.Location = new Point(0, 520);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(250, 72);
            BtnExit.TabIndex = 2;
            BtnExit.UseVisualStyleBackColor = true;
            // 
            // BtnPayMode
            // 
            BtnPayMode.BackgroundImage = (Image)resources.GetObject("BtnPayMode.BackgroundImage");
            BtnPayMode.BackgroundImageLayout = ImageLayout.Zoom;
            BtnPayMode.Location = new Point(0, 95);
            BtnPayMode.Name = "BtnPayMode";
            BtnPayMode.Size = new Size(244, 77);
            BtnPayMode.TabIndex = 1;
            BtnPayMode.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(247, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // BtnCategori
            // 
            BtnCategori.BackgroundImage = (Image)resources.GetObject("BtnCategori.BackgroundImage");
            BtnCategori.BackgroundImageLayout = ImageLayout.Zoom;
            BtnCategori.Location = new Point(3, 261);
            BtnCategori.Name = "BtnCategori";
            BtnCategori.Size = new Size(244, 77);
            BtnCategori.TabIndex = 4;
            BtnCategori.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 592);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Name = "MainView";
            Text = "Supermarket";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button BtnPayMode;
        private Button BtnExit;
        private Button BtnProduct;
        private Button BtnCategori;
    }
}