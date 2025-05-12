using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CocktailEntityModels;
using System.Drawing;

namespace CocktailDataAccess
{
    public class CocktailAccessor
    {
        public static Image RetrieveCocktailImage(String imageName)
        {
            Image image = null; ;
            try
            {
                image = Image.FromFile(AppData.DataPath + imageName);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return image;
        }

        public static CocktailArticle RetrieveCocktailArticle(String articleName)
        {
            CocktailArticle cocktailArticle = new CocktailArticle();
            StreamReader fileReader = null;
            try
            {
                fileReader = new StreamReader(AppData.DataPath + articleName);
                cocktailArticle.Title = fileReader.ReadLine();
                cocktailArticle.ArticleText = fileReader.ReadToEnd();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                fileReader.Close();
            }
            return cocktailArticle;
        }
        // end retrieve article
        public static List<Cocktail> RetrieveCocktailList()
        { 
            List<Cocktail> cocktailList = new List<Cocktail>();

            char[] separator = { ',' };
            StreamReader fileReader = null;
            // unsafe 
            try
            {
                fileReader = new StreamReader(AppData.DataPath + AppData.CocktailListFileName);
                while (fileReader.EndOfStream == false)
                {
                    String line = fileReader.ReadLine();
                    String[] parts;
                    if (line.Length > 16)
                    {
                        parts = line.Split(separator);
                        if (parts.Count() == 6)
                        {
                            Cocktail newCocktail = new Cocktail()
                            {
                                Name = parts[0],
                                Creation = parts[1],
                                Date = parts[2],
                                Bars = parts[3],
                                ArticleFileName = parts[4],
                                ImageFileName = parts[5]

                            };
                            cocktailList.Add(newCocktail);
                        }
                    }
                }
            }
            catch (Exception) 
            {
                throw;
            }
            finally
            {
                fileReader.Close();
            }
            return cocktailList;
        }   // end of cocktail list

        

        public static bool UpdateCocktail(int cocktailIndex, CocktailArticle cocktailArticle,List<Cocktail> cocktailList)
        {
            try
            {
                StreamWriter fileWriter = new StreamWriter(AppData.DataPath + @"\" + cocktailList[cocktailIndex].ArticleFileName);
                fileWriter.WriteLine(cocktailArticle.Title);
                fileWriter.WriteLine(cocktailArticle.ArticleText);
                fileWriter.Close();

                StreamWriter fileWriter2 = new StreamWriter(AppData.DataPath + @"\" + AppData.CocktailListFileName);
                foreach (Cocktail cocktail in cocktailList)
                {
                    fileWriter2.WriteLine(cocktail.Name + "," +
                                           cocktail.Creation + "," +
                                           cocktail.Date + "," +
                                           cocktail.Bars + "," +
                                           cocktail.ArticleFileName + "," +
                                           cocktail.ImageFileName);
                }
                fileWriter2.Close();
                } 
                catch (Exception) 
                {
                    return false;
                }
            return true;
        }

        public static bool AddCocktail(Cocktail cocktail, CocktailArticle cocktailArticle)
        {
            try
            {
               StreamWriter fileWriter = new StreamWriter(AppData.DataPath + @"\" + cocktail.ArticleFileName);
                fileWriter.WriteLine(cocktailArticle.Title);
                fileWriter.Write(cocktailArticle.ArticleText);
                fileWriter.Close();

                StreamWriter fileWriter2 = new StreamWriter(AppData.DataPath + @"\" + AppData.CocktailListFileName, true);
                fileWriter2.WriteLine(cocktail.Name + ","+
                                        cocktail.Creation + "," +
                                        cocktail.Date + "," +
                                        cocktail.Bars+ "," +
                                        cocktail.ArticleFileName + "," +
                                        cocktail.ImageFileName);
                fileWriter2.Close();
            }
            catch(Exception)
            { 
                return false;
            }
            return true;
        }

    }
}
