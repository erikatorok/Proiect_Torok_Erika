using Proiect_Torok_Erika.Models;
using System.Security.Policy;

namespace Proiect_Torok_Erika.Models.ViewModels
{
    public class MaterialIndexData
    {
        public IEnumerable<Material> Materiale { get; set; }
        public IEnumerable<Client> Clienti { get; set; }

    }
}
