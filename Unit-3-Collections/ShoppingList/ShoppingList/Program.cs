namespace ShoppingList;

class Program
{
    static void Main(string[] args)
    {
        decimal sum = 0;
        Dictionary<string, decimal> shoppingList = new Dictionary<string, decimal>();
        
        shoppingList["Apple"] = 3;
        shoppingList["Bananas"] = 2;
        shoppingList["Pineapple"] = 1.5m;
        shoppingList["Orange"] = 1.1m;
        shoppingList["Fruit Bowl"] = 8;
        shoppingList["Bread"] = 4.5m;
        shoppingList["Chicken"] = 5.4m;
        shoppingList["Toilet Paper"] = 12;
        
        List<string> order = new List<string>();

        foreach (var shopping in shoppingList)
        {
            Console.WriteLine("We sell " + shopping.Key + " for the price of " + shopping.Value);
        }

        do
        {
            Console.WriteLine("Do you want to buy something? Y/N ");
            string userInput = Console.ReadLine();
            if (userInput.ToUpper() == "N")
            {
                break;
            }
            Console.WriteLine("What would you like to add to your order?");
            string item = Console.ReadLine();
           

            if (shoppingList.ContainsKey(item))
            {
                Console.WriteLine("It's been added to your order!");
                order.Add(item);
            }
            else
            {
                Console.WriteLine("We don't have this " + item + " in the store!");
            }

        } while (true);
        

        foreach (var item in order)
        {
            Console.WriteLine("You bought " + item);
            sum += shoppingList[item];
        }
        Console.WriteLine("The total today is : " + sum);
        

        





    }
    
    
}