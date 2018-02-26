using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba1
{
    public partial class Form2 : Form
    {
        Collection collection;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                try
                {
                    collection = new Collection(int.Parse(textBox1.Text));

                    foreach (var item in collection.list)
                    {
                        richTextBox2.Text += item + "\r\n";
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        private void Form2_FormClosed1(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            var order = from i in collection.list
                                 orderby i descending
                                 select i;
            foreach(var item in order)
            {
                richTextBox1.Text += item + "\r\n";

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            var order = from i in collection.list
                        orderby i 
                        select i;
            foreach (var item in order)
            {
                richTextBox1.Text += item + "\r\n";

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            var order = collection.list.Min();

            richTextBox1.Text += order;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            var order = collection.list.Max();

            richTextBox1.Text += order;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int res = default(int);
            foreach(var item in collection.list)
            {
                res += item;
            }
            richTextBox1.Clear();
            richTextBox1.Text += res;
        }
    }
}
