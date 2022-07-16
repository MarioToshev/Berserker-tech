namespace BerserkerTech.Models.DTOs
{
    public class Request
    {
        private string id;
        private string client_id;
        private string builder_id;
        private string computer_id;
        private string status;

        public Request(string client_id, string builder_id, string computer_id, string status)
        {
            this.Id = Guid.NewGuid().ToString();
            this.Client_Id = client_id;
            this.Builder_Id = builder_id;
            this.Computer_Id = computer_id;
            this.Status = status;
        }
        public Request() { }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public string Computer_Id
        {
            get { return computer_id; }
            set { computer_id = value; }
        }


        public string Builder_Id
        {
            get { return builder_id; }
            set { builder_id = value; }
        }
        public string Client_Id
        {
            get { return client_id; }
            set { client_id = value; }
        }


        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public override string ToString()
        {
            return $"Request Id: {Id}, Status: {Status}";
        }
    }
}
