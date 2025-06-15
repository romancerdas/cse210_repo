namespace common;

public class RandomNumberGenerator
{
    public static int getRandomNumber(int upperBound)
    {
        Random random = new Random();
        int randomInt = random.Next(upperBound);
        return randomInt;
    }
}