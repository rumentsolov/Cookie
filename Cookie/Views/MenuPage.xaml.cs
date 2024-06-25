using Cookie.Models;
using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;

namespace Cookie.Views
{
    public partial class MenuPage : ContentPage
    {
        public ObservableCollection<Dish> Dishes { get; set; }

        public MenuPage()
        {
            InitializeComponent();

            Dishes = new ObservableCollection<Dish>
            {
                new Dish { Name = "Pizza", Price = 9.99m, Description = "Delicious cheese pizza", TimeForCooking = "20 minutes", Picture = "pizza.jpg" },
                new Dish { Name = "Burger", Price = 5.99m, Description = "Juicy beef burger", TimeForCooking = "15 minutes", Picture = "burger.jpg" },
                // Add more dishes as needed
            };

            dishesCollectionView.ItemsSource = Dishes;
        }

        private async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedDish = e.CurrentSelection.FirstOrDefault() as Dish;
            if (selectedDish != null)
            {
                await Navigation.PushAsync(new DishDetailPage(selectedDish));
                ((CollectionView)sender).SelectedItem = null;
            }
        }
    }
}
