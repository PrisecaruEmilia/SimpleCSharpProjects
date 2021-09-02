using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CountDownTimer : Form
    {

        private int seconds = 0;
        int number;
        public CountDownTimer()
        {
            InitializeComponent();
        }

        private void ChangeLabel()
        {
            lblNrSeconds.Text = seconds + " Seconds";
        }

        private void CountDownTimer_Load(object sender, EventArgs e)
        {
            
        }

        private void textInput_TextChanged(object sender, EventArgs e)
        {
            bool success = int.TryParse(textInput.Text, out number);

            if (success)
            {
                seconds = number;
            } else
            {
                seconds = 60;
            }

            ChangeLabel();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if(seconds > 0)
            {
                seconds -= 1;
                ChangeLabel();
            } else
            {
                timer.Stop();
                lblNrSeconds.Text = "Time is up!";

            }
        }

        private void btnPlus5_Click(object sender, EventArgs e)
        {
            seconds += 5;
            ChangeLabel();
        }

        private void btnMinus5_Click(object sender, EventArgs e)
        {
            seconds -= 5;
            ChangeLabel();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            timer.Stop();
            seconds = 60;
            ChangeLabel();
        }

       
    }
}
