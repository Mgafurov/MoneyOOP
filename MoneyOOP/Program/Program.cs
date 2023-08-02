using System;

class Program
{
    static void Main()
    {
        Money money1 = new Money(10, 50);
        Money money2 = new Money(5, 75);
        //Выводим информацию о созданных объектах
        Console.WriteLine("Объект 1: " + money1);
        Console.WriteLine("Объект 2: " + money2);
        //Добавим копеек к объекту 1
        money1.AddKopeks(80);
        Console.WriteLine("Объект 1 (после добавления копеек): " + money1);
        //Вычитаем копейки с объекта 1
        money2.SubtractKopeks(30);
        Console.WriteLine("Объект 2 (после вычитания копеек): " + money2);
        //Считаем кол-во созданных объектов с помощью статической функции
        int totalObjects = Money.GetTotalObjects();
        Console.WriteLine("Кол-во созданных объектов: " + totalObjects);
        Console.ReadKey();
    }
}