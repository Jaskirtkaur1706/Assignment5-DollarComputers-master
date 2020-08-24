using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Student Name - JASKIRAT KAUR
 * Student No. - 301107505
 * Programming 2 - Assignment5 (Dollar Computers)
 */


namespace Assignment5_DollarComputers.Views
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is event handler for splash form load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashForm_Load(object sender, EventArgs e)
        {
            SplashTimer.Enabled = true;
        }
        /// <summary>
        /// this is the event handler for the splash timer tick event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            //SplashTimer.Enabled = false;
            //Program.Views.StartForm.Show();
            //this.Hide();
            
            StartForm startForm = new StartForm();
            startForm.Show();
            SplashTimer.Enabled = false;
            this.Hide();
        }

        private void WelcomeLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
