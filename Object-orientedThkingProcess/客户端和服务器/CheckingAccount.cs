using System;
using System.Xml;
using System.Xml.Serialization;

namespace Object_orientedFourElements.客户端和服务器
{
    [XmlRoot("account")]
    public class CheckingAccount
    {
        private string _Name;
        private int _AccountNumber;

        [XmlElement("name")]
        public string Name
        {
            get => _Name;
            set => _Name = value;
        }

        [XmlElement("account_num")]
        public int AccountNumber
        {
            get => _AccountNumber;
            set => _AccountNumber = value;
        }

        public CheckingAccount()
        {
            _Name = "John Doe";
            _AccountNumber = 54321;
            Console.WriteLine("Creating Checking  Account!");
        }
    }
}