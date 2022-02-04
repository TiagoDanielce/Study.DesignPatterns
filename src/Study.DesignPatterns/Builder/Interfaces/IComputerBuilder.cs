namespace Study.DesignPatterns.Builder
{
    public interface IComputerBuilder
    {
        ComputerBuilder WithCpuManufacturer(ECpuManufacturer cpuManufacturer);
        ComputerBuilder WithCpuModel(string cpuModel);
        ComputerBuilder WithMotherBoardCompatibility(EMotherBoardCompatibility motherBoardCompatibility);
        ComputerBuilder WithMotherBoardModel(string motherBoardModel);
        ComputerBuilder WithRamMemoryManufacturer(ERamMemoryManufacturer ramMemoryManufacturer);
        ComputerBuilder WithRamMemorySize(int ramMemorySize);
        Computer Build();
    }
}
