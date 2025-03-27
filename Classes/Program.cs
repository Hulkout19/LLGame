using System;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Deck myDeck = new Deck();
// string[] drawPile = myDeck.GetDrawPile();
// myDeck.Shuffle();
List<string> shuffled = myDeck.GetShuffledPile();

for (int i = 0; i < shuffled.Count; i++)
{
    Console.WriteLine(shuffled[i]);
}

for (int i = 0; i < 17; i++)
{
    System.Console.WriteLine("Your card is:" + myDeck.Draw());
}

System.Console.WriteLine("Shuffled Length = " + shuffled.Count);


Player player1 = new Player("Sven", false);
Player player2 = new Player("Haleigh", true);
List<Player> playerList = new List<Player> {player1,player2};