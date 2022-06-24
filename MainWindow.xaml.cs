
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
using System.Text.Json;
using System.IO;
using GuessThePlayer.Classes;

namespace GuessThePlayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Team teamObject;

        public MainWindow()
        {
            InitializeComponent();
            string filename = "C:/Users/alangley/Desktop/Stuff/Football/GuessThePlayer/GuessThePlayer/Teams/AFC/AFC North/Steelers.json";
            string teamJson = File.ReadAllText(filename);
            teamObject = JsonSerializer.Deserialize<Team>(teamJson);
        }

        private void New_Player_Click(object sender, RoutedEventArgs e)
        {
            
            var teams = new Team
            {
                Quarter_backs = {"Test QB", "Test 2"},
                Wide_Receivers = {"Test WR"},
                Running_Backs = {"Test RB"}
            };

            lblNewPlayer.Content = teamObject.Quarter_backs[0];
            //lblNewPlayer.Content = (JsonSerializer.Serialize(teams));
        }

        
    }
}
