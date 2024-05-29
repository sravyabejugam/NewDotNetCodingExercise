using CodingExercise.Utilities;
using System.Collections;

namespace CodingExercise.Services
{
    public class FizzBuzz : IFizzBuzz
    {
        ArrayList arrlist2 = new ArrayList();

        private readonly IDivision _division;

        public FizzBuzz(IDivision division)
        {
            _division = division;
        }

        public ArrayList GetandPost(ArrayList arr)
        {
            int numeric;
            int val1 = Constants.val1, val2 = Constants.val2;
            string str1, str2;
            foreach (var item in arr)
            {
                if (item == null)
                {
                    arrlist2.Add(Constants.invalid);
                }

                else 
                {
                    if (int.TryParse(item.ToString(), out numeric))
                    {
                        if ((_division.DivideByNumber(numeric, val1)) && (_division.DivideByNumber(numeric, val2)))   

                        {
                            arrlist2.Add(Constants.fizbuz);
                        }
                        else if (_division.DivideByNumber(numeric, val1))
                        {
                            arrlist2.Add(Constants.fizz);
                        }
                        else if (_division.DivideByNumber(numeric, val2))
                        {
                            arrlist2.Add(Constants.buzz);
                        }
                        else
                        {
                            str1 = string.Format($"Divided {numeric} by {val1}");
                            str2 = string.Format($"Divided {numeric} by {val2}");
                            arrlist2.Add(str1);
                            arrlist2.Add(str2);
                        }

                    }

                    else
                    {
                        arrlist2.Add(Constants.invalid);
                    }


                }
                
            }

            return arrlist2;

        }
  
    }
}
