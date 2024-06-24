using Cookie.Models;
using Microsoft.Maui.Controls;
using System.Collections.Generic;

namespace Cookie.Views
{
    public partial class PurchasePage : ContentPage
    {
        private readonly DishRepository _dishRepository;

        public PurchasePage()
        {
            InitializeComponent();
            _dishRepository = new DishRepository();
            LoadDishes();
        }

        private void LoadDishes()
        {
            List<Dish> dishes = _dishRepository.GetDishes();
            dishesCollectionView.ItemsSource = dishes;
        }

        private async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection != null && e.CurrentSelection.Count > 0)
            {
                var selectedDish = e.CurrentSelection[0] as Dish;
                if (selectedDish != null)
                {
                    await Navigation.PushAsync(new DishDetailPage(selectedDish));
                }

                ((CollectionView)sender).SelectedItem = null; // Clear selection
            }
        }
    }
}
