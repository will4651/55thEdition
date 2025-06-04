using BallBearing.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallBearing.ViewModels
{
    public partial class MainViewModel : ViewModelBase
    {
        [ObservableProperty]
        private ViewModelBase _currentPage;

        private readonly HomeViewModel _homeView = new ();
        private readonly SettingsViewModel _settingsView = new ();
        private readonly ActionViewModel _actionView = new ();
        private readonly CampaignViewModel _campaignView = new ();
        private readonly CharacterViewModel _characterView = new ();
        private readonly ClassViewModel _classView = new ();
        private readonly EncounterViewModel _counterView = new ();
        private readonly ItemViewModel _itemView = new ();
        private readonly RulesViewModel _rulesView = new ();

        public MainViewModel()
        {
            CurrentPage = _homeView;
        }

        [RelayCommand]
        private void GoToHome() => CurrentPage = _homeView;

        [RelayCommand]
        private void GoToSettingse() => CurrentPage = _settingsView;

        [RelayCommand]
        private void GoToAction() => CurrentPage = _actionView;

        [RelayCommand]
        private void GoToCampaign() => CurrentPage = _campaignView;

        [RelayCommand]
        private void GoToCharacter() => CurrentPage = _characterView;

        [RelayCommand]
        private void GoToClass() => CurrentPage = _classView;

        [RelayCommand]
        private void GoToEncounter() => CurrentPage = _counterView;

        [RelayCommand]
        private void GoToItem() => CurrentPage = _itemView;

        [RelayCommand]
        private void GoToRules() => CurrentPage = _rulesView;
    }
}
