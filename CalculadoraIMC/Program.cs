
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Start
{
    static void Main()
    {
        CalculoIMC();

        Console.WriteLine("Quer fazer o calculo novamente?");
    }

    private static void CalculoIMC()
    {
        IMC imc = Interface();

        if (imc.Altura == 0)
        {
            Console.WriteLine("A altura deve ser maior que zero");

            imc = Interface();
        }

        if (imc.Kg == 0)
        {
            Console.WriteLine("O peso deve ser maior que zero");

            imc = Interface();
        }

        double resultado = Resultado(imc);

        Console.WriteLine($"Seu IMC: {resultado:F2} - Categoria: {Classificar(resultado)}");
    }

    private static IMC Interface()
    {
        IMC imc = new IMC();

        Console.WriteLine("Digite seu peso: ");
        imc.Kg = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite sua altura (em metros): ");
        imc.Altura = double.Parse(Console.ReadLine());

        return imc;
    }

    private static double Resultado(IMC imc)
        => imc.Kg / Math.Pow(imc.Altura, 2);

    private static string Classificar(double imc)
    {
        double magrezaLimite = 18.5f;
        double normalLimte = 24.9f;
        double sobrepesoLimite = 29.9f;

        if (imc < magrezaLimite)
        {
            return "Magreza";
        }
        else if (imc <= normalLimte)
        {
            return "Normal";
        }
        else if (imc <= sobrepesoLimite)
        {
            return "Sobrepeso";
        }
        else
        {
            return "Obesidade";
        }
    }
}