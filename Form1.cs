using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp34 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            double rost = Convert.ToDouble(textBox1.Text); //Рост
            double ves = Convert.ToDouble(textBox2.Text); //Вес
            double vozr = Convert.ToDouble(textBox3.Text); //Возраст
                                                            //Определение типа и коэффициента по обхвату запястья
            if (this.radioButton1.Checked) //Переключатель Меньше 15 см
            {
                richTextBox1.Text =  "У Вас астенический тип\n";
            }
            if (this.radioButton2.Checked) //Переключатель От 15 до 17 см
            {
                richTextBox1.Text = "У Вас нормостенический тип\n";
            }
            if (this.radioButton3.Checked) //Переключатель Более 17 см
            {
                richTextBox1.Text = " У Вас гиперстенический тип\n" ;
             
            }
            //Расчет индекса массы тела по Кетле
           double imt = ves / Math.Pow((rost / 100.0), 2);
             richTextBox1.Text += "Индекс массы тела по Кетле = "
                                                                           + imt.ToString("0.00") + Environment.NewLine;
            //Анализ состояния тела по ИМТ по Кетле
            if (imt < 18.5)
                 richTextBox1.Text += "У вас дефицит веса" + Environment.NewLine;
            if (imt >= 18.5 && imt <= 24.9)
                 richTextBox1.Text += "У вас норма" + Environment.NewLine;
            if (imt >= 25.0 && imt <= 29.9)
                 richTextBox1.Text += "У вас избыточный вес" + Environment.NewLine;
            if (imt >= 30.0 && imt <= 34.9)
                 richTextBox1.Text += "У вас ожирение 1 степени" + Environment.NewLine;
            if (imt >= 35.0 && imt <= 39.9)
                 richTextBox1.Text += "У вас ожирение 2 степени" + Environment.NewLine;
            if (imt >= 40.0)
                 richTextBox1.Text += "У вас ожирение 3 степени" + Environment.NewLine;
             richTextBox1.Text += Environment.NewLine;

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }
    }
}
