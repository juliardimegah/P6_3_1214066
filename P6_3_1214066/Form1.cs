using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace P6_3_1214066
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtHuruf_Leave(object sender, EventArgs e)
        {
            if(txtHuruf.Text == "")
            {
                epWarning.SetError(txtHuruf, "TextBox huruf tidak boleh kosong");
                epWrong.SetError(txtHuruf, "");
                epCorrect.SetError(txtHuruf, "");
            }
            else
            {
                if ((txtHuruf.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(txtHuruf, "");
                    epWrong.SetError(txtHuruf, "");
                    epCorrect.SetError(txtHuruf, "Betul!");
                }
                else
                {
                    epWarning.SetError(txtHuruf, "");
                    epWrong.SetError(txtHuruf, "Inputan hanya boleh huruf!");
                    epCorrect.SetError(txtHuruf, "");
                }
            }
        }

        private void txtAngka_Leave(object sender, EventArgs e)
        {
            if (txtAngka.Text == "")
            {
                epWarning.SetError(txtAngka, "Textbox angka tidak boleh kosong!");
                epWrong.SetError(txtAngka, "");
                epCorrect.SetError(txtAngka, "");
            }

            else if ((txtAngka.Text).All(Char.IsNumber))
            {
                epWarning.SetError(txtAngka, "");
                epWrong.SetError(txtAngka, "");
                epCorrect.SetError(txtAngka, "Betul!");
            }

            else
            {
                epWarning.SetError(txtAngka, "");
                epWrong.SetError(txtAngka, "Inputan hanya boleh angka!");
                epCorrect.SetError(txtAngka, "");
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                epWarning.SetError(txtEmail, "Text box email tidak boleh kosong!");
                epWrong.SetError(txtEmail, "");
                epCorrect.SetError(txtEmail, "");
            }
            else if (Regex.IsMatch(txtEmail.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
            {
                epWarning.SetError(txtEmail, "");
                epWrong.SetError(txtEmail, "");
                epCorrect.SetError(txtEmail, "Betul!");
            }
            else
            {
                epWarning.SetError(txtEmail, "");
                epWrong.SetError(txtEmail, "Format email salah!\nContoh: a@b.c");
                epCorrect.SetError(txtEmail, "");
            }
        }

        private void txtAngka1_Leave(object sender, EventArgs e)
        {
            int[] arraynumber = new int[10];
            arraynumber[0] = int.Parse(txtAngka1.Text);
            arraynumber[1] = int.Parse(txtAngka2.Text);

            if (txtAngka2.Text == "")
            {
                epWarning.SetError(txtAngka2, "TextBox angka 2 tidak boleh kosong");
                epWrong.SetError(txtAngka2, "");
                epCorrect.SetError(txtAngka2, "");
            }
            else
            {
                if ((txtAngka1.Text).All(Char.IsNumber))
                {
                    if (arraynumber[0] >= arraynumber[1])
                    {
                        epWarning.SetError(txtAngka1, "");
                        epWrong.SetError(txtAngka1, "");
                        epCorrect.SetError(txtAngka1, "Betul!");
                        epWarning.SetError(txtAngka2, "");
                        epWrong.SetError(txtAngka2, "");
                        epCorrect.SetError(txtAngka2, "Betul!");
                    }

                    else if (arraynumber[0] < arraynumber[1])
                    {
                        epWarning.SetError(txtAngka1, "Angka 2 harus lebih kecil dari angka 1");
                        epWrong.SetError(txtAngka1, "");
                        epCorrect.SetError(txtAngka1, "");
                        epWarning.SetError(txtAngka2, "Angka 2 harus lebih kecil dari angka 1");
                        epWrong.SetError(txtAngka2, "");
                        epCorrect.SetError(txtAngka2, "");
                    }

                    else
                    {
                        epWarning.SetError(txtAngka1, "");
                        epWrong.SetError(txtAngka1, "Inputan hanya boleh angka!");
                        epCorrect.SetError(txtAngka1, "");
                    }
                }
            }
        }
        private void txtAngka2_Leave(object sender, EventArgs e)
        {

            int[] arraynumber = new int[10];
            arraynumber[0] = int.Parse(txtAngka1.Text);
            arraynumber[1] = int.Parse(txtAngka2.Text);

            if (txtAngka1.Text == "")
            {
                epWarning.SetError(txtAngka2, "TextBox angka 1 tidak boleh kosong");
                epWrong.SetError(txtAngka2, "");
                epCorrect.SetError(txtAngka2, "");
            }
            else
            {
                if ((txtAngka1.Text).All(Char.IsNumber))
                {
                    if (arraynumber[0] >= arraynumber[1])
                    {
                        epWarning.SetError(txtAngka2, "");
                        epWrong.SetError(txtAngka2, "");
                        epCorrect.SetError(txtAngka2, "Betul!");
                    }

                    else if (arraynumber[0] < arraynumber[1])
                    {
                        epWarning.SetError(txtAngka1, "Angka 2 harus lebih kecil dari angka 1");
                        epWarning.SetError(txtAngka2, "Angka 2 harus lebih kecil dari angka 1");
                        epWrong.SetError(txtAngka1, "");
                        epWrong.SetError(txtAngka2, "");
                        epCorrect.SetError(txtAngka1, "");
                        epCorrect.SetError(txtAngka2, "");
                    }
                    else
                    {
                        epWarning.SetError(txtAngka2, "");
                        epWrong.SetError(txtAngka2, "Inputan hanya boleh angka!");
                        epCorrect.SetError(txtAngka2, "");
                    }
                }
            }
        }
    }
}
