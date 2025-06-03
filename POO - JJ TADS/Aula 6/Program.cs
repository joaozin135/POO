using System; // Adicione esta linha para System.Action e Console.WriteLine

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Teste");

        // Exemplo de uso após a correção:
        Gato meuGato = new Gato(2);
        meuGato.ExibirIdade();
        meuGato.ComemoraAniversario();
        meuGato.ExibirIdade();
    }
}