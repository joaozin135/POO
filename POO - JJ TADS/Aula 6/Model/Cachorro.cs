public class Cachorro : Animal
{
    public Cachorro(int idadeInicial) : base(idadeInicial)
    {

    }

    public override void ComemoraAniversario()
    {
        idade++;
        OnIdadeAlterada();
        Console.WriteLine("Cachorro Parabéns");
    }
}