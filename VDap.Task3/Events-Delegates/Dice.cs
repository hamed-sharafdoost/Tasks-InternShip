using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDap.Task3.Events_Delegates
{
    public class Dice
    {
        private int number;
        private int six_in_a_row;
        public event EventHandler<CustomArgs> moreThan3;
        public event EventHandler<CustomArgs> sixInaRow;
        public void Roll()
        {
            number = new Random().Next(1,7);
            if (number == 6)
            {
                six_in_a_row++;
                if(six_in_a_row == 2)
                {
                    CustomArgs args = new CustomArgs();
                    args.SixInARow = six_in_a_row;
                    OnSixInaRow(args);
                }
            }
            if(number > 3)
            {
                CustomArgs args = new CustomArgs();
                args.MoreThan3 = number;
                OnMoreThan3(args);
            }

        }
        protected virtual void OnMoreThan3(CustomArgs args)
        {
            EventHandler<CustomArgs> handler = moreThan3;
            if(handler != null)
                handler(this,args);
        }
        protected virtual void OnSixInaRow(CustomArgs args)
        {
            EventHandler<CustomArgs> handler = sixInaRow;
            if (handler != null)
                handler(this, args);
        }
    }
    public class CustomArgs : EventArgs
    {
        public int SixInARow { get; set; }
        public int MoreThan3 { get; set; }
    }
}
