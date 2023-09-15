using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form2
{
    public partial class Form1 : Form
    {
        private string[] сitiesOfRussia = { "Москва", "Санкт-Петербург", "Ставрополь" };
        private string[] сitiesOfUkraine = { "Киев", "Николаев", "Одесса" };
        private string[] сitiesOfKazakhstan = { "Астана", "Есик", "Уральск" };
        private string[] сitiesOfUSA = { "Лос-Анджелес", "Нью-Йорк", "Сан-Франциско" };

        public Form1()
        {
            InitializeComponent();

            this.cityComboBox.Enabled = false;
            this.maleRadioButton.Checked = true;
        }

        private void resultRichTextBox_TextChanged(object sender, EventArgs e)
        {
            this.resultRichTextBox.Text = $"Фамилия: {this.surnameTextBox.Text}\n" +
                $"Имя: {this.nameTextBox.Text}\n" +
                $"Отчество: {this.patronymicTextBox.Text}\n\n" +
                $"Пол: {(this.maleRadioButton.Checked == true ? "мужской" : "женский")}\n\n" +
                $"Страна: {this.countryComboBox.Text}\n" +
                $"Город: {this.cityComboBox.Text}\n";
        }

        private void countryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cityComboBox.Enabled = true; // comboBox c выбором города становится активным
            this.cityComboBox.Items.Clear(); // принудительно очищается этот comboBox

            switch (this.countryComboBox.Text)
            {
                case "Россия": this.cityComboBox.Items.AddRange(this.сitiesOfRussia); break;
                case "Украина": this.cityComboBox.Items.AddRange(this.сitiesOfUkraine); break;
                case "Казахстан": this.cityComboBox.Items.AddRange(this.сitiesOfKazakhstan); break;
                case "США": this.cityComboBox.Items.AddRange(this.сitiesOfUSA); break;
            }
        }

        private void completeButton_Click(object sender, EventArgs e)
        {
            if (this.surnameTextBox.Text == "" || this.nameTextBox.Text == "" || this.patronymicTextBox.Text == "" || this.countryComboBox.Text == "" || this.cityComboBox.Text == "") // это бы в отдельный метод засунуть, но пусть так будет
            {
                string errorMessage = null;

                if (this.surnameTextBox.Text == "")
                {
                    errorMessage += "Вы не заполнили поле с фамилией!\n";
                }
                if (this.nameTextBox.Text == "")
                {
                    errorMessage += "Вы не заполнили поле с именем!\n";
                }
                if (this.patronymicTextBox.Text == "")
                {
                    errorMessage += "Вы не заполнили поле с отчеством!\n";
                }
                if (this.countryComboBox.Text == "")
                {
                    errorMessage += "Вы не заполнили поле со страной!\n";
                }
                if (this.cityComboBox.Text == "")
                {
                    errorMessage += "Вы не заполнили поле с городом!\n";
                }

                MessageBox.Show(errorMessage, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Анкета была отправлена, спасибо!", "Анкета", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
