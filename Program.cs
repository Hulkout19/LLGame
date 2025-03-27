using System;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Deck myDeck = new Deck();
// string[] drawPile = myDeck.GetDrawPile();
List<int> discardPile = myDeck.GetDiscardPile();
myDeck.Shuffle();
List<string> shuffled = myDeck.GetShuffledPile();

// for (int i = 0; i < drawPile.Length; i++)
// {
//     Console.WriteLine(drawPile[i]);
// }

System.Console.WriteLine("Shuffled Length = " + shuffled.Count);
for (int i = 0; i < shuffled.Count; i++)
{
    Console.WriteLine(shuffled[i]);
}