namespace ShellTitleBar_Issue;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
		ShellBtn.IsVisible = Application.Current.MainPage is not Shell;
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

	private void ShellBtn_Clicked(object sender, EventArgs e)
	{
		Application.Current.MainPage = new AppShell();
	}
}

