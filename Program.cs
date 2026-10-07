double alltotal = 0;
int choice = 1;


while (choice !=0)
{
    Console.WriteLine("Enter amount: ");
    double amount = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter quantity: ");
    int quantity = Convert.ToInt32(Console.ReadLine());

   
    int total = (int)(amount * quantity);
    Console.WriteLine("Total: " + total);


    Console.WriteLine("Is there anything else? (1 for yes, 0 for no)");
    choice = Convert.ToInt32(Console.ReadLine());

    alltotal = alltotal + total;
    Console.WriteLine("All totals: " + alltotal);
    
}
Console.WriteLine();