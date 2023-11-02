using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDap.Task3.GenericMethods_Classes
{
    public class Pair<T,U>
    {
        public T FirstVariable { get; set; }
        public U SecondVariable { get; set; }
        public Pair(T first,U second)
        {
            FirstVariable = first;
            SecondVariable = second;
        }
        public override string ToString()
        {
            return "FirstVariable is : {" + FirstVariable.ToString() + "} SecondVariable is : {" + SecondVariable.ToString() + "}";
        }
        public Pair<U,T> Swap()
        {
            return new Pair<U, T>(SecondVariable, FirstVariable);
        }
    }
}
