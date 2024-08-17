using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Cookbook
{
    /// <summary>
    /// </summary>
    public partial class MainWindow : Window
    {
        public static List<Recipe> recipes = new List<Recipe>();
        private static string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
        

        public MainWindow()
        {
            
            InitializeComponent();
            InitializerecipeList();
            InitialzeDataGrid();
        }

        private void InitializerecipeList()
        {
            recipes.Add(new Recipe
            {
                Id = Guid.NewGuid(),
                Ingredients = Common.Ingredients1,
                Description = Common.Description1,
                Name = Common.Name1,
                Image = baseDirectory + Common.Image1,
                Time = Common.Time1
            });
            recipes.Add(new Recipe
            {
                Id = Guid.NewGuid(),
                Ingredients = Common.Ingredients2,
                Description = Common.Description2,
                Name = Common.Name2,
                Image = baseDirectory + Common.Image2,
                Time = Common.Time2
            });

            recipes.Add(new Recipe
            {
                Id = Guid.NewGuid(),
                Ingredients = Common.Ingredients3,
                Description = Common.Description3,
                Name = Common.Name3,
                Image = baseDirectory + Common.Image3,
                Time = Common.Time3 
            });

            recipes.Add(new Recipe
            {
                Id = Guid.NewGuid(),
                Ingredients = Common.Ingredients4,
                Description = Common.Description4,
                Name = Common.Name4,
                Image = baseDirectory + Common.Image4,
                Time = Common.Time4
            });

            recipes.Add(new Recipe
            {
                Id = Guid.NewGuid(),
                Ingredients = Common.Ingredients5,
                Description = Common.Description5,
                Name = Common.Name5,
                Image = baseDirectory + Common.Image5,
                Time = Common.Time5
            });

            recipes.Add(new Recipe
            {
                Id = Guid.NewGuid(),
                Ingredients = Common.Ingredients6,
                Description = Common.Description6,
                Name = Common.Name6,
                Image = baseDirectory + Common.Image6,
                Time = Common.Time6
            });

            recipes.Add(new Recipe
            {
                Id = Guid.NewGuid(),
                Ingredients = Common.Ingredients7,
                Description = Common.Description7,
                Name = Common.Name7,
                Image = baseDirectory + Common.Image7,
                Time = Common.Time7
            });

            recipes.Add(new Recipe
            {
                Id = Guid.NewGuid(),
                Ingredients = Common.Ingredients8,
                Description = Common.Description8,
                Name = Common.Name8,
                Image = baseDirectory + Common.Image8,
                Time = Common.Time8
            });


        }
        private void InitialzeDataGrid()
        {
            List<Recipe> sortedByNameRecipes = recipes.OrderBy(x => x.Name).ToList();
            if (sortedByNameRecipes.Count > 0)
            {
                dataGrid.ItemsSource = sortedByNameRecipes;
            }
        }
        private void DataGridCell_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Recipe row;
            int selectedIndex = Int32.Parse(dataGrid.SelectedIndex.ToString());
            if (selectedIndex != recipes.Count)
            {
                row = (Recipe)dataGrid.SelectedItem;
                ShowRecipe showRecipe = new ShowRecipe(row.Id);
                showRecipe.Show();
            }
        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}