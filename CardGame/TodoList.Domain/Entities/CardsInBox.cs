using System.ComponentModel.DataAnnotations.Schema;

namespace CardGame.Domain.Entities
{
    public class CardsInBox : Entity
    {
        [ForeignKey("id_user")]
        public Users user { get; set; }
        [ForeignKey("idCards")]
        public Cards card { get; set; }
        public int count { get; set; }
    }
}
