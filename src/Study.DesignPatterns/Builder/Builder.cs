using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    public enum ECpuManufacturer
    {
        AMD,
        Intel
    }

    public enum ERamMemoryManufacturer
    {
        Corsair,
        HyperX,
        Kingston,
        Crucial,
        GSkill
    }

    public enum EMotherBoardCompatibility
    {
        AMD,
        Intel
    }

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
