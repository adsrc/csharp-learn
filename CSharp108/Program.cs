using System;

namespace CSharp108
{
    public class Program
    {
	private int age;

	public string Name { get; set; }
	public int Age {
		get{
			
			return age; 
			
		}

		set{
		
			age = value;
		
		}
	}


        static void Main(string[] args)
        {
		
		var myProgram = new Program();
		myProgram.Age = 24;
		myProgram.Name = "John";

		Console.WriteLine(myProgram.Age);

        }
    }
}
