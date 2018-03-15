using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace Laba2
{
    public partial class Form1 : Form
    {
        public static  Data data = new Data();
        public static  DataJson dataJson = new DataJson();
        public static  DataXml dataXml = new DataXml();
        public static  Validator Validator = new Validator();
        public static  DataSave DataSave = new DataSave();
        public static  DataSearch DataSearch = new DataSearch();

        public Form1()
        {
            InitializeComponent();
           
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                data.Add(new Student(
                    Validator.Validator_TextBox(textBoxFIO.Text),
                    Convert.ToInt32(Math.Round(numericUpDownAGE.Value, 0)),
                    dateTimePicker1.Value,
                    comboBoxSpec.GetItemText(comboBoxSpec.SelectedItem),
                    int.Parse(Validator.Validator_checkBox(checkedListBoxCours)),
                    int.Parse(Validator.Validator_checkBox(checkedListBoxGroup)),
                    int.Parse(Validator.Validator_TextBox_int(textBoxSB.Text)),
                    Validator.Validator_Sex(checkBoxM,checkBoxW),
                    new Adress(
                        textBoxCity.Text,
                        textBoxIndex.Text,
                        textBoxstreet.Text,
                        int.Parse(textBoxHome.Text),
                        int.Parse(textBoxFlat.Text)
                        ),
                    new Job(
                        textBoxCompany.Text,
                        textBoxPosition.Text,
                        double.Parse(textBoxExpensiv.Text)
                        )
 
                    ));
                viewdata(DataSave.SaveInJsonFormat(data), richTextBoxOutput);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,ex.Source);
            }
        }
        private void viewdata(DataJson data,RichTextBox richTextBox)
        {
            richTextBox.Clear();
            foreach(var item in data)
            {
                richTextBox.AppendText(item);
            }
        }
        private void viewdata(DataXml data, RichTextBox richTextBox)
        {
            richTextBox.Clear();
            foreach (var item in data)
            {
                richTextBox.AppendText(item);
            }
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                DataSave.SaveInTxtJson(data,openFileDialog1.FileName);
                
            }
          
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                string json = default(string);
                using (StreamReader file = new StreamReader(openFileDialog1.FileName))
                {
                    json = file.ReadToEnd();

                };
                data = JsonConvert.DeserializeObject<Data>(json);
                
            }
            viewdata(DataSave.SaveInJsonFormat(data), richTextBoxOutput);

        }

        private void SerchButton_Click(object sender, EventArgs e)
        {
            SerchForm serchForm = new SerchForm();
            serchForm.Show();
        }
    }
}
