using calculatorTp;
internal class Program
{
    private static void Main(string[] args)
    {
        double numero;
        int opc;
        string opcString = " ";
        Calculadora Resultado = new Calculadora();
        int parar;
        do
        {
            Console.WriteLine("\t=====  CASSIO (fx-95) =====\n");
            Console.WriteLine("\t(0) SUMAR\n \t(1) RESTA\n \t(2) MULTIPLICACION\n \t(3) DIVISION\n \t(3) LIMPIAR\n \t\t\t by Juliancillo\t");
            opcString = Console.ReadLine();
            int.TryParse(opcString, out opc);
            Console.WriteLine("Resultado de momento = "+ Resultado.Dato);
            Console.WriteLine("ingrese un numero para comenzar el acarreo\n");
            opcString = Console.ReadLine();
            double.TryParse(opcString, out numero);
            switch (opc)
            {
                case 0:
                    Resultado.Sumar(numero);
                break;
                case 1:
                    Resultado.Restar(numero);
                    break;
                case 2:
                    Resultado.Multiplicar(numero);
                    break;
                case 3:
                    Resultado.Dividir(numero);
                    break;
                case 4:
                    Resultado.Limpiar();
                break;
            }
            Console.WriteLine("Resultado de momento = "+ Resultado.Dato);
            Console.WriteLine("¿ Desea Parar ? ok = 0 no = 1");
            opcString= Console.ReadLine();
            int.TryParse(opcString, out parar);

        } while (parar == 1);

    }
}