namespace Webshop.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlShowcart = new System.Windows.Forms.Panel();
            this.pnlJewelry = new System.Windows.Forms.Panel();
            this.pnlClothes = new System.Windows.Forms.Panel();
            this.pnlHomedecor = new System.Windows.Forms.Panel();
            this.pnlElectronics = new System.Windows.Forms.Panel();
            this.btnShowcart = new System.Windows.Forms.Button();
            this.btnJewelry = new System.Windows.Forms.Button();
            this.btnClothes = new System.Windows.Forms.Button();
            this.btnHomedecor = new System.Windows.Forms.Button();
            this.btnElectronics = new System.Windows.Forms.Button();
            this.btnLogo = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.homeUC1 = new Webshop.Pages.HomeUC();
            this.jewelryUC1 = new Webshop.Pages.JewelryUC();
            this.cartUC1 = new Webshop.Pages.CartUC();
            this.clothesUC1 = new Webshop.Pages.ClothesUC();
            this.electronicsUC1 = new Webshop.Pages.ElectronicsUC();
            this.homedecorUC1 = new Webshop.Pages.HomedecorUC();
            this.pnlHome = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.exitBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1419, 47);
            this.panel1.TabIndex = 0;
            // 
            // exitBtn
            // 
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Image = ((System.Drawing.Image)(resources.GetObject("exitBtn.Image")));
            this.exitBtn.Location = new System.Drawing.Point(1379, 9);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(28, 35);
            this.exitBtn.TabIndex = 0;
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Controls.Add(this.pnlHome);
            this.panel2.Controls.Add(this.pnlShowcart);
            this.panel2.Controls.Add(this.pnlJewelry);
            this.panel2.Controls.Add(this.pnlClothes);
            this.panel2.Controls.Add(this.pnlHomedecor);
            this.panel2.Controls.Add(this.pnlElectronics);
            this.panel2.Controls.Add(this.btnShowcart);
            this.panel2.Controls.Add(this.btnJewelry);
            this.panel2.Controls.Add(this.btnClothes);
            this.panel2.Controls.Add(this.btnHomedecor);
            this.panel2.Controls.Add(this.btnElectronics);
            this.panel2.Controls.Add(this.btnLogo);
            this.panel2.Location = new System.Drawing.Point(173, 47);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1072, 80);
            this.panel2.TabIndex = 1;
            // 
            // pnlShowcart
            // 
            this.pnlShowcart.BackColor = System.Drawing.Color.White;
            this.pnlShowcart.Location = new System.Drawing.Point(905, 69);
            this.pnlShowcart.Name = "pnlShowcart";
            this.pnlShowcart.Size = new System.Drawing.Size(161, 2);
            this.pnlShowcart.TabIndex = 2;
            // 
            // pnlJewelry
            // 
            this.pnlJewelry.BackColor = System.Drawing.Color.White;
            this.pnlJewelry.Location = new System.Drawing.Point(672, 69);
            this.pnlJewelry.Name = "pnlJewelry";
            this.pnlJewelry.Size = new System.Drawing.Size(122, 2);
            this.pnlJewelry.TabIndex = 2;
            // 
            // pnlClothes
            // 
            this.pnlClothes.BackColor = System.Drawing.Color.White;
            this.pnlClothes.Location = new System.Drawing.Point(572, 69);
            this.pnlClothes.Name = "pnlClothes";
            this.pnlClothes.Size = new System.Drawing.Size(94, 2);
            this.pnlClothes.TabIndex = 2;
            // 
            // pnlHomedecor
            // 
            this.pnlHomedecor.BackColor = System.Drawing.Color.White;
            this.pnlHomedecor.Location = new System.Drawing.Point(407, 69);
            this.pnlHomedecor.Name = "pnlHomedecor";
            this.pnlHomedecor.Size = new System.Drawing.Size(159, 2);
            this.pnlHomedecor.TabIndex = 2;
            // 
            // pnlElectronics
            // 
            this.pnlElectronics.BackColor = System.Drawing.Color.White;
            this.pnlElectronics.Location = new System.Drawing.Point(279, 69);
            this.pnlElectronics.Name = "pnlElectronics";
            this.pnlElectronics.Size = new System.Drawing.Size(122, 2);
            this.pnlElectronics.TabIndex = 2;
            // 
            // btnShowcart
            // 
            this.btnShowcart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowcart.FlatAppearance.BorderSize = 0;
            this.btnShowcart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowcart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowcart.ForeColor = System.Drawing.Color.White;
            this.btnShowcart.Image = ((System.Drawing.Image)(resources.GetObject("btnShowcart.Image")));
            this.btnShowcart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowcart.Location = new System.Drawing.Point(905, 18);
            this.btnShowcart.Name = "btnShowcart";
            this.btnShowcart.Size = new System.Drawing.Size(161, 45);
            this.btnShowcart.TabIndex = 1;
            this.btnShowcart.Text = "     Visa varukorg";
            this.btnShowcart.UseVisualStyleBackColor = true;
            this.btnShowcart.Click += new System.EventHandler(this.btnShowcart_Click);
            // 
            // btnJewelry
            // 
            this.btnJewelry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJewelry.FlatAppearance.BorderSize = 0;
            this.btnJewelry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJewelry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJewelry.ForeColor = System.Drawing.Color.White;
            this.btnJewelry.Image = ((System.Drawing.Image)(resources.GetObject("btnJewelry.Image")));
            this.btnJewelry.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJewelry.Location = new System.Drawing.Point(672, 18);
            this.btnJewelry.Name = "btnJewelry";
            this.btnJewelry.Size = new System.Drawing.Size(122, 45);
            this.btnJewelry.TabIndex = 1;
            this.btnJewelry.Text = "    Smycken";
            this.btnJewelry.UseVisualStyleBackColor = true;
            this.btnJewelry.Click += new System.EventHandler(this.btnJewelry_Click);
            // 
            // btnClothes
            // 
            this.btnClothes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClothes.FlatAppearance.BorderSize = 0;
            this.btnClothes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClothes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClothes.ForeColor = System.Drawing.Color.White;
            this.btnClothes.Image = ((System.Drawing.Image)(resources.GetObject("btnClothes.Image")));
            this.btnClothes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClothes.Location = new System.Drawing.Point(572, 18);
            this.btnClothes.Name = "btnClothes";
            this.btnClothes.Size = new System.Drawing.Size(94, 45);
            this.btnClothes.TabIndex = 1;
            this.btnClothes.Text = "      Kläder";
            this.btnClothes.UseVisualStyleBackColor = true;
            this.btnClothes.Click += new System.EventHandler(this.btnClothes_Click);
            // 
            // btnHomedecor
            // 
            this.btnHomedecor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHomedecor.FlatAppearance.BorderSize = 0;
            this.btnHomedecor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomedecor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomedecor.ForeColor = System.Drawing.Color.White;
            this.btnHomedecor.Image = ((System.Drawing.Image)(resources.GetObject("btnHomedecor.Image")));
            this.btnHomedecor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHomedecor.Location = new System.Drawing.Point(407, 18);
            this.btnHomedecor.Name = "btnHomedecor";
            this.btnHomedecor.Size = new System.Drawing.Size(159, 45);
            this.btnHomedecor.TabIndex = 1;
            this.btnHomedecor.Text = "      Heminredning";
            this.btnHomedecor.UseVisualStyleBackColor = true;
            this.btnHomedecor.Click += new System.EventHandler(this.btnHomedecor_Click);
            // 
            // btnElectronics
            // 
            this.btnElectronics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnElectronics.FlatAppearance.BorderSize = 0;
            this.btnElectronics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElectronics.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElectronics.ForeColor = System.Drawing.Color.White;
            this.btnElectronics.Image = ((System.Drawing.Image)(resources.GetObject("btnElectronics.Image")));
            this.btnElectronics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnElectronics.Location = new System.Drawing.Point(279, 18);
            this.btnElectronics.Name = "btnElectronics";
            this.btnElectronics.Size = new System.Drawing.Size(122, 45);
            this.btnElectronics.TabIndex = 1;
            this.btnElectronics.Text = "      Elektronik";
            this.btnElectronics.UseVisualStyleBackColor = true;
            this.btnElectronics.Click += new System.EventHandler(this.btnElectronics_Click);
            // 
            // btnLogo
            // 
            this.btnLogo.AutoSize = true;
            this.btnLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogo.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogo.ForeColor = System.Drawing.Color.White;
            this.btnLogo.Location = new System.Drawing.Point(36, 16);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(174, 47);
            this.btnLogo.TabIndex = 0;
            this.btnLogo.Text = "Webshop";
            this.btnLogo.Click += new System.EventHandler(this.btnLogo_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.homeUC1);
            this.panel3.Controls.Add(this.jewelryUC1);
            this.panel3.Controls.Add(this.cartUC1);
            this.panel3.Controls.Add(this.clothesUC1);
            this.panel3.Controls.Add(this.electronicsUC1);
            this.panel3.Controls.Add(this.homedecorUC1);
            this.panel3.Location = new System.Drawing.Point(173, 127);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1072, 661);
            this.panel3.TabIndex = 2;
            // 
            // homeUC1
            // 
            this.homeUC1.Location = new System.Drawing.Point(0, 0);
            this.homeUC1.Name = "homeUC1";
            this.homeUC1.Size = new System.Drawing.Size(1072, 661);
            this.homeUC1.TabIndex = 5;
            // 
            // jewelryUC1
            // 
            this.jewelryUC1.Location = new System.Drawing.Point(0, 0);
            this.jewelryUC1.Name = "jewelryUC1";
            this.jewelryUC1.Size = new System.Drawing.Size(1072, 661);
            this.jewelryUC1.TabIndex = 1;
            // 
            // cartUC1
            // 
            this.cartUC1.Location = new System.Drawing.Point(0, 0);
            this.cartUC1.Name = "cartUC1";
            this.cartUC1.Size = new System.Drawing.Size(1072, 661);
            this.cartUC1.TabIndex = 0;
            // 
            // clothesUC1
            // 
            this.clothesUC1.Location = new System.Drawing.Point(0, 0);
            this.clothesUC1.Name = "clothesUC1";
            this.clothesUC1.Size = new System.Drawing.Size(1072, 661);
            this.clothesUC1.TabIndex = 4;
            // 
            // electronicsUC1
            // 
            this.electronicsUC1.Location = new System.Drawing.Point(0, 0);
            this.electronicsUC1.Name = "electronicsUC1";
            this.electronicsUC1.Size = new System.Drawing.Size(1072, 661);
            this.electronicsUC1.TabIndex = 3;
            // 
            // homedecorUC1
            // 
            this.homedecorUC1.Location = new System.Drawing.Point(0, 0);
            this.homedecorUC1.Name = "homedecorUC1";
            this.homedecorUC1.Size = new System.Drawing.Size(1072, 661);
            this.homedecorUC1.TabIndex = 2;
            // 
            // pnlHome
            // 
            this.pnlHome.Location = new System.Drawing.Point(217, 4);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(10, 21);
            this.pnlHome.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1419, 788);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnJewelry;
        private System.Windows.Forms.Button btnClothes;
        private System.Windows.Forms.Button btnHomedecor;
        private System.Windows.Forms.Button btnElectronics;
        private System.Windows.Forms.Label btnLogo;
        private System.Windows.Forms.Panel pnlJewelry;
        private System.Windows.Forms.Panel pnlClothes;
        private System.Windows.Forms.Panel pnlHomedecor;
        private System.Windows.Forms.Panel pnlElectronics;
        private System.Windows.Forms.Panel pnlShowcart;
        private System.Windows.Forms.Button btnShowcart;
        private Pages.CartUC cartUC1;
        private Pages.ClothesUC clothesUC1;
        private Pages.ElectronicsUC electronicsUC1;
        private Pages.HomedecorUC homedecorUC1;
        private Pages.JewelryUC jewelryUC1;
        private Pages.HomeUC homeUC1;
        private System.Windows.Forms.Panel pnlHome;
    }
}