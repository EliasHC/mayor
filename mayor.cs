//Crear un programa que lea dos números y que escriba el mayor de los dos.
namespace mayor
{
    public class mayor
    {
        static void Main(string[] args)
        {
            int a, b, mayor;
            Console.Write("Ingresa el valor de a: ");
            a = int.Parse(Console.ReadLine());
            
            Console.Write("Ingresa el valor de b: ");
            b = int.Parse(Console.ReadLine());
            if(a>b)
                mayor=a;
            else
                mayor=b;
        }

        public void Imprimir ()
        {
            Console.WriteLine("El numero mayor es: " + mayor);
        }
    }
}

