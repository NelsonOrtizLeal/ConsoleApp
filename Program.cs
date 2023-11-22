using Humanizer;

Console.WriteLine("¿Cual es tu nombre?");
var name = Console.ReadLine();

Console.WriteLine("¿Cual es su cargo?");
var job = Console.ReadLine();

Console.WriteLine("¿Cuantos años tienes?");
var input = Console.ReadLine();
int age;

if (!Int32.TryParse(input, out age))
{
    age = 18;
}

if (age > 0)
{
    Console.WriteLine($"Hola, mi nombre es {name}, mi cargo es {job} y tengo {age.ToWords(new System.Globalization.CultureInfo("es"))} años");
}else{
    Console.WriteLine("La edad no puede ser negativa o 0");
}
