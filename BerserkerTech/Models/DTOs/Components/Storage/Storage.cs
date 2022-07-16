namespace BerserkerTech.Models.DTOs.Components.Storage
{
    public class Storage : ComputerComponent
    {
        private string capacity;
        private string type;
        private string speed;

        public Storage(int quantityInStok, double price, string model, string brand, string capacity, string speed, string storageType, int powerdraw)
                   : base(quantityInStok, price, model, brand, powerdraw)
        {
            this.Capacity = capacity;
            this.Speed = speed;
            this.Type = storageType;
        }
        public Storage():base(){}

        public string Speed
        {
            get { return speed; }
            set { speed = value; }
        }


        public string Type
        {
            get { return type; }
            set { type = value; }
        }


        public string Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }
        public override string GetDescription()
        {
           return $"This {type}  as a max capacity of {capacity} and a speed of {speed} mb/s";
        }

        public override string ToString()
        {
            return  $"{Brand} {Model} {Capacity}GB In stock: {Quantity_Available}";
        }
    }
}
