using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace joe_hawes_sales_report
{
	internal class Program
	{
		static void Main(string[] args)
		{
			PrintL("The Sales Report Application \n ------------------------------------------------------");
			decimal sum = 0.0m;
			decimal[,] sales =
			{

				{1540.0m, 2010.0m, 2450.0m, 1845.0m}, //region 1 is i = 0
				{1130.0m, 1168.0m, 1847.0m, 1491.0m}, // region 2 is i = 1
				{1580.0m, 2305.0m, 2710.0m, 1284.0m}, // region 3 is i = 2
				{1105.0m, 4102.0m, 2391.0m, 1576.0m} // region 4 is i = 3
			};

			// 1) dump data to console by region (rows), quarters (column)
			PrintL("Region\tQ1\tQ2\tQ3\tQ4");
			for (int i = 0; i < sales.GetLength(0); i++)
			{
				Print((i + 1) + "\t");
				for (int j = 0; j < sales.GetLength(1); j++)
				{
					Print(sales[i, j].ToString("c") + "\t");
				}
				PrintL("");
			}
			PrintL("");
			PrintL("Sales by region: ");
			// 2) sum sales by region
			for (int i = 0; i < sales.GetLength(0); i++)
			{Print("Region " + (i + 1) + ": ");
				sum = 0.0m;
				for (int j = 0; j < sales.GetLength(1); j++)
				{
					sum += sales[i, j];
				}
				PrintL(sum.ToString("c"));
			}
			PrintL("");

			// 3) sum sales by quarter ( q1, q2, q3, q4)
			PrintL("Sales by Quarter: ");
			for (int i = 0; i < sales.GetLength(0); i++)
			{
				Print("Q" + (i + 1) + ": ");
				sum = 0.0m;
				for (int j = 0; j < sales.GetLength(1); j++)
				{
					sum += sales[j, i];
				}
				PrintL(sum.ToString("c"));
			}
			PrintL("");

			// 4) sum of all sales
			PrintL("Total sales: ");
			sum = 0.0m;
			for (int i = 0; i < sales.GetLength(0); i++)
			{
				
				
				for (int j = 0; j < sales.GetLength(1); j++)
				{
					sum += sales[i, j];
				}
				
			}
			PrintL(sum.ToString("c"));
			Console.WriteLine("Goodbye-------------------------------------------------");
			static void PrintL(string message)
			{
				Console.WriteLine(message);
			}
			static void Print(string message)
			{
				Console.Write(message);
			}

			
		}
	}
}
