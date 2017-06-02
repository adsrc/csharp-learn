using System;

namespace CSharp103
{
    class Program
    {	
	public static bool multiReturn(out int i,out int j){
		
		i=0;
		j=1;
		return true;
	
	}


        static void Main(string[] args)
        {   int k,l;
            Console.WriteLine("Hello World!");
	    multiReturn(out k,out l);
	    Console.WriteLine("{0},{1}",k.ToString(),l.ToString());

        }
    }
}
