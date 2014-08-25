using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tu dois déplacer tous les disques de la tour 1 à la tour 3 en un minimum de coups\n Tu ne peux déplacer qu'un seul disque à la fois\n un disque ne peut être placé que sur un autre disque plus grand que lui ou sur un emplacement vide");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            int n = Convert.ToInt16( numericUpDown1.Value);

            for (int i=0 ; i < n; i++)
            {

                NewRing(120 -(i*10), 10, pictureBox3.Location.X - 55 +(i*5), pictureBox1.Location.Y -((1+i)* 10 ));
            }

        }

        private  void  NewRing( int hauteur , int largeur , int x , int y )
        {
            pictureBox1.SendToBack();
            pictureBox3.SendToBack();
            pictureBox4.SendToBack();
            PictureBox ring = new PictureBox();
            ring.Location = new Point (x , y);
            ring.Size = new Size(hauteur, largeur);
            ring.BackColor = Color.BlueViolet;
            ring.BringToFront();
            ring.BorderStyle = BorderStyle.Fixed3D ;
            panel1.Controls.Add(ring);
            pictureBox3.SendToBack();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
