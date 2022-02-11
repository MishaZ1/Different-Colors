using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		int Correct = 0;
		int Choice = 0;
		int Score = 0;
		void Randomize()
		{ 
			PictureBox[] Pics = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4 }; 
			int R = 0;
			int G = 0;
			int B = 0;
			
			for(int i = 0; i < Pics.Length; i++)
			{
				Random Rand = new Random();
				R = Convert.ToInt32(Rand.Next()) % 256;
				G = Convert.ToInt32(Rand.Next()) % 256;
				B = Convert.ToInt32(Rand.Next()) % 256;
				Pics[i].BackColor = Color.FromArgb(R, G, B);
			}
			Random Rand2 = new Random();
			int RandIndex = Rand2.Next() % 4;
			R += 10;
			G += 10;
			B += 10;
			if (R > 255)
				R = 255;
			if (G > 255)
				G = 255;
			if (B > 255)
				B = 255;
			Pics[RandIndex].BackColor = Color.FromArgb(R, G, B);
			Correct = RandIndex + 1;
		}
		public void Check()
        {
			if (Choice == Correct)
			{
				Randomize();
				Score += 10;
				label1.Text = "Score: " + Convert.ToString(Score);
			}
            else
            {
				Score -= 100;
				label1.Text = "Score: " + Convert.ToString(Score);
			}
        }
		private void Form1_Load(object sender, EventArgs e)
		{
			Randomize();			
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Choice = 1;
			Check();
		}

        private void pictureBox2_Click(object sender, EventArgs e)
        {
			Choice = 2;
			Check();
		}

        private void pictureBox3_Click(object sender, EventArgs e)
        {
			Choice = 3;
			Check();
		}

        private void pictureBox4_Click(object sender, EventArgs e)
        {
			Choice = 4;
			Check();
		}
    }
}
