using BerserkerTech.Models.DTOs;
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
    public partial class AdminPanel : Form
    {
        private readonly UserService _userService;
        private readonly DesktopLogInService _desktopLogInService;

        public AdminPanel()
        {
            InitializeComponent();
            _userService = new UserService();
            _desktopLogInService = new DesktopLogInService();
            RefreshList();
            roleCmb.Items.AddRange(new string[] { "Admin", "Builder"});
            changeRoleCmb.Items.AddRange(new string[] { "Admin", "Builder" });
        }

        private void changeRoleBtn_Click(object sender, EventArgs e)
        {
            _userService.ChangeRole(changeRoleCmb.Text, AllEmployees.SelectedItem.ToString().Split(" ").ToList()[2]);
            RefreshList();
        }
        private void RefreshList()
        {
            AllEmployees.Items.Clear();
            foreach (var user in _userService.GetAllUsers())
            {
                AllEmployees.Items.Add(user);
            }
        }

        private void CreateUser_Click(object sender, EventArgs e)
        {
            UserDTO newUser = new UserDTO()
            {
                FirstName = firstNameTb.Text,
                SecondName = secondNameTb.Text,
                Email = emailTb.Text,
                Address = addressTb.Text,
                Password = pwdTb.Text,
                Role_Name = roleCmb.Text,
            };

            _userService.AddUser(newUser);
        }
    }
}
