using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication3.Models
{
    

    public class User

    {
        public User()
        {
            
        }


        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public long  UserId { get; set; }
        public string  Nom { get; set; }
        public string Prenom { get; set; }
        public string Niveau{ get; set; }

        public virtual ICollection<Emprunt> Emprunts { get; set; }

    }

}
