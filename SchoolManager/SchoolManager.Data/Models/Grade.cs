using SchoolManager.Data.Enums;

namespace SchoolManager.Data.Models
{
    public class Grade
    {
        public SchoolSubjects SchoolSubject { get; set; }

        public double Value { get; set; }

        public int Weight { get; set; }

        public string Task { get; set; }

        public string Comment { get; set; }
    }
}