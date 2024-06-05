using static System.Console;

internal class Program
{
    private static void Main(string[] args)
    {
        int llamas = 120;
        int whales = 15;
        int dodos = 0;

        if(dodos > 0)
        {
            WriteLine("Egads, I thought dodos were extinct!");
        }
    
        if(dodos < 0)
        {
            WriteLine("Hold on, how can we have NEGATIVE dodos??!");
        }

        if (llamas > whales) 
        {
            WriteLine("Whales may be bigger, but llamas are better, ha!");
        }

        if(llamas <= whales)
        {
            WriteLine("Aw man, brawn over brains I guess. Whales beat llamas.");
        }

        WriteLine("There's been a huge increase in the dodo population via cloning!");
        dodos += 100;

        if((whales + llamas) < dodos)
        {
            WriteLine("I never thought I'd see the day when dodos ruled the earth.");
        }

        if(llamas > whales && llamas > dodos)
        {
            WriteLine("I don't know how, but the llamas have come out ahead! Sneaky!");
        }
    }
}