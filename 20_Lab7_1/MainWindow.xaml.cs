using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _20_Lab7_1 {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
			array = new int[random.Next(2, 20)];
			for (int i = 0; i < array.Length; i++) {
				array[i] = random.Next(-99, 100);
			}
			index = random.Next(array.Length);
		}

		Random random = new Random();
		int[] array;
		int index;
	}
}
