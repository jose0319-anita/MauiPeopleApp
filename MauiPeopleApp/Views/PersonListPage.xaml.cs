using MauiPeopleApp.Models;
using MauiPeopleApp.ViewModels;

namespace MauiPeopleApp.Views;

public partial class PersonListPage : ContentPage
{
    private PersonListViewModel ViewModel => BindingContext as PersonListViewModel;

    public PersonListPage()
    {
        InitializeComponent();
        BindingContext = new PersonListViewModel();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        if (ViewModel.People.Count == 0)
            ViewModel.LoadPeopleCommand.Execute(null);
    }

    private async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var selectedPerson = e.CurrentSelection.FirstOrDefault() as Person;
        if (selectedPerson == null)
            return;
        var detailPage = new PersonDetailPage();
        detailPage.SetPerson(selectedPerson);
        await Navigation.PushAsync(detailPage);


        ((CollectionView)sender).SelectedItem = null;
    }
}