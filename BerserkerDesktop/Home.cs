using BerserkerDesktop.ComponentForms;
using BerserkerTech.Models.ViewModels.User;
using BerserkerTech.Services.UserLogic;
using BerserkerTech.Services.UserLogic.DesktopOnlyService;
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
    public partial class Home : Form
    {
        private readonly DesktopLogInService _userService;

        public Home()
        {
            _userService = new DesktopLogInService();
            InitializeComponent();
            welcomeLbl.Text = $"Hello {_userService.GetLoggedUser().FirstName}";
            //adminBtn.Enabled = false;
            //if (_userService.GetLoggedUser().role.Role_name == "Admin")
            //{
            //    adminBtn.Enabled = true;
            //}
        }

        private void AddPartsBtn_Click(object sender, EventArgs e)
        {
            ControlPanel form = new ControlPanel();
            form.Show();
            this.Hide();
        }
        private void logOutBtn_Click(object sender, EventArgs e)
        {
            _userService.LogOut();
            LogIn form = new LogIn();
            form.Show();
            this.Hide();
        }

        private void buildComputerbtn_Click(object sender, EventArgs e)
        {
            BuildersPage form = new BuildersPage();
            form.Show();
        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
            if (_userService.GetLoggedUser().Role_Name == "Admin")
            {
                AdminPanel form = new AdminPanel();
                form.Show();
            }
            else
                MessageBox.Show("Only admins have access to this page");
        }
    }
}
