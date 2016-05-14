using System;
namespace Studte
{
	class Student
	{
		
		public string FirstName;
		public string LastName;
		public string BirthDate;
		public string AddressLine1,AddressLine2;
		public string City;
		public string State;
		public int zip;
		public string country;
	}
	/*class Teacher
	{
		string FirstName;
		string LastName;
		string BirthDate;
		string AddressLine1,AddressLine2;
		string City;
		string State;
		int zip;
		string Country;
		
	}
	class UProgramInfo
	{
		string ProgramName;
		string DepartmentHead;
		string[] Degrees;
	}
	class DegreeInfo
	{
		string DegreeName;
		int credits;
	}
	class CourseInfo
	{
		string CourseName;
		int credits;
		int weeks;
		string teacher;
	}
	*/
	class Exec
	{
		static void Main(string[] args)
		{
			Student s=new Student();
			Console.WriteLine("Enter first name");
			s.FirstName=Console.ReadLine();
			Console.WriteLine("Enter last name");
			s.LastName=Console.ReadLine();
			
			Console.WriteLine("Enter BirthDate");
			s.BirthDate=Console.ReadLine();
			Console.WriteLine("AddressLine1 and AddressLine2");
			s.AddressLine1=Console.ReadLine();
			s.AddressLine2=Console.ReadLine();
			
			Console.WriteLine("City");
			s.City=Console.ReadLine();
			Console.WriteLine("State");
			s.State=Console.ReadLine();
			Console.WriteLine("Zip");
			s.zip=Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter country");
			s.country=Console.ReadLine();
			
			Console.WriteLine("\r\n");
			Console.WriteLine("The entered values are: ");
			Console.WriteLine("First name: {0}",s.FirstName);
			Console.WriteLine("Last name: {0}",s.LastName);
			Console.WriteLine("BirthDate: {0}",s.BirthDate);
			Console.WriteLine("AddressLine1: {0}",s.AddressLine1);
			Console.WriteLine("AddressLine2: {0}",s.AddressLine2);
			Console.WriteLine("City: {0}",s.City);
			Console.WriteLine("State: {0}",s.State);
			Console.WriteLine("Zip: {0}",s.zip);
			Console.WriteLine("Country: {0}",s.country);
			Console.ReadLine();
			
			
		}
	}
}
