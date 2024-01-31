using GradeBook;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks.Sources;

namespace TestProjectGradeBook
{
    public class Tests
    {


        [Test]
        public void Test1()
        {
            //arrange
            var rat = new Logic();
            float score = 5;
            double libra = 1.8;
            float coinmax = 30;
            //act

            //assert

            double result = rat.RatingWeightScore(score, libra, coinmax);


            Assert.AreEqual(120, result);
        }
    }
}