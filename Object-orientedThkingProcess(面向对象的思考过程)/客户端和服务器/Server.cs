using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Xml.Serialization;

namespace Object_orientedFourElements.客户端和服务器
{
    public class Server
    {
        public Server()
        {
            TcpListener server = null;
            TcpClient client = null;
            try
            {
                server = new TcpListener(IPAddress.Parse("127.0.0.1"), 11111);
                server.Start();

                // 设置输入缓冲区
                var bytes = new Byte[256];

                // 无限循环
                while (true)
                {
                    // 以阻塞模式获取到来的请求
                    client = server.AcceptTcpClient();
                    Console.WriteLine("Connected!");

                    // 打开流
                    var networkStream = client.GetStream();
                    // 从流中获取数据
                    int i;
                    while ((i = networkStream.Read(bytes, 0, bytes.Length)) != 0)
                    {
                        // 准备一个支持序列化器的流
                        var memoryStream = new MemoryStream(bytes);
                        // 准备序列化器
                        var xmlSerializer = new XmlSerializer(typeof(CheckingAccount));
                        // 从流中创建CheckingAccount对象
                        var account = (CheckingAccount) xmlSerializer.Deserialize(memoryStream);
                        // 现在演示确实创建了对象
                        Console.WriteLine($"Name: {account.Name}, Account Number: {account.AccountNumber}.");
                        // 抛出异常从而退出循环
                        throw new Exception("ignore");
                    }
                }
            }
            catch (Exception e)
            {
                if (!e.Message.Equals("ignore"))
                    Console.WriteLine(e);
            }
            finally
            {
                // 关闭资源
                client?.Close();
                server?.Stop();
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}