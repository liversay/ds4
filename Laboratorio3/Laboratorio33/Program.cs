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

        double perimetro, lado1, lado2;
        Console.WriteLine("Ingrese la medida del primer par de lados: ");
        lado1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese la medida del segundo par de lados: ");
        lado2 = Convert.ToInt32(Console.ReadLine());

        perimetro = lado1 + lado1 + lado2 + lado2;
        Console.WriteLine("El perimetro del rectangulo es: " + perimetro);
    }
}