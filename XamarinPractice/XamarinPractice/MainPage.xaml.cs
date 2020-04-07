using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinPractice.Shared;

namespace XamarinPractice
{
	// Learn more about making custom code visible in the Xamarin.Forms previewer
	// by visiting https://aka.ms/xamarinforms-previewer
	[DesignTimeVisible(false)]
	public partial class MainPage : ContentPage
	{
		bool isTaskRunning = true;

		public MainPage()
		{
			InitializeComponent();
		}

		void OnButtonClicked(object sender, EventArgs args)
		{
			isTaskRunning = !isTaskRunning;
			isLoading.IsRunning = isTaskRunning;

			mainLabel.BackgroundColor = Randomizer
				.GetRandomDouble() > 0.5
					? Color.Red
					: Color.Green;
		}
	}
}
