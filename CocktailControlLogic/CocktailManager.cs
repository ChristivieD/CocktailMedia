using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CocktailDataAccess;
using CocktailEntityModels;

namespace CocktailControlLogic
{
    public class CocktailManager
    {
        List<Cocktail> _cocktailList;
        public CocktailManager() 
        {
            _cocktailList = GetCocktailsList();
        }

        public Image GetCocktailImage(String imageName)
        {
            Image image = null;
            try
            {
                image = CocktailAccessor.RetrieveCocktailImage(imageName);
            }
            catch(Exception ex)
            {
                throw new ApplicationException("Iamge not found.", ex);
            }
            return image;
        }
        public CocktailArticle GetCocktailArticle(String articleName)
        {
            CocktailArticle cocktailArticle = null;
            try
            {
                cocktailArticle = CocktailAccessor.RetrieveCocktailArticle(articleName);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Article not found.", ex);
            }
            return cocktailArticle;
        }
        public List<Cocktail> GetCocktailsList()
        {
            List<Cocktail> cocktailList = null;
            try
            {
                cocktailList = CocktailAccessor.RetrieveCocktailList();
            }
            catch (Exception ex) 
            {
                throw new ApplicationException("The cocktail data was not retrieved.", ex);
            }
            return cocktailList;
        }
        public List<Cocktail> CocktailList
        {
            get { return _cocktailList; }
        }
        
        public List<Cocktail> EditCocktail(Cocktail cocktail, CocktailArticle cocktailArticle, int _currentCocktail)
        {
            try
            {
                _cocktailList[_currentCocktail] = cocktail;
                if (CocktailAccessor.UpdateCocktail(_currentCocktail, cocktailArticle, _cocktailList))
                {
                    _cocktailList = CocktailAccessor.RetrieveCocktailList();
                    return _cocktailList;
                }
                return _cocktailList;
            }
            catch (Exception  )
            {
                throw;
            }
        }
        public List<Cocktail> AddCocktail(Cocktail cocktail, CocktailArticle cocktailArticle) 
        {
            try
            {
                if (CocktailAccessor.AddCocktail(cocktail,cocktailArticle))
                {
                    _cocktailList = CocktailAccessor.RetrieveCocktailList();
                }
                return _cocktailList;
            }
            catch (Exception )
            {
                throw;
            }
        }
    }
}
