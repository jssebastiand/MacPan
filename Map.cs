using System;
using System.Collections.Generic;
using System.IO;
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

namespace MacPan
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        enum tiles {wall, blank, ghostGate, superPill, ghostTile};
        public MainWindow()
        {
            readMap(5);
            InitializeComponent();
        }

        public void readMap(int mapSize)
        {
            string filePath = "map.txt";
            StreamReader reader = new StreamReader(filePath);
            tiles[,] gameBoard = new tiles[mapSize,mapSize];
            //gameBoard[5, 7];
            int Linecounter = 0; //add when going to new line
            while (!reader.EndOfStream)
            {
                char[] temp = reader.ReadLine().ToCharArray();
                for (int i = 0; i < temp.Length; i++)
              {
                    //      ((tiles)(int.Parse(temp[i].ToString())).ToString()
                    MessageBox.Show(((tiles)(int.Parse(temp[i].ToString()))).ToString());
//                    gameBoard[Linecounter, i] =(tiles) gameBoard.GetValue(int.Parse(temp[i].ToString()));
                }
            }
            for(int i = 0; i < gameBoard.GetLength(0); i++)
            {
                MessageBox.Show(gameBoard[i, 0].ToString());
            }
        }
    }
}
