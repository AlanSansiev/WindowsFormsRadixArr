using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsRadixArr
{
    public partial class Form1 : Form
    {
        Arr arr;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonRandomoutput_Click(object sender, EventArgs e)
        {

            statusStrip1.Text = "Генерирую";
            int from = Convert.ToInt32(textBoxFrom.Text);
            int to = Convert.ToInt32(textBoxTo.Text);
            uint count = Convert.ToUInt32(textBoxRandCount.Text);
            arr = new Arr();
            arr.loadFromRandom(from, to, count);
            initialArr.Text = arr.toStr();
            statusStrip1.Text = "Сгенерировано";


        }



        private void button1_Click_1(object sender, EventArgs e)
        {

            arr = new Arr();
            arr.loadFromString(textBoxKeyboard.Text);
            initialArr.Text = arr.toStr();

            statusStrip1.Text = "Загружено";

        }

        private void buttonSort_Click_1(object sender, EventArgs e)
        {

                if (arr != null)
            {
                buttonSort.Enabled = false;
                statusStrip1.Text = "Сортирую";
                arr.Sort();
                sortedArr.Text = arr.toStr();
                buttonSort.Enabled = true;
                statusStrip1.Text = "Массив отсортирован";
                Int64 t= arr.getTime();
                textBoxtime.Text = Convert.ToString(t);
                int k = arr.getArray().Length;
                textBoxmas.Text = Convert.ToString(k);
                

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Текстовые файлы (*.txt)|*.txt";
            if (fd.ShowDialog() == DialogResult.OK)
                FilePath.Text = fd.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string path = FilePath.Text;
            if (File.Exists(path))
            {
                arr = new Arr();
                arr.loadFromFile(path);
                initialArr.Text = arr.toStr();
                statusStrip1.Text = "Загружено";
            }


        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "Текстовые файлы (*.txt)|*.txt";
            ;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                statusStrip1.Text = "Сохранение";
                StreamWriter SW = new StreamWriter(fd.FileName);
                string[] tmparr = sortedArr.Text.Split(' ');
                for (int t = 0; t < tmparr.Length; t++)
                {
                    SW.WriteLine(tmparr[t]);
                }
                SW.Close();
                statusStrip1.Text = "Результат сохранен";
            }
        }

        private void textBoxmas_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBoxtime_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxKeyboard_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
