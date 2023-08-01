using System;

namespace _20_Lab7_2 {
	class Program {
		static void Main() {
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			Console.Title = "Lab5_3";

			MyMatrix<int> matrix = null;
			while (Console.KeyAvailable)
				Console.ReadKey();
			for (; ; ) {
				int a, b;
				if (matrix == null) {
					Console.Write("Введіть ширину матриці від 1 до 9: ");
					do {
						a = GetNumberKey();
					} while (a < 1);
					Console.WriteLine(a);

					Console.Write("Введіть висоту матриці від 1 до 9: ");
					do {
						b = GetNumberKey();
					} while (b < 1);
					Console.WriteLine(b);

					matrix = new MyMatrix<int>(a, b);
				}

				Console.WriteLine("Що Ви хочете зробити?");
				Console.WriteLine("1. Показати матрицю");
				Console.WriteLine("2. Редагувати матрицю");
				Console.WriteLine("3. Перестворити матрицю");
				Console.WriteLine("4. Додати стовпчик до матриці");
				Console.WriteLine("5. Додати рядок до матриці");
				Console.WriteLine("6. Видалити стовпчик з матриці");
				Console.WriteLine("7. Видалити рядок з матриці");
				Console.WriteLine("8. Вийти з програми");

				do {
					a = GetNumberKey();
				} while (a < 1 || a > 8);
				switch (a) {
				case 1:
					ShowMatrix(matrix);
					break;
				case 2:
					EditMatrix(matrix);
					break;
				case 3:
					matrix = null;
					break;
				case 4:
					Console.WriteLine("У кінець матриці додано стовпчик.");
					matrix.AddOneColumn();
					break;
				case 5:
					Console.WriteLine("У кінець матриці додано рядок.");
					matrix.AddOneRow();
					break;
				case 6:
					Console.WriteLine("Видалено останній стовпчик матриці.");
					matrix.RemoveOneColumn();
					break;
				case 7:
					Console.WriteLine("Видалено останній рядок матриці.");
					matrix.RemoveOneRow();
					break;
				case 8:
					return;
				}
			}
		}

		static void ShowMatrix(MyMatrix<int> matrix) {
			for (var i = 0; i < matrix.Height; i++) {
				for (var j = 0; j < matrix.Width; j++) {
					Console.Write("{0,4}", matrix[j, i]);
				}
				Console.WriteLine();
			}
		}

		static void EditMatrix(MyMatrix<int> matrix) {
			ShowMatrix(matrix);

			var fgc = Console.ForegroundColor;
			var bgc = Console.BackgroundColor;
			var x = 0;
			var y = 0;
			var currentline = Console.CursorTop;
			Console.CursorVisible = false;
			while (Console.KeyAvailable)
				Console.ReadKey();
			for (; ; ) {
				Console.SetCursorPosition(x * 4, currentline - matrix.Height + y);
				Console.BackgroundColor = fgc;
				Console.ForegroundColor = bgc;
				Console.Write("{0,4}", matrix[x, y]);
				Console.ResetColor();
				Console.SetCursorPosition(0, currentline);

				ConsoleKey key = Console.ReadKey(true).Key;
				Console.SetCursorPosition(x * 4, currentline - matrix.Height + y);
				Console.Write("{0,4}", matrix[x, y]);
				Console.SetCursorPosition(0, currentline);
				switch (key) {
				case ConsoleKey.Enter:
					goto Exit;
				case ConsoleKey.LeftArrow:
					if (x > 0)
						x--;
					break;
				case ConsoleKey.UpArrow:
					if (y > 0)
						y--;
					break;
				case ConsoleKey.RightArrow:
					if (x < matrix.Width - 1)
						x++;
					break;
				case ConsoleKey.DownArrow:
					if (y < matrix.Height - 1)
						y++;
					break;
				case ConsoleKey.D0:
				case ConsoleKey.D1:
				case ConsoleKey.D2:
				case ConsoleKey.D3:
				case ConsoleKey.D4:
				case ConsoleKey.D5:
				case ConsoleKey.D6:
				case ConsoleKey.D7:
				case ConsoleKey.D8:
				case ConsoleKey.D9:
					if (matrix[x, y] < 0)
						matrix[x, y] = -matrix[x, y];
					matrix[x, y] = (matrix[x, y] % 10 * 10) + (key - ConsoleKey.D0);
					break;
				case ConsoleKey.NumPad0:
				case ConsoleKey.NumPad1:
				case ConsoleKey.NumPad2:
				case ConsoleKey.NumPad3:
				case ConsoleKey.NumPad4:
				case ConsoleKey.NumPad5:
				case ConsoleKey.NumPad6:
				case ConsoleKey.NumPad7:
				case ConsoleKey.NumPad8:
				case ConsoleKey.NumPad9:
					if (matrix[x, y] < 0)
						matrix[x, y] = -matrix[x, y];
					matrix[x, y] = (matrix[x, y] % 10 * 10) + (key - ConsoleKey.NumPad0);
					break;
				case ConsoleKey.OemMinus:
				case ConsoleKey.Subtract:
					matrix[x, y] = -matrix[x, y];
					break;
				default:
					break;
				}
			}
		Exit:
			Console.CursorVisible = true;
		}

		static int GetNumberKey() {
			for (; ; ) {
				var key = Console.ReadKey(true).Key;
				switch (key) {
				case ConsoleKey.D0:
				case ConsoleKey.D1:
				case ConsoleKey.D2:
				case ConsoleKey.D3:
				case ConsoleKey.D4:
				case ConsoleKey.D5:
				case ConsoleKey.D6:
				case ConsoleKey.D7:
				case ConsoleKey.D8:
				case ConsoleKey.D9:
					return key - ConsoleKey.D0;
				case ConsoleKey.NumPad0:
				case ConsoleKey.NumPad1:
				case ConsoleKey.NumPad2:
				case ConsoleKey.NumPad3:
				case ConsoleKey.NumPad4:
				case ConsoleKey.NumPad5:
				case ConsoleKey.NumPad6:
				case ConsoleKey.NumPad7:
				case ConsoleKey.NumPad8:
				case ConsoleKey.NumPad9:
					return key - ConsoleKey.NumPad0;
				}
			}
		}
	}
}
