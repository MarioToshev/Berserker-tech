using BerserkerTech.Models.DTOs;
using BerserkerTech.Models.DTOs.Components;
using BerserkerTech.Services.ComponentLogic.Interfaces;

namespace BerserkerTech.Services.ComponentLogic
{
    public class RamService : IComponentService
    {
        private DatabaseComunication _databaseComunication;
        public RamService()
        {
            _databaseComunication = new DatabaseComunication();
        }
        public void Add(ComputerComponent component)
        {
           
            var query = @"Insert into ram (Id,Model,  Brand, Capacity, Speed, Ddr_Gen, Photo_id, PowerDraw, Quantity_Available, Price)
                         values(@Id, @Model, @Brand, @Capacity, @Speed, @Ddr_Gen, @Photo_id, @Powerdraw, @Quantity_Available, @Price);";
            RAM ram = (RAM)component;

            _databaseComunication.InsertData(query, new Dictionary<string, dynamic>
            {
                { "@Id"  , ram.Id},
                { "@Brand"  , ram.Brand},
                { "@Model"  , ram.Model},
                { "@Capacity"  , ram.Capacity},
                { "@Speed"  , ram.Speed},
                { "@Ddr_Gen"  , ram.Ddr_Gen},
                { "@Photo_id"  , ram.Photo},
                { "@Powerdraw"  , ram.PowerDraw},
                { "@Quantity_Available"  , ram.Quantity_Available},
                { "@Price"  , ram.Price}
            });
        }

        public void Delete(string Id)
        {
            var query = @"delete from ram where Id = @Id;";
            _databaseComunication.InsertData(query, new Dictionary<string, dynamic>
            {
                {"@Id", Id}
            });
        }

        public List<RAM> GetAll()
        {
            var query = @"Select * from ram";
            return _databaseComunication.Get<RAM>(query, new Dictionary<string, dynamic> { });
        }
        public List<RAM> GetAllAvailable()
        {
            var query = @"Select * from ram
                          where Quantity_Available >= 1";
            return _databaseComunication.Get<RAM>(query, new Dictionary<string, dynamic> { });
        }
        public RAM GetOne(string Id)
        {
            var query = @"Select * from ram where Id = @Id";
            try
            {
                return _databaseComunication.Get<RAM>(query, new Dictionary<string, dynamic> { { "@Id", Id } })[0];
            }
            catch (Exception)
            {

               return null;
            }
           
        }
        public ComputerComponent GetOneByModelAndBrand(string Brand, string Model)
        {
            var query = @"Select * from ram where Model = @Model and Brand = @Brand";
            try
            {
                RAM result = new RAM();
                result = _databaseComunication.Get<RAM>(query, new Dictionary<string, dynamic>
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
            var query = @"Update ram set Brand =@Brand ,Model = @Model,Capacity = @Capacity,Speed = @Speed,Ddr_Gen = @Ddr_Gen,PowerDraw = @Powerdraw,Quantity_Available = @Quantity_Available,Price = @Price
                          where Id = @Id;";
            RAM ram = (RAM)component;

            _databaseComunication.Get<RAM>(query, new Dictionary<string, dynamic> {
                { "@Id"  , ram.Id},
                { "Brand"  , ram.Brand},
                { "Model"  , ram.Model},
                { "Capacity"  , ram.Capacity},
                { "Speed"  , ram.Speed},
                { "Ddr_Gen"  , ram.Ddr_Gen},
                { "Photo_id"  , ram.Photo},
                { "Powerdraw"  , ram.PowerDraw},
                { "Quantity_Available"  , ram.Quantity_Available},
                { "Price"  , ram.Price}
            });
        }
    }
}
