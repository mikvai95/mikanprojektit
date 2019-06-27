using System;
using System.Collections.Generic;
using System.Linq;

namespace Blackjack
{
    public enum GameResult {Voitto = 1, Hävisit = -1, Tasapeli = 0, Pending = 2};
    public class Card
    {
        public string ID { get; set; }
        public string Suit { get; set; }
        public int Value { get; set; }
        
        public Card(string id, string suit, int value)
        {
            ID = id;
            Suit = suit;
            Value = value;
        }
    }
    
    public class Deck : Stack<Card>
    {
        public Deck(IEnumerable<Card> collection) : base(collection) { }
        public Deck() : base(52) { }

        public Card this[int index]
        {
            get
            {
                Card item;

                if (index >= 0 && index <= this.Count - 1)
                {
                    item = this.ToArray()[index];
                }
                else
                {
                    item = null;
                }

                return item;
            }
        }

        public double Value
        {
            get
            {
                return BlackJackRules.HandValue(this);
            }
        }
    }

    public class Member
    {
        public Deck Hand;

        public Member()
        {
            Hand = new Deck();
        }
    }

    public static class BlackJackRules
    {
        public static string[] ids = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "A", "J", "Q", "K" };

        public static string[] suits = { "Hertta", "Pata", "Ruutu", "Risti" };

        public static Deck NewDeck
        {
            get
            {
                Deck d = new Deck();
                int value;

                foreach(string suit in suits)
                {
                    foreach (string id in ids)
                    {
                        value = Int32.TryParse(id, out value) ? value : id == "A" ? 1 : 10;
                        d.Push(new Card(id, suit, value));
                    }
                }

                return d;
            }
        }

        public static Deck ShuffledDeck
        {
            get
            {
                return new Deck(NewDeck.OrderBy(card => System.Guid.NewGuid()).ToArray());
            }
        }

        public static double HandValue(Deck deck)
        {
            int val1 = deck.Sum(c => c.Value);

            double aces = deck.Count(c => c.ID == "A");
            double val2 = aces > 0 ? val1 + (10 * aces) : val1;

            return new double[] { val1, val2 }
                .Select(handVal => new
                {
                    handVal,
                    weight = Math.Abs(handVal - 21) + (handVal > 21 ? 100 :
                        0)
                })
                    .OrderBy(n => n.weight)
                    .First().handVal;
        }

        public static bool CanDealerHit(Deck deck, int standLimit)
        {
            return deck.Value < standLimit;
        }

        public static bool CanPlayerHit(Deck deck)
        {
            return deck.Value < 21;
        }

        public static GameResult GetResult(Member player, Member dealer)
        {
            GameResult res = GameResult.Voitto;

            double playerValue = HandValue(player.Hand);
            double dealerValue = HandValue(dealer.Hand);

            if (playerValue <= 21)
            {
                if (playerValue != dealerValue)
                {
                    double closestValue = new double[] { playerValue, dealerValue }
                        .Select(handVal => new
                        {
                            handVal, weight = Math.Abs(handVal - 21) + (handVal > 21
                            ? 100 : 0)
                        })
                            .OrderBy(n => n.weight)
                            .First().handVal;

                    res = playerValue == closestValue ? GameResult.Voitto : GameResult.Hävisit;
                }
                else
                {
                    res = GameResult.Tasapeli;
                }
            }
            else
            {
                res = GameResult.Hävisit;
            }
            return res;
        }
        }

        public class BlackJack
        {
        public Member Dealer = new Member();
        public Member Player = new Member();
        public GameResult Result { get; set; }

        public Deck MainDeck;

        public int StandLimit { get; set; }

        public BlackJack(int dealerStandLimit)
        {
            Result = GameResult.Pending;

            StandLimit = dealerStandLimit;

            MainDeck = BlackJackRules.ShuffledDeck;

            Dealer.Hand.Clear();
            Player.Hand.Clear();

            for (int i = 0; ++i < 3; )
            {
                Dealer.Hand.Push(MainDeck.Pop());
                Player.Hand.Push(MainDeck.Pop());
            }
        }

        public void Hit()
        {
            if (BlackJackRules.CanPlayerHit(Player.Hand) && Result == GameResult.Pending)
            {
                Player.Hand.Push(MainDeck.Pop());
            }
        }

        public void Stand()
        {
            if (Result == GameResult.Pending)
            {

                while (BlackJackRules.CanDealerHit(Dealer.Hand, StandLimit))
                {
                    Dealer.Hand.Push(MainDeck.Pop());
                }

                Result = BlackJackRules.GetResult(Player, Dealer);
            }
        }
    }

    public class Program
    {
        public static void ShowStats(BlackJack bj)
        {
            Console.WriteLine("Jakaja");
            foreach (Card c in bj.Dealer.Hand)
            {
                Console.WriteLine(string.Format("{0}{1}", c.ID, c.Suit));
            }

            Console.WriteLine(bj.Dealer.Hand.Value);

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Pelaaja");
            foreach (Card c in bj.Player.Hand)
            {
                Console.WriteLine(string.Format("{0}{1}", c.ID, c.Suit));
            }
            Console.WriteLine(bj.Player.Hand.Value);

            Console.WriteLine(Environment.NewLine);
        }
        public static void Main()
        {
            Aloitus:
            string input = "";
            BlackJack bj = new BlackJack(17);
            ShowStats(bj);

            while (bj.Result == GameResult.Pending)
            {
                input = Console.ReadLine();

                if (input.ToLower() == "h")
                {
                    bj.Hit();
                    ShowStats(bj);
                }
                else
                {
                    bj.Stand();
                    ShowStats(bj);
                }
            }

            Console.WriteLine(bj.Result);
            Console.ReadLine();
            Console.WriteLine("Halauatko pelata uudelleen? kyllä/ei: ");
            bool vastaus = true;
            string vas = Console.ReadLine();

            while (vastaus)
            {
                if (vas == "k" || vas == "K" || vas == "kyllä" || vas == "KYLLÄ")
                {
                    goto Aloitus;
                }
                else if (vas == "e" || vas == "E" || vas == "ei" || vas == "EI")
                {
                    vastaus = false;
                }
                else
                {
                    Console.Write("Virhe! Laita k, K, kyllä, KYLLÄ jos haluat jatkaa, e, E, ei, EI jos et halua jatkaa.");
                    vas = Console.ReadLine();
                }
            }
            Console.Clear();
        }
    }
}
