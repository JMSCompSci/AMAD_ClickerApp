namespace ClickerApp;

public partial class MainPage : ContentPage
{

	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void CounterAdd_Clicked(object sender, EventArgs e)
	{
		count++;
		//Shell.Current.DisplayAlert("Oh no!", "You broke it.", "Cancel");
		counterLabel.Text = $"Count: {count}";
	}
}

