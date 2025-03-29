namespace Unidad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresá tu usuario");
            string usuario = Console.ReadLine();
            Console.WriteLine("Ingresá tu apellido");
            string apellido= Console.ReadLine();
            Console.WriteLine("Ingresá tu nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingresá tu número de celular");
            string celular= Console.ReadLine();
            Console.Write($"La persona {apellido}, {nombre} tiene el usuario: ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(usuario);
            Console.ResetColor(); // Volvemos al color normal
            Console.WriteLine($". Y su número de celular es: {celular}");
            Console.WriteLine("\n***** Variables definidas e inicializadas *****");
            bool miBool = true;
            byte miByte = 255;
            char miChar = 'C';
            decimal miDecimal = 1234.56m;
            double miDouble = 1234.56789;
            float miFloat = 1234.56f;
            int miInt = 1000;
            long miLong = 9999999999;
            short miShort = 32000;
            string miString = "Hola mundo";

            Console.WriteLine("bool: " + miBool);
            Console.WriteLine("byte: " + miByte);
            Console.WriteLine("char: " + miChar);
            Console.WriteLine("decimal: " + miDecimal);
            Console.WriteLine("double: " + miDouble);
            Console.WriteLine("float: " + miFloat);
            Console.WriteLine("int: " + miInt);
            Console.WriteLine("long: " + miLong);
            Console.WriteLine("short: " + miShort);
            Console.WriteLine("string: " + miString);

            Console.WriteLine("\n***** Valores mínimo y máximo de tipos numéricos *****");
            Console.WriteLine("byte: min = " + byte.MinValue + " | max = " + byte.MaxValue);
            Console.WriteLine("short: min = " + short.MinValue + " | max = " + short.MaxValue);
            Console.WriteLine("int: min = " + int.MinValue + " | max = " + int.MaxValue);
            Console.WriteLine("long: min = " + long.MinValue + " | max = " + long.MaxValue);
            Console.WriteLine("float: min = " + float.MinValue + " | max = " + float.MaxValue);
            Console.WriteLine("double: min = " + double.MinValue + " | max = " + double.MaxValue);
            Console.WriteLine("decimal: min = " + decimal.MinValue + " | max = " + decimal.MaxValue);


            //¿Las siguientes variables están bien inicializadas? ¿cual es el error de compilación? 
            //int numero = "string";
            //string cadena = 2;
            //bool booleano = "true";
            // No están bien inicializadas:
            // int numero debería recibir un entero --> int numero=3;
            // string cadena deberia recibir una cadena de caracteres --> string cadena="hola mundo!";
            // bool booleano deberia recibir true o false --> bool boolaeano=truw;
        }
    }
}