using System;
using Actividad_1;
using System.Collections.Generic;

namespace Actividad_6
{
    abstract public class CardGame
    {
        protected Persona player1;
        protected Persona player2;
        protected List<int> player1Hand = new List<int>();
        protected List<int> player2Hand = new List<int>();
        protected List<int> deck = new List<int>();
        protected int player1Score = 0;
        protected int player2Score = 0;
        protected Persona winner;
        protected Random card = new Random();
        public Persona gameBegins(Persona player1, Persona player2)
        {
            this.player1 = player1;
            this.player2 = player2;
            this.shuffleDeck();
            this.dealingCards();
            
            while(this.player1Score !=5 && this.player2Score !=5)
            {
                this.playingAHand();
            }

            if(this.player1Score > this.player2Score)
            {
                this.winner = this.player1;
            }else
            {
                this.winner = this.player2;
            }

            return this.winner;
        }

        abstract protected void shuffleDeck();
        abstract protected void dealingCards();
        abstract protected void takeCards();
        abstract protected void discardCards();
        
        virtual protected void playingAHand()
        {
            this.takeCards();
            this.discardCards();
        }

        virtual public void getWinner()
        {
            if(this.winner != null)
            {
                Console.WriteLine("\nPuntaje de {0}: {1}", this.player1.getNombre(), this.player1Score);
                Console.WriteLine("Puntaje de {0}: {1}", this.player2.getNombre(), this.player2Score);
                Console.WriteLine("El ganador del juego es: {0}", this.winner.getNombre());
            }else
            {
                Console.WriteLine("No se ha iniciado un juego, y por lo tanto no existen ganadores");
            }
        }
        abstract protected bool playerExists();
    }

    class AwfulCardGame:CardGame
    {
        /*En este juego, la partida inicia mezclando el mazo y repartiando 5 cartas a cada jugador.
        Cada carta es un número entero. El jugador cuya mano contenga cartas con una suma mayor resulta el vencedor.*/
        override protected void shuffleDeck()
        {
            Console.WriteLine("***********************************************");
            Console.WriteLine("*  Comenzando una partida de Awful Cardgame   *");
            Console.WriteLine("***********************************************\n");
            Console.WriteLine("Mezclando cartas en mazo.");
            for(int i =1;i<41;i++)
            {
                this.deck.Add(i);
            }
        }

        override protected void dealingCards()
        {
            Console.WriteLine("Repartiendo cartas a cada jugador.");
            
            for(int i=0;i<5;i++)
            {
                this.player1Hand.Add(card.Next(this.deck.Count));
                this.player2Hand.Add(card.Next(this.deck.Count));
            }
        }

        override protected void playingAHand()
        {
            Console.WriteLine("Comenzando nueva ronda.");
            int player1Total = 0;
            int player2Total = 0;
            
            for(int i=0;i<5;i++)
            {
                player1Total = player1Total + this.player1Hand[i];
                player2Total = player2Total + this.player2Hand[i];
            }

            if(player1Total>player2Total)
            {
                this.player1Score++;
                Console.WriteLine("El ganador de esta ronda es: {0}\n", this.player1.getNombre());
            }
            if(player2Total > player1Total)
            {
                this.player2Score++;
                Console.WriteLine("El ganador de esta ronda es: {0}\n", this.player2.getNombre());
            }
            if(player1Total == player2Total)
            {
                Console.WriteLine("Esta ronda resultó en empate.\n");
            }
            this.discardCards();
            this.takeCards();
        }

        override protected void takeCards()
        {
            this.dealingCards();
        }

        override protected void discardCards()
        {
            Console.WriteLine("Ambos jugadores descartan sus cartas y las regresan al mazo");
            this.player1Hand = new List<int>();
            this.player2Hand = new List<int>();
        }

        override protected bool playerExists()
        {
            Console.WriteLine("Determinando si hay jugadores.");
            return this.player1 == null & this.player2==null;
        }
    }

    class BoringCardGame:CardGame
    {
        /*Este juego inicia mezclando las cartas en el mazo y seleccionando una de ellas al azar,
        la cual será referida a partir de ahora como el "target". Las cartas del mazo son números
        enteros. Luego se reparten 3 cartas para cada jugador. Si un jugador contiene en su mano el
        target, resulta ser el vencedor. Si ninguno de los dos lo tuviese, ambos jugadores regresan
        las cartas que tienen al mazo y toman otras 3. El proceso se repite hasta que haya un ganador.*/
        private int target;
        
        override protected void shuffleDeck()
        {
            Console.WriteLine("***********************************************");
            Console.WriteLine("*  Comenzando una partida de Boring Cardgame  *");
            Console.WriteLine("***********************************************\n");
            Console.WriteLine("Mezclando cartas en mazo y seleccionando una carta al azar.");
            for(int i =1;i<41;i++)
            {
                this.deck.Add(i);
            }

            this.target = this.card.Next(this.deck.Count);
        }

        override protected void dealingCards()
        {
            Console.WriteLine("Repartiendo cartas a cada jugador");
            for(int i=0;i<3;i++)
            {
                this.player1Hand.Add(card.Next(this.deck.Count));
                this.player2Hand.Add(card.Next(this.deck.Count));
            }
        }

        override protected void playingAHand()
        {
            do
            {
                if(this.player1Hand.Contains(this.target))
                {
                    this.player1Score++;
                    this.discardCards();
                    this.takeCards();
                    Console.WriteLine("\nEl Ganador de esta ronda es: {0}", this.player1.getNombre());
                }   else if(this.player2Hand.Contains(this.target))
                {
                    this.player2Score++;
                    this.discardCards();
                    this.takeCards();
                    Console.WriteLine("\nEl Ganador de esta ronda es: {0}", this.player2.getNombre());
                }else
                {
                    this.discardCards();
                    this.takeCards();
                }
            } while (!this.player1Hand.Contains(this.target) && !this.player2Hand.Contains(this.target));
        }
        
        override protected void takeCards()
        {
            this.dealingCards();
        }

        override protected void discardCards()
        {
            Console.WriteLine("Ambos jugadores descartan sus cartas y las regresan al mazo");
            this.player1Hand = new List<int>();
            this.player2Hand = new List<int>();
        }

        override protected bool playerExists()
        {
            Console.WriteLine("Determinando si hag jugadores.");

            return this.player1 == null & this.player2==null;
        }
    }
}