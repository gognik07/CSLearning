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
            Console.WriteLine($"Вы должны отстоять в очереди" +
                $" {patientAppointmentTime * countPatients / countMinutesInHour} часа " +
                $"{patientAppointmentTime * countPatients % countMinutesInHour} минут");
        }
    }
}
