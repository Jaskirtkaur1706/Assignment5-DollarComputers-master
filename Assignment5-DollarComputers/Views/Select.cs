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
    public partial class Select : Form
    {
        public Select()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is an event handler for select load event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Select_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /// <summary>
        /// This is the event handler for Backbutton click event 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            
            Program.startForm.Show();
            this.Hide();
        }
        /// <summary>
        /// This is the event handler for Nextbutton click event 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            
            
            Program.productInfo.Show();
            this.Hide();
        }
    }
}
