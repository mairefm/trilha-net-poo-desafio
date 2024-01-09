namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone" - Feito!
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo" - Feito
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalação do aplicativo " + nomeApp + " no Iphone.");

        }
    }
}