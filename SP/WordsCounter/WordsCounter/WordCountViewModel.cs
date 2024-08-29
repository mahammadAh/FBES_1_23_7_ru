using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WordsCounter
{
    public class WordCountViewModel : ViewModelBase
    {


        private string fileUrl;
        public string FileUrl
        {
            get { return fileUrl; }
            set { Set(ref fileUrl, value); }
        }


        private string wordsCount;
        public string WordsCount
        {
            get { return wordsCount; }
            set { Set(ref wordsCount, value); }
        }


        private string clickCounter = "0";
        public string ClickCounter
        {
            get { return clickCounter; }
            set { Set(ref clickCounter, value); }
        }



        private RelayCommand clickButtonCommand;

        public RelayCommand ClickButtonCommand
        {
            get
            {
                return clickButtonCommand ?? new RelayCommand(
                 async () =>
                {
                    WordsCount = await getWordsCountAsync(FileUrl);

                    // C:\Users\ahmadov_m\Desktop\Code\FBES_1_23_7_ru\SP\WordsCounter\WordsCounter\Data.txt

                });
            }

        }


        public Task<string> getWordsCountAsync(string fileUrl)
        {

            return Task<string>.Run(() =>
            {
                int wordsArrayLength;

                using (StreamReader file = new StreamReader(fileUrl))
                {
                    var result = file.ReadToEnd();

                    var words = result.Split(' ');

                    wordsArrayLength = words.Length;

                }

                return wordsArrayLength.ToString();
            });
            

    

            //return Task.Run(() =>
            //{
            //    using (StreamReader file = new StreamReader(FileUrl))
            //    {
            //        var result = file.ReadToEnd();

            //        var words = result.Split(' ');

            //        var wordsArrayLength = words.Length;

            //        WordsCount = wordsArrayLength.ToString();

            //        return WordsCount;

            //    }
            //})
        }


        private RelayCommand clickerButtonCommand;

        public RelayCommand ClickerButtonCommand
        {
            get
            {
                return clickerButtonCommand ?? new RelayCommand(
                () =>
                {
                    var newClickCounter = Int32.Parse(ClickCounter);

                    newClickCounter = newClickCounter + 1;

                    ClickCounter = newClickCounter.ToString();

                  

                });
            }

        }

    }
}