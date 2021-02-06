using NUnit.Framework;
using PantheonProject.Kronos.NET;

namespace PantheonProject.Kronos.NET.Test
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
			Program.Main(null);
		}

		[Test]
		public void Test1()
		{
			Assert.Pass();
		}
	}
}