// See https://aka.ms/new-console-template for more information

// primitive datatypes
//// int, string, char, bool
// Object Oriented Programming - Creating your own datatype
// class - blueprint


using ClassessAndObjects;

/*
// create an object of Person class
Person person = new ();
string middleName = string.Empty;

WriteLine("Enter First Name");
person.FirstName = ReadLine();

WriteLine("Enter Last Name");
person.LastName = ReadLine();

WriteLine("Enter your age:");
person.Age = Convert.ToInt32(ReadLine());

WriteLine("Enter your salary:");
double salary = Convert.ToDouble(ReadLine());

WriteLine("Enter MiddleName:");
middleName = ReadLine();

if (string.IsNullOrEmpty(middleName))
{
    WriteLine($"Full Name is: {person.getFullName() }");
}
else
{
    WriteLine($"Full Name is: {person.getFullName(middleName) }");

}


person.setSalary(salary);

person.getFullName();
WriteLine($"Person age is: {person.Age}");
WriteLine($"Year of Birth is: {DateUtil.YearofBirth(person.Age)}");
WriteLine($"Person salary is: {person.getSalary()} ");

*/

Country country = new ();

WriteLine("Enter the country name:");
country.Name = ReadLine();

WriteLine("Enter the president name:");
country.president = ReadLine();

double avgSalary = 100.00;
WriteLine("Enter the country's average salary: ");

avgSalary = Convert.ToDouble(ReadLine());
country.setAvgSalary(avgSalary);

country.setAvgSalary(avgSalary);

if (!string.IsNullOrEmpty(country.Name))
{
    country.getCountryData();
}

