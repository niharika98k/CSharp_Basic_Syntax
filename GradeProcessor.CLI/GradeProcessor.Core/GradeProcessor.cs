namespace GradeProcessor.Core
{
    public class GradeProcessor
    {
        public static double CalculateAvg(List<int> grades)
        {
            if (grades.Count == 0)
            {
                throw new ArgumentException("Empty List");
            }
            return grades.Average();
        }

        public static int CalculateMaxGrade(List<int> grades)
        {
            if (grades.Count == 0)
            {
                throw new ArgumentException("Grades list cannot be empty.");
            }
            return grades.Max();
        }

        public static double CalculateMedianGrade(List<int> grades)
        {
            if (grades.Count == 0)
            {
                throw new ArgumentException("Grades list cannot be empty.");
            }
            var sortedGrades = grades.OrderBy(g => g).ToList();
            int count = sortedGrades.Count;

            if (count % 2 == 1)
            {
                return sortedGrades[count / 2];
            }
            else
            {
                return (sortedGrades[(count / 2) - 1] + sortedGrades[count / 2]) / 2.0;
            }
        }
    }
}
