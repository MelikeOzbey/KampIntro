using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<int, string> mylist = new Dictionary<int, string>();

            Person person1 = new Person
            {
                Id = 1,
                Name = "Melike Özbey"
            };

            Person person2 = new Person
            {
                Id = 2,
                Name = "Ayşe Yılmaz"
            };

            //mylist.Add(person.Id, person.Name);

            MyDictionary<int,string> myDictionaryList = new MyDictionary<int, string>();
            myDictionaryList.Add(person1.Id, person1.Name);
            myDictionaryList.Add(person2.Id, person2.Name);

            Console.WriteLine(myDictionaryList.Count);
            myDictionaryList.List();
        }
    }
}
