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
    public partial class AddPSU : Form
    {
        private readonly PsuService _psuService;
        private bool editMode;
        private PSU oldPsu;
        public AddPSU()
        {
            _psuService = new PsuService();
            editMode = false;
            InitializeComponent();
        }
        public AddPSU(PSU psu)
        {
            _psuService = new PsuService();
            InitializeComponent();
            oldPsu = psu;
            editMode = true;
            brandTb.Text = oldPsu.Brand;
            certificateTb.Text = oldPsu.Certificate;
            modelTb.Text = oldPsu.Model;
            MaxPowerTb.Text = oldPsu.Max_power.ToString();
            priceTb.Text = oldPsu.Price.ToString();
            quantityTb.Text = oldPsu.Quantity_Available.ToString();
            quantityTb.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TextFieldsAreFilled())
            {
                try
                {
                    if (editMode)
                    {
                        oldPsu.Brand = brandTb.Text;
                        oldPsu.Certificate = certificateTb.Text;
                        oldPsu.Model = modelTb.Text;
                        oldPsu.Max_power = int.Parse(MaxPowerTb.Text);
                        oldPsu.Price = double.Parse(priceTb.Text);
                        oldPsu.Quantity_Available = int.Parse(quantityTb.Text);
                        _psuService.Update(oldPsu);
                    }
                    else
                        _psuService.Add(new PSU()
                        {
                            Brand = brandTb.Text,
                            Certificate = certificateTb.Text,
                            Model = modelTb.Text,
                            Max_power = int.Parse(MaxPowerTb.Text),
                            Price = double.Parse(priceTb.Text),
                            Quantity_Available = int.Parse(quantityTb.Text)
                        });
                    this.Hide();
                }
                catch (Exception)
                {

                    MessageBox.Show("Price, Quantity, and Power should be numbers");
                }
               
            }
        }
       
        private bool TextFieldsAreFilled()
        {
            if (brandTb.Text != "" &&
                certificateTb.Text != "" &&
                modelTb.Text != "" &&
                MaxPowerTb.Text != "" &&
                MaxPowerTb.Text != "" &&
                priceTb.Text != "" &&
                quantityTb.Text != ""
                )
            {
                return true;
            }
            else
            return false;
        }

    }
}
