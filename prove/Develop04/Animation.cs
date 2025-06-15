
public class Animation
{
    List<string> animationStrings = new List<string> { "|", "/", "-", @"\ ", "|" };


    public void runAnimation(int duration)
    {
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write("\r" + animationStrings[i]);
            Thread.Sleep(500);
            i = (i + 1) % animationStrings.Count;
        }
        Console.Write("\r "); 
        Console.Write("\r "); 
        Console.WriteLine();
        
    }
}