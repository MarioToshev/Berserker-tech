using BerserkerTech.Models.DTOs.Components;

namespace BerserkerTech.Models.DTOs
{
    public class Cart_Item
    {
        private string id;

        private ComputerComponent component;
        private int quantitiy;
        private double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }


        public int Quantity
        {
            get { return quantitiy; }
            set { quantitiy = value; }
        }


        public ComputerComponent Component
        {
            get { return component; }
            set { component = value; }
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

    }
}
