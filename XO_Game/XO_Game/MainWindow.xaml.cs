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

namespace XO_Game
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int count=0;
        private string[,] mat = new string[3,3];
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            int row = (int)b.GetValue(Grid.RowProperty);
            int col = (int)b.GetValue(Grid.ColumnProperty);
            if ((string)b.Content=="?")
            {
                if (count % 2 == 0)
                {
                    b.Content = "X";
                    mat[row, col] = "X";
                }
                else
                {
                    b.Content = "O";
                    mat[row, col] = "O";
                }
            }
            if(count>=4)
            {
                IsWiner(row, col);
            }
            count++;
            
        }

        private void IsWiner(int i, int j)
        {
            int count1 = 0, count2 = 0, count3 = 0,count4=0,k=2;
            for (int x = 0; x < 3; x++)
            {
                if (mat[i, x] == mat[i, j])
                    count1++;
                if (mat[x, j] == mat[i, j])
                    count2++;
                if (mat[x, k - x] == mat[i, j])
                    count3++;
                if (mat[x,x] == mat[i, j])
                    count4++;
            }
         if(count1==3||count2==3||count3==3||count4==3)
            MessageBox.Show(mat[i, j] + " winer");
        }


    }
}
