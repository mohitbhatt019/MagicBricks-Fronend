namespace TranspotationManagment.View;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    public string ValidateCommand { get; set; }

    private async void LoginButton_Clicked(object sender, EventArgs e)
    {
        if (IsCredentialsCorrect(Username.Text, Password.Text))
        {
            await DisplayAlert("Login Succesfull", "This Username and password Is Valid", "OK");
        }
        else
            await DisplayAlert("Login failed", "Username or password if invalid", "Try again");
    }

    bool IsCredentialsCorrect(string username, string password)
    {
        return Username.Text == "Rahul" & Password.Text == "1234";
    }

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        await Shell.Current.GoToAsync("//signin");
    }
}