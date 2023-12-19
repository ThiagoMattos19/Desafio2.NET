namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
           
            int CapacidadeMaxima = 3;
            if (Hospedes == null)
            {
                Hospedes = new List<Pessoa>();
            }
            if (Hospedes.Count <= CapacidadeMaxima)
            {
                Hospedes = hospedes;
            }
            else
            {
                
                throw new Exception("A capacidade de Hospedes excede o limite");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            
            Console.WriteLine("Quantidade De Hospedes");
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
           
            decimal valor = DiasReservados * Suite.ValorDiaria;
            if (DiasReservados >= 10)
            {
                valor -= valor * 0.10m;
            }
           
            Console.WriteLine("Desconto de 10% aplicado devido a quantidade de dias reservadas");
            return valor;

        }
    }
}