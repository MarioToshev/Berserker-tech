using BerserkerTech.Models.DTOs.Components;
using BerserkerTech.Services.ComponentLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BerserkerDesktop.ComponentForms.ComponentCreation
{
    public partial class AddMotherboard : Form
    {
        private readonly MotherboardService _motherboardService;
        private bool editMode;
        private Motherboard oldMotherboard;
        public AddMotherboard()
        {
            editMode = false;
            InitializeComponent();
            _motherboardService = new MotherboardService();
        }
        public AddMotherboard(Motherboard motherboard)
        {
            InitializeComponent();
            editMode = true;
            _motherboardService = new MotherboardService();
            oldMotherboard = motherboard;

            brandTb.Text = oldMotherboard.Brand;
            modelTb.Text = oldMotherboard.Model;
            socketTb.Text = oldMotherboard.Socket;
            CpuGenerationSupptb.Text = oldMotherboard.Supported_CPU_Models;
            MaxRamCapacityTb.Text = oldMotherboard.Max_Ram_Capacity.ToString();
            NvmeSlotsTb.Text = oldMotherboard.NvmeSlots.ToString();
            priceTb.Text = oldMotherboard.Price.ToString();
            quantityTb.Text = oldMotherboard.Quantity_Available.ToString();
            ramGenSupportTb.Text = oldMotherboard.RamGenSupport;
            ramSlotsTb.Text = oldMotherboard.Ram_Slots.ToString();
            quantityTb.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (editMode)
            {
                oldMotherboard.Brand = brandTb.Text;
                oldMotherboard.Model = modelTb.Text;
                oldMotherboard.Socket = socketTb.Text;
                oldMotherboard.Supported_CPU_Models = CpuGenerationSupptb.Text;
                oldMotherboard.Max_Ram_Capacity = int.Parse(MaxRamCapacityTb.Text);
                oldMotherboard.NvmeSlots = int.Parse(NvmeSlotsTb.Text);
                oldMotherboard.Price = double.Parse(priceTb.Text);
                oldMotherboard.Quantity_Available = int.Parse(quantityTb.Text);
                oldMotherboard.RamGenSupport = ramGenSupportTb.Text;
                oldMotherboard.Ram_Slots = int.Parse(ramSlotsTb.Text);
                _motherboardService.Update(oldMotherboard);
            }
            else
                _motherboardService.Add(new Motherboard()
                {
                    Brand = brandTb.Text,
                    Model = modelTb.Text,
                    Socket = socketTb.Text,
                    Supported_CPU_Models = CpuGenerationSupptb.Text,
                    Max_Ram_Capacity = int.Parse(MaxRamCapacityTb.Text),
                    NvmeSlots = int.Parse(NvmeSlotsTb.Text),
                    Price = double.Parse(priceTb.Text),
                    Quantity_Available = int.Parse(quantityTb.Text),
                    RamGenSupport = ramGenSupportTb.Text,
                    Ram_Slots = int.Parse(ramSlotsTb.Text)
                });
            this.Hide();
        }
    }
}
