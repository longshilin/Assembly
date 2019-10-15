using System;
using System.Net.Sockets;
using System.Xml.Serialization;

namespace Object_orientedFourElements.客户端和服务器
{
    public class Client
    {
        public static void Connect()
        {
            var checkingAccount = new CheckingAccount();
            try
            {
                // 创建TCP套接字
                TcpClient client = new TcpClient("127.0.0.1", 11111);
                // 准备将CheckingAccount对象序列化到XML中
                var xmlSerializer = new XmlSerializer(typeof(CheckingAccount));
                // 创建TCP流
                var networkStream = client.GetStream();
                // 序列化对象到TCP流
                xmlSerializer.Serialize(networkStream, checkingAccount);
                // 关闭所有资源
                networkStream.Close();
                client.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}