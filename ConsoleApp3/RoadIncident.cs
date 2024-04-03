using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class RoadIncident
    {
        public enum Severity
        {
            Minor,    // Незначительные повреждения
            Serious,  // Серьезные повреждения
            Violation // Нарушение правил дорожного движения
        }

        // Свойство для хранения серьезности происшествия
        public Severity IncidentSeverity { get; set; }

        // Конструктор класса RoadIncident
        public RoadIncident(Severity severity)
        {
            IncidentSeverity = severity; // Инициализация серьезности происшествия
        }
    }
}
