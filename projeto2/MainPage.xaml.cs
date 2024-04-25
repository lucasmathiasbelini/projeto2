using System.Text.Json;
using Projeto2;

namespace projeto2;

public partial class MainPage : ContentPage
{
    Prototipo prototipo;
    Resposta resposta;
    const string url = "https://api.hgbrasil.com/weather?woeid=455927&key="; 
    
    
    public MainPage(){
        InitializeComponent();
        AtualizaTempo();
    }

    async void AtualizaTempo(){
        try{
            var HttpClient = new HttpClient();
            var Response = await HttpClient.GetAsync(url);
           
            if (Response.IsSuccessStatusCode){
                var Content = await Response.Content.ReadAsStringAsync();
                prototipo = JsonSerializer.Deserialize<Prototipo>(Content);
            }
        }
        catch(Exception e){
            System.Diagnostics.Debug.WriteLine(e);
        }
        void chora(){
            LabelTemperatura.Text = resposta.prototipo.temp + "9c".ToString();
             LabelAmanhecer.Text = resposta.prototipo.sunrise;
              LabelAnoitecer.Text = resposta.prototipo.sunset;
               LabelChuva.Text = resposta.prototipo.rain.ToString();
                LabelDirecao.Text = resposta.prototipo.description;
                 LabelFase.Text = resposta.prototipo.moonPhase;
                  LabelForca.Text = resposta.prototipo.windSpeedy.ToString();
                  
        }
    }

}


