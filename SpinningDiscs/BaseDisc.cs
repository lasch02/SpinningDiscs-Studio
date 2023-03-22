using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;


namespace SpinningDiscs
{
    public abstract class BaseDisc
    {
        public string Name { get; set; }
        public double Capacity { get; }
        public double DataUsed { get; set; } = 0;
        public string DiscType { get; }
        public double MaxReadSpeed { get; }
        public double MaxWriteSpeed { get; }
        public List<string> Content { get; set; }

        public BaseDisc(string name, double capacity, string discType double maxReadSpeed, double maxWriteSpeed) 
        {
            Name = name;
            Capacity = capacity;
            DiscType = discType;
            MaxReadSpeed = maxReadSpeed;
            MaxWriteSpeed = maxWriteSpeed;
        }
        
        
        public abstract void WriteData(double data, List<string>data)
        {
            if (DataUsed + dataSize > Capacity)
            {
                Console.WriteLine("The disc does not have enough space to write all your data!");
                return;
            }
            else
            {
                Content = data;
                DataUsed += dataSize;
            }
        }

        public void GetProperties();
        {
            Console.WriteLine("--------------");
            Console.WriteLine("DISC INFORMATION");
            Console.WriteLine($"Disc Name: {Name}");
            Console.WriteLine($"Disc Type: {DiscType}");
            Console.WriteLine($"Storage Capacity: {Capacity} | Data Used: {DataUsed}");
            Console.WriteLine($"Max Read Speed: {MaxReadSpeed} | Max Write Speed: {MaxWriteSpeed}");
            Console.WriteLine("--------------");

        }

}

    public interface CheckCapacity(int data)
    {
        if (StorageCapacity < data)
        {
        return StorageCapacity;
        }
        else 
        {
        return data; 
        }
        

    }
}


