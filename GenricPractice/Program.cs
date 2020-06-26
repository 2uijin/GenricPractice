using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenricPractice
{
    class Wanted<T> {
        public T Value;
        public Wanted(T value) {
            this.Value = value;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Wanted<string> wantedString = new Wanted<string>("사물함에서 오이냄시 나지 않을까?");
            Wanted<int> wantedint = new Wanted<int>(2);
            Wanted<double> wanteddouble = new Wanted<double>(00.564);
            Console.WriteLine("문자열 : " + wantedString.Value);
            Console.WriteLine("정수 : " + wantedint.Value);
            Console.WriteLine("실수 : " + wanteddouble.Value);

        }
    }
}
