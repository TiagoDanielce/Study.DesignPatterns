namespace Study.DesignPatterns.Builder
{
    public class ComputerBuilder : IComputerBuilder
    {
        private Computer _computer = new Computer();

        public ComputerBuilder WithCpuManufacturer(ECpuManufacturer cpuManufacturer)
        {
            _computer.CpuManufacturer = cpuManufacturer;
            return this;
        }

        public ComputerBuilder WithCpuModel(string cpuModel)
        {
            _computer.CpuModel = cpuModel;
            return this;
        }

        public ComputerBuilder WithMotherBoardCompatibility(EMotherBoardCompatibility motherBoardCompatibility)
        {
            _computer.MotherBoardCompatibility = motherBoardCompatibility;
            return this;
        }

        public ComputerBuilder WithMotherBoardModel(string motherBoardModel)
        {
            _computer.MotherBoardModel = motherBoardModel;
            return this;
        }

        public ComputerBuilder WithRamMemoryManufacturer(ERamMemoryManufacturer ramMemoryManufacturer)
        {
            _computer.RamMemoryManufacturer = ramMemoryManufacturer;
            return this;
        }

        public ComputerBuilder WithRamMemorySize(int ramMemorySize)
        {
            _computer.RamMemorySize = ramMemorySize;
            return this;
        }

        public Computer Build()
        {
            return _computer;
        }
    }
}
