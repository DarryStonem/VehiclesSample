using System;
using System.Collections.ObjectModel;
using MyCars.Models;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyCars.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public ICommand AddCarCommand
        {
            get
            {
                return new Command(() =>
                {
                    AddVehicle();
                });
            }
        }

        private string brand;
        public string Brand
        {
            get { return brand; }
            set
            {
                brand = value;
                OnPropertyChanged(nameof(Brand));
            }
        }

        private string model;
        public string Model
        {
            get { return model; }
            set
            {
                model = value;
                OnPropertyChanged(nameof(Model));
            }
        }

        private int year;
        public int Year
        {
            get { return year; }
            set
            {
                year = value;
                OnPropertyChanged(nameof(Year));
            }
        }

        private ObservableCollection<Vehicle> vehicles;
        public ObservableCollection<Vehicle> Vehicles
        {
            get { return vehicles; }
            set
            {
                vehicles = value;
                OnPropertyChanged(nameof(Year));
            }
        }

        public HomeViewModel()
        {
            LoadFirstVehicles();
        }

        private void AddVehicle()
        {
            if(String.IsNullOrEmpty(Brand) && String.IsNullOrEmpty(Model) && Year <= 0)
            {
                // Error
                return;
            }

            var vehicle = new Vehicle
            {
                Brand = this.Brand,
                Model = this.Model,
                Year = this.Year
            };

            Vehicles.Add(vehicle);
        }

        private void LoadFirstVehicles()
        {
            if (Vehicles == null)
                Vehicles = new ObservableCollection<Vehicle>();
            else
                Vehicles.Clear();

            Vehicles.Add(new Vehicle()
            {
                Model = "Soul",
                Brand = "Kia",
                Year = 2019
            });

            Vehicles.Add(new Vehicle()
            {
                Model = "Sentra",
                Brand = "Nissan",
                Year = 2010
            });
        }
    }
}
