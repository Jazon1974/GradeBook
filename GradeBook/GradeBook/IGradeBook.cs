using static GradeBook.GradeBookBase;

namespace GradeBook
{
    public interface IGradeBook
    {
        string Name { get; }
        string Surname { get; }

        void AddGrade(float grade);

        void AddGrade(int grade);

        void AddGrade(double grade);

        event GradeAddedDelegate GradeAdded;


    }
}
