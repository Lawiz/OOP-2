using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba2
{
    public partial class SearchResult : Form
    {
        public SearchResult()
        {
            InitializeComponent();
            
            ShowResult();
        }
        private void ShowResult()
        {
            foreach (var item in Form1.DataSearch)
            {
                richTextBoxResult.Text += item.ToString()+"\r\n";
            }
        }
    }
}
