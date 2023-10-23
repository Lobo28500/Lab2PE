using System;

class Program
{
    static void Main(string[] args)
    {
        char opcion;
        do
        {
            Console.WriteLine("Menú de opciones:");
            Console.WriteLine("1. Calcular salario bruto");
            Console.WriteLine("2. Calcular descuentos individuales (ISSS, ISR, AFP)");
            Console.WriteLine("3. Calcular salario neto");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción digitando un numero de opcion (1,2,3,4): ");
            opcion = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (opcion)
            {
                case '1':
                    CalcularSalarioBruto();
                    break;
                case '2':
                    CalcularDescuentosIndividuales();
                    break;
                case '3':
                    CalcularSalarioNeto();
                    break;
                case '4':
                    Console.WriteLine("¡Hasta luego!");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, elija una opción válida.");
                    break;
            }
        } while (opcion != '4');
    }

    static double CalcularSalarioBruto()
    {
        Console.Write("Ingrese las horas trabajadas: ");
        double horasTrabajadas = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el precio por hora: ");
        double precioPorHora = double.Parse(Console.ReadLine());

        double salarioBruto = horasTrabajadas * precioPorHora;
        Console.WriteLine($"Salario Bruto: ${salarioBruto}");
        return salarioBruto;
    }

    static double CalcularDescuentosIndividuales()
    {
        double salarioBruto = CalcularSalarioBruto();

        double isss = salarioBruto * 0.03;
        double isr = salarioBruto > 500 ? salarioBruto * 0.1 : 0;
        double afp = salarioBruto * 0.072;

        Console.WriteLine($"Descuento ISSS: ${isss}");
        Console.WriteLine($"Descuento ISR: ${isr}");
        Console.WriteLine($"Descuento AFP: ${afp}");

        return isss + isr + afp;
    }

    static double CalcularSalarioNeto()
    {
        double salarioBruto = CalcularSalarioBruto();
        double descuentos = CalcularDescuentosIndividuales();

        double salarioNeto = salarioBruto - descuentos;
        Console.WriteLine($"Salario Neto: ${salarioNeto}");
        return salarioNeto;
    }
}