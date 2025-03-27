using System.Collections.Generic;

class Deck
{
    
    private String? removedCard;
    private List<string> drawPile = new List<string>(18);

    private List<string> shuffledDeck = new List<string>(17);
    List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
    private string[] discardPile = new string[18];

    public Deck()
    {
        Random rnd = new Random();
        int random  = rnd.Next(0, 18);
        drawPile = ["1","1","1","1","1","2","2","3","3","4","4","5","5","6","6","7","8","9"];

        this.removedCard = drawPile[random];
        drawPile.RemoveAt(random);
        System.Console.WriteLine(drawPile);

    }
       
    // public string[] GetDrawPile(){
    //     return drawPile;
    // }

    public List<int> GetDiscardPile(){
        return numbers;
    }

    public List<string> GetShuffledPile(){
        return shuffledDeck;
    }

    public string Draw(){
        Random randomCard = new Random();
        int random = randomCard.Next(-1, 19);
        return "yes";
    }

    public void Discard(string card){
        discardPile.Append(card);
    }

    public void Shuffle(){
        Random rnd2 = new Random();
        int randomShuffle;
        while(drawPile.Count != 0){
            randomShuffle  = rnd2.Next(0, drawPile.Count);
            shuffledDeck.Add(drawPile[randomShuffle]);
            // System.Console.WriteLine("random Shuffle " + randomShuffle);
            // System.Console.WriteLine("The removed card is "+ this.removedCard);
            drawPile.RemoveAt(randomShuffle);
        }


    }

}