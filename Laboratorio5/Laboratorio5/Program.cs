internal class Program
{
    private static void Main(string[] args)
    {
        //Declaracion erronea
        int valores[];
        //Declaracion valida
        int[] valores;

        int[] valores; //valores sin inicializar
        valores = new int[100]; //100 elementos
        valores = new int[20]; //ahora contiene 20 elementos

        //Arreglos unidimensionales o de dimensión simple
        int[] valores1; //sin inicializar
        int[] avlores2 = new int[50];

        //Arreglos multidimensionales
        int[,] valores1;    //sin inicializar
        int[,] valores2 = new int[3, 7];
        int[,,] valores3 = new int[3, 4, 2]; //Arreglo de tres dimensiones

        //Arreglo de arreglos
        int[][] matriz;     //sin inicilizar
        //Los arreglos de arreglos se inicializan de manera diferente
        int[][] matriz = new int[3][];
        for (int i = 0; i < matriz.Length; i++)
        {
            matriz[i] = new int[4];
        }

        PruebaVector1 pv = new PruebaVector1();
        pv.Cargar();
        pv.Imprimir();

        matriz ma = new matriz();
        ma.Ingresar();
        ma.Imprimir();

        //for each
        int[] numeros;
        numeros = {1, 2, 3, 4, 5};
        foreach (int numero in numeros)
        {
            Console.WriteLine(numeros);
        }
    }
}