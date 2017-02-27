using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using System.Threading;

namespace HSN
{
	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]
	public class Tests
	{
		IApp app;
		Platform platform;

		public Tests(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);
			app.Screenshot("App Launched");
		}

		[Test]
		public void Repl()
		{
			app.Repl();
		}

		[Test]
		public void FirstTest()
		{
			app.Tap("button1");
			Thread.Sleep(4000);
			app.Screenshot("Denied Push Notifications");

			app.Tap("search_button");
			Thread.Sleep(4000);
			app.Screenshot("Tapped on Search Button");

			app.EnterText("Microsoft");
			Thread.Sleep(4000);
			app.Screenshot("Typed in my search, 'Microsoft'");

			app.DismissKeyboard();
			app.Screenshot("Dismissed Keyboard");

			app.Tap("text2");
			app.Screenshot("Searched 'Microsoft'");

			app.Tap("$399.95");
			Thread.Sleep(4000);
			app.Screenshot("Tapped on 'Xbox One Gears of War Ultimate'");

			app.Tap("search_button");
			app.Screenshot("Tapped on Search Button");

			app.EnterText("Surface Pro");
			Thread.Sleep(4000);
			app.Screenshot("Typed in my search, 'Surface Pro'");

			app.DismissKeyboard();
			app.Screenshot("Dismissed Keyboard");

			app.Tap("text2");
			Thread.Sleep(4000);
			app.Screenshot("Searched 'Surface Pro'");

			app.ScrollDown();
			Thread.Sleep(4000);
			app.Screenshot("Scrolled down for more information");

			//app.Back();
			//Thread.Sleep(4000);
			//app.Screenshot("Tapped on 'Back' Button");

			app.Tap("options_menu_account");
			Thread.Sleep(4000);
			app.Screenshot("Tapped on My Account");

			app.Tap("Recently Viewed");
			Thread.Sleep(4000);
			app.Screenshot("Tapped on 'Recently Viewed'");

		}



	}
}
