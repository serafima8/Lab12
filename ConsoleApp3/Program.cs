using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueInput = true; // Переменная для проверки продолжения ввода
            while (continueInput) // Цикл, пока пользователь хочет продолжить ввод
            {
                Console.WriteLine("Введите характер происшествия (1 - незначительные повреждения, 2 - серьезные повреждения, 3 - нарушение правил дорожного движения):");
                int incidentType = int.Parse(Console.ReadLine());

                RoadIncident.Severity severity;

                switch (incidentType)
                {
                    case 1:
                        severity = RoadIncident.Severity.Minor;
                        break;
                    case 2:
                        severity = RoadIncident.Severity.Serious;
                        break;
                    case 3:
                        severity = RoadIncident.Severity.Violation;
                        break;
                    default:
                        Console.WriteLine("Некорректный ввод.");
                        continue; // Переход к следующей итерации цикла
                }

                RoadIncident incident = new RoadIncident(severity);
                Driver driver = new Driver();

                switch (incident.IncidentSeverity)
                {
                    case RoadIncident.Severity.Minor:
                        Console.WriteLine("ДТП с незначительными повреждениями. Путешествие задерживается на 2 часа.");
                        break;
                    case RoadIncident.Severity.Serious:
                        Console.WriteLine("ДТП с серьезными повреждениями. Вызывается эвакуатор.");
                        break;
                    case RoadIncident.Severity.Violation:
                        Console.WriteLine("Нарушение правил дорожного движения. Штраф.");
                        driver.IncreasePenalties();
                        if (driver.NumberOfPenalties >= 3)
                        {
                            Console.WriteLine("У вас уже 3 штрафа. Ваши права аннулированы.");
                        }
                        break;
                }
                Console.ReadKey();
            }
        }
        
    
    }
}
