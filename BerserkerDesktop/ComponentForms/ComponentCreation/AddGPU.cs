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
    public partial class AddGPU : Form
    {
        private readonly GpuService _gpuService;
        private GPU oldGpu;
        private bool editMode;
        public AddGPU()
        {
            editMode = false;
            _gpuService = new GpuService();
            InitializeComponent();
        }
        public AddGPU(GPU gpu)
        {
            oldGpu = gpu;
            editMode = true;
            _gpuService = new GpuService();
            InitializeComponent();
            modelTb.Text = oldGpu.Model;
            brandTb.Text = oldGpu.Brand;
            coreCountTb.Text = oldGpu.Core_Count;
            speedTb.Text = oldGpu.Core_Speed;
            memoryCapTb.Text = oldGpu.Memory_Capacity;
            memorySpeedtb.Text = oldGpu.Memory_Speed;
            manufacturerTb.Text = oldGpu.Manufacturer;
            powerdrawTb.Text = oldGpu.PowerDraw.ToString();
            priceTb.Text = oldGpu.Price.ToString();
            quantityTb.Text = oldGpu.Quantity_Available.ToString();
            quantityTb.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (editMode)
            {
                oldGpu.Model = modelTb.Text;
                oldGpu.Brand = brandTb.Text;
                oldGpu.Core_Count = coreCountTb.Text;
                oldGpu.Core_Speed = speedTb.Text;
                oldGpu.Memory_Capacity = memoryCapTb.Text;
                oldGpu.Memory_Speed = memorySpeedtb.Text;
                oldGpu.Memory_Capacity = memoryCapTb.Text;
                oldGpu.Manufacturer = manufacturerTb.Text;
                oldGpu.PowerDraw = int.Parse(powerdrawTb.Text);
                oldGpu.Price = double.Parse(priceTb.Text);
                oldGpu.Quantity_Available = int.Parse(quantityTb.Text);
                _gpuService.Update(oldGpu);
            }
            else
                _gpuService.Add(new GPU()
                {
                    Model = modelTb.Text,
                    Brand = brandTb.Text,
                    Core_Count = coreCountTb.Text,
                    Core_Speed = speedTb.Text,
                    Memory_Speed = memorySpeedtb.Text,
                    Memory_Capacity = memoryCapTb.Text,
                    Manufacturer = manufacturerTb.Text,
                    PowerDraw = int.Parse(powerdrawTb.Text),
                    Photo = "",
                    Price = double.Parse(priceTb.Text),
                    Quantity_Available = int.Parse(quantityTb.Text)
                });
            this.Hide();
        }

    }
}
