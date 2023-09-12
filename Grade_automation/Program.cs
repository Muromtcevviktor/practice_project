using System;

namespace GradeAutomation
{
    class Program
    {
        public static void Main(string[] args)
        {
 
            int sophia1 = 93;
            int sophia2 = 87;
            int sophia3 = 98;
            int sophia4 = 95;
            int sophia5 = 100;
            string sophiaGrade;
              

            int sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
            decimal sophiaScore = sophiaSum / 5m;
  if(sophiaScore > 97)
                    {
                 sophiaGrade = "A+";
                    }
                        else if(sophiaScore > 93 && sophiaScore < 96)
                        {   
                            sophiaGrade = "A";
                        }
                        else if(sophiaScore > 90 && sophiaScore < 92)
                        {
                            sophiaGrade = "B";
                        }
                        else if(sophiaScore > 87 && sophiaScore < 89)
                        {
                            sophiaGrade = "B+";
            }
            else
            {
                sophiaGrade= "C";
            };

            Console.WriteLine($"Sophia: {sophiaScore}\t{sophiaGrade}");
            
            int nicolas1 = 80;
            int nicolas2 = 83;
            int nicolas3 = 82;
            int nicolas4 = 88;
            int nicolas5 = 85;

            int nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
            decimal nicolasScore = nicolasSum / 5m;
            Console.WriteLine($"Nicolas: {nicolasScore}");

            int zahirah1 = 84;
            int zahirah2 = 96;
            int zahirah3 = 73;
            int zahirah4 = 85;
            int zahirah5 = 79;

            int zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
            decimal zahirahScore = zahirahSum / 5m;
            Console.WriteLine($"Zahirah: {zahirahScore}");

            int jeong1 = 90;
            int jeong2 = 92;
            int jeong3 = 98;
            int jeong4 = 100;
            int jeong5 = 97;

            int jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;
            decimal jeongScore = jeongSum / 5m;
            Console.WriteLine($"Jeong: {jeongScore}");


            Console.Read();

        }


    }
}
