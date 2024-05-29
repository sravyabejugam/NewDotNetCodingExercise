namespace CodingExercise.Utilities
{
    public class Division : IDivision
    {
        public bool DivideByNumber(int value1, int value2)
        {
            if(value1 % value2 == 0)
            {
                return true;
            }

            return false;
        }
    }
}
