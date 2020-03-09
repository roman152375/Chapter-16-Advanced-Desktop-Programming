using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarliCards_GUI
{
    [Serializable]

    public class GameOptions : INotifyPropertyChanged
    {
        private ObservableCollection<string> _PlayerNames = new ObservableCollection<string>();
        public List<string> SelectedPlayers { get; set; }

        private bool _playAgainstComputer = true;
        private int _numberOfPlayers = 2;
        private int _minutedbeforeloss = 10;
        private ComputerSkillLevel _computerSkill = ComputerSkillLevel.Dumb;

        public GameOptions()
        {
            SelectedPlayers = new List<string>();
        }

        public ObservableCollection<string> PlayerNames
        {
            get
            {
                return _PlayerNames;
            }
            set
            {
                _PlayerNames = value;
                OnPropertyChanged("PlayerNames");
            }
        }
        public void AddPlayer(string playerName)
        {
            if (_PlayerNames.Contains(playerName))
                return;
            _PlayerNames.Add(playerName);
            OnPropertyChanged("PlayerNames");

        }

        public int NumberOfPlayers
        {
            get { return _numberOfPlayers; }
            set
            {
                _numberOfPlayers = value;
                OnPropertyChanged("NumberOfPlayers");
            }
        }
        public bool PlayAgainstComputer
        {
            get { return _playAgainstComputer; }
            set
            {
                _playAgainstComputer = value;
                OnPropertyChanged("PlayAgainstComputer");
            }
        } 
          
        public int MinuteBeforeLoss
        {
            get { return _minutedbeforeloss; }
            set
            {
                _minutedbeforeloss = value;
                OnPropertyChanged("MinutesBeforeLoss");
            }
        }
        public ComputerSkillLevel ComputerSkill
        {
            get { return _computerSkill; }
            set
            {
                _computerSkill = value;
                OnPropertyChanged("ComputerSkill");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    [Serializable]
    public enum ComputerSkillLevel
    {
        Dumb,
        Good,
        Cheats
    }
     
}
