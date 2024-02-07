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
                    switch (grade)
                        {
                        case 1:
                            grade = 1;
                            break;
                        case 2:
                            grade = 2;
                            break;
                        case 3:
                            grade = 3;
                            break;
                        case 4:
                            grade = 4;
                            break;
                        case 5:
                            grade = 5;
                            break;
                        case 6:
                            grade = 6;
                            break;
                    }
                    writer.Write(itiem);
                    writer.WriteLine(grade);

                    if (GradeAdded != null)
                    {
                        GradeAdded(this, new EventArgs());
                    }
                }
                else
                {
                    //throw new Exception("Number out of range 0-100");
                }
        }

        public override void AddGrade(char itiem, string grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                //if (grade >= 1 && grade <= 6)
                // {
                switch (grade)
                {
                    case "1":
                        grade = "1";
                        break;
                    case "1+":
                        grade = "1,49";
                        break;
                    case "-2" or "2-":
                        grade = "1,51";
                        break;
                    case "2":
                        grade = "2";
                        break;
                    case "2+" or "+2":
                        grade = "2,29";
                        break;
                    case "-3" or "3-":
                        grade = "2,59";
                        break;
                    case "3":
                        grade = "3";
                        break;
                    case "+3" or "3+":
                        grade = "3,49";
                        break;
                    case "-4" or "4-":
                        grade = "3,51";
                        break;
                    case "4":
                        grade = "4";
                        break;
                    case "+4" or "4+":
                        grade = "4,49";
                        break;
                    case "-5" or "5-":
                        grade = "4,51";
                        break;
                    case "5":
                        grade = "5";
                        break;
                    case "+5" or "5+":
                        grade = "5,49";
                        break;
                    case "-6" or "6-":
                        grade = "5,51";
                        break;
                    case "6":
                        grade = "6";
                        break;
                }
                writer.Write(itiem);
                writer.WriteLine(grade);

                //if (GradeAdded != null)
                //{
                //    GradeAdded(this, new EventArgs());
                //}

                //else
                //{
                //    throw new Exception("Number out of range 0-100");
                //}
            }
        }
    //  }

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
