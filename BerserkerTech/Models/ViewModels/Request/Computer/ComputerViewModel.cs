namespace BerserkerTech.Models.ViewModels.Request.Computer
{
    public class ComputerViewModel
    {
        public string Id { get; set; }
        public string CpuInfo { get; set; }
        public string GpuInfo { get; set; }
        public string MotherboardInfo { get; set; }
        public string RamInfo { get; set; }
        public int RamQuantity { get; set; }
        public string StorageInfo { get; set; }
        public string PsuInfo { get; set; }
    }
}
