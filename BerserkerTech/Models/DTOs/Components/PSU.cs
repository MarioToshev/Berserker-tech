namespace BerserkerTech.Models.DTOs.Components
{
    public class PSU:ComputerComponent
    {
        private string certificate;
        private int max_power;

        public int Max_power
        {
            get { return max_power; }
            set { max_power = value; }
        }


        public PSU(int quantityInStok, double price, string model, string brand, string certificate, int maxPower) 
            : base(quantityInStok, price, model, brand,0)
        {
            this.Max_power = maxPower;
            this.Certificate = certificate;
        }
        public PSU() : base() { }
       


        public string Certificate
        {
            get { return certificate; }
            set { certificate = value; }
        }


        public override string GetDescription()
        {
            return $"This {max_power}W PSU has {certificate} certificate ";
        }
        public override string ToString()
        {
            return $"{Brand} {Model} In stock: {Quantity_Available}";
        }
    }
}
