using BerserkerTech.Models.DTOs.Components;
using BerserkerTech.Services.ComponentLogic;
using BerserkerTech.Services.ComponentLogic.Interfaces;
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
    public partial class AddRAM : Form
    {
        private readonly RamService _ramService;
        private bool editMode;
        private RAM oldram;
        public AddRAM()
        {
            editMode = false;
            _ramService = new RamService();
            InitializeComponent();
        }
        public AddRAM(RAM ram)
        {
            _ramService = new RamService();
            oldram = ram;
            editMode = true;
            InitializeComponent();
            brandTb.Text = oldram.Brand;
            modelTb.Text = oldram.Model;
            capacityTb.Text = oldram.Capacity;
            genTb.Text = oldram.Ddr_Gen;
            powerdrawTb.Text = oldram.PowerDraw.ToString();
            quantityTb.Text = oldram.Quantity_Available.ToString();
            powerdrawTb.Text = oldram.Price.ToString();
            speedTb.Text = oldram.Speed;
            quantityTb.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (editMode)
            {
                oldram.Brand = brandTb.Text;
                oldram.Model = modelTb.Text;
                oldram.Capacity = capacityTb.Text;
                oldram.Ddr_Gen = genTb.Text;
                oldram.PowerDraw = int.Parse(powerdrawTb.Text);
                oldram.Quantity_Available = int.Parse(quantityTb.Text);
                oldram.Price = double.Parse(powerdrawTb.Text);
                oldram.Speed = speedTb.Text;
                oldram.Photo = "";
                _ramService.Update(oldram);
            }
            else
                _ramService.Add(new RAM()
                {
                    Brand = brandTb.Text,
                    Model = modelTb.Text,
                    Capacity = capacityTb.Text,
                    Ddr_Gen = genTb.Text,
                    PowerDraw = int.Parse(powerdrawTb.Text),
                    Quantity_Available = int.Parse(quantityTb.Text),
                    Price = double.Parse(powerdrawTb.Text),
                    Speed = speedTb.Text,
                    Photo = ""
                });
            this.Hide();
        }
    }
}
