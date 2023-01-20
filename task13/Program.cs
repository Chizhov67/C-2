int N, thirdNum;

Console.Write("Введите число: ");
N = Convert.ToInt32(Console.ReadLine());

			if (N < 100)
			{
				Console.WriteLine("Третьей цифры нет");
			}

			else
			{
				while(N > 999)
				{
					N = N / 10;
				}

				thirdNum = N % 10;
				Console.WriteLine(thirdNum);
			}

			Console.ReadLine();
        