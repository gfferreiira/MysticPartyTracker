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
    private void DiceBtn_Clicked(object sender, EventArgs e)
    {
        DiceResult.Text = string.Empty;

        //Verificar quantidade de dados pelo picker
        int dices = Convert.ToInt32(DicesPicker.SelectedItem);
        //Instanciação de um novo objeto dice do tipo Dice, através do construtor Dice();

        int sides = Convert.ToInt32(SidesPicker.SelectedItem);
        for (int i = 0; i < dices; i++) {
            
            DiceResult.Text = DiceResult.Text + Convert.ToString(new Dice(sides).Rolar()) + "   ";
        }

        


    }
    private void DiceTypePicker_SelectedIndexChanged(object sender, EventArgs e)
    {
        DiceTypeImage.Source = $"d{SidesPicker.SelectedItem.ToString()}.png";
    }
    private void DicePicker_SelectedIndexChanged(Object sender, EventArgs e)
    {
        
    }



}