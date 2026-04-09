namespace MovieCatalog.Views;

public partial class MoviesListPage : ContentPage
{
    public MoviesListPage()
    {
        InitializeComponent();
    }

    private async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.Count == 0)
            return;

        await Navigation.PushAsync(new MovieDetailPage());

        ((CollectionView)sender).SelectedItem = null;
    }

    private void MenuItem_Clicked(object sender, EventArgs e)
    {
        if (sender is MenuItem menuItem && menuItem.BindingContext is ViewModels.MovieViewModel movie)
        {
            App.MainViewModel.DeleteMovie(movie);
        }
    }
}