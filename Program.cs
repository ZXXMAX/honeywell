using ConsoleApp1.ActivityRef;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace ConsoleApp1
{
    class Program
    {
        private static readonly ActivityRef.AppServicesClient proxy = new ActivityRef.AppServicesClient();

        static void Main(string[] args)
        {
            Console.WriteLine("===== 活动模板管理系统 =====");

            while (true)
            {
                Console.WriteLine("\n请选择操作:");
                Console.WriteLine("1. 获取活动列表");
                Console.WriteLine("6. 退出");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        
                        break;
                    case "6":
                        Console.WriteLine("感谢使用系统，再见！");
                        return;
                    default:
                        Console.WriteLine("无效的选项，请重新输入。");
                        break;
                }
            }
        }


    }
}
