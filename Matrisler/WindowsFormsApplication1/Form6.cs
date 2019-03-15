using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        int tutkonum,konum;
        Color renk;
        void renkdegistir(Label s)
        {
            s.BackColor = Color.RosyBrown;
        }
        void gerial(Label s)
        {
            s.BackColor = renk;
        }
        private void Form6_Load(object sender, EventArgs e)
        {
            
            label9.Text = "  Günlük yaşantımızda, birden fazla veri\naynı anda"+
               " kullanılmak istenildiğinde bu\nveriler tablolar ile temsil edilir."+ 
                "Bu gösterim\nşekli pek çok alanda kullanılmaktadır.\n  Örneğin, muhasebe işlemleri, okullardaki \nders programlarının hazırlanması" 
                +" ve\nöğrencilerin not durumlarının takibi, anket\nsonuçlarının değerlendirilmesi, bazı bilim\ndallarında yapılan deneylerin sonuçlarının\n"+
                "değerlendirilmesi bunlardan bir kaç\ntanesidir.";
            label9.Visible = false;
            konum = -200;
            tutkonum = panel1.Left;
            panel1.Left = -200;
            renk = label2.BackColor;
            gerial(label2); gerial(label3); gerial(label4); gerial(label5); gerial(label6); gerial(label7);
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            label10.Visible = false;
            for (int i=panel1.Left;i<tutkonum;i+=3)
            {
                panel1.Left = i;
                Thread.Sleep(1);   
            }
        }

        private void Form6_MouseEnter(object sender, EventArgs e)
        {
            
            for (int i = panel1.Left; i >= konum; i-=3)
            {
                panel1.Left = i;
                Thread.Sleep(2);
            }
            label10.Visible = true;
        }
       
        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
            this.Show();
            panel1.Left = konum;
            label10.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            this.Hide();
            f4.ShowDialog();
            this.Show();
            panel1.Left = konum;
            label10.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.ShowDialog();
            this.Show();
            panel1.Left = konum;
            label10.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
            this.Show();
            panel1.Left = konum;
            label10.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.ShowDialog();
            this.Show();
            panel1.Left = konum;
            label10.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            this.Hide();
            f5.ShowDialog();
            this.Show();
            panel1.Left = konum;
            label10.Visible = true;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            renkdegistir(label2);
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            gerial(label2);
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            renkdegistir(label3);
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            gerial(label3);
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            renkdegistir(label4);

        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            gerial(label4);
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            renkdegistir(label5);
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            gerial(label5);
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            renkdegistir(label6);
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            gerial(label6);
        }

        private void label7_MouseEnter(object sender, EventArgs e)
        {
            renkdegistir(label7);
        }

        private void label8_Click(object sender, EventArgs e)
        {
           
            Environment.Exit(0);
        }

        private void label8_MouseEnter(object sender, EventArgs e)
        {
            renkdegistir(label8);
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            gerial(label8);
        }

        private void label10_MouseEnter(object sender, EventArgs e)
        {
            renkdegistir(label10);
            label9.Visible = true;
        }

        private void label10_MouseLeave(object sender, EventArgs e)
        {
            gerial(label10);
            label9.Visible = false;
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
            this.Show();
            panel1.Left = konum;
            label10.Visible = true;
        }

        private void label11_MouseEnter(object sender, EventArgs e)
        {
            renkdegistir(label11);
        }

        private void label11_MouseLeave(object sender, EventArgs e)
        {
            gerial(label11);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            gerial(label7);
        }
    }
}
