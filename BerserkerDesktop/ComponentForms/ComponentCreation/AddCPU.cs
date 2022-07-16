using BerserkerTech.Models.DTOs.Components;
using BerserkerTech.Services.ComponentLogic;

namespace BerserkerDesktop
{
    public partial class AddCPU : Form
    {
        public readonly CpuService _cpuService;
        private bool editMode;
        private CPU oldCpu;
        public AddCPU()
        {
            _cpuService = new CpuService();
            editMode = false;
            InitializeComponent();
        }

        public AddCPU(CPU cpu)
        {
            _cpuService = new CpuService();
            editMode = true;
            oldCpu = cpu;
            InitializeComponent();
            brandTb.Text = oldCpu.Brand;
            modelTb.Text = oldCpu.Model;
            speedTb.Text = oldCpu.Speed;
            coreCountTb.Text = oldCpu.Cores;
            genTb.Text = oldCpu.Generation;
            powerdrawTb.Text = oldCpu.PowerDraw.ToString();
            priceTb.Text = oldCpu.Price.ToString();
            quantityTb.Text = oldCpu.Quantity_Available.ToString();
            SocketTb.Text = oldCpu.Socket;
            quantityTb.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (editMode)
            {
                oldCpu.Brand = brandTb.Text;
                oldCpu.Model = modelTb.Text;
                oldCpu.Speed = speedTb.Text;
                oldCpu.Cores = coreCountTb.Text;
                oldCpu.Generation = genTb.Text;
                oldCpu.PowerDraw = int.Parse(powerdrawTb.Text);
                oldCpu.Photo = "";
                oldCpu.Price = double.Parse(priceTb.Text);
                oldCpu.Quantity_Available = int.Parse(quantityTb.Text);
                oldCpu.Socket = SocketTb.Text;
                _cpuService.Update(oldCpu);
            }
            else
            {
                _cpuService.Add(new CPU()
                {
                    Brand = brandTb.Text,
                    Model = modelTb.Text,
                    Speed = speedTb.Text,
                    Cores = coreCountTb.Text,
                    Generation = genTb.Text,
                    PowerDraw = int.Parse(powerdrawTb.Text),
                    Photo = "",
                    Price = double.Parse(priceTb.Text),
                    Quantity_Available = int.Parse(quantityTb.Text),
                    Socket = SocketTb.Text,
                });
            }
            this.Hide();
        }

        private void AddCPU_Load(object sender, EventArgs e)
        {

        }
    }
}