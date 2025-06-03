public class Gato : Animal
{
    public Gato(int idadeInicial) : base(idadeInicial) { }

    public override void ComemoraAniversario()
    {

        Console.WriteLine("Gato comemora aniversário (implementação específica do Gato)");

        OnIdadeAlterada(); // Dispara o evento, usando a idade atual da base.
    }

    protected override void EmitirSom()
    {
        Console.WriteLine("Miauu");
    }
}