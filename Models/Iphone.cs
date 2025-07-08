namespace DesafioPOO.Models
{
    // Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            Console.WriteLine("Criando Iphone");
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"Instalando App - {nome}");
        }
    }
}