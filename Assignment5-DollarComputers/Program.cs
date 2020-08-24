using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment5_DollarComputers.Views;

/* Student Name - JASKIRAT KAUR
 * Student No. - 301107505
 * Programming 2 - Assignment5 (Dollar Computers)
 */

namespace Assignment5_DollarComputers
{
    public static class Program
    {
        public static SplashForm splashForm;
        public static StartForm startForm;
        public static Select selectForm;
        public static ProductInfo productInfo;
        public static OrderForm orderForm;
        public static AboutForm aboutForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            splashForm = new SplashForm();
            startForm = new StartForm();
            selectForm = new Select();
            productInfo = new ProductInfo();
            orderForm = new OrderForm();
            aboutForm = new AboutForm();

            Application.Run(splashForm);
        }
    }
}
