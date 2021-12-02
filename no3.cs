using System;
using System.Threading;

namespace no3{
 class Program{
  public static void Main(String[] args){
   int muarrem = 50;
   Console.WriteLine("md ReplitBrowser C:/Progra~1");
   Thread.Sleep(muarrem);
   Console.WriteLine("md ReplitData C:/Progra~1/ReplitBrowser");
   Thread.Sleep(muarrem);
   Console.WriteLine("mkdir yourtext.txt C:/Progra~1/ReplitBrowser");
  }
 }
}
