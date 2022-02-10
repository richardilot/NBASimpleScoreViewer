using System.Collections.Generic;
using System.Threading.Tasks;
using NBAScore.Models;
using ReactiveUI;

namespace NBAScore.ViewModels
{
    public class MainWindowViewModel : ReactiveObject
    {
        //Bindings of title and headers
        public string Title => "NBA SIMPLE SCORE VIEWER";
        public string SubTitle => "INSTANTLY SEE TWO WEEKS OF YOUR TEAM RESULTS!";
        public string TeamSelectionHeader => "SELECT TEAM";
        public string DateSelectionHeader => "SELECT LAST GAME DATE";

        private List<Team> _allteams = new List<Team>();
        private List<Game> _games = new List<Game>();

        //Teams property for passing teams data to View
        public List<Team>? AllTeams { 
            get => _allteams; 
            set {
                this.RaiseAndSetIfChanged(ref _allteams, value);
            } }

        //Games property for passing game data to View
        public List<Game>? Games
        {
            get => _games;
            set
            {
                this.RaiseAndSetIfChanged(ref _games, value);
            }
        }
                
        //Execute and returns all teams query
        public static async Task<List<Team>> DoGetTeams()
        {
            var _teams = await Teams.GetAllTeamsAsync();
            
            return _teams.data;
        }

    }
}
