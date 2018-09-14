using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using System.Runtime.InteropServices;
namespace ConsoleApp2
{
    class Program
    {
        [DllImport("msvcrt")]
        static extern int _getch();
        public static int sw = 0;
        static void FirstMode()
        {
            PerformanceCounter ram = new PerformanceCounter("Memory", "% Committed Bytes In Use");
            Console.Write("       " + "ОЗУ: " + (int)ram.NextValue() + " % ["); 
            for (int i = 0; i<33; i++)
            {
                if (((double)ram.NextValue() / 3.3) > i)
                    Console.Write("|");
                else
                    Console.Write(".");
            }
            Console.WriteLine("]");
            Console.WriteLine();
            PerformanceCounter cpu = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");
            for(int i = 0; i< 6; i++)
            {
                Console.Write("|");
                int cp = (int)cpu.NextValue();
                for (int j = 0; j<50; j++)
                {
                    if((cp/2)>j)
                    {
                        Console.Write("|");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
                Console.WriteLine("  " + "ЦПУ: " + cp + "%");
                Thread.Sleep(50);
                Console.WriteLine("|");
                Thread.Sleep(50);
            }
        }
        static void SecondMode()
        {
            Console.WriteLine("{0,-35}{1,-15}{2,-15}{3,-15}", "|      Процесс", "|   ID", "|   ЦПУ", "|   ОЗУ");
            for(int i = 0; i<74; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
            foreach (Process process in Process.GetProcesses())
            {
                PerformanceCounter pr = new PerformanceCounter("Process", "% Processor Time", process.ProcessName);
                int ram = (int)process.PrivateMemorySize64 / 1000000;
                double cpu = pr.NextValue();
                int id = (int)process.Id;
                string name = process.ProcessName;
                if(id != 0 && id != 4)
                {
                    Console.WriteLine("{0,-35}{1,-15}{2,-15}{3,-15}", "|      " + name, "|   " + id, "|   " + cpu, "|   " + ram + "MB");
                }
            }
        }

        static void select()
        {
            Console.WriteLine("Выберите режим:");
            Console.WriteLine("1. Загрузка ЦПУ и ОЗУ");
            Console.WriteLine("2. Отображение процессов");
            Console.WriteLine("3. Оба варианта");
            sw = _getch();
            while (sw > 51 || sw < 48)
            {
                Console.WriteLine("Введите заново: ");
                sw = _getch();
            }
            Console.Clear();
            switch(sw)
            {
                case 49:
                    m1:
                    FirstMode();
                    Thread.Sleep(3000);
                    Console.Clear();
                    goto m1;
                    break;
                case 50:
                    m2:
                    SecondMode();
                    Thread.Sleep(7000);
                    Console.Clear();
                    goto m2;
                    break;
                case 51:
                    m3:
                    FirstMode();
                    Console.WriteLine();
                    Console.WriteLine();
                    SecondMode();
                    Thread.Sleep(10000);
                    Console.Clear();
                    goto m3;
                    break;
            }
        }
        static void Main(string[] args)
        {
            select();
        }
    }
 }     
