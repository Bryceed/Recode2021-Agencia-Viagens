using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WellN_M2_AgenciaViagens.Models
{
    public class Clientes
    {
        [Key]
        public int UID { get; set; }
        public string nome { get; set; }
        public int idade { get; set; }
        public DateTime criadoEm { get; set; } = DateTime.Now;

       
         [ForeignKey("Compras")]
         public int SecID { get; set; }
         public virtual Compras? Compras { get; set; }
         

    }
}
