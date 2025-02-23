namespace joe_hawes_wizard_inventory
{
	internal class Program
	{
		static void Main(string[] args)
		{
			PrintL("Welcome to the Wizard Inventory game !\n -----------------------------------------------------");
			PrintL("");
			PrintL("COMMAND MENU: \n" +
				"show - Show all items in your inventory\n" +
				"grab - Grab an item and add it to your inventory\n" +
				"edit - Edit an item in your inventory\n" +
				"drop - Drop an item from your inventory\n" +
				"quit - Exit program\n");
			PrintL("Your satchel has been preloaded with 3 items for your journey. Good luck young mage!");  // this initial message is non repeating
			PrintL("");
			
			List<string> inventory = new List<string>(4);    //new list declared with 4 item slots
			inventory.Add("magic steeek");
			inventory.Add("pointy wizard hat");
			inventory.Add("sissy shoes");
			

			while (true)
			{
				Print("Enter a command: ");
				string command = Console.ReadLine().ToLower();  //user input becomes command
				Console.WriteLine();                            
				switch (command)                         //<<<<<<vvvvvvvv  switch statement to determine which method to call
				{
					case "show":
						ShowInventory(inventory);
						break;
					case "grab":
						GrabItem(inventory, 4);
						break;
					case "edit":
						EditItem(inventory);
						break;
					case "drop":
						DropItem(inventory);
						break;
					case "exit":
						for(; ; )
						{
							Console.WriteLine("You are a QUITTER !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
						}
					default:
						Console.WriteLine("Invalid command. Try again.");
						break;
				}
				
			}

		}
		static void GrabItem(List<string> inventory, int maxItems)
			{
				if (inventory.Count >= maxItems)
				{
					Console.WriteLine("Your satchel is too heavy! Drop something young mage! ");
					return;
				}
				else
				{
					Console.Write("Item Name: ");
					string newItem = Console.ReadLine();
					inventory.Add(newItem);
					Console.WriteLine($"{newItem} was added.");
					PrintL("");
				}
			}

		static void ShowInventory(List<string> inventory)
		{
			if (inventory.Count == 0)
			{
				Console.WriteLine("Your inventory is empty.");
				PrintL("");
			}
			else
			{
				for (int i = 0; i < inventory.Count; i++)
				{
					Console.WriteLine($"{i + 1}. {inventory[i]}");
					
				}
				PrintL("");
			}
		}

		static void PrintL(string s)
		{
			Console.WriteLine(s);
		}

		static void Print(string s)
		{
			Console.Write(s);
		}

		static void EditItem(List<string> inventory)
		{
			if (inventory.Count == 0)
			{
				Console.WriteLine("Your satchel is empty.");
				PrintL("");
				return;
			}
			ShowInventory(inventory);
			Console.Write("Enter the number of the item to edit: ");
			PrintL("");
			if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= inventory.Count)
			{
				Console.Write("Enter the new name for the item: ");
				string newItem = Console.ReadLine();
				inventory[index - 1] = newItem;
				Console.WriteLine("Item name updated.");
				PrintL("");
			}
			else
			{
				Console.WriteLine("Invalid item number.");
				PrintL("");
			}
		}

		static void DropItem(List<string> inventory)
		{
			if (inventory.Count == 0)
			{
				Console.WriteLine("Your inventory is empty.");
				PrintL("");
				return;
			}
			ShowInventory(inventory);
			Console.Write("Enter the number of the item to drop: ");
			PrintL("");
			if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= inventory.Count)
			{
				string item = inventory[index - 1];
				inventory.RemoveAt(index - 1);
				Console.WriteLine($"{item} was removed from your inventory.");
				PrintL("");
			}
			else
			{
				Console.WriteLine("Invalid item number.");
				PrintL("");
			}
		}
	}
}
