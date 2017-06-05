using System;

/*
	structs are semantically different from classes.
	
	They are "value type" objects, derived from System.ValueType.
	Classes are "reference type" objects.
	
	Structs are more useful to avoid unnecessary memory allocation
	in case of a not-so-complex data type (think points and colors)
	
	They can be declared without the "new" keyword.

	Structs cannot be instantiated using default constructors. They
	need parametrised constructors.

	They cannot follow inheritance. However, like classes, they can 
	implement interfaces.

	When structs are copied, they are reassigned instead of a change
	in reference (think deep copy in python)

	Struct can be used as a nullable type and can be assigned null 
	value.***
*/



namespace CSharp107
{
 	public struct coOrd{
		
		public int x;
		public int y;

		public coOrd(int f,int s){
		
			this.x = f;
			this.y = s;
		
		}

		public static void Main(string [] args){
			
			// takeaway : instance of a struct can be just
			// declared and variables can be declared later
			// + struct can have a main method and overall
			// function like a class!

			coOrd myPoint;
			myPoint.x = 3;

			Console.WriteLine(myPoint.x);
			// Uncomment the line below to see an error!
			// HINT: Uninitialzed field
			// Console.WriteLine(myPoint.y) ;
		
		
		}
	
	
	}

	
	
}
