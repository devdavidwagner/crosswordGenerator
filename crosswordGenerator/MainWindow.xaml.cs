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

/*CROSSWORD GENERATOR
*David Wagner 08/17/2017 CREATED
* 
*/

namespace crosswordGenerator
{
   
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public string[] upClues;
        public string[] downClues;

        public string[] upAns;
        public string[] downAns;

        public TextBox[] txtUp;
        public TextBox[] txtDown;

        //switches window to answers and saves clues
        private void btnAns_Click(object sender, RoutedEventArgs e)
        {
            txtUp = new TextBox[] {up1, up2, up3, up4, up5, up6, up7, up8, up9, up10};
            txtDown = new TextBox[] { down1, down2, down3, down4, down5, down6, down7, down8, down9, down10 };

            int upClueCnt = 0;
            int downClueCnt = 0;

            
            for (int i = 0; i < txtUp.Length; i++)
            {
                if(txtUp[i].Text != "")
                {
                    upClueCnt++;   
                }

            }


            for (int i = 0; i < txtDown.Length; i++)
            {
                if (txtDown[i].Text != "")
                {
                    downClueCnt++;
                }

            }

            upAns = new string[upClueCnt];
            downAns = new string[downClueCnt];

            for (int i = 0; i < upClueCnt; i++)
            {
                if (txtUp[i].Text != "")
                {
                    upAns[i] = txtUp[i].Text;
                   
                }

            }


            for (int i = 0; i < downClueCnt; i++)
            {
                if (txtDown[i].Text != "")
                {
                    downAns[i] = txtDown[i].Text;
                }

            }

            lblDown.Content = "DOWN-ANSWERS";
            lblUp.Content = "UP-ANSWERS";

            btnAns.IsEnabled = false;
            btnAns.Visibility = Visibility.Hidden;



        }
    }
}
