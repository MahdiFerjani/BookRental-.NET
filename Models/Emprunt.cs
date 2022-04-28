namespace WebApplication3.Models
{
    public class Emprunt
    {

        public int EmpruntId { get; set; }
        public DateOnly Date_emprunt { get; set; }
        public DateOnly Date_prevue { get; set; }
        public DateOnly Date_retour { get; set; }
         public status status { get; set; }
        public int  LivreID  { get; set; }
        public  Livre Livre { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

    }
    public enum status { emprunted, returned }
}
