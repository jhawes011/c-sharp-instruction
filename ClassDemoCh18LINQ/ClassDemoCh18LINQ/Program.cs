using System;
using ConsoleLibrary;
namespace ClassDemoCh18LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========Class Demo LINQ=============");


			int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			var evenNumberQuery = from number in numbers
								  where number % 2 == 0
								  orderby number descending
								  select number;
			string evenNumbers = "";
				foreach (var nbr in evenNumberQuery)
			{
				evenNumbers += nbr + " ";
			}
			MyConsole.PrintL(evenNumbers);

			///////////////////////////////////////////////////
			decimal[] salesTotals = [1286.45m, 2433.49m, 2893.85m, 2094.53m];
			var salesList = from sales in salesTotals
							select sales;
			decimal sum = 0;
			foreach (var sales in salesTotals)
			{
				sum += sales;
			}
			MyConsole.PrintL("sales = " + sum.ToString("c"));

			//////////////////////////////////////////////////// pg 583 - invoice list
			List<Invoice> invoicesList = InvoiceDB.GetInvoices();
			//foreach (var invoice in invoicesList)
			//{
			//	MyConsole.PrintL(invoice.ToString());
			//}
			var invoices = from invoice in invoicesList   //using a LINQ query
						   select invoice;
			foreach (var invoice in invoicesList)
			{
				MyConsole.PrintL(invoice.ToString());
			}

			////////////////////////////////////////// pg 585 filtering
			salesList = from sales in salesTotals
						where sales > 2000
						select sales;
			string salesDisplay = "";
			foreach (var sales in salesList)
				salesDisplay += sales.ToString("c") + "|";
			MyConsole.PrintL(salesDisplay);
			MyConsole.PrintL("");

			///////////////////////////////////invoices
			invoices = from invoice in invoicesList
					   where invoice.InvoiceTotal > 150
					   select invoice;
			string invoiceDisplay = "";
			foreach (var invoice in invoices)
			{
				invoiceDisplay += invoice.InvoiceTotal.ToString("c") + "|";
			}
			MyConsole.PrintL(invoiceDisplay);

			//////load all customers
			
			MyConsole.PrintL("==== join in LINQ");
			List<Customer> customersList = new List<Customer>();
			//join 
			var invoices2 = from invoice in invoicesList
					   join customer in customersList
					   on invoice.CustomerID equals customer.CustomerID
					   where invoice.InvoiceTotal > 150
					   orderby customer.Name, invoice.InvoiceTotal descending
					   select new { customer.Name, invoice.InvoiceTotal };
			invoiceDisplay = "Customer Name\t\tInvoice Amount\n";
			foreach (var i in invoices2)
			{
				invoiceDisplay += i.Name + "\t\t" + i.InvoiceTotal.ToString("c") + "\n";
			}
			MyConsole.PrintL(invoiceDisplay);


			//p593 - extension methods
			// list of invoices totals > 150 ordered by customerid, then by invoice total (desc)
			var invoices3 = invoicesList.
				Where(i => i.InvoiceTotal > 150).
				OrderBy(i => i.CustomerID).
				ThenByDescending(i => i.InvoiceTotal).
				Select(i => new { i.CustomerID, i.InvoiceTotal });
			foreach (var i in invoices3)
			{
				MyConsole.PrintL($"{i.CustomerID}, {i.InvoiceTotal:c}");
			}


		}
    }
}
