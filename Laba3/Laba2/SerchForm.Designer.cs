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
            this.textBoxSearchSb = new System.Windows.Forms.TextBox();
            this.textBoxSearchLayer = new System.Windows.Forms.TextBox();
            this.textBoxSerchName = new System.Windows.Forms.TextBox();
            this.textBoxSearchspec = new System.Windows.Forms.TextBox();
            this.searchFiO = new MaterialSkin.Controls.MaterialLabel();
            this.seasrchSpeshal = new MaterialSkin.Controls.MaterialLabel();
            this.searchCours = new MaterialSkin.Controls.MaterialLabel();
            this.searchSB = new MaterialSkin.Controls.MaterialLabel();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialCheckBoxCA = new MaterialSkin.Controls.MaterialCheckBox();
            this.SuspendLayout();
            // 
            // textBoxSearchSb
            // 
            this.textBoxSearchSb.Location = new System.Drawing.Point(125, 116);
            this.textBoxSearchSb.Name = "textBoxSearchSb";
            this.textBoxSearchSb.Size = new System.Drawing.Size(170, 20);
            this.textBoxSearchSb.TabIndex = 0;
            // 
            // textBoxSearchLayer
            // 
            this.textBoxSearchLayer.Location = new System.Drawing.Point(125, 90);
            this.textBoxSearchLayer.Name = "textBoxSearchLayer";
            this.textBoxSearchLayer.Size = new System.Drawing.Size(170, 20);
            this.textBoxSearchLayer.TabIndex = 1;
            // 
            // textBoxSerchName
            // 
            this.textBoxSerchName.Location = new System.Drawing.Point(125, 38);
            this.textBoxSerchName.Name = "textBoxSerchName";
            this.textBoxSerchName.Size = new System.Drawing.Size(170, 20);
            this.textBoxSerchName.TabIndex = 2;
            // 
            // textBoxSearchspec
            // 
            this.textBoxSearchspec.Location = new System.Drawing.Point(125, 64);
            this.textBoxSearchspec.Name = "textBoxSearchspec";
            this.textBoxSearchspec.Size = new System.Drawing.Size(170, 20);
            this.textBoxSearchspec.TabIndex = 3;
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
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(236, 151);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(59, 36);
            this.materialFlatButton1.TabIndex = 14;
            this.materialFlatButton1.Text = "Найти";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // materialCheckBoxCA
            // 
            this.materialCheckBoxCA.AutoSize = true;
            this.materialCheckBoxCA.Depth = 0;
            this.materialCheckBoxCA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.materialCheckBoxCA.Location = new System.Drawing.Point(1, 151);
            this.materialCheckBoxCA.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBoxCA.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBoxCA.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBoxCA.Name = "materialCheckBoxCA";
            this.materialCheckBoxCA.Ripple = true;
            this.materialCheckBoxCA.Size = new System.Drawing.Size(169, 30);
            this.materialCheckBoxCA.TabIndex = 15;
            this.materialCheckBoxCA.Text = "полное соответствие";
            this.materialCheckBoxCA.UseVisualStyleBackColor = true;
            // 
            // SerchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 205);
            this.Controls.Add(this.materialCheckBoxCA);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.searchSB);
            this.Controls.Add(this.searchCours);
            this.Controls.Add(this.seasrchSpeshal);
            this.Controls.Add(this.searchFiO);
            this.Controls.Add(this.textBoxSearchspec);
            this.Controls.Add(this.textBoxSerchName);
            this.Controls.Add(this.textBoxSearchLayer);
            this.Controls.Add(this.textBoxSearchSb);
            this.Name = "SerchForm";
            this.Text = "SerchForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSearchSb;
        private System.Windows.Forms.TextBox textBoxSearchLayer;
        private System.Windows.Forms.TextBox textBoxSerchName;
        private System.Windows.Forms.TextBox textBoxSearchspec;
        private MaterialSkin.Controls.MaterialLabel searchFiO;
        private MaterialSkin.Controls.MaterialLabel seasrchSpeshal;
        private MaterialSkin.Controls.MaterialLabel searchCours;
        private MaterialSkin.Controls.MaterialLabel searchSB;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBoxCA;
    }
}