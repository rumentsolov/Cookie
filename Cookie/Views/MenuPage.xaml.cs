using Cookie.Models;
using Cookie.Services;
using System.Collections.ObjectModel;
using System.Linq;
using Cookie.ViewModels;
using System.ComponentModel;
using Realms;
using System.Runtime.CompilerServices;

namespace Cookie.Views
{
    public partial class MenuPage : ContentPage, INotifyPropertyChanged
    {
        private ObservableCollection<Dish> dishes;

        public ObservableCollection<Dish> Dishes
        {
            get => dishes;
            set
            {
                if (dishes != value)
                {
                    dishes = value;
                    OnPropertyChanged();
                }
            }
        }

        public MenuPage()
        {
            InitializeComponent();
            Dishes = new ObservableCollection<Dish>();
            BindingContext = this;
            LoadDishes();
        }
        private async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedDish = e.CurrentSelection.FirstOrDefault() as Dish;
            if (selectedDish != null)
            {
                await Navigation.PushAsync(new DishDetailedPage(selectedDish));
                ((CollectionView)sender).SelectedItem = null;
            }
        }

        private void LoadDishes()
        {
            //AddSomeDishesToRealm();
            var realm = Realm.GetInstance();

            // Query all Dish objects from Realm
            var dishesFromRealm = realm.All<Dish>();

            // Populate the ObservableCollection with the queried dishes
            foreach (Dish dish in dishesFromRealm)
            {
                Dishes.Add(dish);
            }
        }

        private void AddSomeDishesToRealm()
        {
            var realm = Realm.GetInstance();
            realm.Write(() =>
            {
                // Clear existing data for demonstration purposes
                realm.RemoveAll<Dish>();

                // Add new dishes
                realm.Add(new Dish
                {
                    Name = "Pizza",
                    Pcs = 0,
                    Price = 9.99,
                    Description = "Classic Margherita pizza with tomato sauce and mozzarella cheese",
                    TimeForCooking = 15,
                    Picture = "pizza.png"
                });

                realm.Add(new Dish
                {
                    Name = "Burger",
                    Pcs = 0,
                    Price = 12.99,
                    Description = "Juicy beef burger",
                    TimeForCooking = 20,
                    Picture = "burger.png"
                });

                realm.Add(new Dish
                {
                    Name = "Sallad",
                    Pcs = 0,
                    Price = 7.99,
                    Description = "Fresh salad",
                    TimeForCooking = 5,
                    Picture = "salad.png"
                });

                realm.Add(new Dish
                {
                    Name = "Soup",
                    Pcs = 0,
                    Price = 2.99,
                    Description = "Incredible hot soup",
                    TimeForCooking = 18,
                    Picture = "soup.png"
                });

                realm.Add(new Dish
                {
                    Name = "Cake",
                    Pcs = 0,
                    Price = 1.99,
                    Description = "Sweet cheese cake",
                    TimeForCooking = 12,
                    Picture = "cake.png"
                });

                realm.Add(new Dish
                {
                    Name = "Fish",
                    Pcs = 0,
                    Price = 13.99,
                    Description = "Incredible baked fish",
                    TimeForCooking = 8,
                    Picture = "fish.png"
                });
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
