// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    public static float LerNumero()
    {
        return Convert.ToSingle(Console.ReadLine());
    }
    public static void Escrever(string a)
    {
        Console.WriteLine(a);
    }
    public static string Imc(float m, float a)
    {
        float imc;
        imc = m/(a*a);

        if (imc > 40)
        {
            return "Obesidade III (mórbida)";
        }
        else if (imc > 35)
        {
            return "Obesidade II (severa)";
        }
        else if (imc > 30)
        {
            return "Obesidade I";
        }
        else if (imc > 25)
        {
            return "Acima do Peso";
        }
        else if (imc > 18.5)
        {
            return "Peso Normal";
        }
        else if (imc > 17)
        {
            return "Abaixo do Peso";
        }
        else
        {
            return "Muito a baixo do peso";
        }
    }
    static void Main(string[] args)
    {
        float peso, altura;

        Console.WriteLine("Insira o peso em kg: ");
        peso = LerNumero();
        Console.WriteLine("Insira a sua altura, em metros: ");
        altura = LerNumero();

        Escrever(Imc(peso, altura));
    }
}
