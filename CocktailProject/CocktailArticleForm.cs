using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using CocktailEntityModels;
using CocktailControlLogic;

namespace CocktailProject
{
    public partial class CocktailArticleForm : Form
    {
        // creating reference variable
        private CocktailManager _cocktailManager = null;
        private Cocktail _cocktail = null;
        private List<Cocktail> _cocktailList = null;
        private int _currentCocktail;
        public CocktailArticleForm(Cocktail cocktail, CocktailManager cocktailManager)
        {
            _cocktailManager = cocktailManager;
            _cocktail = cocktail;
            InitializeComponent();
        }

        private void showArticle()
        {
            try
            {
                CocktailArticle ca = _cocktailManager.GetCocktailArticle(_cocktail.ArticleFileName);
                txtArticle.Text = ca.ArticleText;
                lblTitle.Text = ca.Title;

                txtArticle.SelectionStart = int.MaxValue;
                Image cocktailImage = _cocktailManager.GetCocktailImage(_cocktail.ImageFileName);
                picCocktailImage.Image = cocktailImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.InnerException.Message);
            }
        }
        private void CocktailArticleForm_Load(object sender, EventArgs e)
        {
            lblTitle.Text = _cocktail.Name + ":";
            _cocktailList = _cocktailManager.GetCocktailsList();
            try
            {
                _cocktailList = _cocktailManager.GetCocktailsList();
                for (int i = 0; i < _cocktailList.Count; i++)
                {
                    if (_cocktailList[i].Name == _cocktail.Name)
                    {
                        _cocktail = _cocktailList[i];
                        _currentCocktail = i;
                        break;
                    }
                }
                showArticle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            
            if(_currentCocktail > _cocktailList.Count - 1)
            {
                _currentCocktail = 0;
            }
            _cocktail = _cocktailList[_currentCocktail];

            _currentCocktail++;
            lblTitle.Text = _cocktailList[_currentCocktail].Name;
            showArticle();
        }
        private void btnBack_Click_1(object sender, EventArgs e)
        {
            _currentCocktail--; ;
            if (_currentCocktail < 0)
            {
                _currentCocktail = _cocktailList.Count - 1;
            }
            lblTitle.Text = _cocktailList[_currentCocktail].Name;
            _cocktail = _cocktailList[_currentCocktail];
            showArticle();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
