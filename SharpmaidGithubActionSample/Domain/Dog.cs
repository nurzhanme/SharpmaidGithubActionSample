namespace SharpmaidGithubActionSample.Domain;

public class Dog : Animal
{
    public int numberOfLegs = 4;

    public override string Speak()
    {
        return "Bark";
    }
}