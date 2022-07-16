namespace BerserkerTech.Models.DTOs.Components
{
    public class Motherboard : ComputerComponent
    {
        private string socket;
        private int ram_Slots;
        private int max_Ram_Capacity;
        private int nvmeSlots;
        private string ramGenSupport;
        private string supported_CPU_Models;


        public Motherboard(int quantityInStok, double price, string model, string brand, string socket, string cpuGenSupport,
            int ramSlots,int maxRamCap, int nvmeSlots,string ramGenSup, int powerdraw)
            : base(quantityInStok, price, model, brand,  powerdraw)
        {
            this.Socket = socket;
            this.Ram_Slots = ramSlots;
            this.Max_Ram_Capacity = maxRamCap;
            this.NvmeSlots = nvmeSlots;
            this.RamGenSupport = ramGenSup;
            this.Supported_CPU_Models = cpuGenSupport;
        }
        public Motherboard() : base()
        {

        }
        public string Supported_CPU_Models
        {
            get { return supported_CPU_Models; }
            set { supported_CPU_Models = value; }
        }
        public string RamGenSupport
        {
            get { return ramGenSupport; }
            set { ramGenSupport = value; }
        }

        public int NvmeSlots
        {
            get { return nvmeSlots; }
            set { nvmeSlots = value; }
        }


        public int Max_Ram_Capacity
        {
            get { return max_Ram_Capacity; }
            set { max_Ram_Capacity = value; }
        }


        public int Ram_Slots
        {
            get { return ram_Slots; }
            set
            {
                if (value > 0 && value % 2 == 0)
                {
                    ram_Slots = value;
                }
            }
        }
        public string Socket
        {
            get { return socket; }
            set { socket = value; }
        }

        public override string GetDescription()
        {
            return $"This MotherBoard has {socket} socket, it supports {supported_CPU_Models} " +
                $"CPUs and works with {ramGenSupport} ram stiks. The max capacity is {max_Ram_Capacity}";
        }
        public override string ToString()
        {
            return $"{Brand} {Model} In stock: {Quantity_Available}";
        }
    }
}
