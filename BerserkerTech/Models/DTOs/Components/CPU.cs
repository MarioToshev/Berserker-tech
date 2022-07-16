namespace BerserkerTech.Models.DTOs.Components
{
    public class CPU : ComputerComponent
    {
        private string cores;
        private string speed;
        private string socket;
        private string generation;

        public CPU():base()
        {
        }

        public CPU(string model, string brand, int quantityInStok, double price, 
            string cores,string speed,string socket, string generation, int powerdraw)
           : base(quantityInStok, price, model, brand,  powerdraw)
        {
            this.Cores = cores;
            this.Speed = speed;
            this.Socket = socket;
            this.Generation = generation;
        }

        public string Generation
        {
            get { return generation; }
            set { generation = value; }
        }


        public string Socket
        {
            get { return socket; }
            set { socket = value; }
        }

        public string Speed
        {
            get { return speed; }
            set
            {
                //if (int.Parse(value) > 0)
              //  {
                    speed = value;
               // }
            }
        }
        public string Cores
        {
            get { return cores; }
            set
            {
                if (int.Parse(value) > 0)
                {
                    cores = value;
                }
            }
        }
        public override string GetDescription()
        {
            return $"This CPU has {cores} cores  clocked at {speed}";
        }
        public override string ToString()
        {
            return $"{Brand} {Model} In stock: {Quantity_Available}";
        }

    }
}
