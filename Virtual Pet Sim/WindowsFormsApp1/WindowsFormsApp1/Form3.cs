using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        private int Time;
        private int info;
        public Form3()
        {
            InitializeComponent();
            Time = 60;
            info = 5;
            timer1.Start();
            //
            Energy.Minimum = 0;
            Energy.Maximum = 100;
            //
            Energy.Minimum = 0;
            Energy.Maximum = 100;
            //
            Energy.Minimum = 0;
            Energy.Maximum = 100;

       
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Time > 0)
            {
                Time--;
                label5.Text = Time.ToString();
            }
            else
            {
                Time = 60;
                label5.Text = Time.ToString();
            }
            //STATUS
            if (Time == 30)
            {
                Energy.Value = Energy.Value - 10;
            }
            if (Time == 20)
            {
                Hunger.Value = Hunger.Value - 10;
            }
            if (Time == 50)
            {
                Happiness.Value = Happiness.Value - 10;
            }
        }

    

        private void Feed_Click(object sender, EventArgs e)
        {

            //ACTIONS
            if (Hunger.Value < 100)
            {
                Hunger.Value = Hunger.Value + 10;
            }
            else
            {
                label4.Text = "YOUR PET IS STILL FULL";
            }
            //
            timer2.Start();
            if (!timer2.Enabled)
            {
                info = 5; // Set the countdown time (e.g., 10 seconds)
                label6.Text = info.ToString(); // Display the initial time
                timer2.Start(); // Start the timer
            }
            else
            {
                // Optionally, you can reset the timer value if it's already running
                info = 5; // Reset the countdown time
                label6.Text = info.ToString();
            }
           

        }

        private void Rest_Click(object sender, EventArgs e)
        {
            if (Energy.Value < 100)
            {
                Energy.Value = Energy.Value + 10;
            }
            else
            {
                label4.Text = "YOUR PET IS NOT TIRED";
            }
            //
            timer2.Start();
            if (!timer2.Enabled)
            {
                info = 5; // Set the countdown time (e.g., 10 seconds)
                label6.Text = info.ToString(); // Display the initial time
                timer2.Start(); // Start the timer
            }
            else
            {
                // Optionally, you can reset the timer value if it's already running
                info = 5; // Reset the countdown time
                label6.Text = info.ToString();
            }

        }

        private void Pat_Click(object sender, EventArgs e)
        {

            if (Happiness.Value < 100)
            {
                Happiness.Value = Happiness.Value + 10;
            }
            else
            {
                label4.Text = "YOUR PET IS STILL HAPPY";
            }
            //
            timer2.Start();
            if (!timer2.Enabled)
            {
                info = 5; // Set the countdown time (e.g., 10 seconds)
                label6.Text = info.ToString(); // Display the initial time
                timer2.Start(); // Start the timer
            }
            else
            {
                // Optionally, you can reset the timer value if it's already running
                info = 5; // Reset the countdown time
                label6.Text = info.ToString();
            }


        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (info > 0) 
            {
                info--;
                label6.Text = info.ToString();
            }
            else
            {
                label4.Text = "...";
            }
         

        }

       
    }
}
