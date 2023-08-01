using System;
using System.Collections.Generic;
using System.Text;

namespace _20_Lab7_3 {
	class Article {
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
