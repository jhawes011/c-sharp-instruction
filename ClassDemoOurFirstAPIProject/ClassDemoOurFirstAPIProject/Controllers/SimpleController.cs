using Microsoft.AspNetCore.Mvc;

namespace ClassDemoOurFirstAPIProject.Controllers
{
	[Route("api/hello-world")]
	[ApiController]
	public class SimpleController : ControllerBase
	{
		private static List<string> names = new List<string>();

		//pg 51 - manually added a controller

		[HttpGet("a")]
		public string HelloWorld()
		{
			return "Hello World!!!";
		}

		//see bottom pg 43
		

		public string HelloWorld2()
		{
			return "abc";
		}

		[HttpGet("say-hello/{message}")]
		public string SayHello(string message)
		{
			return $"Hello {message}";
		}

		[HttpGet("add-name/{name}")]
		public string AddName(string name)
		{
			names.Add(name);
			return $"{name} added";
		}

		[HttpGet("names")]
		public string GetNames()
		{
			string namesStr = string.Join("|", names);
			return namesStr;
		}
	}
}
