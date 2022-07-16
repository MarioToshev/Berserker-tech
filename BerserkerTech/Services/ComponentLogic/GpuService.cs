using BerserkerTech.Models.DTOs;
using BerserkerTech.Models.DTOs.Components;
using BerserkerTech.Services.ComponentLogic.Interfaces;
using System.ComponentModel;

namespace BerserkerTech.Services.ComponentLogic
{
    public class GpuService : IComponentService
    {
        private DatabaseComunication _databaseComunication;

        public GpuService()
        {
            _databaseComunication = new DatabaseComunication();
        }
        public void Add(ComputerComponent component)
        {
            var query = @"Insert into gpus(Id, Brand, Model, Manufacturer, Core_Speed,Core_Count, Memory_Speed, Memory_Capacity, Photo_id, PowerDraw, Quantity_Available, Price)
                         values(@Id, @Brand, @Model, @Manufacturer, @Core_Speed, @Memory_Speed, @Core_Count,@Memory_Capacity, @Photo_id, @Powerdraw, @Quantity_Available, @Price);";
            GPU gpu = (GPU)component;

            _databaseComunication.InsertData(query, GetDict(gpu));
        }

        public void Delete(string Id)
        {
            var query = @"delete from gpus where Id = @Id;";
            _databaseComunication.InsertData(query, new Dictionary<string, dynamic>
            {
                {"@Id", Id}
            });
        }

        public List<GPU> GetAll()
        {
            var query = @"Select * from gpus";
            return _databaseComunication.Get<GPU>(query, new Dictionary<string, dynamic> { });
        }
        public List<GPU> GetAllAvailable()
        {
            var query = @"Select * from gpus
                          where Quantity_Available >= 1";
            return _databaseComunication.Get<GPU>(query, new Dictionary<string, dynamic> { });
        }

        public GPU GetOne(string Id)
        {
            var query = @"Select * from gpus where Id = @Id";
            try
            {
                return _databaseComunication.Get<GPU>(query, new Dictionary<string, dynamic> { { "@Id", Id } })[0];
            }
            catch (Exception)
            {

                return null;
            }
           
        }
        public ComputerComponent GetOneByModelAndBrand(string Brand, string Model)
        {
            var query = @"Select * from gpus where Model = @Model and Brand = @Brand";
            try
            {
                GPU result = new GPU();
                result = _databaseComunication.Get<GPU>(query, new Dictionary<string, dynamic>
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
            var query = @"Update gpus set Brand =@Brand ,Model = @Model,Manufacturer = @Manufacturer,Core_Speed = @Core_Speed,Memory_Speed = @Memory_Speed,Memory_Capacity = @Memory_Capacity,PowerDraw = @Powerdraw,Quantity_Available = @Quantity_Available,Price = @Price
                          where Id = @Id;";
            GPU gpu = (GPU)component; 

            _databaseComunication.Get<GPU>(query, GetDict(gpu));
        }
        public Dictionary<string, dynamic> GetDict(GPU gpu)
        {
            return new Dictionary<string, dynamic>{

                { "@Id"  , gpu.Id},
                { "Brand"  , gpu.Brand},
                { "Model"  , gpu.Model},
                { "Manufacturer"  , gpu.Manufacturer},
                { "Core_Speed"  , gpu.Core_Speed},
                { "Core_Count"  , gpu.Core_Count},
                { "Memory_Speed"  , gpu.Memory_Speed},
                { "Memory_Capacity"  , gpu.Memory_Capacity},
                { "Photo_id"  , gpu.Photo},
                { "Powerdraw"  , gpu.PowerDraw},
                { "Quantity_Available"  , gpu.Quantity_Available},
                { "Price"  , gpu.Price}
            };
        }
    }
}
