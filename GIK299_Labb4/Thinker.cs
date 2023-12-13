namespace GIK299_Labb4;

public class Thinker
{
    public void Think(int times, int timeMs)
    {
        for (int i = 0; i < times; i++)
        {
            Console.Clear();
            Thread.Sleep(timeMs);
            Console.Clear();
            Console.WriteLine("Thinking.");
            Thread.Sleep(timeMs);
            Console.Clear();
            Console.WriteLine("Thinking..");
            Thread.Sleep(timeMs);
            Console.Clear();
            Console.WriteLine("Thinking...");
            Thread.Sleep(timeMs);
            Console.Clear();
        }
    }
}