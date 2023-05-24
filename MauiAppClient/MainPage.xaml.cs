namespace MauiAppClient
{
    public partial class MainPage : ContentPage
    {
        private readonly HttpClient _httpClient = new();
        private const string BaseAddress = "https://0x52nz4m-5015.euw.devtunnels.ms";

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            var resultJson = await _httpClient.GetStringAsync($"{BaseAddress}/WeatherForecast/");

            weatherResult.Text = resultJson;
        }
    }
}