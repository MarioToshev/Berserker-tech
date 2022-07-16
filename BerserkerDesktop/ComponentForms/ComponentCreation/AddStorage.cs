using BerserkerTech.Models.DTOs.Components.Storage;
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
    public partial class AddStorage : Form
    {
        private readonly StorageService _storageService;
        private bool editMode;
        private Storage oldStorage;
        public AddStorage()
        {
            editMode = false;
            _storageService = new StorageService();
            InitializeComponent();
        }
        public AddStorage(Storage storage)
        {
            editMode = true;
            oldStorage = storage;
            _storageService = new StorageService();
            InitializeComponent();
            brandTb.Text = oldStorage.Brand;
            capacityTb.Text = oldStorage.Capacity;
            modelTb.Text = oldStorage.Model;
            powerdrawTb.Text = oldStorage.PowerDraw.ToString();
            priceTb.Text = oldStorage.Price.ToString();
            quantityTb.Text = oldStorage.Quantity_Available.ToString();
            speedTb.Text = oldStorage.Speed;
            typeTb.Text = oldStorage.Type;
            quantityTb.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (editMode)
            {
                oldStorage.Brand = brandTb.Text;
                oldStorage.Capacity = capacityTb.Text;
                oldStorage.Model = modelTb.Text;
                oldStorage.PowerDraw = int.Parse(powerdrawTb.Text);
                oldStorage.Price = double.Parse(priceTb.Text);
                oldStorage.Quantity_Available = int.Parse(quantityTb.Text);
                oldStorage.Speed = speedTb.Text;
                oldStorage.Type = typeTb.Text;
                _storageService.Update(oldStorage);
            }
            else
                _storageService.Add(new Storage()
                {
                    Brand = brandTb.Text,
                    Capacity = capacityTb.Text,
                    Model = modelTb.Text,
                    PowerDraw = int.Parse(powerdrawTb.Text),
                    Price = double.Parse(priceTb.Text),
                    Quantity_Available = int.Parse(quantityTb.Text),
                    Speed = speedTb.Text,
                    Type = typeTb.Text
                });
            this.Hide();
        }

        private void AddStorage_Load(object sender, EventArgs e)
        {

        }
    }
}
