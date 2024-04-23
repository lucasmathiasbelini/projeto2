namespace projeto2
{
    public partial class MainPage : ContentPage
    {
        const string url = "https://api.hgbrasil.com/weather?woeid=455927&key="; 
        string result;

        public MainPage()
        {
            InitializeComponent();
            atualizarTempo();
        }

        async void atualizarTempo()
        {
            try
            {
                HttpClient httpClient = new HttpClient();
                HttpResponseMessage response = await httpClient.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    result = await response.Content.ReadAsStringAsync();
                    
                }
                else
                {
                    
                }
            }
            catch (Exception ex)
            {
                
            }
        }
    }
}

