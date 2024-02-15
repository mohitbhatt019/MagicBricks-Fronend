using TranspotationManagment.Models;

namespace TranspotationManagment.View;

public partial class Homepage : ContentPage
{
    public Homepage()
    {
        InitializeComponent();

        var propertyModels = new List<Category>()
    {
        (new Category { Name = "Home", ImageUrl = "house.png"  }),
       (new Category  { Name = "hotel", ImageUrl = "hotel.png" }),
        (new Category { Name = "apartment", ImageUrl = "apartment.png" }),
        (new Category { Name = "penthouse", ImageUrl = "penthouse.png" })
    };

        CvCategories.ItemsSource = propertyModels;

    }

    private void TapSearch_Tapped(object sender, TappedEventArgs e)
    {

    }

    private void CvCategories_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {

    }

    private void CvTopPicks_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {

    }

    private async void AddingNewProperty(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new AddingNewProperty());
    }

}