using System;

namespace CSharp106
{
    public class Program
    {	
	public static void Main(string[] args){
	
		List myList = new List(3);
		for(int i=0;i<myList.flowers.Length;i++){
			
			Console.WriteLine(myList.flowers[i]+" ");
		
		}
		Console.WriteLine("\n");
		
		myList.flowers[0] = "JASMINE";

		for(int i=0;i<myList.flowers.Length;i++){
		
			Console.WriteLine(myList.flowers[i]+" ");
		
		}


	}
	

	
    }

    public struct List{
    
    	public string[] flowers;
	
	public List(int a){
			
		this.flowers = new string[] {"Lotus","Rose","Hibiscus"};
		
	}


	public string this[int index]
	{
		get{ return this.flowers[index];}
		set{ this.flowers[index] = value;}
	
	}
    
    }


}
