using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Laba2
{
    class Searcher
    {

        private string FIO;
        private string Spec;
        private string Layer;
        private string SB;
        public Searcher(string _fio, string _spec,string _layer, string _sb)
        {
            FIO = _fio;
            Spec = _spec;
            Layer = _layer;
            SB = _sb;
        }
        public Regex MakeRegex(Searcher searcher)
        {
            string[] combineLines = { "", "", "", "" };
            if (FIO == string.Empty)
                combineLines[0] = string.Empty;
            else
                combineLines[0] = this.FIO + "\\.?| ";
            if (Spec == string.Empty)
                combineLines[1] = string.Empty;
            else
            combineLines[1]=this.Spec + "\\.?| ";
            if (Layer == string.Empty)
                combineLines[2] = string.Empty;
            else
                combineLines[2] = this.Layer + "\\.?| ";
            if (SB == string.Empty)
                combineLines[3] = string.Empty;
            else
                combineLines[3] = this.Layer + "\\.?| ";

            return new Regex(@"[(" + combineLines[0] + combineLines[1] + combineLines[2] + combineLines[3] + ")]",RegexOptions.Singleline);


        }

        public DataSearch Serch(Data data,Regex patterns, bool confirmity)
        {
            DataSearch returnSearch = new DataSearch();
            foreach(var item in data)
            {
              
                   
                        if (patterns.IsMatch(item.Index))
                            returnSearch.Add(item);
                           
                    
                
            }

            return returnSearch;
        }



    }
}
