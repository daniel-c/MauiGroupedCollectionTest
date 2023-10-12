using TestCollectionView.ViewModels;

namespace TestCollectionView;

public partial class GroupedCollectionPage : ContentPage
{
	public GroupedCollectionPage()
	{
		InitializeComponent();

		BindingContext = new GroupedCollectionViewModel();
	}

	private async void OnAddClicked(object sender, EventArgs e)
	{
		if (BindingContext is GroupedCollectionViewModel viewModel)
		{
			if (!viewModel.AddAnimal())
			{
				await DisplayAlert("Adding animal", "No more animal to add from base list", "Ok");
			}
		}
	}

    private void OnClearClicked(object sender, EventArgs e)
    {
        if (BindingContext is GroupedCollectionViewModel viewModel)
        {
			viewModel.Reset();
        }
    }
}

