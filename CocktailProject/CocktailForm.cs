using CocktailControlLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CocktailEntityModels;
using CocktailProject;

namespace CocktailPresentation
{
    public partial class CocktailListForm : Form
    {
        CocktailManager _cocktailManager = new CocktailManager();
        public CocktailListForm()
        {
            InitializeComponent();
        }
        private void CocktailListForm_Load(object sender, EventArgs e)
        {
            populateList();
        }
        private void populateList()
        {
            List<Cocktail> cocktailList = null;
            try
            {
                cocktailList = _cocktailManager.GetCocktailsList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.InnerException.Message);
                return;
            }

            listCocktail.Items.Clear();

            for(int item = 0; item < cocktailList.Count; item++)
            {
                listCocktail.Items.Add(cocktailList[item].Name);
                listCocktail.Items[listCocktail.Items.Count - 1].SubItems.Add(cocktailList[item].Creation);
                listCocktail.Items[listCocktail.Items.Count - 1].SubItems.Add(cocktailList[item].Date.ToString());
                listCocktail.Items[listCocktail.Items.Count - 1].SubItems.Add(cocktailList[item].Bars);
            }
        }
        private void listCocktail_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listCocktail.SelectedIndices.Count > 0)
            {
                String cocktail = listCocktail.SelectedItems[0].Text;

                Cocktail selectedCocktail = null;
                try
                {
                    List<Cocktail> cocktails = _cocktailManager.GetCocktailsList();
                    foreach (Cocktail c in cocktails)
                    {
                        if (c.Name == cocktail)
                        {
                            selectedCocktail = c;
                            // MessageBox.Show(selectedCocktail.ImageFileName);
                            break;
                        }
                    }
                    CocktailArticleForm cocktailForm = new CocktailArticleForm(selectedCocktail, _cocktailManager);
                    cocktailForm.ShowDialog();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Select a cocktail from the list");
            }
        }

        private void btnArticle_Click(object sender, EventArgs e)
        {
            listCocktail_MouseDoubleClick(sender, (MouseEventArgs)e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addForm = new CocktailAddEditFrom();
            addForm.ShowDialog();
            _cocktailManager = new CocktailManager();
            populateList();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.listCocktail.SelectedIndices.Count > 0)
            {
                var editForm = new CocktailAddEditFrom(listCocktail.SelectedIndices[0], _cocktailManager);
                editForm.ShowDialog();
                _cocktailManager = new CocktailManager();
                populateList();
            }
            else
            {
                MessageBox.Show("Nothing seleted");
            }
        }
         
    }
}
