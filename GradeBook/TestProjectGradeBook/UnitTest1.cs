using GradeBook;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks.Sources;

namespace TestProjectGradeBook
{
    public class Tests
    {


        [Test]
        public void RatingWeightScoreCoinTest()
        {
            //arrange
            var rat = new Logic("Jacek","Jaxiewicz");
            float score = 5;
            double libra = 1.8;
            float coinmax = 30;
            //act

            //assert
            double result = rat.RatingWeightScoreCoin(score, libra, coinmax);
            Assert.AreEqual(270, result);
        }
        [Test]
        public void RatingWeightScoreTest()
        {
            //arrange
            var rat = new Logic("Jacek","Jaxiewicz");
            float score = 5;
            double libra = 1.8;
            //act

            //assert
            double result = rat.RatingWeightScore(score, libra);
            Assert.AreEqual(9, result);
        }
    }
}