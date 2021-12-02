using System;
using System.Threading;

namespace no2{ 
 class Program{
 public static void Main(String[] args){
   Console.WriteLine((6*1));
   Thread.Sleep(50);
   Console.WriteLine("X");
   Thread.Sleep(50);
   Console.WriteLine((3*1));
   Thread.Sleep(50);
   Console.WriteLine("=");
   Thread.Sleep(50);
   Console.WriteLine((6*3));
  }
 }
}
