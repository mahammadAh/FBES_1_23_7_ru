using FuzzyLogic.Services;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuzzyLogic.Models;
using System.Text.Json;
using System.IO;

namespace FuzzyLogic.ViewModels
{
    internal class AdminPanelViewModel : ViewModelBase
    {
        private IMyNavigationService MyNavigationServie { get; set; }

        private string categorieName;

        public string CategorieName
        {
            get { return categorieName; }
            set { Set(ref categorieName, value); }
        }


        private Test currentTest;

        public Test CurrentTest
        {
            get { return currentTest; }
            set { Set(ref currentTest, value); }
        }

        private List<Catigorie> catigories { get; set; } = new List<Catigorie>();


        public AdminPanelViewModel(IMyNavigationService navigationService) 
        {
            MyNavigationServie = navigationService;
            CurrentTest = new Test();
        }

        private RelayCommand openUserPanelCommand;

        public RelayCommand OpenUserPanelCommand
        {
            get
            {
                return openUserPanelCommand ?? new RelayCommand(
                () =>
                {
                    using (FileStream fs = new FileStream("tests.json", FileMode.OpenOrCreate))
                    {
                        JsonSerializer.Serialize<List<Catigorie>>(fs,catigories);
                    }

                    MyNavigationServie.Navigate("userPanel");
                });
            }

        }


        private RelayCommand addQuestionCommand;

        public RelayCommand AddQuestionCommand
        {
            get
            {
                return addQuestionCommand ?? new RelayCommand(
                () =>
                {
                   var foundCatigorie =  catigories.FirstOrDefault(x => x.CatigorieName == CategorieName);

                    if (foundCatigorie != null)
                    {
                        foundCatigorie.Tests.Add(new Test
                        {
                            Answer = CurrentTest.Answer,
                            Question1 = CurrentTest.Question1,
                            Question2 = CurrentTest.Question2,
                            Question3 = CurrentTest.Question3,
                            Question4 = CurrentTest.Question4,
                            CorrectAnswer = 1

                        });
                    }
                    else
                    {
                        catigories.Add(new Catigorie() { CatigorieName = CategorieName });

                        var newFoundCatigorie = catigories.FirstOrDefault(x => x.CatigorieName == CategorieName);


                        newFoundCatigorie.Tests.Add(new Test
                        {
                            Answer = CurrentTest.Answer,
                            Question1 = CurrentTest.Question1,
                            Question2 = CurrentTest.Question2,
                            Question3 = CurrentTest.Question3,
                            Question4 = CurrentTest.Question4,
                            CorrectAnswer = 1

                        });

                    }

                        CurrentTest = new Test();


                });
            }

        }

    }
}
