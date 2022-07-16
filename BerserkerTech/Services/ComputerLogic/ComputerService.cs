using BerserkerTech.Models.DTOs;
using BerserkerTech.Models.DTOs.Components;
using BerserkerTech.Models.ViewModels.Request.Computer;
using BerserkerTech.Services.ComputerLogic.Interfaces;

namespace BerserkerTech.Services.ComputerLogic
{
    public class ComputerService : IComputerService
    {
        //Server side Update of a computer
        private static Computer _computer;
        private readonly DatabaseComunication _databaseComunication;
        private readonly DbComputerService dbComputerService;
        public ComputerService()
        {

            _databaseComunication = new DatabaseComunication();
            dbComputerService = new DbComputerService();
        }

        public void SetComputer(Computer computer)
        {
            _computer = computer;
        }
        public Computer GetComputer()
        {
            if (_computer == null)
                _computer = new Computer();

            return _computer;
        }
        public ComputerViewModel GetComputerInfoFromBase(string id)
        {
            string query = @"select pc.Id, concat(cp.Brand, ' ' ,cp.Model) as CpuInfo,
                           concat(gp.Brand, ' ', gp.Model) as GpuInfo ,
                           concat(mb.Brand, ' ', mb.Model) as MotherboardInfo ,
                           concat(ps.Brand, ' ', ps.Model) as PsuInfo,
                           concat(rm.Brand, ' ', rm.Model) as RamInfo,
                           pc.RAM_Quantity as RamQuantity,
                           concat(sp.Brand, ' ', sp.Model) as StorageInfo
                           from computers pc
                           inner join cpus cp on pc.CPU_Id = cp.Id
                           inner join gpus gp on pc.GPU_Id = gp.Id
                           inner join motherboards mb on pc.Motherboard_ID = mb.Id
                           inner join ram rm on pc.RAM_ID = rm.Id
                           inner join storage_parts sp on pc.Storage_ID = sp.Id
                           inner join psus ps on pc.PSU_ID = ps.Id
                           Where pc.Id = @Id; ";

            return _databaseComunication.Get<ComputerViewModel>(query, new Dictionary<string, dynamic>
                {
                  {"@Id", id}
                })[0];

        }
        public string SaveComputer()
        {
            if (!ComputerContainsEmptyPlaces())
            {

                string message = TryBuildComputer();
                if (message == "")
                {
                    dbComputerService.AddComputer(_computer);
                    return "";
                }
                else return message;
            }
            else
            return "Add all the parts first";

        }

        private bool ComputerContainsEmptyPlaces()
        {
            if (_computer.CPU.Model == null ||
                _computer.Motherboard.Model == null ||
                _computer.GPU.Model == null ||
                _computer.PSU.Model == null ||
                _computer.RAM.Model == null ||
                _computer.Storage.Model == null)
            {
                return true;
            }
            else
                return false;
        }

        public string TryBuildComputer()
        {
            try
            {
                if (CheckCpuMotherboardCompatability(_computer) &&
               CheckIfPowerIsEnough(_computer) &&
               CheckRamMotherboardCompatability(_computer))
                    return "";
                else return "";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }

        public void UpdateComputer(ComputerComponent component)
        {
            GetComputer();
            var comp = typeof(Computer);

            foreach (var property in comp.GetProperties())
            {
                var type = property.PropertyType;

                if (type == component.GetType())
                {
                    property.SetValue(_computer, component, null);
                    break;
                }
            }
        }
        private bool CheckCpuMotherboardCompatability(Computer computer)
        {
            if (computer.CPU.Socket == computer.Motherboard.Socket &&
           computer.Motherboard.Supported_CPU_Models.Split(' ', ',').Contains(computer.CPU.Generation))
                return true;
            else
            {
                throw new Exception("Cpu and motherboard are not compadable");
            }
        }

        private bool CheckIfPowerIsEnough(Computer computer)
        {
            int totalConsumption = computer.CPU.PowerDraw + computer.GPU.PowerDraw + computer.RAM.PowerDraw +
                computer.Motherboard.PowerDraw + computer.Storage.PowerDraw;

            if (computer.PSU.Max_power > totalConsumption)
                return true;
            else
            {
                throw new Exception("Power is not enough");
            }
        }

        private bool CheckRamMotherboardCompatability(Computer computer)
        {
            if (computer.RamQuantity <= computer.Motherboard.Ram_Slots && computer.RAM.Ddr_Gen.ToLower() == computer.Motherboard.RamGenSupport.ToLower())
                return true;
            else
            {
                throw new Exception("Ram and motherboard are not compadable");
            }
        }
        //ToIMPLEMENT
        //public string IsComplete()
        //{
        //    return "";
        //}

        public double GetTotalPrice()
        {
            return (_computer.CPU.Price + _computer.GPU.Price + (_computer.RAM.Price * _computer.RamQuantity) + _computer.Motherboard.Price +
                _computer.PSU.Price + _computer.Storage.Price);
        }
        public void ClearComputer()
        {
            _computer = null;
        }
    }
}
