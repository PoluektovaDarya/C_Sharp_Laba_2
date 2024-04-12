using System;

class Program
{
    enum DayOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    enum TimeOfDay
    {
        Morning,
        Day,
        Evening,
        Night
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Введите день недели (0 - Понедельник, 1 - Вторник, и т.д.):");
        int dayIndex = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите время (от 0 до 23):");
        int hour = Convert.ToInt32(Console.ReadLine());

        if (Enum.IsDefined(typeof(DayOfWeek), dayIndex) && hour >= 0 && hour <= 23)
        {
            DayOfWeek day = (DayOfWeek)dayIndex;
            TimeOfDay time;

            if (hour >= 7 && hour <= 12)
            {
                time = TimeOfDay.Morning;
            }
            else if (hour >= 13 && hour <= 18)
            {
                time = TimeOfDay.Day;
            }
            else if (hour >= 19 && hour <= 23)
            {
                time = TimeOfDay.Evening;
            }
            else
            {
                time = TimeOfDay.Night;
            }

            Console.WriteLine($"Сейчас {day}, {GetTimeOfDayString(time)}");
        }
        else
        {
            Console.WriteLine("Ошибка: некорректный ввод.");
        }
    }

    static string GetTimeOfDayString(TimeOfDay time)
    {
        switch (time)
        {
            case TimeOfDay.Morning:
                return "Утро";
            case TimeOfDay.Day:
                return "День";
            case TimeOfDay.Evening:
                return "Вечер";
            case TimeOfDay.Night:
                return "Ночь";
            default:
                return "";
        }
    }
}
