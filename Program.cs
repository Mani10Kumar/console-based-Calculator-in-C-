using System;
namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
         int i,n,sum=0,rule,sub,mul,div;
        r:
         Console.WriteLine("WELCOME IN Calculator");
         Console.WriteLine("Rules:-");
        
         Console.WriteLine("If you want to \nAdd write =1\nSub =2\nMul =3\nDiv =4");
         rule=Convert.ToInt32(Console.ReadLine());
         switch(rule)
         {
             case 1:
             Console.WriteLine("Enter how much didgit you want ");
         n=Convert.ToInt32(Console.ReadLine());
         int[] arr=new int[n];
        
         Console.WriteLine("Enter {0} digits:-",n);
         for(i=0;i<n;i++)
         {
             Console.Write("digit {0} =",i);
             arr[i]=Convert.ToInt32(Console.ReadLine());
         }
         Console.WriteLine("Output: ");
         for(i=0;i<n;i++)
         {
             sum=sum+arr[i];
             
         }
         Console.Write("{0} ",sum);
         Console.WriteLine("\n");
         goto r;
         break;    
         case 2:
         int a,b;
         Console.WriteLine("Enter didgit for substraction");
         Console.WriteLine("Enter first digit:- ");
         a=Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Enter Second digit:- ");
         b=Convert.ToInt32(Console.ReadLine());
         sub=a-b;
         Console.WriteLine(sub);
         goto r;
         break;
         case 3:
         int c,d;
         Console.WriteLine("Enter didgit for Multiplication");
         Console.WriteLine("Enter first digit:- ");
         c=Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Enter Second digit:- ");
         d=Convert.ToInt32(Console.ReadLine());
         mul=c*d;
         Console.WriteLine(mul);
         goto r;
         break;
         case 4:
         int e,f;
         Console.WriteLine("Enter didgit for diviision");
         Console.WriteLine("Enter first digit:- ");
         e=Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Enter Second digit:- ");
         f=Convert.ToInt32(Console.ReadLine());
         div=e/f;
         Console.WriteLine(div);
         goto r;
         break;
         default:
         Console.WriteLine("Enter between 1 to 4");
         goto r;
         break;
         }
          
        }
    }
}
