using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практика
{
    public partial class Form1 : Form
    {
        private MyArray array = new MyArray();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.AllowUserToAddRows = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int length = (int)numericUpDown1.Value;
            int diapasonA = (int)numericUpDown2.Value;
            int diapasonB = (int)numericUpDown3.Value;
            if (diapasonA >= diapasonB)
            {
                MessageBox.Show("Неверно задан диапазон");
                return;
            }
            array.Create(length, diapasonA, diapasonB);
            PrintArray();
        }

        private void PrintArray()
        {
            try
            {
                int length = array.GetLegth();
                if (length > 100)
                {
                    MessageBox.Show("Слишком много элементов, они не будут выведены в таблицу"); return;
                }
                if (dataGridView1.RowCount > 0)
                {
                    dataGridView1.Rows.Clear();
                }

                dataGridView1.ColumnCount = length;

                for (int i = 0; i < length; i++)
                {
                    dataGridView1.Columns[i].Name = $"Column{i + 1}";
                }

                dataGridView1.Rows.Add();

                for (int i = 0; i < length; i++)
                {
                    dataGridView1.Rows[0].Cells[i].Value = array.GetByIndex(i).ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Не удалось вывести элементы в таблицу"); return;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!array.GetStatus())
            {
                MessageBox.Show("Массив не создан"); return;
            }

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            array.Sort();
            stopwatch.Stop();
            PrintArray();
            textBox1.Text = stopwatch.Elapsed.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!array.GetStatus())
            {
                MessageBox.Show("Массив не создан"); return;
            }
            int length = array.GetLegth();
            int cellIndex = 0;
            for (int i = length - 1; i >= 0; i--)
            {
                dataGridView1.Rows[0].Cells[cellIndex].Value = array.GetByIndex(i);
                cellIndex++;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!array.GetStatus())
            {
                MessageBox.Show("Массив не создан"); return;
            }
            PrintArray();
        }
    }
}
