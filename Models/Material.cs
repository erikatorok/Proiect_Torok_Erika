namespace Proiect_Torok_Erika.Models
{
    public class Material
    {
        public int ID { get; set; }
        public string NumeMaterial { get; set; }
        public ICollection<Client>? Clienti { get; set; } //navigation property
    }
}
