Console.WriteLine("Welcome to this cool to-do list!");

List<string> Incomplete_Title = new List<string>();
List<string> Incomplete_Description = new List<string>();
List<string> Incomplete_Creation = new List<string>();
List<string> Complete_Title = new List<string>();
List<string> Complete_Description = new List<string>();
List<string> Complete_Creation = new List<string>();
List<string> Complete_Finished = new List<string>();


while(true){
    display();
    Console.WriteLine("Press '1' to add to your to-do list.\nPress '2' to check items off your list.\nPress '3' to end the program.");
    string main_menu = Console.ReadLine();
    if (main_menu == "1")
    function1();
    else if (main_menu == "2")
    function2();
    else if (main_menu == "3")
    break;
    else
    {Console.WriteLine("Sorry, that was an invalid input. Please try again...");
    return;}
}

void function1(){

while(true){
Console.WriteLine("What is the title of the list item?");
string title = Console.ReadLine();
Console.WriteLine("What is the description of the list item?");
string description = Console.ReadLine();
string time = DateTime.Now.ToString();

Incomplete_Title.Add(title);
Incomplete_Description.Add(description);
Incomplete_Creation.Add(time);

Console.WriteLine("Type '1' if you would like to add another item.");
if (Console.ReadLine() != "1") break;
}
}

void function2(){

display();

Console.WriteLine("Which item do you want to mark as completed?(#)");
int index = int.Parse(Console.ReadLine());
Complete_Title.Add(Incomplete_Title[index-1]);
Complete_Description.Add(Incomplete_Description[index-1]);
Complete_Creation.Add(Incomplete_Creation[index-1]);
Complete_Finished.Add(DateTime.Now.ToString());
Incomplete_Title.RemoveAt(index-1);
Incomplete_Description.RemoveAt(index-1);
Incomplete_Creation.RemoveAt(index-1);

}

void display(){
    Console.WriteLine("\n\nTo-Do:");
    for (int i=1; i <= Incomplete_Title.Count; i++){
        Console.WriteLine($"{i}: {Incomplete_Title[i-1]}:   {Incomplete_Description[i-1]}   Created on: {Incomplete_Creation[i-1]}");
    }

    Console.WriteLine("\n\nCompleted:");
    for (int i=1; i <= Complete_Title.Count; i++){
        Console.WriteLine($"{i}: {Complete_Title[i-1]}:   {Complete_Description[i-1]}   Created on:{Complete_Creation[i-1]}   Finished on:{Complete_Finished[i-1]}");
    }
    Console.WriteLine("\n\n");
}