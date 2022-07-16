namespace BerserkerTech.Models.DTOs.Components
{
    public class GPU : ComputerComponent
    {
        private string coresCount;
        private string coreSpeed;
        private string manufacturer;
        private string memory;
        private string memorySpeed;
        private string memoryCap;

     
        public GPU(int quantityInStok, double price, string model, string brand,
            string cores, string coreSpeed,string manufacturer,string memoryCount, string memorySpeed, int powerdraw)
          : base(quantityInStok, price, model, brand, powerdraw)
        {
            this.Core_Count = cores;
            this.Core_Speed = coreSpeed;
            this.Manufacturer = manufacturer;
            this.Memory_Speed = memorySpeed;
            this.Memory_Capacity = memoryCount;
        }
        public GPU():base()
        {
        }
        public string Memory_Capacity
        {
            get { return memoryCap; }
            set { memoryCap = value; }
        }

        public string Memory_Speed
        {
            get { return memorySpeed; }
            set { memorySpeed = value; }
        }
        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }

        public string Core_Speed
        {
            get { return coreSpeed; }
            set { coreSpeed = value; }
        }


        public string Core_Count
        {
            get { return coresCount; }
            set { coresCount = value; }
        }
        public override string GetDescription()
        {
           return $"This gpu has {coresCount} cores clocked at {coreSpeed} and {memory} gb of vram clocked at {memorySpeed}";
        }
        public override string ToString()
        {
            return $"{Brand} {Manufacturer} {Model} {Memory_Capacity}GB In stock: {Quantity_Available}";
        }

    }
}
