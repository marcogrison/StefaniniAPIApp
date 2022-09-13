using System.ComponentModel.DataAnnotations;

namespace StefaniniAPI
{
    public class Cidade
    {
        //Key
        public int Id { get; set; }

        //Members
        [StringLength(200)]
        public string CidadeNome { get; set; } = string.Empty;

        [StringLength(2)]
        public string Uf { get; set; } = string.Empty;
    }
}
