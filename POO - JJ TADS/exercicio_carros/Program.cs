using System; 


class Program
{
    static void Main(string[] args)
    {
        Carro gol = new Carro(2024, "sdfsf", "g4");
        gol.ExibirPlaca();
        gol.ExibirAno();
        gol.ExibirModelo();  

        Carro Jetta = new Carro(2012, "ppa5t98", "turbo");
        Jetta.ExibirPlaca();
        Jetta.ExibirAno();
        Jetta.ExibirModelo(); 
    }
}