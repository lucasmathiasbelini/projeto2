using System.Reflection.Emit;
using System.Text.Json;
using Projeto2;

namespace projeto2;

public partial class MainPage : ContentPage
{
    Resposta resposta;
    const string URL = "https://api.hgbrasil.com/weather?woeid=455927&key=e0109e39 "; 
    
    
    public MainPage(){
        InitializeComponent();
        AtualizaTempo();
    }

    async void AtualizaTempo(){
        try{
            var HttpClient = new HttpClient();
            var Response = await HttpClient.GetAsync(URL);
           
            if (Response.IsSuccessStatusCode){
                var Content = await Response.Content.ReadAsStringAsync();
                resposta = JsonSerializer.Deserialize<Resposta>(Content);
                
            }
            chora();
        }
        catch(Exception e){
            System.Diagnostics.Debug.WriteLine(e);
        }

        
    }
        void chora(){

            LabelTemperatura.Text = (resposta.results.temp + "9c").ToString();
            LabelAmanhecer.Text = resposta.results.sunrise;
            LabelAnoitecer.Text = resposta.results.sunset;
            LabelChuva.Text = resposta.results.rain.ToString();
            LabelDirecao.Text = resposta.results.description;
            LabelFase.Text = resposta.results.moonPhase;
            LabelForca.Text = resposta.results.windSpeedy.ToString();
            
            if(resposta.results.moonPhase=="full")
            LabelFase.Text = "cheia";

            else if (resposta.results.moonPhase=="new")
            LabelFase.Text = "lua crescente";

            else if (resposta.results.moonPhase=="waxing_crescent")
            LabelFase.Text = "Quarto crescente";

            else if (resposta.results.moonPhase=="first_quarter")
            LabelFase.Text = "primeiro quarto";
        }
    

}


