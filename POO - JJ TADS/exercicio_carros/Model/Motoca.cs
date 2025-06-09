public class Motoca : Veiculo
{
    string _placa = "";
    public Motoca(int ano, string modelo, bool locado, string placa) : base(ano modelo, locado, placa)
    {
        _placa = placa;
    }
}