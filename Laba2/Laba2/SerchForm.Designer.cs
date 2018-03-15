namespace Laba2
{
    partial class SerchForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.searchFiO = new MaterialSkin.Controls.MaterialLabel();
            this.seasrchSpeshal = new MaterialSkin.Controls.MaterialLabel();
            this.searchCours = new MaterialSkin.Controls.MaterialLabel();
            this.searchSB = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SearchButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.checkBoxConfirmity = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(125, 90);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(170, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(125, 38);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(170, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(125, 64);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(170, 20);
            this.textBox4.TabIndex = 3;
            // 
            // searchFiO
            // 
            this.searchFiO.AutoSize = true;
            this.searchFiO.Depth = 0;
            this.searchFiO.Font = new System.Drawing.Font("Roboto", 11F);
            this.searchFiO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.searchFiO.Location = new System.Drawing.Point(-3, 37);
            this.searchFiO.MouseState = MaterialSkin.MouseState.HOVER;
            this.searchFiO.Name = "searchFiO";
            this.searchFiO.Size = new System.Drawing.Size(42, 19);
            this.searchFiO.TabIndex = 7;
            this.searchFiO.Text = "ФИО";
            // 
            // seasrchSpeshal
            // 
            this.seasrchSpeshal.AutoSize = true;
            this.seasrchSpeshal.Depth = 0;
            this.seasrchSpeshal.Font = new System.Drawing.Font("Roboto", 11F);
            this.seasrchSpeshal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.seasrchSpeshal.Location = new System.Drawing.Point(-3, 65);
            this.seasrchSpeshal.MouseState = MaterialSkin.MouseState.HOVER;
            this.seasrchSpeshal.Name = "seasrchSpeshal";
            this.seasrchSpeshal.Size = new System.Drawing.Size(120, 19);
            this.seasrchSpeshal.TabIndex = 8;
            this.seasrchSpeshal.Text = "Специальнсоть";
            // 
            // searchCours
            // 
            this.searchCours.AutoSize = true;
            this.searchCours.Depth = 0;
            this.searchCours.Font = new System.Drawing.Font("Roboto", 11F);
            this.searchCours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.searchCours.Location = new System.Drawing.Point(-3, 91);
            this.searchCours.MouseState = MaterialSkin.MouseState.HOVER;
            this.searchCours.Name = "searchCours";
            this.searchCours.Size = new System.Drawing.Size(42, 19);
            this.searchCours.TabIndex = 9;
            this.searchCours.Text = "Курс";
            // 
            // searchSB
            // 
            this.searchSB.AutoSize = true;
            this.searchSB.Depth = 0;
            this.searchSB.Font = new System.Drawing.Font("Roboto", 11F);
            this.searchSB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.searchSB.Location = new System.Drawing.Point(-3, 117);
            this.searchSB.MouseState = MaterialSkin.MouseState.HOVER;
            this.searchSB.Name = "searchSB";
            this.searchSB.Size = new System.Drawing.Size(109, 19);
            this.searchSB.TabIndex = 10;
            this.searchSB.Text = "Средний балл";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(101, 9);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(206, 19);
            this.materialLabel1.TabIndex = 11;
            this.materialLabel1.Text = "Введите параметры поиска";
            // 
            // SearchButton
            // 
            this.SearchButton.AutoSize = true;
            this.SearchButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SearchButton.Depth = 0;
            this.SearchButton.Location = new System.Drawing.Point(236, 145);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SearchButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Primary = false;
            this.SearchButton.Size = new System.Drawing.Size(59, 36);
            this.SearchButton.TabIndex = 12;
            this.SearchButton.Text = "Найти";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // checkBoxConfirmity
            // 
            this.checkBoxConfirmity.AutoSize = true;
            this.checkBoxConfirmity.Location = new System.Drawing.Point(12, 156);
            this.checkBoxConfirmity.Name = "checkBoxConfirmity";
            this.checkBoxConfirmity.Size = new System.Drawing.Size(136, 17);
            this.checkBoxConfirmity.TabIndex = 13;
            this.checkBoxConfirmity.Text = "Полное соответствие";
            this.checkBoxConfirmity.UseVisualStyleBackColor = true;
            // 
            // SerchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 180);
            this.Controls.Add(this.checkBoxConfirmity);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.searchSB);
            this.Controls.Add(this.searchCours);
            this.Controls.Add(this.seasrchSpeshal);
            this.Controls.Add(this.searchFiO);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "SerchForm";
            this.Text = "SerchForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private MaterialSkin.Controls.MaterialLabel searchFiO;
        private MaterialSkin.Controls.MaterialLabel seasrchSpeshal;
        private MaterialSkin.Controls.MaterialLabel searchCours;
        private MaterialSkin.Controls.MaterialLabel searchSB;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialFlatButton SearchButton;
        private System.Windows.Forms.CheckBox checkBoxConfirmity;
    }
}