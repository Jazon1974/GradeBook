


using Microsoft.VisualBasic;
using static System.Formats.Asn1.AsnWriter;

namespace GradeBook
{
    public class Logic()
    {
        public double RatingWeightScore(float score, double libra, float coinmax)
        {

            double rws = (score * libra * coinmax);
            return rws;
        }
        public void  AverageGrade()
        {

        }

        public void PortfolioValue()
        { 
        
        }



    }
}
