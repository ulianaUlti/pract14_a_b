using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRACTICA14_3_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
               
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n=0;
           
            if(textBox1.Text ==" ")
            {
                MessageBox.Show("Пустое поле");
               n = Convert.ToInt32(Console.ReadLine());
            }
            Queue Q = new Queue();
            for (int i = 1; i < n; i++)
            {

                Q.Enqueue(i);
                label2.Text = ("Размер очереди равно " + Q.Count);
                label3.Text = ("Верхний элемент в очереди" + Q.Peek());
                label4.Text = ("Содержимое равно ");
                while (Q.Count != 0)
                {
                    label5.Text ="{0}"+Q.Dequeue();
                }
                label6.Text = ("Новая размерность " + Q.Count);
            }
        }
    }
}
