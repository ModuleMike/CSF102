double temp, conNumber;
string unit, conUnit;

Console.WriteLine("Welcome to Temperature Conversion!");
Console.WriteLine("==================================");
Console.WriteLine("Available units are (C)elsius, (F)ahrenheit, (K)elvin.\n");


Console.Write("Enter Temperature: ");
temp = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter Unit: ");
unit = Console.ReadLine().ToUpper();

Console.Write("Enter Conversion Unit: ");
conUnit = Console.ReadLine().ToUpper();

Console.WriteLine();

if (unit == conUnit)
{
    Console.WriteLine("You are trying to convert to the same unit! No Conversion needs to be done!");
    conNumber = temp;
}
else if ( (unit != "C" && unit != "K" && unit != "F") || (conUnit != "C" && conUnit != "K" && conUnit != "F"))
{
    Console.WriteLine("You have entered an invalid unit!!");
}
else
{
    if (unit == "C")
    {
        if (conUnit == "K")
        {
            conNumber = Math.Round(temp + 273.15, 2);
        }
        else 
        {
            conNumber = Math.Round((temp) * 9 / 5 + 32, 2);
        }
    }
    else if (unit == "K")
    {
        if (conUnit == "C")
        {
            conNumber = Math.Round(temp - 273.15, 2);
        }
        else 
        {
            conNumber = Math.Round((temp - 273.15) * 5 / 9 + 32, 2);
        }
    }
    else
    {
        if (conUnit == "C")
        {
            conNumber = Math.Round((temp - 32) * 5 / 9, 2);
        }
        else 
        {
            conNumber = Math.Round((temp - 32) * 5 / 9 + 273.15, 2);
        }
    }
    Console.WriteLine($"A temperature of {temp}{unit} is {conNumber}{conUnit}.");
}