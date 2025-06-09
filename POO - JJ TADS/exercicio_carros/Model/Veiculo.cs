public abstract class Veiculo : IVeiculo
{
   int _ano;
   string _modelo;
   bool _locado = false;

   public event Action<int, string>? VeiculoAlugado;

   public Veiculo(int ano, string modelo, bool locado)
   {
      _modelo = modelo;

      _ano = ano;
      _locado = locado;
   }

    

   public virtual void ExibirPlaca()
   {
      Console.WriteLine($"A placa do veiculo é: {_placa}");
   }

   public virtual void ExibirAno()
   {
      Console.WriteLine($"O ano do carro é: {_ano}");
   }

   public virtual void ExibirModelo()
   {
      Console.WriteLine($"O modelo do carro é: {_modelo}\n");
   }

   protected virtual void OnVeiculoAlugado()
   {
      VeiculoAlugado?.Invoke(this.GetType)
   }

}