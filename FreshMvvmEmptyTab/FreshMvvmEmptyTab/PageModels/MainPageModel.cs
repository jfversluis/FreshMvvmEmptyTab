using System.Collections.ObjectModel;
using FreshMvvm;
using Xamarin.Forms;

namespace FreshMvvmEmptyTab.PageModels
{
    public class MainPageModel : FreshBasePageModel
    {
        public ObservableCollection<Page> Pages { get; set; }

        public Page SelectedPage { get; set; }

        public MainPageModel()
        {
            Pages = new ObservableCollection<Page>
            {
                FreshPageModelResolver.ResolvePageModel<Tab1PageModel>(),
                FreshPageModelResolver.ResolvePageModel<Tab2PageModel>()
            };

            //SelectedPage = Pages[1];
        }

        public override void Init(object initData)
        {
            base.Init(initData);

            SelectedPage = Pages[1];

            RaisePropertyChanged("SelectedPage");
        }
    }
}