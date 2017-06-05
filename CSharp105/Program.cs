using System;

namespace CSharp105
{	
    public struct coffee{
    
	public int strength;
	public String Bean;

	public coffee(int strength, String Bean){
	
		this.strength = strength;
		this.Bean = Bean;
	
	}
    
    }

    class Program
    {
        static void Main(string[] args)
        {	
	    coffee espresso = new coffee(100,"cocoa");

            Console.WriteLine(espresso.Bean);
        }
    }
}
