using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace WordsCount.BL
{
    public class BL
    {
        public DataSet GetAllCategories()
        {
            DAL.DAL obj = new DAL.DAL();
            return obj.GetAllCategories();
        }

        public string GetTextFromFile(string path)
        {
            string text = File.ReadAllText(path);
            return text;
        }

    }
}
