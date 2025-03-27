using System.Collections.Generic;

class Deck
{
    
    private int? removedCard;
    public string[] drawPile = new string[18];

    List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
    private string[] discardPile = new string[18];

    public Deck()
    {
        Random rnd = new Random();
        int random  = rnd.Next(-1, 5);
        drawPile = ["1","1","1","1","1","2","2","3","3","4","4","5","5","6","6","7","8","9"];
        //removedCard = drawPile[random];
        removedCard = numbers[random];

        numbers.RemoveAt(random);
        //drawPile[random] = "null";
        System.Console.WriteLine(drawPile);
    }
       
    public string[] GetDrawPile(){
        return drawPile;
    }

    public List<int> GetDiscardPile(){
        return numbers;
    }

    public string Draw(){
        Random randomCard = new Random();
        int random = randomCard.Next(-1, 19);
        return "yes";
    }

    public void Discard(string card){
        discardPile.Append(card);
    }

}