namespace Bilgi_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0;
        int dogru = 0;
        int yanlis = 0;
        int sure = 20;
        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            sure = 20;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            label9.Text=sure.ToString();
            button5.Text = "ÝLERÝ";
            soruno++;
            label1.Text = soruno.ToString();

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;

            if (soruno == 1)
            {
                richTextBox1.Text = "2024 tarihinde toplam olarak en çok kill alan oyuncu kimdir ?";
                button1.Text = "NiKo";
                button2.Text = "jL";
                button3.Text = "m0NESY";
                button4.Text = "w0nderful";
                label4.Text = "m0NESY";

            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Faceit sýralamasýnda 1. sýrada bulunan esporcunun takýmý nedir ?";
                button1.Text = "Natus Vincere";
                button2.Text = "Eternal Fire";
                button3.Text = "Team Spirit";
                button4.Text = "Vitality";
                label4.Text = "Team Spirit";
            }
            if (soruno == 3)
            {
                pictureBox1.Visible = true;
                richTextBox1.Text = "Fotoðraftaki skinin adý nedir";
                button1.Text = "Case hardened karambit";
                button2.Text = "Bowie býçaðý ";
                button3.Text = "Talon knife case hardened";
                button4.Text = "Talon knife gamma doppler";
                label4.Text = "Talon knife case hardened";
            }
            if (soruno == 4)
            {
                pictureBox2.Visible = true;
                richTextBox1.Text = "Fotoðraftaki ak-47 skininin adý nedir ?";
                button1.Text = "Inheritance ak-47";
                button2.Text = "Asiimov ak-47";
                button3.Text = "Wasteland Rebel ak-47";
                button4.Text = "Case Hardened ak-47";
                label4.Text = "Inheritance ak-47";
            }
            if (soruno == 5)
            {
                pictureBox3.Visible = true;
                richTextBox1.Text = "Fotoðraftaki awp skininin adý nedir";
                button1.Text = "Atheris awp";
                button2.Text = "Man o war awp";
                button3.Text = "phobos awp";
                button4.Text = "awp fade";
                label4.Text = "Man o war awp";
            }
            if (soruno == 6)
            {
                pictureBox4.Visible = true;
                richTextBox1.Text = "Fotoðraftaki map hangi maptir";
                button1.Text = "Dust 2";
                button2.Text = "Ancient";
                button3.Text = "Anubis";
                button4.Text = "Ýtaly";
                label4.Text = "Anubis";
            }
            if (soruno == 7)
            {
                pictureBox5.Visible = true;
                richTextBox1.Text = "Fotoðraftaki esporcunun adý nedir ?";
                button1.Text = "b1t";
                button2.Text = "rain";
                button3.Text = "XANTARES";
                button4.Text = "w0nderful";
                label4.Text = "w0nderful";
            }
            if (soruno == 8)
            {
                richTextBox1.Text = "Aktif olarak hltv sýralamasýnda en iyi cs 2 takýmý hangisidir";
                button1.Text = "Eternal Fire";
                button2.Text = "G2 esports";
                button3.Text = "Vitality esports";
                button4.Text = "Natus Vincere";
                label4.Text = "Natus Vincere";
            }
            if (soruno == 9)
            {
                pictureBox6.Visible = true;
                richTextBox1.Text = "Aþaðýdaki oyunculardan hangisi fotoðraftaki iki takýmda oynamamýþtýr       (Not: Aktif olarak en son maç baz alýnacaktýr.)";
                button1.Text = "Jl";
                button2.Text = "Xantares";
                button3.Text = "S1mple";
                button4.Text = "iM";
                label4.Text = "S1mple";
            }
            if (soruno == 10)
            {
                pictureBox7.Visible = true;
                richTextBox1.Text = "Yeni gelen güncelleme ile pass de bilet baþýna kaç yýldýz toplayabiliriz";
                button1.Text = "200";
                button2.Text = "45";
                button3.Text = "40";
                button4.Text = "150";
                label4.Text = "40";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

            timer1.Enabled=false;


            label3.Text = button1.Text;
            if (label3.Text == label4.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                label8.Text = yanlis.ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

            timer1.Enabled = false;


            label3.Text = button2.Text;
            if (label3.Text == label4.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                label8.Text = yanlis.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

            timer1.Enabled = false;


            label3.Text = button3.Text;
            if (label3.Text == label4.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                label8.Text = yanlis.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

            timer1.Enabled = false;


            label3.Text = button4.Text;
            if (label3.Text == label4.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                label8.Text = yanlis.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure=Convert.ToInt32(label9.Text);
            sure = sure - 1;
            label9.Text = sure.ToString();
            if (sure == 0)
            {
                timer1.Enabled = false;
                yanlis++;
                label8.Text = yanlis.ToString();
            }
        }
    }
}
