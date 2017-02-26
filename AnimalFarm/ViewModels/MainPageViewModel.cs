using AnimalFarm.Models;
using Microsoft.EntityFrameworkCore;
using ServerViewWPF.Common;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Input;

namespace AnimalFarm.ViewModels
{
    class MainPageViewModel : INotifyPropertyChanged
    {

        private ICommand showAnimalsCommand;
        private bool _canExecuteMyCommand = true;

        ObservableCollection<Animal> animalsCollection = new ObservableCollection<Animal>();

        // Dont really need this at the moment, but maybe at some point i want to update properties of an animal.
        public event PropertyChangedEventHandler PropertyChanged;

        public MainPageViewModel()
        {

            ShowAnimalsCommand = new RelayCommand(
            ShowAnimals,
            () => _canExecuteMyCommand);

            //addAnimalToDb("Dog", "/img/dog.jpg");
                       
        }

        internal void addAnimalToDb(string animalName, string animalImagePath)
        {
            AnimalRepository animalRepository = new AnimalRepository();
            Animal animal = new Animal();

            animal.animalName = animalName;
            animal.animalImage = animalImagePath;

            animalRepository.Add(animal);
        }

        private void ShowAnimals()
        {
            IRepository<Animal> animalRep = new AnimalRepository();

            foreach(Animal animal in animalRep.List)
            {
                Animal newAnimal = new Animal();
                newAnimal.animalName = animal.animalName;
                newAnimal.animalImage = animal.animalImage;

                animalsCollection.Add(newAnimal);
            }
        }

        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

        public ICommand ShowAnimalsCommand
        {
            get
            {
                return showAnimalsCommand;
            }

            set
            {
                showAnimalsCommand = value;
            }
        }

        public ObservableCollection<Animal> AnimalsCollection
        {
            get
            {
                return animalsCollection;
            }

            set
            {
                animalsCollection = value;
            }
        }
    }
}
