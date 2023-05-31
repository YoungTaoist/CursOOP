using System.Media;
using System.Reflection;

namespace CursOOP
{
    public partial class Form1 : Form
    {
        SimvolChange SimvolChange = new SimvolChange();
        
        public Form1()
        {
            InitializeComponent();
            SimvolChange.player = 1;
            label1.Text = "Сейчас ходит первый игрок";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SimvolChange.Game(sender,label1);
            sender.GetType().GetProperty("Enabled").SetValue(sender, false);
            checkwin();
            
        }
        private void checkwin()
        {
            if (button1.Text == button2.Text && button2.Text == button3.Text && button1.Text != "")
            {
                
                    if (button2.Text == "x")
                    {
                        MessageBox.Show("Победил первый игрок!");
                    }
                if (button2.Text == "o")
                {
                    MessageBox.Show("Победил второй игрок!");
                };
                cansel();
                
            }

                if (button4.Text == button5.Text && button5.Text == button6.Text && button4.Text != "")
            {
                
                    if (button5.Text == "x")
                    {
                        MessageBox.Show("Победил первый игрок!");
                    }
                if (button5.Text == "o")
                {
                    MessageBox.Show("Победил второй игрок!");
                };
                cansel();
            }
            if (button7.Text == button8.Text && button8.Text == button9.Text && button7.Text != "")
            {
                
                    if (button8.Text == "x")
                    {
                        MessageBox.Show("Победил первый игрок!");
                    }
                if (button8.Text == "o")
                {
                    MessageBox.Show("Победил второй игрок!");
                };
                cansel();
            }
            if (button1.Text == button4.Text && button4.Text == button7.Text && button1.Text != "")
            {
                
                    if (button4.Text == "x")
                    {
                        MessageBox.Show("Победил первый игрок!");
                    }
                if (button4.Text == "o")
                {
                    MessageBox.Show("Победил второй игрок!");
                };
                cansel();
                
            }
            if (button2.Text == button5.Text && button5.Text == button8.Text && button2.Text != "")
            {
                
                    if (button5.Text == "x")
                    {
                        MessageBox.Show("Победил первый игрок!");
                    }
                if (button5.Text == "o")
                {
                    MessageBox.Show("Победил второй игрок!");
                };
                cansel();
            }
            if (button3.Text == button6.Text && button6.Text == button9.Text && button3.Text != "")
            {               
                    if (button6.Text == "x")
                    {
                        MessageBox.Show("Победил первый игрок!");
                    }
                if (button6.Text == "o")
                {
                    MessageBox.Show("Победил второй игрок!");
                };
                cansel();
            }
            if (button1.Text == button5.Text && button5.Text == button9.Text && button1.Text != "")
            {                
                    if (button5.Text == "x")
                    {
                        MessageBox.Show("Победил первый игрок!");
                    }
                if (button5.Text == "o")
                {
                    MessageBox.Show("Победил второй игрок!");
                };
                cansel();
            }
            if (button3.Text == button5.Text && button5.Text == button7.Text && button3.Text != "")
            {
                    if (button5.Text == "x")
                    {
                        MessageBox.Show("Победил первый игрок!");
                    }
                if (button5.Text == "o")
                {
                    MessageBox.Show("Победил второй игрок!");
                };
                cansel();
            }
        }

        private void cansel()
        {
            button1.Text = "";
            button1.Enabled = true;
            button2.Text = "";
            button2.Enabled = true;
            button3.Text = "";
            button3.Enabled = true;
            button4.Text = "";
            button4.Enabled = true;
            button5.Text = "";
            button5.Enabled = true;
            button6.Text = "";
            button6.Enabled = true;
            button7.Text = "";
            button7.Enabled = true;
            button8.Text = "";
            button8.Enabled = true;
            button9.Text = "";
            button9.Enabled = true;
            SimvolChange.player = 1;
            label1.Text = "Сейчас ходит первый игрок";
        }
        private void button10_Click(object sender, EventArgs e)
        {
            cansel();
        }


    }
    }
    
