using System;

namespace CSLight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите кол-во старушек: ");
            int countPatients = Convert.ToInt32(Console.ReadLine());
            int patientAppointmentTime = 10;
            int countMinutesInHour = 60;
            int hoursInQueue = patientAppointmentTime * countPatients / countMinutesInHour;
            int minutesInQueue = patientAppointmentTime * countPatients % countMinutesInHour;
            Console.WriteLine($"Вы должны отстоять в очереди" +
                $" {hoursInQueue} часа {minutesInQueue} минут");
        }
    }
}
