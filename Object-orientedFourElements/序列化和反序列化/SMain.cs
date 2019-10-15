using System;
using System.IO;
using System.Xml.Serialization;

namespace Object_orientedFourElements.序列化和反序列化
{
    public class SMain
    {
        static void Main(string[] args)
        {
            var sMain = new SMain();
        }


        public SMain()
        {
            Serialize();
            DeSerialize();
        }

        private void Serialize()
        {
            var persons = new Person[3];
            persons[0] = new Person("John", 32, 65);
            persons[1] = new Person("Joe", 12, 32);
            persons[2] = new Person("Jike", 43, 95);
            var xmlSerializer = new XmlSerializer(typeof(Person[]));
            var streamWriter = new StreamWriter("person.xml");
            xmlSerializer.Serialize(streamWriter, persons);
            streamWriter.Close();
        }

        private void DeSerialize()
        {
            Person[] restoredPeople;
            var xmlSerializer = new XmlSerializer(typeof(Person[]));
            var streamReader = new StreamReader("person.xml");
            restoredPeople = (Person[]) xmlSerializer.Deserialize(streamReader);
            Console.WriteLine("My People restored:");
            foreach (var listPerson in restoredPeople)
            {
                Console.WriteLine($"{listPerson.Name} is {listPerson.Age} years old.");

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}