using System.ComponentModel.DataAnnotations;

namespace WellN_M2_AgenciaViagens.Models
{
    public class Compras
    {
        [Key]
        public int SecID { get; set; }
        [Required]
        public int ID { get; set; }
        [Required]
        public int UID { get; set; }
        public DateTime createdAt { get; set; } = DateTime.Now;
        public int qtdd { get; set; } = 1;
        public DateTime plannedAt { get; set; }

        public virtual List<Pacotes>? ListPacotes { get; set; }
        public virtual List<Clientes>? ListClientes { get; set; }
        public virtual List<Suporte>? ListSuporte { get; set; }

    }
}
