using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using VDap.Task7.Commands;
using VDap.Task7.DataProvider;
using VDap.Task7.Model;

namespace VDap.Task7.ViewModel
{
    public class GameViewModel : ViewBaseModel
    {
        private IGameDataProvider dataProvider;
        private static GameViewModel instance;
        private string label;
        private AddGameCommand command;
        public string Name { get; set; }
        public string Description { get; set; }
        private GameViewModel()
        {
            dataProvider = GameDataProvider.GetInstance();
            command = new AddGameCommand(this);
        }
        public static GameViewModel GetInstance()
        {
            instance = instance ?? new GameViewModel();
            return instance;
        }
        public string Label
        {
            get { return label; }
            set
            {
                label = value;
                OnPropertyChanged();
            }
        }
        public ICommand AddCommand
        {
            get
            {
                return command;
            }
        }
        public ObservableCollection<Game> Games { get; } = new ObservableCollection<Game>();
        public ObservableCollection<Game> LoadData()
        {
            foreach(var game in dataProvider.GetGames())
            {
                Games.Add(game);
            }
            return Games;
        }
        public void Add()
        {
            if (!String.IsNullOrEmpty(Name) && !String.IsNullOrEmpty(Description))
            {
                Label = string.Empty;
                Games.Add(new Game() { Name = Name, Description = Description });
            }
            else if(String.IsNullOrEmpty(Name) && String.IsNullOrEmpty(Description))
            {
                Label = "Fill both boxes";
            }
            else if(String.IsNullOrEmpty(Description))
            {
                Label = "You have to fill Description box";
            }
            else
            {
                Label = "You have to fill Name box";
            }
        }
    }
}
