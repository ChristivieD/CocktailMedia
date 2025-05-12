using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailEntityModels
{
    public class AppData
    {
        public static string DataPath { get; set; }
        public static readonly String CocktailListFileName = "cocktailList.csv";
        public static readonly String DataFolder = "Cocktaildata";

    }
}
