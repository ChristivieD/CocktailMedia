using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using CocktailControlLogic;
using CocktailEntityModels;

namespace CocktailProject
{
    partial class CocktailAddEditFrom : Form
    {
        bool editMode;
        String picFilename = " ";
        String dataPath = Application.StartupPath + "Cocktaildata";

        CocktailManager _cocktailManager;
        int _currentCocktail;

        public CocktailAddEditFrom()
        {
            editMode = false;
            _cocktailManager = new CocktailManager();
            InitializeComponent();
        }
        public CocktailAddEditFrom(int cocktailIndex, CocktailManager cocktailManager) 
        {
            editMode = true;
            _cocktailManager = cocktailManager;
            _currentCocktail = cocktailIndex;
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e){}
        private void textBox1_TextChanged(object sender, EventArgs e){}
        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.FileName = "";
            this.openFileDialog1.Multiselect = false;

            this.openFileDialog1.Filter = "png files (*.png)|*.png";

            this.openFileDialog1.InitialDirectory = dataPath;
            this.openFileDialog1.ShowDialog(this);

            if(openFileDialog1.FileName != null && openFileDialog1.FileName != "")
            {
                picCocktailImage.Image= Image.FromFile(openFileDialog1.FileName);
                picFilename = this.openFileDialog1.SafeFileName;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtCocktailName.Text == "")
            {
                MessageBox.Show("enter the cocktail name");
                txtCocktailName.Focus();
                return;
            }
            if (txtCreation.Text == "")
            {
                MessageBox.Show("Enter the country of origin");
                txtCreation.Focus();
                return;
            }
            if (txtDate.Text == "")
            {
                MessageBox.Show("Enter the creation date");
                txtDate.Focus();
                return;
            }
            if (txtbars.Text== "")
            {
                MessageBox.Show("enter a bar name");
                txtbars.Focus();
                return;
            }
            if (picCocktailImage.Image == null)
            {
                MessageBox.Show("Choose a cocktail picture");
                btnChooseImage.Focus();
                return;

            }
            if (txtArticleTitle.Text == "")
            {
                MessageBox.Show("enter an article title");
                txtArticleTitle.Focus();
                return;
            }
            if (txtArticleText.Text == "")
            {
                MessageBox.Show("enter the article text");
                txtArticleText.Focus();
                return;
            }
            if (txtArticleFileName.Text == "")
            {
                MessageBox.Show("enter the article filename");
                txtArticleFileName.Focus();
                return;
            }
            if (txtArticleFileName.Text.Length < 7)
            {
                MessageBox.Show("Inavalid file name. ");
                txtArticleFileName.Focus();
                return;
            }
            if (System.IO.File.Exists(dataPath + txtArticleFileName.Text) && editMode == false)
            {
                MessageBox.Show("File already exists");
                txtArticleFileName.Focus();
                return;
            }
            var cocktail = new Cocktail();
            cocktail.Name = txtCocktailName.Text;
            cocktail.Creation = txtCreation.Text;
            cocktail.Date = txtDate.Text;
            cocktail.Bars = txtbars.Text;
            cocktail.ImageFileName = picFilename;
            cocktail.ArticleFileName = txtArticleFileName.Text;

            var cocktailArticle = new CocktailArticle();
            cocktailArticle.Title = txtArticleTitle.Text;
            cocktailArticle.ArticleText = txtArticleText.Text;
            if (editMode == true)
            {
                _cocktailManager.EditCocktail(cocktail, cocktailArticle, _currentCocktail);
                this.Close();
            }
            else
            {
                int cocktailCount = _cocktailManager.CocktailList.Count;
                var newList = _cocktailManager.AddCocktail(cocktail, cocktailArticle);
                if (newList.Count > cocktailCount)
                {
                    MessageBox.Show("new cocktail added.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Add failed");
                    this.Close();
                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure?", "abandon Edits!", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void CocktailAddEditFrom_Load(object sender, EventArgs e)
        {
            if(editMode == true)
            {
            }
        }
    }
}
