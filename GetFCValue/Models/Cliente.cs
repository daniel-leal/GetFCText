namespace GetFCValue.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string CpfCnpj { get; set; }

        public int TipoPessoa { get; set; }
    }

    public enum TipoPessoa
    {
        Fisica = 1,
        Juridica = 2
    }
}