namespace CardGame.Domain.Entities
{
    public class Cards : Entity
    {
        public string cardImage { get; set; }
        public string name { get; set; }
        public int hp { get; set; }
        public int mp { get; set; }
        public int atk { get; set; }
        public int price { get; set; }

        public Cards(string cardImage, string name, int hp, int mp, int atk, int price) : this(cardImage, name, hp, mp, atk)
        {
            this.price = price;
        }

        public Cards(string cardImage, string name, int hp, int mp, int atk) : this(cardImage, name, hp, mp)
        {
            this.atk = atk;
        }

        public Cards(string cardImage, string name, int hp, int mp) : this(cardImage, name, hp)
        {
            this.mp = mp;
        }

        public Cards(string cardImage, string name, int hp) : this(cardImage, name)
        {
            this.hp = hp;
        }

        public Cards(string cardImage, string name)
        {
            this.cardImage = cardImage;
            this.name = name;
        }
    }
}
