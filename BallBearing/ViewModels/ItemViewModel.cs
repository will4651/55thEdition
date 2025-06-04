using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallBearing.ViewModels
{
    public partial class ItemViewModel : ViewModelBase
    {
        [ObservableProperty]
        private string testString = "Item binding functional";
    }
}
