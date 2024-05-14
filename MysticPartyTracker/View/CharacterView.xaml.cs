namespace MysticPartyTracker.View;
using MysticPartyTracker.Model;
using MysticPartyTracker.ViewModel;


public partial class CharacterView : ContentPage
{
	public CharacterView()
	{
		InitializeComponent();
        BindingContext = new CharacterViewModel();
    }
}