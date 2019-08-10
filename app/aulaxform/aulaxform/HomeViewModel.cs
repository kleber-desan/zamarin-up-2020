using aulaxform.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;


namespace aulaxform
{
    public sealed class HomeViewModel : BindableObject

    {
        private ObservableCollection<Candy> items = new ObservableCollection<Candy>();

        public ObservableCollection<Candy> Items
        { get => items;
            set { items = value; OnPropertyChanged(); }
        }

        public HomeViewModel()
        {
            Items = new ObservableCollection<Candy>(
            new List<Candy> {
            new Candy { Name = "zzzzz", Description = "asdasdasd"}
            });
        }

    }
}
