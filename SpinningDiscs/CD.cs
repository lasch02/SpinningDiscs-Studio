using System;

namespace SpinningDiscs
{
    public class CD : BaseDisc, IOpticalDisc 
    {
        // TODO: Implement your custom interface.
        public CD(string name, double capacity, string discType double maxReadSpeed, double maxWriteSpeed) : base(name, capacity, discType, maxReadSpeed, maxWriteSpeed) { }

        public void SpinDisc()
        {
            Console.WriteLine("A CD spins at about 500 RPM at teh inside edge and 200 RRM at the outside edge");
        }

        public void ReadData() 
        {
            foreach (string item in Content)
            {
                Console.WriteLine("___________");
                Console.WriteLine(item);
                Console.WriteLine("___________\n");
            }
        }

    }
}

