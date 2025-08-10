using MauiPeopleApp.Models;
using Microsoft.Maui.Controls;

namespace MauiPeopleApp.Views
{
    public partial class PersonDetailPage : ContentPage
    {
        public PersonDetailPage()
        {
            InitializeComponent();
        }

        public void SetPerson(Person person)
        {
            BindingContext = person;
        }
    }

}