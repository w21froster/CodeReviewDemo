namespace CodeReviewDemo;
/// <summary>
/// will do later
/// </summary>
public class animal
{
    public string name;
    public string sound;

    public animal(string name, string sound)
    {
        this.name = name;
        this.sound = sound;
    }

    public string get_Sound()
    {
        return this.sound; // get sound of animal
    }
}