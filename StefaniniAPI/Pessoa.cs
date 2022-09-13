using System.ComponentModel.DataAnnotations;

namespace StefaniniAPI
{
    public class Pessoa
    {
        //Key
        public int Id { get; set; }

        //Members
        [StringLength(300)]
        public string Nome { get; set; } = string.Empty;

        [StringLength(11)]
        public string Cpf { get; set; } = string.Empty;

        public int CidadeId { get; set; }

        public Cidade? Cidade { get; set; }

        public int Idade { get; set; }
    }
}
