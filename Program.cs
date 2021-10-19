using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Разработать абстрактный класс Animal, который описывает животное. Класс содержит следующие элементы:
//абстрактное свойство - название животного.
//В классе Animal нужно определить следующие методы:
//конструктор, устанавливающий значение по умолчанию для названия;
//абстрактный метод Say(), который выводит звук, который издает животное;
//неабстрактный метод ShowInfo(), который выводит на консоль последовательно название, а затем звук (вызывая метод Say()).
//Разработать классы Cat и Dog, которые реализуют абстрактный класс Animal. В классах реализовать следующие элементы:
//свойство – название животного;
//метод Say(), выводящий на экран «Мяу» либо «Гав» соответственно.
//Создайте экземпляры классов Cat и Dog и проверьте их работоспособность.


namespace Lab_14
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = "Cat";
            Console.WriteLine("Введите Cat или Dog");
            Name = Console.ReadLine();
            Animal say = new Animal(Name);
            Console.WriteLine(say.Say());
            Main(args);
        }
    }
    abstract public class AbstractAnimal
    {
        public abstract string Name { set; get; }
        public string say { set; get; }

        public abstract string Say();
    }
    public class Animal : AbstractAnimal
    {
        public override string Name { set; get; }
        public Animal(string name)
        {
            this.Name = name;
        }
        public override string Say()
        {
            if (Name == "Cat")
            {
                say = "Мяу";
            }
            else
            {
                say = "Гав";
            }
            return string.Format("{0}", say);
        }

    }
}
