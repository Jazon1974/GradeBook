namespace GradeBook
{
    public class EmployeeInFile : GradeBookBase
    {
        public override event GradeAddedDelegate GradeAdded;

        private const string fileName = "GradeBook.txt";

        public EmployeeInFile(string name, string surname)
            : base(name, surname)
        { 
        }

        public override void AddGrade(char itiem, double grade)
        {
            using (var writer = File.AppendText(fileName))

                if (grade >= 1 && grade <= 6)
                {
                    writer.Write(itiem);
                    writer.WriteLine(grade);

                    if (GradeAdded != null)
                    {
                        GradeAdded(this, new EventArgs());
                    }
                }
                else
                {
                    throw new Exception("Number out of range 0-100");
                }
        }

        public override void AddGrade(int grade)
        {
            float result = (float)grade;
            AddGrade(result);
        }

        public override void AddGrade(double grade)
        {
            float result = (float)grade;
            AddGrade(result);
        }

        public override void AddGrade(float grade)
        {
        }

        public override void ItemScoreAdd(double score)
        {
            throw new NotImplementedException();
        }
    }
}
