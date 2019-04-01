using System.Collections.Generic;
using XamarinFloatingTabs.Models;

namespace XamarinFloatingTabs.Views
{
    public partial class DiscoverPage : BasePage
    {
        public IEnumerable<Story> Stories { get; }

        public DiscoverPage()
        {
            InitializeComponent();

            Stories = new Story[]
            {
                new Story() { Category = "The Wilds", Title = "Why we need to save the scavengers?", ImageUrl = "http://www.birdlife.org/sites/default/files/styles/1600/public/news/european_turtle_dove_streptopelia_turtur_websitec_revital_salomon.jpg" },
                new Story() { Category = "Science", Title = "Drunk birds? What is happening...", ImageUrl = "http://www.birdlife.org/sites/default/files/styles/full_620x295/public/news/little_spiderhunter_c_noicherrybeans_shutterstock_smaller_1.jpg" },
                new Story() { Category = "The Wilds", Title = "Why we need to save the scavengers?", ImageUrl = "http://www.birdlife.org/sites/default/files/styles/full_620x295/public/news/canada_warbler_c_jayne_gulbrand_smaller.jpg" },
                new Story() { Category = "Science", Title = "Drunk birds? What is happening...", ImageUrl = "http://cdn.images.express.co.uk/img/dynamic/13/590x/549233_1.jpg" },
                new Story() { Category = "The Wilds", Title = "Why we need to save the scavengers?", ImageUrl = "http://www.birdlife.org/sites/default/files/styles/full_620x295/public/news/rufous_hummingbird_selasphorus_rufus_c_ryan_bushby_1.jpg" }
            };

            BindingContext = this;
        }
    }
}