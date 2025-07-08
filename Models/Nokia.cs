namespace DesafioPOO.Models
{
    // Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            Console.WriteLine("Criando Nokia");
        }
        // Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"Instalando App - {nome}");
        }
    }
}