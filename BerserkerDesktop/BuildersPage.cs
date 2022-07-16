using BerserkerTech.Models.DTOs;
using BerserkerTech.Models.ViewModels.Request.Computer;
using BerserkerTech.Services.ComputerLogic;
using BerserkerTech.Services.OrderLogic;
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
    public partial class BuildersPage : Form
    {
        private readonly RequestService _requestService;
        private readonly ComputerService _computerService;

        public BuildersPage()
        {
            _requestService = new RequestService();
            _computerService = new ComputerService();
            InitializeComponent();
            foreach (var item in _requestService.GetAllWithStatus("Sent"))
            {
              Requestslb.Items.Add(item);
            }
        }
        private void buildBtn_Click(object sender, EventArgs e)
        {
            if (Requestslb.SelectedItem != null)
            {
                Request request = Requestslb.SelectedItem as Request;
                ComputerViewModel pc = _computerService.GetComputerInfoFromBase(request.Computer_Id);
                ComputerInfo form = new ComputerInfo(pc);
                form.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Selewct something first");
        }
    } 
}
