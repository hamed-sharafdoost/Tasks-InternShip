using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDap.Task2.SecondQuestion
{
    public class HugeInteger
    {
        public int Sign { get; set; }
        int lengthOfResult_Add = 0;
        public int[] Number;
        public int Length;
        string words = "0123456789";
        public HugeInteger()
        {
            Number = new int[1];
        }
        public HugeInteger(string number)
        {
            int i = 0;
            if (number.Length > 40 || (number[0] != '+' && number[0] != '-'))
            {
                Console.WriteLine("Please insert the number in a correct form");
            }
            else
            {
                Number = new int[41];
                Number[0] = number[0];
                foreach (char word in number.Skip(1).Take(number.Length))
                {
                    if (words.Contains(word))
                    {
                        i++;
                        this.Number[i] = (word - '0');
                    }
                    else
                    {
                        Console.WriteLine("Enter the number in a correct form");
                        break;
                    }
                }
                Sign = number[0] == '+' ? 1 : -1;
            }
            Length = number.Length - 1;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var i in Number.Skip(1).Take(Length))
            {
                sb.Append(i);
            }
            return sb.ToString();
        }
        public bool Equals(HugeInteger number2)
        {
            return this.ToString().Equals(number2.ToString());
        }
        public bool IsGreaterThan(HugeInteger number2)
        {
            //Ascci code of + is 43 and for - is 45
            if (Number[0] < number2.Number[0])
                return true;
            //Check if the sign of numbers and their lengths are equal
            else if (Number[0] == number2.Number[0] && Length == number2.Length)
            {
                for (int j = 1; j < Length; j++)
                {
                    if (Number[j] > number2.Number[j])
                        return true;
                    else
                        return false;
                } 
            }
            else if (Number[0] == number2.Number[0] && Length > number2.Length)
                return true;
            return false;
        }
        public bool IsLessThan(HugeInteger number2)
        {
            int check = 0;
            //Ascci code of + is 43 and for - is 45
            if (Number[0] > number2.Number[0])
                return true;
            if (Number[0] == number2.Number[0] && Length == number2.Length)
            {
                for (int j = 1; j < Length; j++)
                {
                    if (Number[j] < number2.Number[j])
                        return true;
                    else
                        return false;
                }
            }
            else if (Number[0] == number2.Number[0] && Length < number2.Length)
                return true;
            return false;
        }
        public bool IsZero()
        {
            if (Number[1] == 0)
                return true;
            return false;
        }
        public int[] Add(HugeInteger number2)
        {
            int maxlength = Math.Max(Length, number2.Length);
            int minlength = Math.Min(Length, number2.Length);
            int[] result = new int[41];
            int[] longnum = new int[maxlength];
            int[] shortnum = new int[minlength];
            int carriage = 0;
            int counter = 40;
            if (maxlength == Length)
            {
                longnum = Number.Skip(1).Take(maxlength+1).ToArray();
                shortnum = number2.Number.Skip(1).Take(minlength+1).ToArray();
            }
            else
            {
                longnum = number2.Number.Skip(1).Take(maxlength + 1).ToArray();
                shortnum = Number.Skip(1).Take(minlength+1).ToArray();
            }
            for (int i = maxlength-1,j = minlength-1; i >=0 || j >=0; i--,j--)
            {
                var plus = 0;
                if (j < 0)
                {
                    plus = longnum[i] + carriage;
                    if (plus >= 10)
                    {
                        result[counter] = plus - 10;
                        carriage = 1;
                        counter--;
                    }
                    else
                    {
                        result[counter] = plus;
                        carriage = 0;
                        counter--;
                    }
                }
                else
                {
                    plus = longnum[i] + shortnum[j] + carriage;
                    if (plus >= 10)
                    {
                        result[counter] = plus - 10;
                        carriage = 1;
                        counter--;
                    }
                    else
                    {
                        result[counter] = plus;
                        carriage = 0;
                        counter--;
                    }
                }
            }
            if (carriage == 1)
                result[counter] = 1;
            lengthOfResult_Add = 41-counter;
            return result;
        }
        public int[] Subtract(HugeInteger number2)
        {
            int maxlength = Math.Max(Length, number2.Length);
            int carriage = 1;
            int[] result = new int[41];
            //Get the second complement of the number2 if Length of numbers are equal
            if (Length == number2.Length)
            {
                for (int i = number2.Length; i >= 1; i--)
                {
                    var plus = 9 - number2.Number[i] + carriage;
                    if (plus >= 10)
                    {
                        number2.Number[i] = plus - 10;
                        carriage = 1;
                    }
                    else
                    {
                        number2.Number[i] = plus;
                        carriage = 0;
                    }
                }
            }
            else if(Length > number2.Length)
            {
                var diff = Length - number2.Length;
                for(int j = number2.Length; j >=1;j--)
                {
                    number2.Number[j+diff] = number2.Number[j];
                    number2.Number[j] = 0;
                }
                for(int i = maxlength; i >= 1;i--)
                {
                    var plus = 9 - number2.Number[i] + carriage;
                    if (plus >= 10)
                    {
                        number2.Number[i] = plus - 10;
                        carriage = 1;
                    }
                    else
                    {
                        number2.Number[i] = plus;
                        carriage = 0;
                    }
                }
                number2.Length = Length;
                Console.Write("+");
            }
            else
            {
                var diff = number2.Length - Length;
                for(int j = Length; j >=1;j--)
                {
                    Number[j+diff] = Number[j];
                    Number[j] = 0;
                }
                Length = number2.Length;
                Console.Write("-");
                number2.Subtract(this);
            }
            //Add number to number2
            result = this.Add(number2);
            if (lengthOfResult_Add > maxlength)
            {
                result[41-lengthOfResult_Add] = 0;
            }
            else
            {
                for (int i = 40; i > lengthOfResult_Add; i--)
                {
                    result[i] = 10 - result[i];
                }
            }
            return result;
        }
    }
}
