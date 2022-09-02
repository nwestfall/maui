using Microsoft.Maui.Controls.Core.UnitTests;
using Microsoft.Maui.Graphics;
using NUnit.Framework;

namespace Microsoft.Maui.Controls.Xaml.UnitTests
{
	public partial class ColorConverter : ContentPage
	{
		public ColorConverter()
		{
			InitializeComponent();

			BindingContext = this;
		}

		public ColorConverter(bool useCompiledXaml)
		{
			//this stub will be replaced at compile time
		}

		public string ButtonBackground
		{
			get
			{
				return "#fc87ad";
			}
		}

		[TestFixture]
		public class Tests
		{
			[TestCase(false)]
			[TestCase(true)]
			public void StringsAreValidAsColor(bool useCompiledXaml)
			{
				var layout = new ColorConverter(useCompiledXaml);

				var expected = Color.FromArgb("#fc87ad");

				Assert.AreEqual(expected, layout.Button0.BackgroundColor);
			}
		}
	}
}
