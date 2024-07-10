using System.Collections.ObjectModel;
using UpworkDemo.Models;

namespace UpworkDemo.Pages;

public partial class WelcomePage : ContentPage
{
	public ObservableCollection<Banner> Banners { get; set; }
	public WelcomePage()
	{
		InitializeComponent();
        LoadBannerData();
        bannerCarousel.ItemsSource = Banners;
	}

	private void LoadBannerData()
	{
        Banners = new ObservableCollection<Banner>
		{
            new Banner
			{
                ImagePath = "image1.jpg",
                Title = "Find great work",
                ShortDescription = "Meet clients you're excited to work with and grow your independent career or business."
            },
            new Banner
			{
                ImagePath = "image3.jpg",
                Title = "Find opportuniies for every stage of your freelance career",
                ShortDescription = "Search and apply for jobs, save job searches and more."
            },
            new Banner
            {
                ImagePath = "image2.jpg",
                Title = "Collaborate on the go",
                ShortDescription = "Chat, share files, and share progress."
            }
        };
    }   
}