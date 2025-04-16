using Lab4_2_;

Console.WriteLine("Введiть марку автомобiля: ");
string brand = Console.ReadLine();
Console.WriteLine("Введiть модель автомобiля: ");
string model = Console.ReadLine();
Console.WriteLine("Введiть рiк випуску автомобiля: ");
int year = int.Parse(Console.ReadLine());
Console.WriteLine("Введiть обем двигуна: ");
double vengine = double.Parse(Console.ReadLine());
Console.WriteLine("Введiть тип пального: ");
string typefuel = Console.ReadLine();
Console.WriteLine("Введiть пробiг: ");
int probig = int.Parse(Console.ReadLine());
Console.WriteLine("Введiть середню витрату пального л/100км: ");
double serednyavitratafuel = double.Parse(Console.ReadLine());
Console.WriteLine("Введiть цiну автомобiля: ");
double price = double.Parse(Console.ReadLine());
Console.WriteLine("Введiть цiну пального за лiтр: ");
double fuelPrice = double.Parse(Console.ReadLine());

Car myCar = new Car();

myCar.Brand = brand;
myCar.Model = model;
myCar.Year = year;
myCar.VEngine = vengine;
myCar.TypeFuel = typefuel;
myCar.Probig = probig;
myCar.SerednyaVitrataFuel = serednyavitratafuel;
myCar.Price = price;

double priceper100km = myCar.GetFuelPricePer100km(fuelPrice);

Console.WriteLine();
Console.WriteLine("Iнформацiя про автомобiль: ");
Console.WriteLine("Марка: " + myCar.Brand);
Console.WriteLine("Модель: " + myCar.Model);
Console.WriteLine("Рiк випуску: " + myCar.Year);
Console.WriteLine("Обем двигуна: " + myCar.VEngine);
Console.WriteLine("Тип пального: " + myCar.TypeFuel);
Console.WriteLine("Пробiг: " + myCar.Probig);
Console.WriteLine("Середня витрата пального л/100км:" + myCar.SerednyaVitrataFuel);
Console.WriteLine("Вартiсть автомобiля: " + myCar.Price);
Console.WriteLine("Вартiсть пального на 100 км: " + priceper100km.ToString("0.00"));


