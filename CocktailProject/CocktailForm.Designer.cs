namespace CocktailPresentation
{
    partial class CocktailListForm
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
            this.btnArticle = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPlace = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listCocktail = new System.Windows.Forms.ListView();
            this.colBars = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnArticle
            // 
            this.btnArticle.Location = new System.Drawing.Point(31, 341);
            this.btnArticle.Name = "btnArticle";
            this.btnArticle.Size = new System.Drawing.Size(158, 69);
            this.btnArticle.TabIndex = 1;
            this.btnArticle.Text = "Article\r\n";
            this.btnArticle.UseVisualStyleBackColor = true;
            this.btnArticle.Click += new System.EventHandler(this.btnArticle_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(313, 341);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(158, 69);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(605, 341);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(158, 69);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // colName
            // 
            this.colName.Text = "CocktailName";
            this.colName.Width = 200;
            // 
            // colPlace
            // 
            this.colPlace.Text = "Creation_place";
            this.colPlace.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colPlace.Width = 150;
            // 
            // colDate
            // 
            this.colDate.Text = "Date";
            this.colDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colDate.Width = 100;
            // 
            // listCocktail
            // 
            this.listCocktail.BackColor = System.Drawing.Color.LightCoral;
            this.listCocktail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colPlace,
            this.colDate,
            this.colBars});
            this.listCocktail.FullRowSelect = true;
            this.listCocktail.GridLines = true;
            this.listCocktail.HideSelection = false;
            this.listCocktail.Location = new System.Drawing.Point(12, 72);
            this.listCocktail.MultiSelect = false;
            this.listCocktail.Name = "listCocktail";
            this.listCocktail.Size = new System.Drawing.Size(776, 235);
            this.listCocktail.TabIndex = 0;
            this.listCocktail.UseCompatibleStateImageBehavior = false;
            this.listCocktail.View = System.Windows.Forms.View.Details;
            this.listCocktail.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listCocktail_MouseDoubleClick);
            // 
            // colBars
            // 
            this.colBars.Text = "Bars Place";
            this.colBars.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colBars.Width = 300;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(28, 37);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(487, 25);
            this.lblInfo.TabIndex = 4;
            this.lblInfo.Text = "Choose a cocktail to get more information about it";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CocktailListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnArticle);
            this.Controls.Add(this.listCocktail);
            this.Name = "CocktailListForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CocktailListForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnArticle;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ListView listCocktail;
        public System.Windows.Forms.ColumnHeader colName;
        public System.Windows.Forms.ColumnHeader colPlace;
        public System.Windows.Forms.ColumnHeader colDate;
        private System.Windows.Forms.Label lblInfo;
        public System.Windows.Forms.ColumnHeader colBars;
    }
}

