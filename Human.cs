public class Human
{
    public string name;
    public int age;


    public Human(string name, int age)
    {
        this.name = name;
        this.age = age;

      
    }
    static void HumanActionMusic(Human human)
    {
        Console.WriteLine($"{human.name} включил музыку");
    }
    static void HumanActionSleep(Human human)
    {
        Console.WriteLine($"{human.name} Заснул");
    }

    static void HumanActionDrinkCoffe(Human human)
    {
        Console.WriteLine($"{human.name} Выпил кофе");
    }
}

