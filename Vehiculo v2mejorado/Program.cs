using System;

namespace EjemploClaseVehiculo
{
    public class Vehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Anio { get; set; }

        public Vehiculo()
        {
            Console.Write("Ingrese la marca del vehículo: ");
            Marca = PedirCadenaSinNumeros();

            Console.Write("Ingrese el modelo del vehículo: ");
            Modelo = PedirCadenaSinNumeros();

            Console.Write("Ingrese el año del vehículo: ");
            bool anioValido = false;
            while (!anioValido)
            {
                if (int.TryParse(Console.ReadLine(), out int anio))
                {
                    Anio = anio;
                    anioValido = true;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero.");
                }
            }
        }

        private string PedirCadenaSinNumeros()
        {
            string entrada;
            bool entradaValida = false;
            while (!entradaValida)
            {
                entrada = Console.ReadLine();
                if (SoloContieneCaracteres(entrada))
                {
                    entradaValida = true;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, ingrese solo caracteres.");
                }
            }
            return entrada;
        }

        private bool SoloContieneCaracteres(string cadena)
        {
            foreach (char c in cadena)
            {
                if (!Char.IsLetter(c) && c != ' ')
                {
                    return false;
                }
            }
            return true;
        }
        // Modelo del vehículo
        public string Modelo { get; set; }

        // Año del vehículo
        public int Anio { get; set; }

        // Constructor vacío de la clase Vehiculo
        public Vehiculo()
        {
            // Solicitar al usuario que ingrese la información del vehículo
            Console.Write("Ingrese la marca del vehículo: ");
            Marca = Console.ReadLine();

            Console.Write("Ingrese el modelo del vehículo: ");
            Modelo = Console.ReadLine();

            Console.Write("Ingrese el año del vehículo: ");
            // Manejo de errores en caso de que la entrada no sea un número

        }

        // Constructor con parámetros de la clase Vehiculo
        public Vehiculo(string marca, string modelo, int anio)
        {
            Marca = marca;
            Modelo = modelo;
            Anio = anio;
        }

        // Método virtual para mostrar la información del vehículo
        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Año: {Anio}");
        }
    }

    // Definición de la clase Car
    public class Car : Vehiculo
    {
        // Propiedad adicional de la clase Car
        public int NumeroPuertas { get; set; }

        // Constructor de la clase Car
        public Car(string marca, string modelo, int anio, int numeroPuertas) : base(marca, modelo, anio)
        {
            NumeroPuertas = numeroPuertas;
        }

        // Método para mostrar la información del auto
        public void MostrarInformacionDelAuto()
        {
            Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Año: {Anio}, Número de puertas: {NumeroPuertas}");
        }
    }

    // Clase principal del programa
    class Program
    {
        // Punto de entrada del programa
        static void Main(string[] args)
        {
            // Crear un objeto de la clase Car
            Car miAuto = new Car("Toyota", "Corolla", 2020, 4);

            // Mostrar la información del auto
            miAuto.MostrarInformacionDelAuto();

            // Esperar a que el usuario presione una tecla para salir
            Console.ReadKey();
        }
    }
}