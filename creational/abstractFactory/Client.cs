using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace abstractFactory
{
    public class Client
    {
        ISuv suv;
        ISedan sedan;

        public Client(ISuv suv, ISedan sedan)
        {
            this.suv = suv;
            this.sedan = sedan;
        }

        public void GetSuv()
        {
            System.Console.WriteLine(suv.ShowDetails());
        }

        public void GetSedan()
        {
            System.Console.WriteLine(sedan.ShowDetails());
        }
    }
}