﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using winamr.Contracts.Services.General;
using winamr.Models;
using Xamarin.Forms;

namespace winamr.ViewModels
{
    public class DeviceViewModel : BaseViewModel
    {
        #region Properties

        private DeviceGroup _devices;

        public DeviceGroup Devices
        {
            get => _devices;
            set
            {
                _devices = value;
                OnPropertyChanged();
            }
        }

        #endregion

        #region Constructor

        public DeviceViewModel(IConnectionService connectionService,
            INavigationService navigationService,
            IDialogService dialogService) : base(connectionService, navigationService, dialogService)
        {
            // handle this
        }

        #endregion

        #region Commands

        /*
        public ICommand PieTappedCommand => new Command<Pie>(OnPieTapped);
        public ICommand AddToCartCommand => new Command<Pie>(OnAddToCart);
        */

        public ICommand AddDeviceGroupCommand => new Command(OnAddDeviceTapped);

        #endregion

        #region Virtual Method InitializeAsync

        public override async Task InitializeAsync(object data)
        {
            // PiesOfTheWeek = (await _catalogDataService.GetPiesOfTheWeekAsync()).ToObservableCollection();
            Devices = (DeviceGroup)data;
            //return Task.FromResult(false);
        }

        #endregion

        #region Private Methods

        private async void OnAddDeviceTapped(object addDeviceTappedEventArgs)
        {

        }

        #endregion
    }
}
