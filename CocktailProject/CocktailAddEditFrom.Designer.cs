namespace CocktailProject
{
    partial class CocktailAddEditFrom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.txtCocktailName = new System.Windows.Forms.TextBox();
            this.txtCreation = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtArticleTitle = new System.Windows.Forms.TextBox();
            this.txtArticleText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtArticleFileName = new System.Windows.Forms.TextBox();
            this.picCocktailImage = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnChooseImage = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbars = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picCocktailImage)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCocktailName
            // 
            this.txtCocktailName.Location = new System.Drawing.Point(47, 37);
            this.txtCocktailName.Name = "txtCocktailName";
            this.txtCocktailName.Size = new System.Drawing.Size(205, 22);
            this.txtCocktailName.TabIndex = 0;
            // 
            // txtCreation
            // 
            this.txtCreation.Location = new System.Drawing.Point(47, 100);
            this.txtCreation.Name = "txtCreation";
            this.txtCreation.Size = new System.Drawing.Size(205, 22);
            this.txtCreation.TabIndex = 1;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(47, 159);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(205, 22);
            this.txtDate.TabIndex = 2;
            // 
            // txtArticleTitle
            // 
            this.txtArticleTitle.Location = new System.Drawing.Point(375, 62);
            this.txtArticleTitle.Name = "txtArticleTitle";
            this.txtArticleTitle.Size = new System.Drawing.Size(173, 22);
            this.txtArticleTitle.TabIndex = 6;
            // 
            // txtArticleText
            // 
            this.txtArticleText.Location = new System.Drawing.Point(375, 128);
            this.txtArticleText.Multiline = true;
            this.txtArticleText.Name = "txtArticleText";
            this.txtArticleText.Size = new System.Drawing.Size(374, 241);
            this.txtArticleText.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(372, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Article Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cocktail Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Creation Country";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(372, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Article Text";
            // 
            // txtArticleFileName
            // 
            this.txtArticleFileName.Location = new System.Drawing.Point(375, 405);
            this.txtArticleFileName.Name = "txtArticleFileName";
            this.txtArticleFileName.Size = new System.Drawing.Size(374, 22);
            this.txtArticleFileName.TabIndex = 15;
            // 
            // picCocktailImage
            // 
            this.picCocktailImage.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.picCocktailImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picCocktailImage.Location = new System.Drawing.Point(57, 263);
            this.picCocktailImage.Name = "picCocktailImage";
            this.picCocktailImage.Size = new System.Drawing.Size(171, 150);
            this.picCocktailImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCocktailImage.TabIndex = 11;
            this.picCocktailImage.TabStop = false;
            this.picCocktailImage.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(375, 433);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 43);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(564, 433);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 43);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.Location = new System.Drawing.Point(78, 433);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(114, 43);
            this.btnChooseImage.TabIndex = 3;
            this.btnChooseImage.Text = "Choose Image";
            this.btnChooseImage.UseVisualStyleBackColor = true;
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(372, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Article FileName";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Bars";
            // 
            // txtbars
            // 
            this.txtbars.Location = new System.Drawing.Point(47, 216);
            this.txtbars.Name = "txtbars";
            this.txtbars.Size = new System.Drawing.Size(205, 22);
            this.txtbars.TabIndex = 17;
            this.txtbars.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CocktailAddEditFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 497);
            this.Controls.Add(this.txtbars);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnChooseImage);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.picCocktailImage);
            this.Controls.Add(this.txtArticleFileName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtArticleText);
            this.Controls.Add(this.txtArticleTitle);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtCreation);
            this.Controls.Add(this.txtCocktailName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CocktailAddEditFrom";
            this.Text = "CocktailAddEditFrom";
            ((System.ComponentModel.ISupportInitialize)(this.picCocktailImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCocktailName;
        private System.Windows.Forms.TextBox txtCreation;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtArticleTitle;
        private System.Windows.Forms.TextBox txtArticleText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtArticleFileName;
        private System.Windows.Forms.PictureBox picCocktailImage;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnChooseImage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbars;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
