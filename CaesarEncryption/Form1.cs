using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaesarEncryption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        char[] TextNormal;
        String cipher;
        int adim = 2;

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            TextNormal = textBox1.Text.ToCharArray();
            for (int i = 0; i < TextNormal.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (TextNormal[i] == alphabet[j])
                    {
                        if (j + adim > 25)
                        {
                            int a = (j + adim) - 25;
                            cipher = cipher + alphabet[a];

                        }
                        else
                        {
                            cipher = cipher + alphabet[j + adim];
                        }
                    }
                }
            }

            textBox2.Text = cipher;
            cipher = "";

        }

        private void textBoxCount_TextChanged(object sender, EventArgs e)
        {
            adim = Convert.ToInt32(textBoxCount.Text) - 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            TextNormal = textBox2.Text.ToCharArray();
            for (int i = 0; i < TextNormal.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (TextNormal[i] == alphabet[j])
                    {
                        if (j - adim < 0)
                        {
                            int a = 25 + (j - adim);
                            cipher = cipher + alphabet[a];
                        }
                        else
                        {
                            cipher = cipher + alphabet[j - adim];
                        }
                    }
                }
            }

            textBox1.Text = cipher;
            cipher = "";

        }
    }
}
