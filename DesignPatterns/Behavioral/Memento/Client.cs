﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._3_5._07._2024.DesignPatterns.Behavioral.Memento
{
    internal class Client
    {
        public static void Execute()
        {
            var person = new Person();
            //var caretaker = new Caretaker<Person>(person);
            var caretaker = new AutoCaretaker<Person>(person);

            person.FirstName = "Ewa";
            person.LastName = "Ewowska";
            Console.WriteLine(person);
            //caretaker.SaveState();

            Thread.Sleep(1500);

            person.FirstName = "Monika";
            Console.WriteLine(person);
            //caretaker.SaveState();

            Thread.Sleep(1500);

            person.LastName = "Monikowska";
            Console.WriteLine(person);
            //caretaker.SaveState();

            Thread.Sleep(1500);

            person.LastName = "";
            Console.WriteLine(person);

            caretaker.RestoreState();
            Console.WriteLine(person);

            caretaker.RestoreState(DateTime.Now.AddSeconds(-4));
            Console.WriteLine(person);
        }
    }
}
