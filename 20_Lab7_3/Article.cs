using System;
using System.Collections.Generic;
using System.Text;

namespace _20_Lab7_3 {
	class Article {
		// У WPF проекті створити клас Article, що містить наступні закриті поля:
		// назва товару; назва магазину, в якому продається товар; вартість товару в гривнях.

		// Я зроблю трохи інакше, оскільки гадаю, що умови
		// завдання були складені коли мова C# тільки
		// з'явилась, і ще не було властивостей.
		public string ItemName {
			get;
		}
		public string StoreName {
			get;
		}
		public int Price {
			get;
		}

		public Article(string item, string store, int price) {
			ItemName = item.Trim();
			StoreName = store.Trim();
			Price = price;
		}
	}
}
