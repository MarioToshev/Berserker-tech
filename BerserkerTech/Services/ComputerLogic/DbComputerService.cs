using BerserkerTech.Models.DTOs;
using BerserkerTech.Models.DTOs.Components;
using BerserkerTech.Services.ComputerLogic.Interfaces;

namespace BerserkerTech.Services.ComputerLogic
{
    public class DbComputerService
    {
        //updating a computer in the database
        private readonly DatabaseComunication _databaseComunication;
        public DbComputerService()
        {
            _databaseComunication = new DatabaseComunication();
        }

        public void GetComputer(string Id)
        {
            throw new NotImplementedException();
        }

        public void UpdateComputer(string Id, ComputerComponent component)
        {
            throw new NotImplementedException();
        }
        public void AddComputer(Computer computer)
        {
            _databaseComunication.InsertData(
            @"Insert into computers(Id, CPU_Id, Motherboard_Id, GPU_Id, RAM_Id, RAM_Quantity, PSU_Id, Storage_Id)
             values(@Id, @CPU_Id, @Motherboard_Id, @GPU_Id, @RAM_Id, @RAM_Quantity, @PSU_Id, @Storage_Id);",
            new Dictionary<string, dynamic>
            {
               { "@Id", computer.Id },
               { "@CPU_Id", computer.CPU.Id },
               { "@Motherboard_Id", computer.Motherboard.Id },
               { "@GPU_Id", computer.GPU.Id },
               { "@RAM_Id", computer.RAM.Id },
               { "@RAM_Quantity", computer.RamQuantity },
               { "@PSU_Id", computer.PSU.Id },
               { "@Storage_Id", computer.Storage.Id }
            });

        }
    }
}
