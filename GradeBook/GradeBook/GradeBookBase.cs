
namespace GradeBook
{
    public abstract class GradeBookBase : IGradeBook
    {
        public delegate void GradeAddedDelegate(object sender, EventArgs args);

        public abstract event GradeAddedDelegate GradeAdded;

        public List<float> grades = new List<float>();

        public GradeBookBase(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
        public abstract void ItemScoreAdd(double score);

        public string Name { get; set; }

        public string Surname { get; set; }

        public abstract void AddGrade(char itiem, double grade);


        public abstract void AddGrade(char itiem, string grade);

        public abstract void AddGrade(float grade);

        public abstract void AddGrade(int grade);

        public abstract void AddGrade(double grade);


    }
}
