namespace Aula19
{
    public class IngressoVIP : Ingresso
    {
        public float ValorAdicional { get; set; }

        public void MostrarValorVip(){
            float resultadoVip = ValorAdicional + Valor;

            System.Console.WriteLine($"O valor do ingresso VIP é de R$ {resultadoVip}");

        }
    }
}