

using System.Runtime.CompilerServices;
using static System.Formats.Asn1.AsnWriter;

namespace GradeBook
{
    public class Logic : GradeBookBase
    {
        public Logic(string name, string surname)
            : base(name, surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public override event GradeAddedDelegate GradeAdded;

        public void nameitem()
        {
            var logo = new Item();
            var nam = logo.Equals;
            Console.WriteLine(nam);
        }

        public double RatingWeightScore(double score, double libra)
        {
            double rws = (score * libra);
            return rws;
        }
        public double RatingWeightScoreCoin(float score, double libra, float coinmax)
        {
            double rwsc = (score * libra * coinmax);
            return rwsc;
        }

        public void AverageGrade()
        {
        }

        public void PortfolioValue()
        {
        }

        public override void AddGrade(float grade)
        {
            this.grades.Add(grade);
        }

        public override void AddGrade(int grade)
        {
            throw new NotImplementedException();
        }

        public override void AddGrade(double grade)
        {
            throw new NotImplementedException();
        }

        public override void AddGrade(char itiem, double grade)
        {
            throw new NotImplementedException();
        }


        public static double ItemScoreAdd()
        {
            Item.Mathematics();
            double libra1 = Item.Mathematics();
            double score = 5;
            var logic = new Logic("Jacek", "Jaxiewicz");
            double s = logic.RatingWeightScore(score, libra1);
            Console.WriteLine(s);
            return s;
        }

        public override void ItemScoreAdd(double score)
        {

            Item.Mathematics();
            double libra1 = Item.Mathematics();
            var logic = new Logic("Jacek", "Jaxiewicz");
            double s = logic.RatingWeightScore(score, libra1);
            Console.WriteLine(s);
        }
    }
}
