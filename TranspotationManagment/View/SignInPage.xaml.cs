namespace TranspotationManagment.View;

public partial class SignInPage : ContentPage
{
    public SignInPage()
    {
        InitializeComponent();
    }

    private void UserNameUnFocus(object sender, FocusEventArgs e)
    {
        if (UsernameEntry.Text == null || UsernameEntry.Text == "")
            Username.IsVisible = false;
        else
        {
            Username.IsVisible = true;
        }
    }

    private void UserNameFocus(object sender, FocusEventArgs e)
    {
        Username.IsVisible = true;
    }

    private void PasswordFocused(object sender, FocusEventArgs e)
    {
        Password.IsVisible = true;
    }

    private void PasswordUnFocused(object sender, FocusEventArgs e)
    {
        if (PasswordEntry.Text == null || PasswordEntry.Text == "")
        {
            Password.IsVisible = false;
        }
        else
        {
            Password.IsVisible = true;
        }
    }

    private async void GoToLogin(object sender, TappedEventArgs e)
    {
        await Shell.Current.GoToAsync("//login");

    }
}