using CommunityToolkit.Mvvm.ComponentModel;
using Cookie.Models;

namespace Cookie.ViewModels
{
    public partial class MenuPageViewModel : ObservableObject
    {
        [ObservableProperty]
        IList<Dish> dishes;

        private void LoadDishes()
        {
            Dishes = new IList<Dish>();
        }
        public MenuPageViewModel()
        {
            LoadDishes();
        }


    }
}
