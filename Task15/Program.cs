int N;
Console.Write("Введите цифру дня недели: ");
N = Convert.ToInt32(Console.ReadLine());

if (N >= 1 && N <= 5)
			{
				Console.WriteLine("нет");
			}

			else if (N >= 6 && N <= 7)
			{
				Console.WriteLine("да");
			}

			else
			{
				Console.WriteLine("Такого дня не существует");
			}	

			Console.ReadLine();
		
