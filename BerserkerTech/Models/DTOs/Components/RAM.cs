namespace BerserkerTech.Models.DTOs.Components
{
    public class RAM:ComputerComponent
    {
        private string capacity;
        private string ddr_Gen;
        private string speed;

        public RAM(int quantityInStok, double price, string model, string brand,
            string speed, string generation, string capacity, int powerdraw) : base(quantityInStok, price, model, brand, powerdraw)
        {
            Speed = speed;
            Ddr_Gen = generation;
            Capacity = capacity;
        }
        public RAM() : base() { }

        public string Speed
        {
            get { return speed; }
            set { speed = value; }
        }


        public string Ddr_Gen
        {
            get { return ddr_Gen; }
            set { ddr_Gen = value; }
        }


        public string Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public override string GetDescription()
        {
            return $"{capacity}gb {ddr_Gen} RAM stick clocked at {speed}";
        }
        public override string ToString()
        {
            return  $"{Brand} {Model} {capacity}GB In stok: {Quantity_Available}";
        }

    }
}
