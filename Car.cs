
public class Car
{
    public string type;
    public string colour;
    public int id = 0;
    public Human Human;
    public Engine Engine;



    public Car(string type, string colour, int id, Human human, Engine engine)
    {
        this.type = type;
        this.colour = colour;
        this.id = id;
        this.Human = human;
        this.Engine = engine;
    }


    public static void ActionStart(Car car)
    {
        
        Console.WriteLine($"{car.id} - {car.type} : поехал");
    }
    public static void ActionStop(Car car)
    {
        Console.WriteLine($"{car.id} - {car.type} : остановился");
    }
    public static void ActionRight(Car car)
    {
        Console.WriteLine($"{car.id} - {car.type} : повернул на право");
    }
    public static void ActionLeft(Car car)
    {
        Console.WriteLine($"{car.id} - {car.type} : повернул на лево");
    }
    public static void ActionBip(Car car)
    {
        Console.WriteLine($"{car.id} - {car.type} : издал звук");
    }

    public override string ToString()
    {
        return $"Тип: {type};\n Цвет: {colour};\n Id: {id};\n Водитель: {Human.name}, {Human.age} лет;\n Двигатель - {Engine.etype}, {Engine.liters} литров";
    }

}

