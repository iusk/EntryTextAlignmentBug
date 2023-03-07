namespace EntryTextAlignmentBug;

public partial class MainPage : ContentPage
{
	private bool isVisible;
	public bool IsVisible
	{
		get
		{
			return isVisible;
		}
		set
		{
			isVisible = value;
			OnPropertyChanged(nameof(IsVisible));
		}
	}

    private bool isVisible2;
    public bool IsVisible2
    {
        get
        {
            return isVisible2;
        }
        set
        {
            isVisible2 = value;
            OnPropertyChanged(nameof(IsVisible2));
        }
    }

    public MainPage()
	{
		InitializeComponent();
		IsVisible = true;
		IsVisible2 = false;
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		IsVisible = !IsVisible;
		IsVisible2 = !IsVisible2;
	}
}

