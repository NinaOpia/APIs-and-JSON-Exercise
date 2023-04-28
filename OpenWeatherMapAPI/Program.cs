using Newtonsoft.Json.Linq;


//create a client

//Need my Endpoint at this link: https://api.openweathermap.org/data/2.5/weather?lat=57&lon=-2.15&appid={API key}&units=imperial

//Need api key

//Create request

//Parse object

//Display weather

var client = new HttpClient();

var apiKey = "716106803d19d47bb8d44bbc6a9c32f3";

Console.WriteLine("Enter in a city: ");
var cityName = Console.ReadLine();


var weatherMapURL = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={apiKey}&units=imperial";
string weatherResponse = client.GetStringAsync(weatherMapURL).Result;
JObject weatherObject = JObject.Parse(weatherResponse);

Console.WriteLine("Weather Object");
//Console.WriteLine(weatherObject);
//Console.WriteLine(weatherResponse);
//Console.WriteLine();
Console.WriteLine("Weather: ");
Console.WriteLine($"It is {weatherObject["main"]["temp"]} degrees Fahrenheit in {cityName}");
