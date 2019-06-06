using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        int Map_width, Map_height;
        private Graphics g1;
        Grid Map;      
        float RecWidth;
        float RecHeight;
        private static System.Timers.Timer aTimer;


        public Form1()
        {

            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UserClick(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            PointF coordinates = me.Location;
            int i = -1, j = -1;

            while(coordinates.X >0)
            {
                coordinates.X -= RecWidth;
                i++;
            }
            while(coordinates.Y>0)
            {
                coordinates.Y -= RecHeight;
                j++;
            }

            Map.Map[j, i].NegateState();
            DrawCells(Map.Map);
    
        }

        private void Start_button_Click(object sender, EventArgs e)
        {
            try { 
                Map_width = int.Parse(textBox1.Text);
                Map_height = int.Parse(textBox2.Text);         
                
                for(int i =0; i<1; i++)
                {
                    Map.UpdateVector();
                    DrawCells(Map.Map);   
                }
                
               

            }
            catch (System.FormatException)
            {
                System.Windows.Forms.MessageBox.Show("Nieprawidłowe wartości - tylko liczby całkowite");
            }

        }

        private void DrawCells(Cell[,] Map)
        {
            pictureBox1.Refresh();
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g1 = Graphics.FromImage(this.pictureBox1.Image);
            Pen pen = new Pen(Color.Black, 1);
            SolidBrush brush = new SolidBrush(Color.Red);
            float x = 0, y= 0;

            RecWidth = (float)pictureBox1.Width / (float)Map_width ;
            RecHeight = (float)pictureBox1.Height / (float)Map_height ;

            if (RecWidth > RecHeight)
            {
                RecWidth = RecHeight;
            }
            else
            {
                RecHeight = RecWidth;
            }
            for (int i =0; i<Map_height; i++)
            {

                 for (int j = 0; j < Map_width; j++)
                 {
                    if(Map[i,j].GetState()==true)
                    {
                        brush.Color = Color.Black;
                    }
                    else
                    {
                        brush.Color = Color.White;
                    }
                    g1.FillRectangle(brush, x, y, RecWidth, RecHeight);
                    g1.DrawRectangle(pen, x, y, RecWidth, RecHeight);
                    x += RecWidth;
                }
               
                x = 0;
                y += RecHeight;
            }
            //g1.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void beehive_button_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            try
            {
                Map_width = int.Parse(textBox1.Text);
                Map_height = int.Parse(textBox2.Text);
            }
            catch (System.FormatException)
            {
                System.Windows.Forms.MessageBox.Show("Nieprawidłowe wartości - tylko liczby całkowite");
            }

            Map = new Grid(Map_width, Map_height);

            Map.Map[Map_height / 2, Map_width / 2].SetState(true);
            Map.Map[Map_height / 2, (Map_width / 2) + 1].SetState(true);

            Map.Map[(Map_height / 2) - 1, (Map_width / 2) - 1].SetState(true);
            Map.Map[(Map_height / 2) - 1, (Map_width / 2) + 2].SetState(true);

            Map.Map[(Map_height / 2) - 2, Map_width / 2].SetState(true);
            Map.Map[(Map_height / 2) - 2, Map_width / 2 + 1].SetState(true);

            DrawCells(Map.Map);
        }

        private void Stop_button_Click(object sender, EventArgs e)
        {
            aTimer.Enabled = false;
        }

        private void Glider_button_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            try
            {
                Map_width = int.Parse(textBox1.Text);
                Map_height = int.Parse(textBox2.Text);
            }
            catch (System.FormatException)
            {
                System.Windows.Forms.MessageBox.Show("Nieprawidłowe wartości - tylko liczby całkowite");
            }

            Map = new Grid(Map_width, Map_height);

            Map.Map[Map_height / 2 -1, Map_width / 2].SetState(true);
            Map.Map[Map_height / 2 -1, (Map_width / 2) -1].SetState(true);

            Map.Map[(Map_height / 2 -1) -1, (Map_width / 2) -1].SetState(true);
            Map.Map[(Map_height / 2 -1) -1, (Map_width / 2) - 2].SetState(true);

            Map.Map[(Map_height / 2 -1) -2, Map_width / 2].SetState(true);

            DrawCells(Map.Map);
        }

 
        private void Oscillator_button_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            try
            {
                Map_width = int.Parse(textBox1.Text);
                Map_height = int.Parse(textBox2.Text);
            }
            catch (System.FormatException)
            {
                System.Windows.Forms.MessageBox.Show("Nieprawidłowe wartości - tylko liczby całkowite");
            }

            Map = new Grid(Map_width, Map_height);

            Map.Map[Map_height / 2, Map_width / 2].SetState(true);
            Map.Map[(Map_height / 2) - 1, (Map_width / 2)].SetState(true);
            Map.Map[(Map_height / 2) + 1, (Map_width / 2)].SetState(true);
            

            DrawCells(Map.Map);
        }

        private void Random_button_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            pictureBox1.Refresh();
            try
            {
                Map_width = int.Parse(textBox1.Text);
                Map_height = int.Parse(textBox2.Text);
            }
            catch (System.FormatException)
            {
                System.Windows.Forms.MessageBox.Show("Nieprawidłowe wartości - tylko liczby całkowite");
            }

            Map = new Grid(Map_width, Map_height);

           for (int i =0; i<Map_height; i++)
            {
                for (int j = 0; j < Map_width; j++)
                {
                    Map.Map[i, j].SetState(Convert.ToBoolean(rand.Next(2)));
                }
            }


            DrawCells(Map.Map);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Simulation_button_Click(object sender, EventArgs e)
        {
            aTimer = new System.Timers.Timer();
            aTimer.Interval = 400;
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;

        }
        private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                Map_width = int.Parse(textBox1.Text);
                Map_height = int.Parse(textBox2.Text);

                for (int i = 0; i < 1; i++)
                {
                    Map.UpdateVector();
                    BeginInvoke(new Action(() =>
                    {
                        DrawCells(Map.Map);
                    }));
                }



            }
            catch (System.FormatException)
            {
                System.Windows.Forms.MessageBox.Show("Nieprawidłowe wartości - tylko liczby całkowite");
            }
        }

        private void Powerful_Glider_gun_button_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            textBox1.Text = "40";
            textBox2.Text = "40";
            try
            {
                Map_width = int.Parse(textBox1.Text);
                Map_height = int.Parse(textBox2.Text);
            }
            catch (System.FormatException)
            {
                System.Windows.Forms.MessageBox.Show("Upośledzony czy niespełna rozumu - tylko cyferki");
            }

            Map = new Grid(Map_width, Map_height);

            Map.Map[19, 0].SetState(true);
            Map.Map[19, 1].SetState(true);
                             
            Map.Map[20, 0].SetState(true);
            Map.Map[20, 1].SetState(true);
                              
            Map.Map[19, 10].SetState(true);
            Map.Map[20, 10].SetState(true);
            Map.Map[21, 10].SetState(true);
                            
            Map.Map[18, 11].SetState(true);
            Map.Map[22, 11].SetState(true);
                             
            Map.Map[17, 12].SetState(true);
            Map.Map[17, 13].SetState(true);
                             
            Map.Map[23, 12].SetState(true);
            Map.Map[23, 13].SetState(true);
                             
            Map.Map[20, 14].SetState(true);
                             
            Map.Map[19, 16].SetState(true);
            Map.Map[20, 16].SetState(true);
            Map.Map[21, 16].SetState(true);
                             
            Map.Map[18, 15].SetState(true);
            Map.Map[22, 15].SetState(true);
                             
            Map.Map[20, 17].SetState(true);
                             
            Map.Map[17, 21].SetState(true);
            Map.Map[18, 21].SetState(true);
            Map.Map[19, 21].SetState(true);
                             
            Map.Map[17, 20].SetState(true);
            Map.Map[18, 20].SetState(true);
            Map.Map[19, 20].SetState(true);
                             
            Map.Map[16, 22].SetState(true);
            Map.Map[20, 22].SetState(true);
                             
            Map.Map[16, 24].SetState(true);
            Map.Map[15, 24].SetState(true);
                             
            Map.Map[20, 24].SetState(true);
            Map.Map[21, 24].SetState(true);
                             
            Map.Map[18, 34].SetState(true);
            Map.Map[18, 35].SetState(true);
                             
            Map.Map[17, 34].SetState(true);
            Map.Map[17, 35].SetState(true);

            DrawCells(Map.Map);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
