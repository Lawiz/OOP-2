using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
namespace Laba2
{
    class Validator
    {
        private const string Error_msg ="некорректный ввод";
        private const string Error_mas_checkBox = "Выберите один элемент";
        private const string Data_Empty = "Значение не выбрано";


        public string Validator_TextBox(string fio)
        {
            if (fio.Any(c => char.IsLetter(c)))
                return fio;
            else return Error_msg;
        }
        public string Validator_TextBox_int(string fio)
        {
            if (!fio.Any(c => char.IsLetter(c)))
                return fio;
            else return Error_msg;
        }

        public string Validator_Age(int age)
        {
            if (age < 0 || age > 141)
                return Error_msg;
            else return age.ToString();
        }


        public string Validator_checkBox(CheckedListBox cb)
        {
            if (cb.SelectedItems.Count < 1)
                return Error_mas_checkBox;
            else
                return cb.SelectedItem.ToString();
        }
        public string Validator_Sex(CheckBox cb1,CheckBox cb2)
        {
            if (cb1.Checked && !cb2.Checked)
                return "м";
            if (!cb1.Checked && cb2.Checked)
                return "ж";
            if (!cb1.Checked && !cb2.Checked)
                return Data_Empty;
            if (cb1.Checked && cb2.Checked)
                return Error_msg;
            return string.Empty;

        }



    }
}
