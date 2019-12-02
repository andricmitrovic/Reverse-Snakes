using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //  this.Location = new Point(0, 0);
            timer1.Stop();
            pictureBox1.BackColor = Color.FromArgb(106, 197, 169);
            pictureBox6.Parent = pictureBox4;
            pictureBox5.Image=WindowsFormsApplication2.Properties.Resources.CloseButtonV3;
            pictureBox6.Image=WindowsFormsApplication2.Properties.Resources.Gear;
            pictureBox3.Image=WindowsFormsApplication2.Properties.Resources.PlayButtonV2;
            pictureBox1.Location = new Point(220, 340);
            pictureBox2.Location = new Point(560, 270);
            pictureBox8.Location = new Point(580, 270);
            pictureBox9.Location = new Point(600, 270);
            pictureBox10.Location = new Point(620, 270);
            pictureBox11.Location = new Point(640, 270);

            pictureBox12.Location = new Point(220, 100);
            pictureBox13.Location = new Point(235, 100);
            pictureBox14.Location = new Point(275, 100);
            pictureBox15.Location = new Point(295, 100);
            pictureBox16.Location = new Point(315, 100);


            pictureBox19.Location = new Point(1000, 1000);
            pictureBox20.Location = new Point(1000, 1000);
            pictureBox21.Location = new Point(1000, 1000);
            pictureBox22.Location = new Point(1000, 1000);
            pictureBox23.Location = new Point(1000, 1000);
            pictureBox24.Location = new Point(1000, 1000);
            pictureBox25.Location = new Point(1000, 1000);
            pictureBox26.Location = new Point(1000, 1000);
            pictureBox27.Location = new Point(1000, 1000);
            pictureBox28.Location = new Point(1000, 1000);
            pictureBox29.Location = new Point(1000, 1000);
            pictureBox30.Location = new Point(1000, 1000);
            pictureBox31.Location = new Point(1000, 1000);
            pictureBox32.Location = new Point(1000, 1000);
            pictureBox33.Location = new Point(1000, 1000);
            pictureBox34.Location = new Point(1000, 1000);
            pictureBox35.Location = new Point(1000, 1000);
            pictureBox36.Location = new Point(1000, 1000);

                
        }
        int smer_x=0, smer_y=0,zmijica=0,zmijica1=0,zmijica2=0,zmijica3=0,sudar=0,score=0,br_otrova=0,otrovan=0;
        string stpth=Application.StartupPath;
        int[] niz = new int[100];
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                smer_y = -20;
                smer_x = 0;

            }
            if (e.KeyCode == Keys.Down)
            {
                smer_y = 20;
                smer_x = 0;

            }
            if (e.KeyCode == Keys.Right)
            {
                smer_x = 20;
                smer_y = 0;

            }
            if (e.KeyCode == Keys.Left)
            {
                smer_x = -20;
                smer_y = 0;

            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            

            if (sudar > 0)
            {
                sudar--;
                timer1.Interval = 200;
            }
            else
                timer1.Interval = 100;
            if(pictureBox1.Location.X/*+20*/<pictureBox2.Location.X && zmijica==0)
            {
                
                zmijica =1;
            }
            if (pictureBox1.Location.X /*-20*/> pictureBox2.Location.X && zmijica == 0)
            {
                
                zmijica = 2;
            }
            if (pictureBox1.Location.Y < pictureBox2.Location.Y && zmijica == 0)
            {
                
                zmijica = 3;
                
            }
            if (pictureBox1.Location.Y > pictureBox2.Location.Y && zmijica == 0)
            {   
                
                zmijica = 4;
            }
          

            
            






            
            if (pictureBox1.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                timer1.Stop();
                timer2.Stop();
                MessageBox.Show("GAME OVER!!!" );
            }
            if (pictureBox1.Bounds.IntersectsWith(pictureBox8.Bounds))
            {
                timer1.Stop();
                timer2.Stop();
                MessageBox.Show("GAME OVER!!!" );
            }
            if (pictureBox1.Bounds.IntersectsWith(pictureBox9.Bounds))
            {
                timer1.Stop();
                timer2.Stop();
                MessageBox.Show("GAME OVER!!!"  );
            }
            if (pictureBox1.Bounds.IntersectsWith(pictureBox10.Bounds))
            {
                timer1.Stop();
                timer2.Stop();
                MessageBox.Show("GAME OVER!!!"  );
            }
            if (pictureBox1.Bounds.IntersectsWith(pictureBox11.Bounds))
            {
                timer1.Stop();
                timer2.Stop();
                MessageBox.Show("GAME OVER!!!" );
            }

            if (pictureBox1.Location.X > this.Width)
                pictureBox1.Location = new Point(0, pictureBox1.Location.Y);
            if (pictureBox1.Location.X <-20)
                pictureBox1.Location = new Point(this.Width, pictureBox1.Location.Y);
            if (pictureBox1.Location.Y > this.Height)
                pictureBox1.Location = new Point(pictureBox1.Location.X, 30);
            if (pictureBox1.Location.Y < 30)
                pictureBox1.Location = new Point(pictureBox1.Location.X, this.Height);
           
            if (pictureBox2.Location.X > this.Width)
                pictureBox2.Location = new Point(0, pictureBox2.Location.Y);
            if (pictureBox2.Location.X+100 < -20)
                pictureBox2.Location = new Point(this.Width, pictureBox2.Location.Y);
            if (pictureBox2.Location.Y > this.Height)
                pictureBox2.Location = new Point(pictureBox2.Location.X, 30);
            if (pictureBox2.Location.Y < 30)
                pictureBox2.Location = new Point(pictureBox2.Location.X, this.Height);



            pictureBox8.Location = new Point(niz[1], niz[2]);
            pictureBox9.Location = new Point(niz[3], niz[4]);
            pictureBox10.Location = new Point(niz[5], niz[6]);
            pictureBox11.Location = new Point(niz[7], niz[8]);


 
           if(pictureBox1.Location.X-pictureBox2.Location.X>=this.Width/2)
           {
               zmijica = 1;
           }
          if (pictureBox2.Location.X - pictureBox1.Location.X >= this.Width / 2)
           {
               zmijica = 2;
           }

           if (pictureBox1.Location.Y - pictureBox2.Location.Y >= this.Height / 2)
           {
               zmijica = 3;
           }
           if (pictureBox2.Location.Y - pictureBox1.Location.Y >= this.Height / 2)
           {
               zmijica = 4;
           }





           if ((zmijica == 2 && zmijica1 == 1) || (zmijica == 1 && zmijica1 == 2))
           {
               if (pictureBox1.Location.Y < pictureBox2.Location.Y)
               {

                   zmijica = 3;

               }
               if (pictureBox1.Location.Y > pictureBox2.Location.Y)
               {

                   zmijica = 4;
               }
   
           }







           zmijica1 = zmijica;

           if (zmijica == 1)
           {
               pictureBox2.Location = new Point(pictureBox2.Location.X - 20 , pictureBox2.Location.Y);
               zmijica = 0;
           }
           if (zmijica == 2 )
           {
               pictureBox2.Location = new Point(pictureBox2.Location.X + 20 , pictureBox2.Location.Y);
               zmijica = 0;
           }
           if (zmijica == 3)
           {
               pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y - 20 );
               zmijica = 0;
           }
           if (zmijica == 4)
           {
               pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y + 20 );
               zmijica = 0;
           }





            



            niz[1]=pictureBox2.Location.X;
            niz[2]=pictureBox2.Location.Y;
            niz[3]=pictureBox8.Location.X;
            niz[4] = pictureBox8.Location.Y;
            niz[5] = pictureBox9.Location.X;
            niz[6] = pictureBox9.Location.Y;
            niz[7] = pictureBox10.Location.X;
            niz[8] = pictureBox10.Location.Y;
           

//////////////////////////
           if (pictureBox1.Location.X< pictureBox12.Location.X && zmijica2 == 0)
            {

                zmijica2 = 1;
            }
            if (pictureBox1.Location.X > pictureBox12.Location.X && zmijica2 == 0)
            {

                zmijica2 = 2;
            }
            if (pictureBox1.Location.Y < pictureBox12.Location.Y && zmijica2 == 0)
            {

                zmijica2 = 3;

            }
            if (pictureBox1.Location.Y > pictureBox12.Location.Y && zmijica2 == 0)
            {

                zmijica2 = 4;
            }







            if (pictureBox1.Bounds.IntersectsWith(pictureBox12.Bounds))
            {
                timer1.Stop();
                timer2.Stop();
                MessageBox.Show("GAME OVER!!!"  );
            }
            if (pictureBox1.Bounds.IntersectsWith(pictureBox13.Bounds))
            {
                timer1.Stop();
                timer2.Stop();
                MessageBox.Show("GAME OVER!!!"  );
            }
            if (pictureBox1.Bounds.IntersectsWith(pictureBox14.Bounds))
            {
                timer1.Stop();
                timer2.Stop();
                MessageBox.Show("GAME OVER!!!"  );
            }
            if (pictureBox1.Bounds.IntersectsWith(pictureBox15.Bounds))
            {
                timer1.Stop();
                timer2.Stop();
                MessageBox.Show("GAME OVER!!!" );
            }
            if (pictureBox1.Bounds.IntersectsWith(pictureBox16.Bounds))
            {
                timer1.Stop();
                timer2.Stop();
                MessageBox.Show("GAME OVER!!!");
            }






          

            if (pictureBox12.Location.X > this.Width)
                pictureBox12.Location = new Point(0, pictureBox12.Location.Y);
            if (pictureBox12.Location.X + 100 < -20)
                pictureBox12.Location = new Point(this.Width, pictureBox12.Location.Y);
            if (pictureBox12.Location.Y > this.Height)
                pictureBox12.Location = new Point(pictureBox12.Location.X, 30);
            if (pictureBox12.Location.Y < 30)
                pictureBox12.Location = new Point(pictureBox12.Location.X, this.Height);



            pictureBox13.Location = new Point(niz[9], niz[10]);
            pictureBox14.Location = new Point(niz[11], niz[12]);
            pictureBox15.Location = new Point(niz[13], niz[14]);
            pictureBox16.Location = new Point(niz[15], niz[16]);





            if (pictureBox1.Location.X - pictureBox12.Location.X >= this.Width / 2)
            {
                zmijica2 = 1;
            }
            if (pictureBox12.Location.X - pictureBox1.Location.X >= this.Width / 2)
            {
                zmijica2 = 2;
            }

            if (pictureBox1.Location.Y - pictureBox12.Location.Y >= this.Height / 2)
            {
                zmijica2 = 3;
            }
            if (pictureBox12.Location.Y - pictureBox1.Location.Y >= this.Height / 2)
            {
                zmijica2 = 4;
            }


            if ((zmijica2 == 2 && zmijica3 == 1) || (zmijica2 == 1 && zmijica3 == 2))
            {
                if (pictureBox1.Location.Y < pictureBox12.Location.Y)
                {

                    zmijica2 = 3;

                }
                if (pictureBox1.Location.Y > pictureBox12.Location.Y)
                {

                    zmijica2 = 4;
                }

            }












            zmijica3 = zmijica2;

            if (zmijica2 == 1)
            {
                pictureBox12.Location = new Point(pictureBox12.Location.X - 15, pictureBox12.Location.Y);
                zmijica2 = 0;
            }
            if (zmijica2 == 2 )
            {
                pictureBox12.Location = new Point(pictureBox12.Location.X + 15, pictureBox12.Location.Y);
                zmijica2 = 0;
            }
            if (zmijica2 == 3 )
            {
                pictureBox12.Location = new Point(pictureBox12.Location.X, pictureBox12.Location.Y - 15);
                zmijica2 = 0;
            }
            if (zmijica2 == 4)
            {
                pictureBox12.Location = new Point(pictureBox12.Location.X, pictureBox12.Location.Y + 15);
                zmijica2 = 0;
            }









            niz[9] = pictureBox12.Location.X;
            niz[10] = pictureBox12.Location.Y;
            niz[11] = pictureBox13.Location.X;
            niz[12] = pictureBox13.Location.Y;
            niz[13] = pictureBox14.Location.X;
            niz[14] = pictureBox14.Location.Y;
            niz[15] = pictureBox15.Location.X;
            niz[16] = pictureBox15.Location.Y;













            if (pictureBox2.Bounds.IntersectsWith(pictureBox12.Bounds))
            {
                sudar = 3;
            }
            if (pictureBox2.Bounds.IntersectsWith(pictureBox13.Bounds))
            {
                sudar = 3;
            }
            if (pictureBox2.Bounds.IntersectsWith(pictureBox14.Bounds))
            {
                sudar = 3;
            }
            if (pictureBox2.Bounds.IntersectsWith(pictureBox15.Bounds))
            {
                sudar = 3;
            }
            if (pictureBox2.Bounds.IntersectsWith(pictureBox16.Bounds))
            {
                sudar = 3;
            }





            


            if (pictureBox12.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                sudar =3;
            }
            if (pictureBox12.Bounds.IntersectsWith(pictureBox8.Bounds))
            {
                sudar = 3;
            }
            if (pictureBox12.Bounds.IntersectsWith(pictureBox9.Bounds))
            {
                sudar =3;
            }
            if (pictureBox12.Bounds.IntersectsWith(pictureBox10.Bounds))
            {
                sudar =3;
            }
            if (pictureBox12.Bounds.IntersectsWith(pictureBox11.Bounds))
            {
                sudar = 3;
            }


            if (pictureBox1.Bounds.IntersectsWith(pictureBox18.Bounds))

            {
                Random rnd = new Random();
                int a=rnd.Next(0,780),b=rnd.Next(20,580);
                score++;
                textBox1.Text = "Score:" + score;
                pictureBox18.Location = new Point(a, b);
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {       
           
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
            
        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            pictureBox5.Image = WindowsFormsApplication2.Properties.Resources.CloseButtonV3H2;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Image = WindowsFormsApplication2.Properties.Resources.CloseButtonV3;
        }   

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            pictureBox6.Image = WindowsFormsApplication2.Properties.Resources.GearH;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.Image = WindowsFormsApplication2.Properties.Resources.Gear;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(220, 340);
            pictureBox2.Location = new Point(560, 270);
            pictureBox8.Location = new Point(580, 270);
            pictureBox9.Location = new Point(600, 270);
            pictureBox10.Location = new Point(620, 270);
            pictureBox11.Location = new Point(640, 270);

            pictureBox12.Location = new Point(220, 100);
            pictureBox13.Location = new Point(240, 100);
            pictureBox14.Location = new Point(280, 100);
            pictureBox15.Location = new Point(300, 100);
            pictureBox16.Location = new Point(320, 100);


            pictureBox19.Location = new Point(1000, 1000);
            pictureBox20.Location = new Point(1000, 1000);
            pictureBox21.Location = new Point(1000, 1000);
            pictureBox22.Location = new Point(1000, 1000);
            pictureBox23.Location = new Point(1000, 1000);
            pictureBox24.Location = new Point(1000, 1000);
            pictureBox25.Location = new Point(1000, 1000);
            pictureBox26.Location = new Point(1000, 1000);
            pictureBox27.Location = new Point(1000, 1000);
            pictureBox28.Location = new Point(1000, 1000);
            pictureBox29.Location = new Point(1000, 1000);
            pictureBox30.Location = new Point(1000, 1000);
            pictureBox31.Location = new Point(1000, 1000);
            pictureBox32.Location = new Point(1000, 1000);
            pictureBox33.Location = new Point(1000, 1000);
            pictureBox34.Location = new Point(1000, 1000);
            pictureBox35.Location = new Point(1000, 1000);
            pictureBox36.Location = new Point(1000, 1000);


            smer_x = 0;
            smer_y = 0;
            timer1.Start();
            timer2.Start();
            score = 0;
            br_otrova = 0;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            smer_y = 0;
            smer_x = 0;
            timer1.Start();
            pictureBox3.Hide();
            timer2.Start();
           
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {

            if (otrovan > 0)
                otrovan--;
            else
                timer2.Interval = 80;
            br_otrova++;
            if (br_otrova == 20)
            {
                Random rnd = new Random();
                int a = rnd.Next(0, 780), b = rnd.Next(20, 580);
                pictureBox19.Location = new Point(a, b);
            }
            if (br_otrova == 80)
            {
                Random rnd = new Random();
                int a = rnd.Next(0, 780), b = rnd.Next(20, 580);
                pictureBox20.Location=new Point(a,b);
            }
            if (br_otrova == 160)
            {
                Random rnd = new Random();
                int a = rnd.Next(0, 780), b = rnd.Next(20, 580);
                pictureBox21.Location=new Point(a,b);
            }
            if (br_otrova == 240)
            {
                Random rnd = new Random();
                int a = rnd.Next(0, 780), b = rnd.Next(20, 580);
                pictureBox22.Location=new Point(a,b);
            }
            if (br_otrova == 320)
            {
                Random rnd = new Random();
                int a = rnd.Next(0, 780), b = rnd.Next(20, 580);
                pictureBox23.Location=new Point(a,b);
            }
            if (br_otrova == 400)
            {
                Random rnd = new Random();
                int a = rnd.Next(0, 780), b = rnd.Next(20, 580);
                pictureBox24.Location=new Point(a,b);

            }
            if (br_otrova == 480)
            {
                Random rnd = new Random();
                int a = rnd.Next(0, 780), b = rnd.Next(20, 580);
                pictureBox25.Location=new Point(a,b);
            }
            if (br_otrova == 560)
            {
                Random rnd = new Random();
                int a = rnd.Next(0, 780), b = rnd.Next(20, 580);
                pictureBox26.Location=new Point(a,b);
            }
            if (br_otrova == 640)
            {
                Random rnd = new Random();
                int a = rnd.Next(0, 780), b = rnd.Next(20, 580);
                pictureBox27.Location=new Point(a,b);
            }
            if (br_otrova ==720)
            {
                Random rnd = new Random();
                int a = rnd.Next(0, 780), b = rnd.Next(20, 580);
                pictureBox28.Location=new Point(a,b);
            }
            if (br_otrova == 800)
            {
                Random rnd = new Random();
                int a = rnd.Next(0, 780), b = rnd.Next(20, 580);
                pictureBox29.Location=new Point(a,b);
            }
            if (br_otrova == 980)
            {
                Random rnd = new Random();
                int a = rnd.Next(0, 780), b = rnd.Next(20, 580);
                pictureBox30.Location=new Point(a,b);
            }
            if (br_otrova == 1060)
            {
                Random rnd = new Random();
                int a = rnd.Next(0, 780), b = rnd.Next(20, 580);
                pictureBox31.Location=new Point(a,b);
            }
            if (br_otrova == 1140)
            {
                Random rnd = new Random();
                int a = rnd.Next(0, 780), b = rnd.Next(20, 580);
                pictureBox32.Location=new Point(a,b);
            }
            if (br_otrova == 1220)
            {
                Random rnd = new Random();
                int a = rnd.Next(0, 780), b = rnd.Next(20, 580);
                pictureBox33.Location=new Point(a,b);
            }
            if (br_otrova == 1300)
            {
                Random rnd = new Random();
                int a = rnd.Next(0, 780), b = rnd.Next(20, 580);
                pictureBox34.Location=new Point(a,b);
            }
            if (br_otrova == 1380)
            {
                Random rnd = new Random();
                int a = rnd.Next(0, 780), b = rnd.Next(20, 580);
                pictureBox35.Location=new Point(a,b);
            }
            if (br_otrova ==1460)
            {
                Random rnd = new Random();
                int a = rnd.Next(0, 780), b = rnd.Next(20, 580);
                pictureBox36.Location=new Point(a,b);
            }



            if (pictureBox1.Bounds.IntersectsWith(pictureBox19.Bounds))
            {
                timer2.Interval = 120;
                otrovan = 20;
                pictureBox19.Location = new Point(1000, 1000);
            }
            if (pictureBox1.Bounds.IntersectsWith(pictureBox20.Bounds))
            {
                timer2.Interval = 120;
                otrovan = 20;
                pictureBox20.Location = new Point(1000, 1000);
            }
            if (pictureBox1.Bounds.IntersectsWith(pictureBox21.Bounds))
            {
                timer2.Interval = 120;
                otrovan = 20;
                pictureBox21.Location = new Point(1000, 1000);
            }
            if (pictureBox1.Bounds.IntersectsWith(pictureBox22.Bounds))
            {
                timer2.Interval = 120;
                otrovan = 20;
                pictureBox22.Location = new Point(1000, 1000);
            }
            if (pictureBox1.Bounds.IntersectsWith(pictureBox23.Bounds))
            {
                timer2.Interval = 120;
                otrovan = 20;
                pictureBox23.Location = new Point(1000, 1000);
            }
            if (pictureBox1.Bounds.IntersectsWith(pictureBox24.Bounds))
            {
                timer2.Interval = 120;
                otrovan = 20;
                pictureBox24.Location = new Point(1000, 1000);
            }
            if (pictureBox1.Bounds.IntersectsWith(pictureBox25.Bounds))
            {
                timer2.Interval = 120;
                otrovan = 20;
                pictureBox25.Location = new Point(1000, 1000);
            }
            if (pictureBox1.Bounds.IntersectsWith(pictureBox26.Bounds))
            {
                timer2.Interval = 120;
                otrovan = 20;
                pictureBox26.Location = new Point(1000, 1000);
            }
            if (pictureBox1.Bounds.IntersectsWith(pictureBox27.Bounds))
            {
                timer2.Interval = 120;
                otrovan = 20;
                pictureBox27.Location = new Point(1000, 1000);
            }

            if (pictureBox1.Bounds.IntersectsWith(pictureBox28.Bounds))
            {
                timer2.Interval = 120;
                otrovan = 20;
                pictureBox28.Location = new Point(1000, 1000);
            }
            if (pictureBox1.Bounds.IntersectsWith(pictureBox29.Bounds))
            {
                timer2.Interval = 120;
                otrovan = 20;
                pictureBox29.Location = new Point(1000, 1000);
            }
            if (pictureBox1.Bounds.IntersectsWith(pictureBox30.Bounds))
            {
                timer2.Interval = 120;
                otrovan = 20;
                pictureBox30.Location = new Point(1000, 1000);
            }

            if (pictureBox1.Bounds.IntersectsWith(pictureBox31.Bounds))
            {
                timer2.Interval = 120;
                otrovan = 20;
                pictureBox31.Location = new Point(1000, 1000);
            }
            if (pictureBox1.Bounds.IntersectsWith(pictureBox32.Bounds))
            {
                timer2.Interval = 120;
                otrovan = 20;
                pictureBox32.Location = new Point(1000, 1000);
            }
            if (pictureBox1.Bounds.IntersectsWith(pictureBox33.Bounds))
            {
                timer2.Interval = 120;
                otrovan = 20;
                pictureBox33.Location = new Point(1000, 1000);
            }
            if (pictureBox1.Bounds.IntersectsWith(pictureBox34.Bounds))
            {
                timer2.Interval = 120;
                otrovan = 20;
                pictureBox34.Location = new Point(1000, 1000);
            }
            if (pictureBox1.Bounds.IntersectsWith(pictureBox35.Bounds))
            {
                timer2.Interval = 120;
                otrovan = 20;
                pictureBox35.Location = new Point(1000, 1000);
            }
            if (pictureBox1.Bounds.IntersectsWith(pictureBox36.Bounds))
            {
                timer2.Interval = 120;
                otrovan = 20;
                pictureBox36.Location = new Point(1000, 1000);
            }












             pictureBox1.Location = new Point(pictureBox1.Location.X+smer_x, pictureBox1.Location.Y + smer_y);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {

        }

       
    }
}
