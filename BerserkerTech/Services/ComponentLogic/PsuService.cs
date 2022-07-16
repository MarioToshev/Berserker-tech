using BerserkerTech.Models.DTOs;
using BerserkerTech.Models.DTOs.Components;
using BerserkerTech.Services.ComponentLogic.Interfaces;

namespace BerserkerTech.Services.ComponentLogic
{
    public class PsuService:IComponentService
    {
        private DatabaseComunication _databaseComunication;

        public PsuService()
        {
            _databaseComunication = new DatabaseComunication();
        }

        public void Add(ComputerComponent component)
        {//Id, Brand, Certificate, Max_power, Photo_id, Quantity_Avalable, Price
            var query = @"Insert into psus(Id, Brand, Model, Certificate, Max_power, Photo_id, Quantity_Available, Price)
                         values(@Id, @Brand, @Model, @Certificate, @Max_power,@Photo_id, @Quantity_Available, @Price);";
            PSU psu = (PSU)component;

            _databaseComunication.InsertData(query, GetDict(psu));
        }

        public void Delete(string Id)
        {
            var query = @"delete from psus where Id = @Id;";
            _databaseComunication.InsertData(query, new Dictionary<string, dynamic>
            {
                {"@Id", Id}
            });
        }

        public List<PSU> GetAll()
        {
            var query = @"Select * from psus";
            return _databaseComunication.Get<PSU>(query, new Dictionary<string, dynamic> { });
        }
        public List<PSU> GetAllAvailable()
        {
            var query = @"Select * from psus
                          where Quantity_Available >= 1";
            return _databaseComunication.Get<PSU>(query, new Dictionary<string, dynamic> { });
        }

        public PSU GetOne(string Id)
        {
            var query = @"Select * from psus where Id = @Id";
            try
            {
                return _databaseComunication.Get<PSU>(query, new Dictionary<string, dynamic> { { "@Id", Id } })[0];
            }
            catch (Exception)
            {
                return null;
            }
        }
        public ComputerComponent GetOneByModelAndBrand(string Brand, string Model)
        {
            var query = @"Select * from psus where Model = @Model and Brand = @Brand";
            try
            {
                PSU result = new PSU();
                result = _databaseComunication.Get<PSU>(query, new Dictionary<string, dynamic>
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
            var query = @"Update psus set Brand = @Brand,Model = @Model, Certificate = @Certificate, Max_power = @Max_power, Photo_id=@Photo_id, Quantity_Available =@Quantity_Available, Price = @Price
                          where Id = @Id;";
            PSU psu = (PSU)component;

            _databaseComunication.Get<PSU>(query, GetDict(psu));
        }
     
        public Dictionary<string, dynamic> GetDict(PSU psu)
        {
            return new Dictionary<string, dynamic>{

                { "@Id"  , psu.Id},
                { "@Brand"  , psu.Brand },
                { "@Model"  , psu.Model },
                { "@Certificate"  , psu.Brand },
                { "@Max_power"  , psu.Max_power },
                { "@Photo_id"  , psu.Photo },
                { "@Quantity_Available"  , psu.Quantity_Available },
                { "@Price"  , psu.Price }
            };
        }
    }
}
