using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13
{
     abstract class People : Creatures , IMove
    {
        public void Move()
        {
            Console.WriteLine("I can Move");
        }


        public void Eat()
        {
            Console.WriteLine("i csn Eat");

        }


        public void Sleep()
        {
            Console.WriteLine("I can sleep");

        }




























        string Name;
        int Age;
        int SNN;
        string Address;



        public People(string Name , int Age , int SNN, string Address)
        {
            this.Name = Name;
            this.Age = Age;
            this.SNN = SNN;
            this.Address = Address;

            
        }
        public override string ToString()
        {
            return $"your name :{Name} your age is{Age} your snn is {SNN} and your adress {Address}";

        }
    }
}
