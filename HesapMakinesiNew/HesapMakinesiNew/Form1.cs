using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesiNew
{
    public partial class Form1 : Form
    {
        double sayi1, sayi2;
        double sonuc;
        bool control = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // 0, 1, 2, 3, 4, 5, 6, 7, 8, 9
            Button btn = (Button)sender;
           
            if (label2.Text != "+" && label2.Text != "-" && label2.Text != "*" && label2.Text != "/" && label2.Text != "pow" && label2.Text != "mod" && label2.Text != "ebob" && label2.Text != "ekok" && label2.Text != "√")
            {
                 label1.Text += Convert.ToString(btn.Text);
            }
            else
            {
                label3.Text += Convert.ToString(btn.Text);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label5.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // +, -, *, / 
            Button btn2 = (Button)sender;
            label2.Text = Convert.ToString(btn2.Text);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            // ±
            if (int.Parse(label1.Text) > 0)
            {
                sayi1 = Convert.ToDouble(label1.Text);
                double eksiSayi1 = sayi1 * -1;
                label1.Text = Convert.ToString(eksiSayi1);
            }
            else if (int.Parse(label3.Text) > 0)
            {
                sayi2 = Convert.ToDouble(label3.Text);
                double eksiSayi2 = sayi2 * -1;
                label3.Text = Convert.ToString(eksiSayi2);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // C
            label1.Text = " ";
            label2.Text = " ";
            label3.Text = " ";
            label4.Text = " ";
            label5.Text = " ";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // CE 
            if (label4.Text != " ")
            {
                label4.Text = " ";
            }
            else if (label3.Text != " ")
            {
                label3.Text = " ";
            }
            else if (label2.Text != " ")
            {
                label2.Text = " ";
            }
            else if (label1.Text != " ")
            {
                label1.Text = " ";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            // pow, ebob, ekok, mod ve √ 
            Button btn3 = (Button)sender;
            label2.Text = btn3.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // <
            if (label2.Text != "")
                control = true;
            else
                control = false;
            
            if(label1.Text != "" && control == false)
            {
                label1.Text = label1.Text.Remove(label1.Text.Length - 1);
            }
            else if (label1.Text != null && control == true && label3.Text != null)
            {
                label3.Text = label3.Text.Remove(label3.Text.Length - 1);
            }
            
        }

        private void button26_Click(object sender, EventArgs e)
        {
            //Gecmis 
            label5.Visible = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            // , 
            if (label2.Text != "+" && label2.Text != "-" && label2.Text != "*" && label2.Text != "/" && label2.Text != "pow" && label2.Text != "mod" && label2.Text != "ebob" && label2.Text != "ekok" && label2.Text != "√")
            {
                label1.Text += ",";
            }

            if (label2.Text == "+" || label2.Text == "-" || label2.Text == "*" || label2.Text == "/")
            {
                label3.Text += ",";
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            //Kapat
            this.Close();
            Application.Exit();
        }

        private void button21_Click_1(object sender, EventArgs e)
        {
            // E 
            if (label2.Text == "/")
            {
                sayi1 = Convert.ToDouble(label1.Text);
                sayi2 = Convert.ToDouble(label3.Text);
                sonuc = sayi1 / sayi2;
            }
            else if (label2.Text == "+")
            {
                sayi1 = Convert.ToDouble(label1.Text);
                sayi2 = Convert.ToDouble(label3.Text);
                sonuc = sayi1 + sayi2;
            }
            else if (label2.Text == "-")
            {
                sayi1 = Convert.ToDouble(label1.Text);
                sayi2 = Convert.ToDouble(label3.Text);
                sonuc = sayi1 - sayi2;
            }
            else if (label2.Text == "*")
            {
                sayi1 = Convert.ToDouble(label1.Text);
                sayi2 = Convert.ToDouble(label3.Text);
                sonuc = sayi1 * sayi2;
            }
            else if (label2.Text == "pow")
            {
                sayi1 = Convert.ToDouble(label1.Text);
                sayi2 = Convert.ToDouble(label3.Text);
                sonuc = Math.Pow(sayi1, sayi2);
            }
            else if (label2.Text == "√")
            {
                if(label1.Text != " ")
                {
                    sayi1 = Convert.ToDouble(label1.Text);
                    sonuc = Math.Sqrt(sayi1);
                }
                else
                {
                    MessageBox.Show("Birinci Sayi Esas Alinacaktir.", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (label2.Text == "mod")
            {
                sayi1 = Convert.ToDouble(label1.Text);
                sayi2 = Convert.ToDouble(label3.Text);
                sonuc = sayi1 % sayi2;
            }
            else if (label2.Text == "ebob")
            {
                sayi1 = Convert.ToDouble(label1.Text);
                sayi2 = Convert.ToDouble(label3.Text);
                int ebob = 0;
                for (int i = 1; i < sayi1; i++)
                {
                    if (sayi1 % i == 0 && sayi2 % i == 0)
                    {
                        ebob = i;
                    }
                }
                sonuc = ebob;
            }
            else if (label2.Text == "ekok")
            {
                int intSayi1 = Convert.ToInt32(label1.Text);
                int intSayi2 = Convert.ToInt32(label3.Text);
                int ekok = 0;
                int max = intSayi1 * intSayi2;
                for (int i = max; i > 0; i--)
                {
                    if (i % intSayi1 == 0 && i % intSayi2 == 0)
                    {
                        ekok = i;
                    }
                }
                int doubleSonuc = ekok;
                sonuc = Convert.ToDouble(doubleSonuc);
            }
            if (label1.Text == " ") //Gerekli uyarılar
            {
                MessageBox.Show("İki Sayi Girilmeden İşlem Yapılamaz!", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (label3.Text == " " && label1.Text != " " && label2.Text != "√")
            {
                MessageBox.Show("İkinci Sayi Girilmeli!", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            label4.Text = "= " + sonuc.ToString();

            if (label4.Text != " ") //Geçmiş yazdırmak
            {
                label5.Text += label1.Text + " " + label2.Text + label3.Text + label4.Text + "\n";
            }
        }
    }  
}
