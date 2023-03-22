// TODO: Declare and initialize a CD and a DVD object.
using SpinningDiscs;

CD cd = new CD("CD example", 700, "CD-R", 350);
DVD dvd = new DVD("DVD example", 4700, "DVD-R", 1450);

cd.SpinDisc();
dvd.SpinDisc();

cd.ReadData();
dvd.ReadDate();

Console.WriteLine(cd.WriteData(275));
Console.WriteLine(dvd.WriteData(8000));

Console.WriteLine(DiskInfo());
Console.WriteLine(DiskInfo());

// TODO: Call each CD and DVD method to verify that they work as expected.