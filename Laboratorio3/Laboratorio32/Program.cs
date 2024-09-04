internal class Program
{
    private static void Main(string[] args)
    {
        double radio, area;
        Console.WriteLine("Ingrese el radio del circulo: ");
        radio = Convert.ToInt32(Console.ReadLine());
        CalculosMatematicos circulo = new CalculosMatematicos();
        area = circulo.calculoArea(radio);
        Console.WriteLine("El area del circulo es: " + area);
    }
}