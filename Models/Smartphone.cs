namespace DesafioPOO.Models
{
    public abstract class Smartphone // classe abstrata
    {


        protected string Numero { get; set; }
        // Implementado!
        public string Modelo { get; set; }

        public string IMEI { get; set; }

        public int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
            // Implementado!
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}