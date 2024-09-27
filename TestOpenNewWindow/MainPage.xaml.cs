namespace TestOpenNewWindow
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            Window window1 = new Window(new AppShell());
            App.Current?.OpenWindow(window1);
        }


    }

}
