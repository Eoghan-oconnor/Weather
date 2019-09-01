using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;
using System.Text;
using Newtonsoft.Json;  // for json functions
using WeatherApp;

namespace WeatherApp

{
    class MyUtils
    {
        /*public const string JSON_DOGS_FILE = "Seaches.txt";
       
        //UWP_IMG_FOLDER + MAINPAGE_IMAGE

        public static ObservableCollection<Seaches> ReadDogListData()
        {
            ObservableCollection<Seaches> myList = new ObservableCollection<Seaches>();
            string jsonText;

            try  // reading the localApplicationFolder first
            {
                string path = Environment.GetFolderPath(
                                Environment.SpecialFolder.LocalApplicationData);
                string filename = Path.Combine(path, JSON_DOGS_FILE);
                using (var reader = new StreamReader(filename))
                {
                    jsonText = reader.ReadToEnd();
                    // need json library
                }
            }
            catch // fallback is to read the default file
            {
                var assembly = IntrospectionExtensions.GetTypeInfo(
                                                typeof(MainPage)).Assembly;
                // create the stream
                Stream stream = assembly.GetManifestResourceStream(
                                    "Weather.Data.Seaches.txt");
                using (var reader = new StreamReader(stream))
                {
                    jsonText = reader.ReadToEnd();
                    // include JSON library now
                }
            }

            myList = JsonConvert.DeserializeObject<ObservableCollection<Seaches>>(jsonText);

            return myList;
        }

        public static void SaveDogListData(ObservableCollection<Seaches> saveList)
        {
            // need the path to the file
            string path = Environment.GetFolderPath(
                Environment.SpecialFolder.LocalApplicationData);
            string filename = Path.Combine(path, JSON_DOGS_FILE);
            // use a stream writer to write the list
            using (var writer = new StreamWriter(filename, false))
            {
                // stringify equivalent
                string jsonText = JsonConvert.SerializeObject(saveList);
                writer.WriteLine(jsonText);
            }
        }*/

    }
}