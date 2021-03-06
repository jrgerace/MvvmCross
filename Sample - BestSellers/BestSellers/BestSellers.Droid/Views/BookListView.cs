using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Graphics.Drawables;

using BestSellers;
using BestSellers.ViewModels;
using Cirrious.MvvmCross.Binding.Android.Views;

namespace BestSellers.Droid.Views
{
    [Activity(Label = "Best Sellers in Category", LaunchMode=Android.Content.PM.LaunchMode.SingleTop)]
    public class BookListView : MvxBindingActivityView<BookListViewModel>
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.Page_BookListView);
        }
    }
}