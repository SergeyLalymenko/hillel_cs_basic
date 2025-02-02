Console.WriteLine("Enter number 1 - 7:");
string input = Console.ReadLine();
int number = Convert.ToInt32(input);
string[] daysOfWeek = ["Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"];
string result = daysOfWeek[number - 1] ? daysOfWeek[number - 1] : "Invalid";
Console.WriteLine(result);


