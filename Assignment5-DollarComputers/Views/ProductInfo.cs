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
    public partial class ProductInfo : Form
    {
        public ProductInfo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the event handler for Nextbutton click event 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void NextButton_Click(object sender, EventArgs e)
        {
            
            Program.orderForm.Show();
            this.Hide();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ProductInfo_Load(object sender, EventArgs e)
        {

        }

        private void ProductInfoGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
