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
    public partial class SerchForm : Form
    {
        Searcher searcher;
        public SerchForm()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            searcher = new Searcher(
                                        textBox3.Text,
                                        textBox4.Text,
                                        textBox2.Text,
                                        textBox1.Text
                );
            Form1.DataSearch=searcher.Serch(Form1.data, searcher.MakeRegex(searcher), checkBoxConfirmity.Checked);

            SearchResult searchResult = new SearchResult();
            searchResult.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
