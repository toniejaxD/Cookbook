using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Cookbook
{
    /// <summary>
    /// </summary>
    public partial class ShowRecipe : Window
    {
        private Recipe _recipe;
        public ShowRecipe(Guid idRecipe)
        {
            _recipe = MainWindow.recipes.FirstOrDefault(x => x.Id == idRecipe);
            InitializeComponent();
            Title = _recipe.Name + " - Książka kucharska dla studentów";
            SetDataInWindow();
        }

        private void SetDataInWindow()
        {
            Name.Content = _recipe.Name;
            Description.Text = _recipe.Description;
            Ingredients.Text = _recipe.Ingredients;
            Time.Content = _recipe.Time;
            if(!string.IsNullOrWhiteSpace(_recipe.Image))
            ImageName.Source = new BitmapImage(new Uri(_recipe.Image, UriKind.Absolute));
        }
    }
}
