using BerserkerTech.Models.ViewModels.User;
using BerserkerTech.Services.UserLogic;
using BerserkerTech.Services.UserLogic.DesktopOnlyService;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BerserkerDesktop
{
    public partial class LogIn : Form
    {
        private readonly DesktopLogInService _userService;
        public LogIn()
        {
            InitializeComponent();
            _userService = new DesktopLogInService();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var succesfull = _userService.LogIn(emailTb.Text, PasswordTb.Text);
           
            if (succesfull)
            {
                Home home = new Home();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Log in succesfull");
            }

        }
    }
}
