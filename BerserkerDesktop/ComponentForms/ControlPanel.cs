using BerserkerDesktop.ComponentForms.ComponentCreation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BerserkerDesktop.ComponentForms
{
    public partial class ControlPanel : Form
    {
        public ControlPanel()
        {
            InitializeComponent();
        }

        

        private void addCpuBtn_Click(object sender, EventArgs e)
        {
            AddCPU addCPU = new AddCPU();
            addCPU.Show();
        }

        private void AddMotherboardBtn_Click(object sender, EventArgs e)
        {
            AddMotherboard addMotherboard = new AddMotherboard();
            addMotherboard.Show();
        }

        private void AddGpuBtn_Click(object sender, EventArgs e)
        {
            AddGPU addGPU = new AddGPU();
            addGPU.Show();
        }

        private void AddRamBtn_Click(object sender, EventArgs e)
        {
            AddRAM addRAM = new AddRAM();
            addRAM.Show();
        }

        private void AddPsuBtn_Click(object sender, EventArgs e)
        {
            AddPSU addPSU = new AddPSU();
            addPSU.Show();
        }

        private void AddStorageBtn_Click(object sender, EventArgs e)
        {
            AddStorage addStorage = new AddStorage();
            addStorage.Show();
        }

        private void allComponentsBtn_Click(object sender, EventArgs e)
        {
            AllComponents form = new AllComponents();
            form.Show();

        }

        private void goBackBtn_Click(object sender, EventArgs e)
        {
            Home form = new Home();
            this.Hide();
            form.Show();
        }
    }
}
