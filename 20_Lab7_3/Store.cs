using System;
using System.Collections.Generic;
using System.Text;

namespace _20_Lab7_3 {
	class Store {
		readonly List<Article> articles = new List<Article>();

		public void AddArticle(Article article) {
			articles.Add(article);
		}

		public Article this[int index] {
			get {
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
				return null;
			}
		}
	}
}
