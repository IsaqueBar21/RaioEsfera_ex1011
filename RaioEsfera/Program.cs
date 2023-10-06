using System.Globalization;

double pi = 3.14159;
double R, volume;

Console.WriteLine("Insira abaixo o valor do Raio: ");
R = double.Parse(Console.ReadLine());

volume = (4 / 3.0) * pi * Math.Pow(R, 3);

Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));

