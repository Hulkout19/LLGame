using System;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Deck myDeck = new Deck();
string[] drawPile = myDeck.GetDrawPile();
List<int> discardPile = myDeck.GetDiscardPile();

for (int i = 0; i < drawPile.Length; i++)
{
    Console.WriteLine(drawPile[i]);
}

for (int i = 0; i < discardPile.Count; i++)
{
    Console.WriteLine(discardPile[i]);
}