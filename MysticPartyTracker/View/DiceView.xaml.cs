namespace MysticPartyTracker.View;
using MysticPartyTracker.Model;
using MysticPartyTracker.ViewModel;

public partial class DiceView : ContentPage
{
	public DiceView()
	{
		InitializeComponent();
        BindingContext = new DiceViewModel();
        
       
    }
   

        


    
    private void DiceTypePicker_SelectedIndexChanged(object sender, EventArgs e)
    {
        DiceTypeImage.Source = $"d{SidesPicker.SelectedItem.ToString()}.png";
    }
    private void DicePicker_SelectedIndexChanged(Object sender, EventArgs e)
    {
        
    }



}