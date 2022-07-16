using BerserkerTech.Models.DTOs;
using BerserkerTech.Models.DTOs.Components;
using BerserkerTech.Services.ComponentLogic.Interfaces;

namespace BerserkerTech.Services.ComponentLogic
{
    public class MotherboardService : IComponentService
    {
        private DatabaseComunication _databaseComunication;
        public MotherboardService()
        {
            _databaseComunication = new DatabaseComunication();
        }

        public void Add(ComputerComponent component)
        {
            var query = @"Insert into motherboards(Id, Model, Brand, Socket, Ram_Slots, RamGenSupport, Supported_CPU_Models, Max_Ram_Capacity, PowerDraw, Photo_id, Quantity_Available, Price)
                         values(@Id, @Model,@Brand,@Socket,@Ram_Slots,@RamGenSupport, @Supported_CPU_Models, @Max_Ram_Capacity, @Powerdraw, @Photo_id, @Quantity_Available, @Price);";
            Motherboard mb = (Motherboard)component;

            _databaseComunication.InsertData(query, GetDict(mb));
        }

        public void Delete(string Id)
        {
            var query = @"delete from motherboards where Id = @Id;";
            _databaseComunication.InsertData(query, new Dictionary<string, dynamic>
            {
                {"@Id", Id}
            });
        }

        public List<Motherboard> GetAll()
        {
            var query = @"Select * from motherboards";
            return _databaseComunication.Get<Motherboard>(query, new Dictionary<string, dynamic> { });
        }
        public List<Motherboard> GetAllAvailable()
        {
            var query = @"Select * from motherboards
                          where Quantity_Available >= 1";
            return _databaseComunication.Get<Motherboard>(query, new Dictionary<string, dynamic> { });
        }

        public Motherboard GetOne(string Id)
        {
            var query = @"Select * from motherboards where Id = @Id";
            try
            {
                return _databaseComunication.Get<Motherboard>(query, new Dictionary<string, dynamic> { { "@Id", Id } })[0];
            }
            catch (Exception)
            {

                return null;
            }
        }
        public ComputerComponent GetOneByModelAndBrand(string Brand, string Model)
        {
            var query = @"Select * from motherboards where Model = @Model and Brand = @Brand";
            try
            {
                Motherboard result = new Motherboard();
                result = _databaseComunication.Get<Motherboard>(query, new Dictionary<string, dynamic>
                {
                  {"@Model", Model},
                  {"@Brand", Brand}
                })[0];
                return result;
            }
            catch (Exception)
            {

                return null;
            }

        }
        public void Update(ComputerComponent component)
        {
            var query = @"Update motherboards set Brand = @Brand ,Model = @Model,Socket = @Socket,Supported_CPU_Models = @Supported_CPU_Models,Photo_id = @Photo_id, Max_Ram_Capacity = @Max_Ram_Capacity,PowerDraw = @Powerdraw,Quantity_Available = @Quantity_Available,Price = @Price
                          where Id = @Id;";
            Motherboard mb = (Motherboard)component;

            _databaseComunication.Get<Motherboard>(query, GetDict(mb));
        }
        public Dictionary<string, dynamic> GetDict(Motherboard mb)
        {
            return new Dictionary<string, dynamic>{

                { "@Id"  , mb.Id},
                { "@Model"  , mb.Model },
                { "@Brand"  , mb.Brand },
                { "@Socket"  , mb.Socket },
                { "@Ram_Slots"  , mb.Ram_Slots },
                { "@Supported_CPU_Models"  , mb.Supported_CPU_Models },
                { "@RamGenSupport"  , mb.RamGenSupport },
                { "@Max_Ram_Capacity"  , mb.Max_Ram_Capacity },
                { "@Powerdraw"  , mb.PowerDraw },
                { "@Photo_id"  , mb.Photo },
                { "@Quantity_Available"  , mb.Quantity_Available },
                { "@Price"  , mb.Price }
            };
        }
    }
}
