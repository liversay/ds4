internal class Program
{
    private static void Main(string[] args)
    {
        double val1, val2;
        Console.WriteLine("Ingrese el primer valor: ");
        val1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo valor: ");
        val2 = Convert.ToInt32(Console.ReadLine());
        CalculosMatematicos obj = new CalculosMatematicos();
        obj.Calcular(val1, val2);

    }

    public class CalculosMatematicos
    {
        public double Calcular(double a, double b)
        {
            double resultado;
            resultado = (a + b) * (a - b);
            return resultado;  
        }
    }
}