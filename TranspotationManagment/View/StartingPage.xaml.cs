namespace TranspotationManagment.View;

public partial class StartingPage : ContentPage
{
    public StartingPage()
    {
        InitializeComponent();
        var propertyModels = new List<PropertyModel>()
    {
        (new PropertyModel { Name = "Property Search", Description = "buy,Rent a property/PG" }),
       (new PropertyModel  { Name = "Post Property AD", Description = "sell or REnt out your Property" }),
        (new PropertyModel { Name = "Property Search", Description = "buy,Rent a property/PG" }),
        (new PropertyModel { Name = "Home Loan , Property Services", Description = "sell or REnt out your Property" })
    };


        PropertyListView.ItemsSource = propertyModels;




    }

    public class PropertyModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

    }
}