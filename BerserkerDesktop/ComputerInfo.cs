using BerserkerTech.Models.DTOs;
using BerserkerTech.Models.ViewModels.Request.Computer;
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
    public partial class ComputerInfo : Form
    {
        private ComputerViewModel _computer { set; get; }
        private readonly RequestService requestService;
        public ComputerInfo(ComputerViewModel _computer)
        {
            InitializeComponent();
            this._computer = _computer;
            requestService = new RequestService();
            cpuLbl.Text = _computer.CpuInfo;
            gpuLbl.Text = _computer.GpuInfo;
            motherboardLbl.Text = _computer.MotherboardInfo;
            psuLbl.Text = _computer.PsuInfo;
            storageLbl.Text = _computer.StorageInfo;
            ramLbl.Text = _computer.RamInfo;
        }

        private void finishBtn_Click(object sender, EventArgs e)
        {
            requestService.MarkAsCompleted(_computer.Id);
            this.Hide();
            BuildersPage form = new BuildersPage();
            form.Show();    
        }

        private void ComputerInfo_Load(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            BuildersPage form = new BuildersPage();
            form.Show();
        }
    }
}
