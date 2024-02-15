using TranspotationManagment.View;

namespace TranspotationManagment
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("//signin", typeof(SignInPage));
            Routing.RegisterRoute("//login", typeof(LoginPage));
            Routing.RegisterRoute("//newproperty", typeof(AddingNewProperty));
        }
    }
}
