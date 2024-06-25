using Cookie.Models;
using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;
using System.Linq;

namespace Cookie.Views
{
    public partial class MenuPage : ContentPage
    {
        public ObservableCollection<Dish> Dishes { get; set; }

        public MenuPage()
        {
            InitializeComponent();
            Dishes = new ObservableCollection<Dish>(DishRepository.GetAllDishes());
            BindingContext = this;
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
