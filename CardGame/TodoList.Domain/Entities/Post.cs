using System.ComponentModel.DataAnnotations.Schema;

namespace CardGame.Domain.Entities
{
    public class Post : Entity
    {
        [ForeignKey("who_id_user")]
        public Users who {  get; set; }
        public string whom { get; set; }
        public string text { get; set; }
        public DateTime whenDate { get; set; }
    }
}
