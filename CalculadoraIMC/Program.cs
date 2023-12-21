using Microsoft.VisualBasic;
using System;
using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;


float resultadoIMC(float kg, float altura)
{

    float alturaAoQuadrado = altura * altura;


    return kg / alturaAoQuadrado;
}
    Console.WriteLine("Digite seu peso: ");
float kg = float.Parse(Console.ReadLine());
Console.WriteLine("Digite sua altura (em metros): ");
float altura= float.Parse(Console.ReadLine());
if (altura == 0)
{
    Console.WriteLine("A altura deve ser maior que zero");
}

else 
{
    float imc = resultadoIMC(kg, altura);
    string categoria = ClassificarIMC(imc);

    Console.WriteLine($"Seu IMC: {imc:F2} - Categoria: {categoria}");
}

string ClassificarIMC(float imc) 
{ 

    float magrezaLimite = 18.5f;
    float normalLimte = 24.9f;
    float sobrepesoLimite = 29.9f;
    float obesidadeLimite = 30.0f;

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