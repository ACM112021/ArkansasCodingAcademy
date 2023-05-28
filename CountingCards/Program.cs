namespace CountingCards
{
     class Program
     {
          public static void Main(string[] args)
          {
               Card card1 = new Card();
               card1.CardColor = Card.Color.Blue;
               card1.CardRank = Card.Rank.DollarSign;

               Card card2 = new Card();
               card2.CardColor = Card.Color.Red;
               card2.CardRank = Card.Rank.Seven;

               Card[] Cards = GetAllCardCombinations();

               foreach (Card card in Cards)
               {
                    System.Console.WriteLine($"Card is The {card.CardColor} {card.CardRank}");
               }
          }

          static Card[] GetAllCardCombinations()
          {
               Card[] Cards = new Card[56];
               int i = 0;

               foreach (Card.Color color in Enum.GetValues(typeof(Card.Color)))
               {
                    foreach (Card.Rank rank in Enum.GetValues(typeof(Card.Rank)))
                    {
                         Card card = new Card();
                         card.CardColor = color;
                         card.CardRank = rank;
                         Cards[i++] = card;
                    }
               }

               return Cards;
          }
     }
}
