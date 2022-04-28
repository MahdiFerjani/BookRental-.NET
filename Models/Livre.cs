using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication3.Models
{
    public class Livre{
        public Livre()
        {
          
        }



        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public long LivreId { get; set; }
        public string Title { get; set; }
        public string Annee { get; set; }
         
        public string Isbn { get; set; }
         public string Description { get; set; }
        public string Image { get; set; }
        public int Exemplaire { get; set; }
        public virtual ICollection<User> Users { get; set; }



    }
}
