using BerserkerTech.Models.DTOs;
using BerserkerTech.Models.DTOs.Components;
using BerserkerTech.Services.ComponentLogic.Interfaces;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

namespace BerserkerTech.Services.ComponentLogic
{
    public class CpuService : IComponentService
    {
        private readonly IConfiguration _configuration;
        private DatabaseComunication _databaseComunication;

        public CpuService(IConfiguration configuration)
        {
            _configuration = configuration;
            _databaseComunication = new DatabaseComunication();
        }
        public CpuService()
        {
            _databaseComunication = new DatabaseComunication();
        }


        public void Add(ComputerComponent component)
        {
            var query = @"Insert into cpus(Id,Brand,Model,Speed,Cores,Photo_id,PowerDraw,Socket,Generation,Quantity_Available,Price)
                         values(@Id,@Brand,@Model,@Speed,@Cores,@Photo_id,@Powerdraw,@Socket,@Generation,@Quantity_Available,@Price);";
            CPU cpu = (CPU)component;

            _databaseComunication.InsertData(query, GetDict(cpu));
        }

        public void Delete(string Id)
        {
            try
            {
                var query = @"delete from Cpus where Id = @Id;";
                _databaseComunication.InsertData(query, new Dictionary<string, dynamic>
            {
                {"@Id", Id}
            });
            }
            catch (Exception)
            {
                throw new Exception("Invalid Cpu id");
            }
          
        }

        public List<CPU> GetAll()
        {
            var query = @"Select * from cpus";
            return _databaseComunication.Get<CPU>(query, new Dictionary<string, dynamic> { });
        }
        public List<CPU> GetAllAvailable()
        {
            var query = @"Select * from cpus
                          where Quantity_Available >= 1";
            return _databaseComunication.Get<CPU>(query, new Dictionary<string, dynamic> { });
        }
        public CPU GetOne(string Id)
        {
            var query = @"Select * from cpus where Id = @Id";
            try
            {
                CPU result = new CPU();
                result = _databaseComunication.Get<CPU>(query, new Dictionary<string, dynamic>
                {
                  {"@Id", Id}

                })[0];
                return result;
            }
            catch (Exception)
            {

                return null;
            }

        }
        public ComputerComponent GetOneByModelAndBrand(string Brand, string Model)
        {
            var query = @"Select * from cpus where Model = @Model and Brand = @Brand";
            try
            {
                CPU result = new CPU();
                result = _databaseComunication.Get<CPU>(query, new Dictionary<string, dynamic>
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
            var query = @"Update cpus set Brand =@Brand ,Model = @Model,Speed = @Speed,Cores = @Cores,Photo_id = @Photo_Id,PowerDraw = @Powerdraw ,Socket = @Socket,Generation = @Generation,Quantity_Available = @Quantity_Available,Price = @Price
                          where Id = @Id;";
            CPU cpu = (CPU)component;

            _databaseComunication.Get<CPU>(query, GetDict(cpu));
        }

        public Dictionary<string, dynamic> GetDict(CPU cpu)
        {
            return new Dictionary<string, dynamic>{

                { "@Id"  , cpu.Id},
                { "Brand"  , cpu.Brand},
                { "Model"  , cpu.Model},
                { "Speed"  , cpu.Speed},
                { "Cores"  , cpu.Cores},
                { "Photo_id"  , cpu.Photo},
                { "Powerdraw"  , cpu.PowerDraw},
                { "Socket"  , cpu.Socket},
                { "Generation"  , cpu.Generation},
                { "Quantity_Available"  , cpu.Quantity_Available},
                { "Price"  , cpu.Price}
            };
        }

    }
}
