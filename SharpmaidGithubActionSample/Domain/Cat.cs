namespace SharpmaidGithubActionSample.Domain;

public class Cat : Animal
{
    public int numberOfLegs = 4;

    public override string Speak()
    {
        return "Meow";
    }
}