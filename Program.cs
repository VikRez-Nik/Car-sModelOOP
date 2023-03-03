class Programm
{
    static void Main() 
    {
        List<Car> CarsList = new();
     
        while (true)
        {
            Console.WriteLine("Привет! Что  ты хочешь сделать? 1 - записать новую машину, 2 - вывести все машины, 3 - Вывести интерисующую машину, 4 - Задать команду машине ");

            switch (Console.ReadLine())
            {
                case "1":
                    // сделать проверку на ввод
                   
                    Console.WriteLine("Введи имя водиетля");
                    string addname = Console.ReadLine();
                    Console.WriteLine("Введи возраст водителя");
                    int addage = Convert.ToInt32(Console.ReadLine());               
          
                    //запись машины
                    Console.WriteLine("Какой тип у машины?");
                    string addtype = Console.ReadLine();
                    Console.WriteLine("Какой цвет у машины?");
                    string addcolour = Console.ReadLine();     
                    int carid = CarsList.Count+1;           

                    //запись двигателя
                    Console.WriteLine("Какой тип у двигателя?");
                    string addetype = Console.ReadLine();
                    Console.WriteLine("Сколько литров?");
                    int addliters = Convert.ToInt32(Console.ReadLine());

                    CarsList.Add(new Car(addtype, addcolour, carid++ , new Human(addname, addage), new Engine(addetype, addliters)));
                    break;

                case "2": //вывод всего списка 
                    foreach (var Car in CarsList)
                    {
                        Console.WriteLine(Car);
                    }
                    break; 

             
                case "3":
                    Console.WriteLine("Введи айди интерисующей машины:");
                    int interesid = Convert.ToInt32(Console.ReadLine());
                    if (interesid > 0 && CarsList.Count >= interesid)
                    {
                        Console.WriteLine(CarsList[interesid-1].ToString());
                    }
                    break;


                  case "4": // Назначение действия для машины                                                 
                    Console.WriteLine("Введи айди интерисующей машины:");
                    int index = Convert.ToInt32(Console.ReadLine());
                    Car car = CarsList[index-1]; //Выбор машины по id
                    Console.WriteLine("Что эта машина должна сделать? \na - поехать; \nb - остановиться; \nc - Повернуть на право; \nd - Повернуть на лево; \ne - Побибикать. ");
                    switch (Console.ReadLine())
                    {
                        case "a":
                            Car.ActionStart(car);
                            break;                                    
                        case "b":
                            Car.ActionStop(car);
                            break;
                        case "c":
                            Car.ActionRight(car);
                            break;
                        case "d":
                            Car.ActionLeft(car);
                            break;
                        case "e":
                            Car.ActionBip(car);
                            break;
                        default:
                            Console.WriteLine("Ты ввёл что-то не то!");
                            break;
                    }
            break;

                default:
                    {
                        Console.WriteLine("Введи что хочешь сделать!");
                        break;
                    }
                    
            }
        }

    }
}


