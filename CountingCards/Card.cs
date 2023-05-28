class Card 
     {
          public enum Color
          {
               Red,
               Green,
               Blue,
               Yellow
          }

          public enum Rank
          {
               One,
               Two,
               Three,
               Four,
               Five,
               Six,
               Seven,
               Eight,
               Nine,
               Ten,
               DollarSign,
               Percent,
               Carat,
               Ampersand
          }

          public Color CardColor { get; set; }
          public Rank CardRank { get; set; }
          
     }