using Newtonsoft.Json.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.JavaScript;
using System.Windows.Forms;
namespace WeatherApiProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string apiKey = Environment.GetEnvironmentVariable("RapidAPIKey"); // Ortam de�i�keni kullan

        private async void Form1_Load(object sender, EventArgs e)
        {


            labelSifirla();

         

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://open-weather13.p.rapidapi.com/city/Ankara/EN"),
                Headers =
    {
        { "x-rapidapi-key", apiKey },
        { "x-rapidapi-host", "open-weather13.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var json = JObject.Parse(body);

                //�ehir ismi
                var cityName = json["name"].ToString();
                lblSehir.Text = cityName;

                //G�n�n tarihi
                var dateOfDay = DateTime.Now.ToString();
                lblTarih.Text = dateOfDay;

                //S�cakl��� F'ten �C �evirme
                var fahrenheit = json["main"]["temp"].ToString();
                var fToCelsius = ((double.Parse(fahrenheit) - 32) / (1.8));
                lblSicaklik.Text = fToCelsius.ToString("0.00") + " �C";

                //Hissedilen S�cakl��� F'ten �C �evirme
                var feelsLikeF = json["main"]["feels_like"].ToString();
                var fLikeFToCelcius = ((double.Parse(feelsLikeF) - 32) / (1.8));
                lblHissedilen.Text = "Hissedilen: " + fLikeFToCelcius.ToString("0.00") + " �C";

                //Minimum S�cakl��� F'ten �C �evirme
                var minTempF = json["main"]["temp_min"].ToString();
                var fTempMinToCelcius = ((double.Parse(minTempF) - 32) / (1.8));
                lblMinSicaklik.Text = "Minimum S�cakl�k: " + fTempMinToCelcius.ToString("0.00") + " �C";

                //Maximum S�cakl��� F'ten �C �evirme
                var maxTempF = json["main"]["temp_max"].ToString();
                var fTempMaxToCelcius = ((double.Parse(maxTempF) - 32) / (1.8));
                lblMaxSicaklik.Text = "Maksimum S�cakl�k: " + fTempMaxToCelcius.ToString("0.00") + " �C";

                //Nem Oran� (Y�zdesel)
                var humidity = json["main"]["humidity"].ToString();
                lblNem.Text = "Nem Oran�: %" + humidity;

                //R�zgar H�z�
                var windSpeed = json["wind"]["speed"].ToString();
                lblRuzgar.Text = "R�zgar H�z�: " + windSpeed + " KM/Saat";

                //Bas�n� �iddeti
                var pressure = json["main"]["pressure"].ToString();
                lblBasinc.Text = "Bas�n� �iddeti: " + pressure + " hPa";

                //G�n�n Hava Durumuna G�re Foto�raf De�i�tirme

                var weatherCondition = json["weather"][0]["main"].ToString();
                switch (weatherCondition)
                {

                    case "Clouds":
                        pBoxHava.Image = WeatherApiProject.Properties.Resources.cloudy;
                        break;
                    case "Clear":
                        pBoxHava.Image = WeatherApiProject.Properties.Resources.cloudy;
                        break;
                    case "Rain":
                        pBoxHava.Image = WeatherApiProject.Properties.Resources.rainy;
                        break;
                    case "Snow":
                        pBoxHava.Image = WeatherApiProject.Properties.Resources.snowy;
                        break;
                    case "Sun":
                        pBoxHava.Image = WeatherApiProject.Properties.Resources.sunny;
                        break;
                    default:
                        pBoxHava.Image = WeatherApiProject.Properties.Resources.cloudy;
                        break;
                }


            }
        }
    

    void labelSifirla()
        {
            lblSehir.Text = "";
            lblTarih.Text = "";
            lblSicaklik.Text = "";
            lblHissedilen.Text = "";
        }

    }
}
