
using RestAPI.Models;
using RestAPI.Services;
using System.Text;

const string serverURL = "http://localhost:5000/games";
//await GetAllGames();
OrderService orderService = new OrderService();

Order order1 = new Order {Id = 1, Customer = "Test", Price = 100, Quantity = 2 };

await orderService.AddOrder(order1);


//var countryService = new CountryService();
//var countries = await countryService.GetAllCountry();

//countries.ForEach(p => Console.WriteLine(p.name.common + "  |  " + p.name.official + "   |   "));


//async Task GetAllGames()
//{
//	try
//	{
//		HttpClient httpRequest = new HttpClient();
//		var result = await httpRequest.GetAsync(serverURL);
//		Console.WriteLine(await result.Content.ReadAsStringAsync());
//		Console.ReadLine();
//	}
//	catch (Exception ex)
//	{
//		Console.WriteLine(ex.ToString());
//		throw ex;
//	}
//}

//async Task AddGame(VideoGame videoGame)
//{
//	try
//	{
//		HttpClient httpRequest = new HttpClient();
//		var json = Newtonsoft.Json.JsonConvert.SerializeObject(videoGame);
//		using HttpContent content = new StringContent(json, Encoding.UTF8, "application");
		
//	}
//	catch (Exception ex)
//	{
//        Console.WriteLine(ex.ToString());
//        throw ex;
//    }
//}




