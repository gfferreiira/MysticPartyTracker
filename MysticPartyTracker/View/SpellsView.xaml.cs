using MysticPartyTracker.ViewModel;
namespace MysticPartyTracker.View;

public partial class SpellsView : ContentPage
{
	public SpellsView()
	{
		BindingContext = new SpellsViewModel();
		InitializeComponent();
	}
}