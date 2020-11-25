using System;
using System.Collections.Generic;
using System.Text;

namespace _20_Lab7_3 {
	class Store {
		// Створити клас Store, який містить масив елементів типу Article.
		// Забезпечити такі можливості:
		// додавання інформації про товар,
		// висновок інформації про товар за номером за допомогою індексу;
		// висновок на екран інформації про товар, назва якого введено з клавіатури, якщо таких товарів немає, видати відповідне повідомлення.


		// Я створюю список, оскільки списки більш гнучкі, ніж звичайні масиви.
		readonly List<Article> articles = new List<Article>();

		public void AddArticle(Article article) {
			articles.Add(article);
		}

		public Article this[int index] {
			get {
				// Якщо товар за індексом не знайдено, повернути порожнечу,
				// а програма вирішить, що далі робити.
				return index >= 0 && index < articles.Count ? articles[index] : null;
			}
		}
		public Article this[string name] {
			get {
				string n = name.ToLower().Trim();
				for (int i = 0; i < articles.Count; i++) {
					if (articles[i].ItemName.ToLower() == n) {
						return articles[i];
					}
				}
				// Якщо нічого не знайшли, повернути порожнечу.
				return null;
			}
		}
	}
}
