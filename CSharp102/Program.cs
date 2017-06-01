using System;

namespace CSharp102
{
    class Program
    {
        static void Main(string[] args)
        {   
            if(true){
                Console.WriteLine("Hmm... This looks like a redundant conditional...");
            }

            for(int i=0;i<100;i++){

                Console.WriteLine("Hey look! I made a loop!");

            }
            int j = 4;
            do{
                Console.WriteLine("I shouldn't be here, but hey! this is a do-while loop!");
            }
            while(j<4);
        }
    }
}
