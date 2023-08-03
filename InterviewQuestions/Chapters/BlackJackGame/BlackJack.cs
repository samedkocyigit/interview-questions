using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BlackJack.Suit;
using static BlackJack.Face;

namespace BlackJack
{
    public enum Suit
    {
        Clubs,
        Hearts,
        Spadec,
        Diamonds
    }
    public enum Face
    {
        Ace,
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
        Jack,
        Queen,
        King
    }

    public class Card
    {   public int Value{get;set;}
        public Suit Suit { get; }
        public Face Face { get; }

        public Card(Suit suit,Face face)
        {
            Suit=suit;
            Face=face;

            switch(Face)
            {
                case Ten:
                case Jack:
                case Queen:
                case King:
                    Value=10;
                    break;
                case Ace:
                    Value=11;
                    break;
                default:
                    Value= (int)Face+1;
                    break;    
            }
        }
    }
    public class Deck
    {
        public List<Card> cards;
        public Deck()
        {
            Initialize();
        }
        public List<Card> GetColdDecks()
        {
            List<Card> coldDecks = new List<Card>();
            for(int i = 0; i < 13; i++)
            {
                for(int j = 0;j<4;j++)
                {
                    coldDecks.Add(new Card((Suit)j,(Face)i));
                }
            }
            return coldDecks;
        }
        public List<Card> DealHand()
        {
            List<Card> Hand= new List<Card>();
            Hand.Add(cards[0]);
            Hand.Add(cards[1]);

            cards.RemoveRange(0, 2);
            return Hand;
        }
        public void Shuffle()
        {
            Random rng = new Random();
            
            int n= cards.Count;
            while (n>1)
            {
                n--;
                int k= rng.Next(n+1);
                Card card=cards[k];
                cards[k]=cards[n];
                cards[n]=card;
            }
        }

        public void Initialize()
        {
            cards = GetColdDecks();
            Shuffle();
        }
    }
}