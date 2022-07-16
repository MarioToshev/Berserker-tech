namespace BerserkerTech.Models.DTOs.Components
{
    public abstract class ComputerComponent
    {
        private string id;
        private string brand;
        private string model;
        private string photo;
        private double price;
        private int quantityInStock;
        private int powerDraw;



        protected ComputerComponent()
        {
            Id = Guid.NewGuid().ToString();
        }
        protected ComputerComponent(int quantityInStok, double price, /*string photo, */ string model, string brand, int powerdraw)
        {
            Quantity_Available = quantityInStok;
            Price = price;
            // Photo = photo;
            Model = model;
            Brand = brand;
            Id = Guid.NewGuid().ToString();
            this.PowerDraw = powerdraw;
        }
        public int PowerDraw
        {
            get { return powerDraw; }
            set { powerDraw = value; }
        }

        public int Quantity_Available
        {
            get { return quantityInStock; }
            set { quantityInStock = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public string Photo
        {
            get { return photo; }
            set { photo = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public virtual string GetDescription()
        {
            return "";
        }
        public override string ToString()
        {
            //component description
            return $"{Brand} {Model}";
        }

    }
}
