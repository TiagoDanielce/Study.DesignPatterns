namespace Study.DesignPatterns.Builder
{
    public class Computer
    {
        public string CpuModel { get; set; }
        public ECpuManufacturer CpuManufacturer { get; set; }
        public int RamMemorySize { get; set; }
        public ERamMemoryManufacturer RamMemoryManufacturer { get; set; }
        public string MotherBoardModel { get; set; }
        public EMotherBoardCompatibility MotherBoardCompatibility { get; set; }
    }
}
