using System.Xml.Serialization;

namespace Object_orientedFourElements.序列化和反序列化
{
    [XmlRoot("person")]
    public class Person
    {
        private string strName;
        private int intAge;
        private int intScore;

        public Person()
        {
            strName = "John Doe";
            intAge = 25;
            intScore = 50;
        }

        public Person(string name, int age, int score)
        {
            Name = name;
            Age = age;
            Score = score;
        }

        [XmlAttribute("name")]
        public string Name
        {
            get => strName;
            set
            {
                if (value == null) return;
                strName = value;
            }
        }

        [XmlAttribute("age")]
        public int Age
        {
            get { return intAge; }
            set { intAge = value; }
        }

        [XmlIgnore]
        public int Score
        {
            get { return intScore; }
            set { intScore = value; }
        }
    }
}