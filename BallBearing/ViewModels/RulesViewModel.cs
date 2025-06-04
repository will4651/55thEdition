using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallBearing.ViewModels
{
    public partial class RulesViewModel : ViewModelBase
    {
        [ObservableProperty]
        private string testString = "Rules binding functional";
    }
}
