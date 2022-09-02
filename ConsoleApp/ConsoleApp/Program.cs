using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = null;
            //警告:零废弃。
            Console.WriteLine($"消息的长度为: {message.Length}");

            var originalMessage = message;
            message = "Hello World!";

            //没有警告。分析确定“消息”不是空的。
            Console.WriteLine($"消息的长度为: {message.Length}");

            //警告
            Console.WriteLine(originalMessage.Length);


            Console.ReadLine();
        }
    }
}
