namespace Aula19
{
    public class Ingresso
    {
       public float Valor { get; set; }
        public void ImprimirValor(){
            System.Console.WriteLine($"O valor comum é igual a R$ {Valor}");
        } 
    }
}