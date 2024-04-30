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
    public partial class DiceViewModel : ObservableObject
    {
        public DiceViewModel()
        {
            RollCommand = new Command(Roll);
        }
        [ObservableProperty]
        public int _numberSides;

        [ObservableProperty]
        public int _quantity;

        [ObservableProperty]
        public int _total;


        private ObservableCollection<int> _rolls = new ObservableCollection<int>();
        public ObservableCollection<int> Rolls
        {
            get { return _rolls; }
            set { _rolls = value; }
        }

        public ICommand RollCommand { get;}



        public void Roll()
        {
            Rolls.Clear();
            Total = 0;
            Dice dice = new Dice(NumberSides);
            
            for(int i = 0; i < Quantity; i++)
            {
                int roll = dice.Rolar();
                Rolls.Add(roll);
                Total += roll;
            }
        }



    }
}
