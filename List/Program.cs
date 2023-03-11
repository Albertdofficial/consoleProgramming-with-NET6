
// list definition
List<string> names = new List<string>();

string name = string.Empty;

// Add values to list
names.Add("Trevoir");


Console.WriteLine("Enter names");

while (!name.Equals("-1")){
    Console.Write("Enter Name:");
    name = Console.ReadLine();

    if (!string.IsNullOrEmpty(name) && !name.Equals("-1") )
    {
        names.Add(name);
        Console.WriteLine($"{name} was added successfully");
    }
}

// print values in a list
Console.WriteLine("Printing names vai for loop");
for (int i = 0; i < names.Count; i++)
{
    Console.WriteLine(names[i]);
}

//foreach
foreach (var item in names)
{
    Console.WriteLine(item);

}