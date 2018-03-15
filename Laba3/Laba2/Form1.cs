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

namespace Laba2
{
    public partial class Form1 : Form
    {
        Data data = new Data();
        DataJson dataJson = new DataJson();
        DataXml dataXml = new DataXml();
        Validator Validator = new Validator();
        DataSave DataSave = new DataSave();

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
                    int.Parse(Validator.Validator_Age((int)numericUpDownAGE.Value)),
                    dateTimePicker1.Value,
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
                data = DataSave.DeserialiseFromJson(openFileDialog1.FileName);
            }
            viewdata(DataSave.SaveInJsonFormat(data), richTextBoxOutput);

        }

        private void materialFlatButtonSearch_Click(object sender, EventArgs e)
        {
            SerchForm serchForm = new SerchForm();
            serchForm.Show();
        }
    }
}
