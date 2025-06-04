public abstract class Veiculo : IVeiculo
{
   int _ano;
   string _placa;
   string _modelo;
   public Veiculo(int ano, string placa, string modelo)
   {
      _modelo = modelo;
      _placa = placa;
      _ano = ano; 
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
}