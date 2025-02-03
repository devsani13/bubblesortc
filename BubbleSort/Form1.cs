using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BubbleSort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] num = new int[10];
        int i, aux, fim;
        Random r = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (i = 0; i < 10; i++)
            {
                num[i] = r.Next(100);
                listBox1.Items.Add(num[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (fim = 8; fim >= 0; fim--)
            {
                for (i = 0; i <= fim; i++)
                {
                    if (num[i] > num[i + 1])
                    {
                        aux = num[i];
                        num[i] = num[i + 1];
                        num[i + 1] = aux;
                    }
                }
            }
            for (i = 0; i < 10; i++)
            {
                listBox2.Items.Add(num[i]);
            }
        }
    }
}
