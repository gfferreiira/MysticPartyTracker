using CommunityToolkit.Mvvm.ComponentModel;
using MysticPartyTracker.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MysticPartyTracker.ViewModel
{
    public partial class CharacterViewModel : ObservableObject
    {

        public CharacterViewModel() {
            CreateCharacter = new Command(CCharacter);
        }

        [ObservableProperty]
        private string _class;

        [ObservableProperty]
        private string _breed;

        [ObservableProperty]
        private int _level;

        [ObservableProperty]
        private string _name;

        private ObservableCollection<Character> _characters = new ObservableCollection<Character>();
        public ObservableCollection<Character> Characters
        {
            get { return _characters; }
            set { _characters = value; }
        }

        public ICommand CreateCharacter { get; }

        public void CCharacter()
        {
            Character character = new Character(Level, Name, Class, Breed);

            Characters.Add(character);

        }

    }
}
