
using Newtonsoft.Json.Linq;

var client = new HttpClient();
var apiKey = "d61331540312d7f681385120f94071ef";

Console.WriteLine("What city would you like to know the weather for?");
var cityName = Console.ReadLine();
var weatherURL = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={apiKey}&units=imperial";
 
var weatherResponse = client.GetStringAsync(weatherURL).Result;
var weatherObject = JObject.Parse(weatherResponse);

Console.WriteLine($"{weatherObject["main"]["temp"]} degrees Fahrenheit for {cityName}");