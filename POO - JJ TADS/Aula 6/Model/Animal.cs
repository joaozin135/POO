public abstract class Animal : IAnimal
{
    protected int idade;
    public event Action<string, int>? IdadeAlterada;

    public Animal(int idadeInicial)
    {
        idade = idadeInicial;
    }

    public virtual void ExibirIdade()
    {
        Console.WriteLine($"Idade é: {idade}");
    }

    public abstract void ComemoraAniversario();

    protected void IncrementarIdade()
    {
        idade++;
        OnIdadeAlterada();
    }

    protected void OnIdadeAlterada()
    {
        IdadeAlterada?.Invoke(this.GetType().Name, idade);
    }

    protected virtual void EmitirSom()
    {
        Console.WriteLine("Emitiu o som");
    }

}
