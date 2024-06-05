using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierApplication
{
    public partial class frmLoginAccount : Form
    {
        public frmLoginAccount()
        {
            InitializeComponent();
        }

        private void Login(object sender, EventArgs e)
        {
            
                string registeredUsername = textBox1.Text;
                string registeredPassword = textBox2.Text;

                
                if (IsValidUser(registeredUsername, registeredPassword))
                {
                    
                    string fullName = GetUserFullName(registeredUsername);
                    string department = GetUserDepartment(registeredUsername);
                    MessageBox.Show($"Welcome, {fullName} {department}!");
               frmPurchaseDiscountedItem discounted = new frmPurchaseDiscountedItem();
                discounted.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password. Please try again.");
                }
            }

            
            private bool IsValidUser(string username, string password)
            {
            return (username == "Cashier01" && password == "DefaultPass");
        }

            
            private string GetUserFullName(string username)
            {
            if (username == "Cashier01")
            {
                return "Manager";
            }
            else
            {
               
                return "Invalid User";
            }
        }

            
            private string GetUserDepartment(string username)
            {
            if (username == "Cashier01")
            {
                return "of Finance";
            }
            else
            {
                
                return "Invalid Department";
            }
        }
        }
    }
    

