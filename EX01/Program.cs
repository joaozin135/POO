using System.Globalization;

namespace EX01;

class Program
{
    static void Main(string[] args)
    {
        Car batMovel = new Car();

        batMovel.marca = "Volkswagem";
        batMovel.modelo = "Tiguan";
        batMovel.ano = 2023;

        batMovel.getMarca();
        batMovel.getModelo();
        batMovel.getAno();

    }
}
