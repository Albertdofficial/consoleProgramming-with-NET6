// See https://aka.ms/new-console-template for more information

// Array defintion

int[] grades = new int[5];

string[] studentNames = { "Albert", "David", "Moses" };

for (int i = 0; i < grades.Length; i++)
{
    Console.WriteLine("Enter grade:");

    grades[i] = Convert.ToInt32(Console.ReadLine());

}

for (int i = 0; i < grades.Length; i++)
{
    Console.WriteLine(grades[i]);
}



