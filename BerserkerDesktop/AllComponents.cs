using BerserkerDesktop.ComponentForms.ComponentCreation;
using BerserkerTech.Models.DTOs.Components;
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

namespace BerserkerDesktop
{
    public partial class AllComponents : Form
    {
        private MainComponentService _mainComponentService;
        public AllComponents()
        {
            _mainComponentService = new MainComponentService();
            InitializeComponent();
            compTypeCmb.Items.AddRange(new string[] { "CPU", "GPU", "Motherboard", "RAM", "PSU", "Storage" });
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (ComponentList.SelectedItem != null)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this component?", "Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    switch (compTypeCmb.Text)
                    {
                        case "CPU":
                            CPU cpu = (CPU)ComponentList.SelectedItem;
                            _mainComponentService._cpuService.Delete(cpu.Id);
                            break;
                        case "GPU":
                            GPU gpu = (GPU)ComponentList.SelectedItem;
                            _mainComponentService._gpuService.Delete(gpu.Id);
                            break;
                        case "Motherboard":
                            Motherboard motherboard = (Motherboard)ComponentList.SelectedItem;
                            _mainComponentService._motherboardService.Delete(motherboard.Id);
                            break;
                        case "RAM":
                            RAM ram = (RAM)ComponentList.SelectedItem;
                            _mainComponentService._ramService.Delete(ram.Id);
                            break;
                        case "PSU":
                            PSU psu = (PSU)ComponentList.SelectedItem;
                            _mainComponentService._psuService.Delete(psu.Id);
                            break;
                        case "Storage":
                            Storage storage = (Storage)ComponentList.SelectedItem;
                            _mainComponentService._storageService.Delete(storage.Id);
                            break;
                        default:
                            throw new ArgumentException();
                    }
                }
                RefreshList();
            }
            else
                MessageBox.Show("Select a component first");
        }
        private void setQuantityBtn_Click(object sender, EventArgs e)
        {
            if (ComponentList.SelectedItem != null)
            {
                switch (compTypeCmb.Text)
                {
                    case "CPU":
                        CPU cpu = (CPU)ComponentList.SelectedItem;
                        cpu.Quantity_Available += int.Parse(quantityTb.Text);
                        _mainComponentService._cpuService.Update(cpu);
                        break;
                    case "GPU":
                        GPU gpu = (GPU)ComponentList.SelectedItem;
                        gpu.Quantity_Available += int.Parse(quantityTb.Text);
                        _mainComponentService._gpuService.Update(gpu);
                        break;
                    case "Motherboard":
                        Motherboard mb = (Motherboard)ComponentList.SelectedItem;
                        mb.Quantity_Available += int.Parse(quantityTb.Text);
                        _mainComponentService._motherboardService.Update(mb);
                        break;
                    case "RAM":
                        RAM rm = (RAM)ComponentList.SelectedItem;
                        rm.Quantity_Available += int.Parse(quantityTb.Text);
                        _mainComponentService._ramService.Update(rm);
                        break;
                    case "PSU":
                        PSU psu = (PSU)ComponentList.SelectedItem;
                        psu.Quantity_Available += int.Parse(quantityTb.Text);
                        _mainComponentService._psuService.Update(psu);
                        break;
                    case "Storage":
                        Storage storage = (Storage)ComponentList.SelectedItem;
                        storage.Quantity_Available += int.Parse(quantityTb.Text);
                        _mainComponentService._storageService.Update(storage);
                        break;
                    default:
                        throw new ArgumentException();
                }
                RefreshList();
            }
            else
                MessageBox.Show("Select a part first");

        }
        private void RefreshList()
        {
            ComponentList.Items.Clear();
            switch (compTypeCmb.Text)
            {
                case "CPU":
                    ComponentList.Items.AddRange(_mainComponentService._cpuService.GetAll().ToArray());
                    break;
                case "GPU":
                    ComponentList.Items.AddRange(_mainComponentService._gpuService.GetAll().ToArray());
                    break;
                case "Motherboard":
                    ComponentList.Items.AddRange(_mainComponentService._motherboardService.GetAll().ToArray());
                    break;
                case "RAM":
                    ComponentList.Items.AddRange(_mainComponentService._ramService.GetAll().ToArray());
                    break;
                case "PSU":
                    ComponentList.Items.AddRange(_mainComponentService._psuService.GetAll().ToArray());
                    break;
                case "Storage":
                    ComponentList.Items.AddRange(_mainComponentService._storageService.GetAll().ToArray());
                    break;
                default:
                    throw new ArgumentException();
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (ComponentList.SelectedItem != null)
            {
                switch (compTypeCmb.Text)
                {
                    case "CPU":
                        AddCPU cpuForm = new AddCPU((CPU)ComponentList.SelectedItem);
                        cpuForm.Show();
                        break;
                    case "GPU":
                        AddGPU gpuForm = new AddGPU((GPU)ComponentList.SelectedItem);
                        gpuForm.Show();
                        break;
                    case "Motherboard":
                        AddMotherboard mbForm = new AddMotherboard((Motherboard)ComponentList.SelectedItem);
                        mbForm.Show();
                        break;
                    case "RAM":
                        AddRAM ramForm = new AddRAM((RAM)ComponentList.SelectedItem);
                        ramForm.Show();
                        break;
                    case "PSU":
                        AddPSU psuForm = new AddPSU((PSU)ComponentList.SelectedItem);
                        psuForm.Show();
                        break;
                    case "Storage":
                        AddStorage strForm = new AddStorage((Storage)ComponentList.SelectedItem);
                        strForm.Show();
                        break;
                    default:
                        throw new ArgumentException();
                }
                RefreshList();
            }
            else
                MessageBox.Show("Select a component first");
        }

        private void compTypeCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshList();
        }

       
    }
}
