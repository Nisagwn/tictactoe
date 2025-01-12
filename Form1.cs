using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tictactoe
{
    public partial class Form1 : Form
    {
        Boolean checker;  // Oyuncu sırasını takip etmek için bir Boolean değeri
        int plusone; // Skor için kullanılan değişken
        // Tüm düğmeleri devre dışı bırakan fonksiyon
        void Enable_False()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }
        // Oyunun sonucunu kontrol eden ve skorları güncelleyen fonksiyon
        void score()
        {
            if(button1.Text=="X"&& button2.Text == "X" && button3.Text == "X")
            {
                button1.BackColor = Color.PowderBlue;
                button2.BackColor = Color.PowderBlue;
                button3.BackColor = Color.PowderBlue;
                MessageBox.Show("X oyuncusu kazandı", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label4.Text);
                label4.Text=Convert.ToString(plusone + 1);
                Enable_False();
            }

            // X oyuncusu için kazanma durumlarını kontrol etme
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                button1.BackColor = Color.PowderBlue;
                button4.BackColor = Color.PowderBlue;
                button7.BackColor = Color.PowderBlue;
                // Kazananı kullanıcıya göster
                MessageBox.Show("X oyuncusu kazandı", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Skoru artır
                plusone = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusone);
                // Oyun bittiğinde tüm düğmeleri devre dışı bırak
                Enable_False();
            }
            // Diğer X oyuncusu kazanma durumları benzer şekilde kontrol ediliyor.
            // ...
            // #################################################################################################
            // O oyuncusu için kazanma durumlarını kontrol etme

            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                button3.BackColor = Color.PowderBlue;
                button5.BackColor = Color.PowderBlue;
                button7.BackColor = Color.PowderBlue;
                MessageBox.Show("X oyuncusu kazandı", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusone);
                Enable_False();
            }


            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                button2.BackColor = Color.PowderBlue;
                button5.BackColor = Color.PowderBlue;
                button8.BackColor = Color.PowderBlue;
                MessageBox.Show("X oyuncusu kazandı", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }


            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                button4.BackColor = Color.PowderBlue;
                button5.BackColor = Color.PowderBlue;
                button6.BackColor = Color.PowderBlue;
                MessageBox.Show("X oyuncusu kazandı", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }


            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                button7.BackColor = Color.PowderBlue;
                button8.BackColor = Color.PowderBlue;
                button9.BackColor = Color.PowderBlue;
                MessageBox.Show("X oyuncusu kazandı", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusone+1);
                Enable_False();
            }

            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                button3.BackColor = Color.PowderBlue;
                button6.BackColor = Color.PowderBlue;
                button9.BackColor = Color.PowderBlue;
                MessageBox.Show("X oyuncusu kazandı", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusone+1);
                Enable_False();
            }
            //#################################################################################################
            if (button1.Text == "0" && button2.Text == "0" && button3.Text == "0")
            {
                button1.BackColor = Color.PowderBlue;
                button2.BackColor = Color.PowderBlue;
                button3.BackColor = Color.PowderBlue;
                MessageBox.Show("0 oyuncusu kazandı", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label5.Text);
                label5.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }


            if (button1.Text == "0" && button4.Text == "0" && button7.Text == "0")
            {
                button1.BackColor = Color.PowderBlue;
                button4.BackColor = Color.PowderBlue;
                button7.BackColor = Color.PowderBlue;
                MessageBox.Show("0 oyuncusu kazandı", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label5.Text);
                label5.Text = Convert.ToString(plusone);
                Enable_False();
            }


            if (button3.Text == "0" && button5.Text == "0" && button7.Text == "0")
            {
                button3.BackColor = Color.PowderBlue;
                button5.BackColor = Color.PowderBlue;
                button7.BackColor = Color.PowderBlue;
                MessageBox.Show("0 oyuncusu kazandı", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label5.Text);
                label5.Text = Convert.ToString(plusone);
                Enable_False();
            }


            if (button2.Text == "0" && button5.Text == "0" && button8.Text == "0")
            {
                button2.BackColor = Color.PowderBlue;
                button5.BackColor = Color.PowderBlue;
                button8.BackColor = Color.PowderBlue;
                MessageBox.Show("0 oyuncusu kazandı", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label5.Text);
                label5.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }


            if (button4.Text == "0" && button5.Text == "0" && button6.Text == "0")
            {
                button4.BackColor = Color.PowderBlue;
                button5.BackColor = Color.PowderBlue;
                button6.BackColor = Color.PowderBlue;
                MessageBox.Show("0 oyuncusu kazandı", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label5.Text);
                label5.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }


            if (button7.Text == "0" && button8.Text == "0" && button9.Text == "0")
            {
                button7.BackColor = Color.PowderBlue;
                button8.BackColor = Color.PowderBlue;
                button9.BackColor = Color.PowderBlue;
                MessageBox.Show("0 oyuncusu kazandı", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label5.Text);
                label5.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (button3.Text == "0" && button6.Text == "0" && button9.Text == "0")
            {
                button3.BackColor = Color.PowderBlue;
                button6.BackColor = Color.PowderBlue;
                button9.BackColor = Color.PowderBlue;
                MessageBox.Show("0 oyuncusu kazandı", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label5.Text);
                label5.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // Oyunu kapatmak için kullanılan buton
        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button1.Text = "X";
                checker= true;
            }
            else
            {
                button1.Text = "0";
                checker= false;
            }
            score();
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (checker == false)
            {
                button2.Text = "X";
                checker = true;
            }
            else
            {
                button2.Text = "0";
                checker = false;
            }
            score();
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (checker == false)
            {
                button3.Text = "X";
                checker = true;
            }
            else
            {
                button3.Text = "0";
                checker = false;
            }
            score();
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (checker == false)
            {
                button4.Text = "X";
                checker = true;
            }
            else
            {
                button4.Text = "0";
                checker = false;
            }
            score();
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (checker == false)
            {
                button5.Text = "X";
                checker = true;
            }
            else
            {
                button5.Text = "0";
                checker = false;
            }
            score();
            button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (checker == false)
            {
                button6.Text = "X";
                checker = true;
            }
            else
            {
                button6.Text = "0";
                checker = false;
            }
            score();
            button6.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (checker == false)
            {
                button7.Text = "X";
                checker = true;
            }
            else
            {
                button7.Text = "0";
                checker = false;
            }
            score();
            button7.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (checker == false)
            {
                button8.Text = "X";
                checker = true;
            }
            else
            {
                button8.Text = "0";
                checker = false;
            }
            score();
            button8.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {

            if (checker == false)
            {
                button9.Text = "X";
                checker = true;
            }
            else
            {
                button9.Text = "0";
                checker = false;
            }
            score();
            button9.Enabled = false;
        }
        // Oyunu yeniden başlatmak ve düğmeleri tekrar aktif hale getirmek için kullanılan "Yeni Oyun" butonu
        private void button11_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

            button11.Enabled = true;

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = ""; 
            button8.Text = "";
            button9.Text = "";

            label4.Text = "0";
            label5.Text = "0";
        }
        // Mevcut oyunu temizlemek ve tüm butonları tekrar etkinleştirmek için "Temizle" butonu
        private void button12_Click(object sender, EventArgs e)
        {

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

            // Tüm butonların metinlerini sıfırla

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
        }
    }
}
