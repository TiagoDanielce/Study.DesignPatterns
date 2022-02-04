﻿namespace Study.DesignPatterns.Prototype
{
    public class Customer : ICustomer
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Document { get; set; }

        public ICustomer Clone()
        {
            return MemberwiseClone() as ICustomer;
        }
    }
}
