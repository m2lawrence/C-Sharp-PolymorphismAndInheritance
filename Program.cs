//Exploring Polymorphism and Inherited Classes: Assigning a Person and Employee.
//Page 361 of: Sams Teach Yourself C# in 21 days. Polymorphism!

using System;
namespace Inherit03
{
	class Person
	{
		protected string firstName;
		protected string lastName;
		
		public Person() { }
		
		public Person(string fn, string ln)
		{
		firstName = fn;
		lastName = ln;
		}
		
		public void displayFullName()
		{
			Console.WriteLine("{0} {1}", firstName, lastName); 
		}
	}

	//Employee Inherits Person.
	class Employee : Person
	{
		public ushort hireYear;
		
		public Employee() : base() { } 
		public Employee(string fn, string ln) : base(fn, ln) { } 
		public Employee(string fn, string ln, ushort hy) : base(fn, ln)
		{
			hireYear = hy;
		}
		
		public new void displayFullName()
		{
			Console.WriteLine("Employee: {0} {1}", firstName, lastName); 
		}
	}
	
	class NameApp
	{
		public static void Main()
		{
			//Employee object.
			Employee me = new Employee("Michael", "Lawrence", 2016); //Employee object.
			
			//An object called Mike was set equal to the Employee object called me.
			Person Mike = me;
			
			me.displayFullName();
			Console.WriteLine("Year hired: {0}", me.hireYear);
			
			Mike.displayFullName();
			
			Console.ReadKey(true);
		}
	}	
}

//All the functionality of a Person is contained within an Employee. Stated more generically, 
//all aspects of a base class are a part of a derived class.
//A derived class is everything that a base class is, but a base class is not everything that a derived class is. 

//How is this polymorphic? Simply put, you can make the same method call to multiple object types, and the method call works. 
//I didn’t have to worry about specifying which class’s method to call. 

//Page 361 of: Sams Teach Yourself C# in 21 days. Polymorphism!