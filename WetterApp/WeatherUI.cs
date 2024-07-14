using OpenMeteo;

namespace WetterApp;

public partial class WeatherUI : Form
{
    OpenMeteo.OpenMeteoClient mateoClient = new OpenMeteo.OpenMeteoClient();
    WeatherForecast weatherData = new WeatherForecast();


    Dictionary<int, string> weathercodesDic = new Dictionary<int, string>
    {
        { 0, "Klarer Himmel" },
        { 1, "‹berwiegend klar" },
        { 2, "Teilweise bewˆlkt" },
        { 3, "Bedeckt" },
        { 45, "Nebel" },
        { 48, "Reifnebel" },
        { 51, "Nieselregen: Leichte Intensit‰t" },
        { 53, "Nieselregen: M‰ﬂige Intensit‰t" },
        { 55, "Nieselregen: Dichte Intensit‰t" },
        { 56, "Gefrierender Nieselregen: Leichte Intensit‰t" },
        { 57, "Gefrierender Nieselregen: Dichte Intensit‰t" },
        { 61, "Regen: Leichte Intensit‰t" },
        { 63, "Regen: M‰ﬂige Intensit‰t" },
        { 65, "Regen: Starke Intensit‰t" },
        { 66, "Gefrierender Regen: Leichte Intensit‰t" },
        { 67, "Gefrierender Regen: Starke Intensit‰t" },
        { 71, "Schneefall: Leichte Intensit‰t" },
        { 73, "Schneefall: M‰ﬂige Intensit‰t" },
        { 75, "Schneefall: Starke Intensit‰t" },
        { 77, "Schneegriesel" },
        { 80, "Regenschauer: Leichte Intensit‰t" },
        { 81, "Regenschauer: M‰ﬂige Intensit‰t" },
        { 82, "Regenschauer: Heftige Intensit‰t" },
        { 85, "Schneeschauer: Leichte Intensit‰t" },
        { 86, "Schneeschauer: Starke Intensit‰t" },
        { 95, "Leichtes Gewitter" },
        { 96, "Gewitter mit leichtem Hagel" },
        { 99, "Gewitter mit starkem Hagel" }
    };

    public WeatherUI()
    {
        InitializeComponent();
    }

    private async void btnCityGo_Click(object sender, EventArgs e)
    {
        weatherData = await mateoClient.QueryAsync(txtBoxCity.Text);

        int weatherCode = GetWeatherCode();

        SetWeatherImage(weatherCode);

        lblCity.Text = "Wetter in " + txtBoxCity.Text;

        SetWeatherDescription(weatherCode);

        lblTemperature.Text = weatherData.Current.Temperature + "∞C";

        txtBoxCity.Text = "";
    }

    /// <summary>
    /// Detects the pressing of the enter key and executes the btnCityGo_Click() method 
    /// </summary>
    private void TxtBoxCity_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            btnCityGo_Click(null, EventArgs.Empty);
            e.SuppressKeyPress = true;
        }
    }

    public int GetWeatherCode()
    {
        return weatherData.Current.Weathercode.Value;
    }

    /// <summary>
    /// Sets the weather image depending on the weather code
    /// </summary>
    /// <param name="weathercode"></param>
    private void SetWeatherImage(int weathercode)
    {
        switch (weathercode)
        {
            case 0:
                picBoxWeather.Image = Properties.Resources.clearsky;
                break;

            case 1:
            case 2:
            case 3:
                picBoxWeather.Image = Properties.Resources.partlycloudy;
                break;

            case 51:
            case 53:
            case 55:
            case 56:
            case 57:
            case 61:
            case 63:
            case 65:
            case 66:
            case 67:
            case 80:
            case 81:
            case 82:
                picBoxWeather.Image = Properties.Resources.rain;
                break;

            case 95:
            case 96:
            case 99:
                picBoxWeather.Image = Properties.Resources.thunderstorm;
                break;

            case 71:
            case 73:
            case 75:
            case 77:
            case 85:
            case 86:
                picBoxWeather.Image = Properties.Resources.snow;
                break;

            default: picBoxWeather.Image = null; break;
        }
    }

    /// <summary>
    /// Sets the weather descripton depending on the weather code
    /// </summary>
    /// <param name="weathercode"></param>
    private void SetWeatherDescription(int weathercode)
    {
        if (weathercodesDic.TryGetValue(weathercode, out var weatherDescription))
        {
            lblWeatherTxt.Text = weatherDescription;
        }
        else
        {
            lblWeatherTxt.Text = "Wetterbeschreibung nicht gefunden.";
        }
    }
} 
/*
WMO Weather interpretation codes (WW)
Code	Description
45, 48	Fog and depositing rime fog
*/
