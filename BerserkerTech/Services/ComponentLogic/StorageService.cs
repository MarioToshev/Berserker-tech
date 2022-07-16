using BerserkerTech.Models.DTOs;
using BerserkerTech.Models.DTOs.Components;
using BerserkerTech.Models.DTOs.Components.Storage;
using BerserkerTech.Services.ComponentLogic.Interfaces;

namespace BerserkerTech.Services.ComponentLogic
{
    public class StorageService:IComponentService
    {
        private DatabaseComunication _databaseComunication;
        public StorageService()
        {
            _databaseComunication = new DatabaseComunication();
        }

        public void Add(ComputerComponent component)
        {
            var query = @"Insert into storage_parts(Id, Brand, Model, Type, Capacity, Speed, Photo_id, PowerDraw, Price, Quantity_Available)
                         values(@Id, @Brand, @Model, @Type, @Capacity, @Speed, @Photo_id, @Powerdraw, @Price, @Quantity_Available);";
            Storage storage = (Storage)component;

            _databaseComunication.InsertData(query, GetDict(storage));
        }

        public void Delete(string Id)
        {
            var query = @"delete from storage_parts where Id = @Id;";
            _databaseComunication.InsertData(query, new Dictionary<string, dynamic>
            {
                {"@Id", Id}
            });
        }

        public List<Storage> GetAll()
        {
            var query = @"Select * from storage_parts";
            return _databaseComunication.Get<Storage>(query, new Dictionary<string, dynamic> { });
        }
        public List<Storage> GetAllAvailable()
        {
            var query = @"Select * from storage_parts
                          where Quantity_Available >= 1";
            return _databaseComunication.Get<Storage>(query, new Dictionary<string, dynamic> { });
        }

        public Storage GetOne(string Id)
        {
            var query = @"Select * from storage_parts where Id = @Id";
            try
            {
                return _databaseComunication.Get<Storage>(query, new Dictionary<string, dynamic> { { "@Id", Id } })[0];
            }
            catch (Exception)
            {
                return null;
            }
        }
        public ComputerComponent GetOneByModelAndBrand(string Brand, string Model)
        {
            var query = @"Select * from storage_parts where Model = @Model and Brand = @Brand";
            try
            {
                Storage result = new Storage();
                result = _databaseComunication.Get<Storage>(query, new Dictionary<string, dynamic>
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
        //Id, Brand, Model, Type, Capacity, Speed, Photo_id, Powerdraw, Price, Quantity_Available
        public void Update(ComputerComponent component)
        {
            var query = @"Update storage_parts set Brand = @Brand, Model = @Model, Type = @Type, Capacity = @Capacity, Speed = @Speed, Photo_id = @Photo_id, PowerDraw = @Powerdraw, Price = @Price, Quantity_Available = @Quantity_Available
                          where Id = @Id;";
            Storage storage = (Storage)component;

            _databaseComunication.Get<Storage>(query, GetDict(storage));
        }
        //Id, Brand, Type, Capacity, Speed, Photo_id, Powerdraw, Price, Quantity_Available
        public Dictionary<string, dynamic> GetDict(Storage storage)
        {
            return new Dictionary<string, dynamic>{

                { "@Id"  , storage.Id},
                { "@Brand"  , storage.Brand },
                { "@Model"  , storage.Model },
                { "@Type"  , storage.Type },
                { "@Speed"  , storage.Speed },
                { "@Capacity"  , storage.Capacity },
                { "@Photo_id"  , storage.Photo },
                { "@Powerdraw"  , storage.PowerDraw },
                { "@Quantity_Available"  , storage.Quantity_Available },
                { "@Price"  , storage.Price }
            };
        }
    }
}
