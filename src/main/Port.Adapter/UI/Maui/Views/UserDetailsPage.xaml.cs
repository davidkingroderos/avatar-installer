using Maui.ViewModels;

namespace Maui.Views;

public partial class UserDetailsPage : ContentPage
{
    private readonly UserDetailsViewModel viewModel;
    public UserDetailsPage(UserDetailsViewModel viewModel)
    {
        InitializeComponent();

        this.viewModel = viewModel;
        BindingContext = this.viewModel;
    }
}