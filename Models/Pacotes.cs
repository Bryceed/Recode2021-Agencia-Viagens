using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WellN_M2_AgenciaViagens.Models
{
    public class Pacotes
    {
        [Key]
        public int ID { get; set; }
        public double preco { get; set; }
        public double? precoOriginal { get; set; }
        public string destino { get; set; }
        public int pessoasContempladas { get; set; } = 1;
        public bool hasOnibus { get; set; } = false;
        public bool hasAviao { get; set; } = false;
        public bool hasNavio { get; set; } = false;
        public bool hasHotel { get; set; } = false;
        public bool hasAlimentacao { get; set; } = false;


        [ForeignKey("Compras")]
        public int SecID { get; set; }
        public virtual Compras? Compras { get; set; }

    }
}
