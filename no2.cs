using System; // removes System from System.Console.ReadLine(); \\
using System.Threading; // removes System from System.Thread.Sleep(ms); \\

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
   public static void Mqin(String[] args){
   bool Echo = true;
   if(Echo == true){
       Console.WriteLine("   6");
       Console.WriteLine("   3");
       Console.WriteLine("X");
       Console.WriteLine("-------");
       Console.WriteLine("   18");
    }
 }
 }
}
