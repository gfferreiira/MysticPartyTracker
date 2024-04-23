namespace MysticPartyTracker.View;
using MysticPartyTracker.Model;

public partial class DiceView : ContentPage
{
	public DiceView()
	{
		InitializeComponent();
       
    }
    private void DiceBtn_Clicked(object sender, EventArgs e)
    {
        //Verificar quantidade de dados pelo picker
        int dices = Convert.ToInt32(DicesPicker.SelectedIndex);
        //Instanciação de um novo objeto dice do tipo Dice, através do construtor Dice();

        int sides = Convert.ToInt32(SidesPicker.SelectedItem);
        Dice dice = new Dice(sides);
        DiceResult.Text = Convert.ToString(dice.Rolar());

        if (DicesPicker.SelectedIndex == 1)
        {
            Dice dicetwo = new Dice(sides);    
            DiceTwoResult.Text = Convert.ToString(dice.Rolar());
        }
        if (DicesPicker.SelectedIndex == 2)
        {
            Dice dicetwo = new Dice(sides);
            Dice dicethree = new Dice(sides);
            DiceTwoResult.Text = Convert.ToString(dice.Rolar());
            DiceThreeResult.Text = Convert.ToString(dice.Rolar());



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