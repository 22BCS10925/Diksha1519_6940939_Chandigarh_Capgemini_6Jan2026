using System.Text;

namespace CollegeManagement
{
    public class Program
    {
        class CollageManagement
        {
            Dictionary<string, Dictionary<string, int>> studentRecords = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, LinkedList<KeyValuePair<string, int>>> studentSubjectsOrder = new Dictionary<string, LinkedList<KeyValuePair<string, int>>>();


            Dictionary<string, Dictionary<string, int>> subjectsRecords = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, LinkedList<KeyValuePair<string, int>>> subjectsStudentsOrder = new Dictionary<string, LinkedList<KeyValuePair<string, int>>>();

            public int AddStudent(string studentId, string subject, int marks)
            {
                if (!studentRecords.ContainsKey(studentId))
                {
                    studentRecords[studentId] = new Dictionary<string, int>();
                }
                if (!studentRecords[studentId].ContainsKey(subject) || marks > studentRecords[studentId][subject])
                {
                    studentRecords[studentId][subject] = marks;
                }
                return 1;

            }

            public int RemoveStudent(string studentId)
            {
                if (studentRecords.ContainsKey(studentId))
                {
                    studentRecords.Remove(studentId);
                }
                return -1;

            }

            public string TopStudent(string subject)
            {
                if (!subjectsRecords.ContainsKey(subject) ||
                 subjectsRecords[subject].Count == 0)
                    return "";

                int maxMarks = subjectsRecords[subject].Values.Max();

                StringBuilder sb = new StringBuilder();

                // print in insertion order (tie rule)
                foreach (var pair in subjectsStudentsOrder[subject])
                {
                    if (pair.Value == maxMarks)
                    {
                        sb.AppendLine(pair.Key + " " + pair.Value);
                    }
                }

                return sb.ToString().Trim();
            }

            public string Result()
            {
                var result = studentRecords.Select(s => new
                {
                    StudentId = s.Key,
                    Avg = s.Value.Average(x => x.Value)
                }).Select(x => $"{x.StudentId} {x.Avg}");

            
            return string.Join("\n", result);
        }
        }
        public static void Main(String[] args)
        {
            CollageManagement cm = new CollageManagement();

            // Sample Input Simulation
            cm.AddStudent("S1", "Math", 80);
            cm.AddStudent("S2", "Math", 90);
            cm.AddStudent("S3", "Math", 90);
            cm.AddStudent("S1", "Phy", 90);

            Console.WriteLine(cm.TopStudent("Math"));
            Console.WriteLine(cm.Result());

            cm.RemoveStudent("S1");

        }
    }
}
