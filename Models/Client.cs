using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;
using System.Xml.Linq;

namespace Proiect_Torok_Erika.Models
{
    public class Client
    {
        public int ID { get; set; }
        [Display(Name = "Nume Client")] 
        public string Nume { get; set; }
        public string Produs { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Pret { get; set; }
        [DataType(DataType.Date)]
        public DateTime DataProcesare { get; set; }
        public int? MaterialID { get; set; }
        public Material? Material { get; set; } } //navigation property


}

