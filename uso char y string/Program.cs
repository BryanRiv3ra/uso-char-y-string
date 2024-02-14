Console.WriteLine("Ingrese un texto:");
string cadena = Console.ReadLine();
string cadenaEnMayusculas = cadena.ToUpper();
Console.WriteLine("La cadena en mayúsculas es:");
Console.WriteLine(cadenaEnMayusculas);

Console.WriteLine("Ingrese un texto:");
string cadena2 = Console.ReadLine();
string cadenaEnMayusculas2 = cadena2.ToLower();
Console.WriteLine("El texto en minusculas es:");
Console.WriteLine(cadenaEnMayusculas2);

Console.WriteLine("Ingrese una cadena de texto:");
string cadena3 = Console.ReadLine();
for (int i = cadena3.Length - 1; i >= 0; i--)
{
    Console.Write(cadena3[i]);
}

Console.WriteLine( "Ingrese una cadena de texto:");
string texto = Console.ReadLine();
Console.WriteLine("Ingrese la palabra que desea buscar:");
string palabra = Console.ReadLine();
if (texto.Contains(palabra))
{
    Console.WriteLine($"La palabra '{palabra}' fue encontrada en el texto.");
}
else
{
    Console.WriteLine($"La palabra '{palabra}' no fue encontrada en el texto.");
}

Console.WriteLine("Ingrese una cadena de texto:");
string texto2 = Console.ReadLine();
int contadorVocales = 0;
foreach (char caracter in texto2)
{
    if ("aeiouAEIOU".Contains(caracter))
    {
        contadorVocales++;
    }
}
Console.WriteLine($"El número de vocales en el texto es: {contadorVocales}");
    