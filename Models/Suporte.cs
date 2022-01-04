using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WellN_M2_AgenciaViagens.Models
{
    public class Suporte
    {
        [Key]
        public int TicketID { get; set; }
        public string name { get; set; }
        public string? email { get; set; }
        public string motivo { get; set; }
        public string mensagem { get; set; }

        [ForeignKey("Compras")]
        public int SecID { get; set; }
        public virtual Compras? Compras { get; set; }
    }
}
