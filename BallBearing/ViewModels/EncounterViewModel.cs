using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallBearing.ViewModels
{
    public partial class EncounterViewModel : ViewModelBase
    {
        [ObservableProperty]
        private string testString = "Encounter binding functional";
    }
}
