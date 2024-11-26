using PlayStore;
int x = 10;
int y = x;

Console.WriteLine("My Play Store");
//How to create object for class?
//new keyword -- object is created in heap memory (mem allocation)(User userObj= new User();)
User userU = new User();
userU.CreateUser(); //function calling

Categories categories = new Categories(11, "RCA", "Root Cause Analyse");
Console.WriteLine(categories.Id);
Console.WriteLine(categories.Name);
Console.WriteLine(categories.Description);

categories.AddCategory(1, "ABC");
categories.AddCategory(2, "XYZ", "Test");


