namespace DiceRoller;



public partial class MainPage : ContentPage
{
    
    public MainPage()
    {
        InitializeComponent();
    }


    public void RollButton_Clicked(object sender, EventArgs e)
    {   ResultLabel.Text = "";
        int numDados = Convert.ToInt32 (qtdeDados.Text.ToString());
        List<string> resultado = new List<string>();
        int modificador = 0;
        int lados = 0;
        int resultadoDados = 0;
        string resultString = "";
        for (int i = 0; i < numDados; i++)
        {
            //Dado dado = new Dado(Convert.ToInt32(SidesPicker.SelectedItem.ToString()), Convert.ToInt32(ModifierPicker.SelectedIndex.ToString())+1);
            lados = Convert.ToInt32(SidesPicker.SelectedItem.ToString());
            modificador = Convert.ToInt32(ModifierPicker.SelectedIndex.ToString()) + 1;
            Dado dado = new Dado(lados, modificador);

            resultadoDados = dado.rolarDados(); 

            resultString = $"Lados: {lados}| Modificador:{modificador} | Resultado: {resultadoDados}";
            resultado.Add( resultString + "\n");

            string item = resultado[i];
            
            ResultLabel.Text += item.ToString();
        }

        
         //A ResultLabel recebe o número sorteado e exbibe na  tela


    }

    //Sortear um número aleatório através do clique do botão
    //Devolver o número sorteado para a interface
    //Conseguir selecionar a quantidade de lados a partir do Picker

}

