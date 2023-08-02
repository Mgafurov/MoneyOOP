public class Money
{
    //закрытые атрибуты для хранения рублей и копеек
    private int rubles;
    private int kopeks;
    //статичная переменная для подсчёта количества созданных объектов
    private static int totalObjects = 0;
    public Money(int rubles, int kopeks)
    {
        this.rubles = rubles;
        this.kopeks = kopeks;
        if (this.kopeks >= 100) //Убеждаемся что копеек не может быть больше 99
        {
            this.rubles += this.kopeks / 100;
            this.kopeks %= 100;
        }
        totalObjects++; //При создании объекта увеличиваем счётчик
    }
    public override string ToString()
    {
        return $"{rubles} руб. {kopeks} коп.";
    }
    public void AddKopeks(int addToKopeks)
    {
        //добавляем копейки с учётом переноса рублей если есть необходимость
        this.kopeks += addToKopeks;
        if (this.kopeks >= 100)
        {
            this.rubles += this.kopeks / 100;
            this.kopeks %= 100;
        }
    }
    public void SubtractKopeks(int kopeksToSubtract)
    {
        //вычитываем копейки с учётом переноса рубля при необходимости
        int totalKopeks = rubles * 100 + kopeks;
        totalKopeks -= kopeksToSubtract;
        if (totalKopeks < 0)
        {
            this.rubles = 0;
            this.kopeks = 0;
        }
        else
        {
            this.rubles = totalKopeks / 100;
            this.kopeks = totalKopeks % 100;
        }
    }
    public static int GetTotalObjects()
    {
        return totalObjects;
    }
}