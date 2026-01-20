using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace int_float_double_converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string secilenYazi =textBox1.Text;
           

            if (string.IsNullOrWhiteSpace(secilenYazi))
            {
                label1.Text = "Lütfen birini sec";
                return;
            }

            if (comboBox1.SelectedItem == null)
            {
                label1.Text = "Lütfen bir tür seçin";
                return;
            }

            string secilenCombo = comboBox1.SelectedItem.ToString();

            double sayiDouble;
            bool basarili = double.TryParse(secilenYazi, out sayiDouble);

            if (!basarili)
            {
                label1.Text = "Geçersiz sayı!";
                return;
            }

            switch (secilenCombo)
            {
                case "Int":
                    int sayiInt = int.Parse(textBox1.Text);

                    label1.Text = $"Int:   {sayiInt}";
                    break;

                case "Float":
                    float sayiFloat = (float)sayiDouble;
                    label1.Text = "Float: " + sayiFloat.ToString();
                    break;

                case "Double":
                    label1.Text = "Double: " + sayiDouble.ToString();
                    break;

                default:
                    label1.Text = "Geçersiz tür.";
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
