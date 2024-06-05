using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierApplication
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLoginAccount loginForm = new frmLoginAccount();


            DialogResult loginResult = loginForm.ShowDialog();


            if (loginResult == DialogResult.OK)
            {
                
            }
            else
            {
            }
        }
    }
}
