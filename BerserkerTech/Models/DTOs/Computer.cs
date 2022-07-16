using BerserkerTech.Models.DTOs.Components;
using BerserkerTech.Models.DTOs.Components.Storage;

namespace BerserkerTech.Models.DTOs
{
    public class Computer
    {
        private CPU cpu;
        private Motherboard motherboard;
        private GPU gpu;
        private RAM ram;
        private int ramQuatity;
        private Storage storage;
        private PSU psu;

        public Computer(PSU psu, int ramQuantity, Storage storage, RAM ram, GPU gpu,
            Motherboard motherboard, CPU cpu)
        {
            Id = Guid.NewGuid().ToString();
            PSU = psu;
            RamQuantity = ramQuantity;
            Storage = storage;
            RAM = ram;
            GPU = gpu;
            Motherboard = motherboard;
            CPU = cpu;
        }

        public Computer()
        {
            Id = Guid.NewGuid().ToString();
            ramQuatity = 1;
            CPU =  new CPU();
            GPU = new GPU();
            RAM = new RAM();
            Storage = new Storage();
            Motherboard = new Motherboard();
            PSU = new PSU();
        }
        //FUTURE => Multiple storages 
        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public  PSU PSU
        {
            get { return psu; }
            set { psu = value; }
        }
        public int RamQuantity
        {
            get { return ramQuatity; }
            set { ramQuatity = value; }
        } 
        public Storage Storage
        {
            get { return storage; }
            set { storage = value; }
        }
        public RAM RAM
        {
            get { return ram; }
            set { ram = value; }
        }
        public GPU GPU
        {
            get { return gpu; }
            set { gpu = value; }
        }
        public Motherboard Motherboard
        {
            get { return motherboard; }
            set { motherboard = value; }
        }
        public  CPU CPU
        {
            get { return cpu; }
            set { cpu = value; }
        }
    }
}
