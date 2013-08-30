using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MusicStore.Data;
using MusicStore.WebAPI;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Net.Http.Headers;
using System.ServiceModel.Web;
using System.Runtime.Serialization;
using MusicStore.Client;


namespace MusicStore.Client
{
    static class Program
    {
        static string baseUrl = "http://localhost:65119/api";


        static void Main(string[] args)
        {
            string inputLine = "";

            RequestConsumer reqConsumer = new RequestConsumer(baseUrl);

            while (true)
            {
                PrintMenu();
                inputLine = Console.ReadLine().ToLower();

                if (inputLine == "4")
                {
                    break;
                }

                ExecuteMenuChoice(inputLine, reqConsumer);

                PrintEndOperationsCycle();
            }


        }

        static void ExecuteMenuChoice(string inputChoice, RequestConsumer reqConsumer)
        {
            switch (inputChoice)
            {
                case "1":
                    {
                        string controller = "/Artists";
                        PrintCurrentPath(controller);

                        PrintCRUDOperationsChoices();
                        inputChoice = Console.ReadLine();

                        ExecuteCRUDChoice(inputChoice, reqConsumer, controller, EnterArtist, UpdateArtist);
                    }
                    break;
                case "2":
                    {
                        string controller = "/Albums";

                        PrintCurrentPath(controller);

                        PrintCRUDOperationsChoices();

                        inputChoice = Console.ReadLine();

                        ExecuteCRUDChoice(inputChoice, reqConsumer, controller, EnterAlbum, UpdateAlbum);
                    } break;
                case "3":
                    {
                        string controller = "/Songs";

                        PrintCurrentPath(controller);

                        PrintCRUDOperationsChoices();

                        inputChoice = Console.ReadLine();

                        ExecuteCRUDChoice(inputChoice, reqConsumer, controller, EnterSong, UpdateSong);
                    } break;

                default: Console.WriteLine("Error, incorrect digit."); break;
            }
        }

        static void ExecuteCRUDChoice(string inputChoice, RequestConsumer reqConsumer, string controller,
            Func<RequestConsumer, string, string> CreateEntry, Func<RequestConsumer, string, string> UpdateEntry)
        {
            switch (inputChoice)
            {
                case "1":
                    {
                        var sent = CreateEntry(reqConsumer, controller);
                        Console.WriteLine(sent);
                    }
                    break;
                case "2":
                    {
                        var recieved = reqConsumer.Read(controller);
                        Console.WriteLine(recieved);
                    }
                    break;
                case "3":
                    {
                        var recieved = UpdateEntry(reqConsumer, controller);
                        Console.WriteLine(recieved);
                    }
                    break;
                case "4":
                    {
                        Console.Write("Enter id: ");
                        var inputId = int.Parse(Console.ReadLine());
                        var recieved = reqConsumer.Delete(controller, inputId.ToString());
                        Console.WriteLine("Deleted: \n{0}", recieved);
                    }
                    break;
                case "5":
                    {
                        Console.Write("Enter id: ");
                        var inputId = int.Parse(Console.ReadLine());
                        var recieved = reqConsumer.Read(controller, inputId.ToString());
                        Console.WriteLine(recieved);
                    }
                    break;
                default: Console.WriteLine("Error, incorrect digit."); break;
            }
        }

        private static string UpdateArtist(RequestConsumer reqConsumer, string controller)
        {
            Console.Write("Enter id: ");
            var inputId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter country(optional): ");
            string country = Console.ReadLine();
            Console.WriteLine("Enter birth date(optional): ");
            DateTime? date = null;
            try
            {
                date = DateTime.Parse(Console.ReadLine());
            }
            catch (FormatException ex)
            {

            }

            Artist newArtist = new Artist()
            {
                Id = inputId,
                Name = name,
                DateOfBirth = date ?? DateTime.MinValue
            };

            Console.WriteLine("As Json(1) Or XML(2)? ");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                var sent = reqConsumer.UpdateAsJson<Artist>(newArtist, controller, inputId.ToString());
                return sent;
            }
            else
            {
                var sent = reqConsumer.UpdateAsXML<Artist>(newArtist, controller, inputId.ToString());
                return sent;
            }
        }

        private static string EnterArtist(RequestConsumer reqConsumer, string controller)
        {
            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter country(optional): ");
            string country = Console.ReadLine();
            Console.WriteLine("Enter birth date(optional): ");
            DateTime? date = null;
            try
            {
                date = DateTime.Parse(Console.ReadLine());
            }
            catch (FormatException ex)
            {

            }

            Artist newArtist = CreateArtistObject(name, date);

            Console.WriteLine("As Json(1) Or XML(2)? ");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                var sent = reqConsumer.CreateAsJson<Artist>(newArtist, controller);
                return sent;
            }
            else
            {
                var sent = reqConsumer.CreateAsXML<Artist>(newArtist, controller);
                return sent;
            }
        }

        private static Artist CreateArtistObject(string name, DateTime? date)
        {
            Artist newArtist = new Artist()
            {
                Name = name,
                DateOfBirth = date ?? DateTime.MinValue
            };
            return newArtist;
        }

        private static string EnterAlbum(RequestConsumer reqConsumer, string controller)
        {
            Console.WriteLine("Enter title: ");
            string title = Console.ReadLine();
            Console.WriteLine("Enter producer(optional): ");
            string producer = Console.ReadLine();
            Console.WriteLine("Enter release date(optional): ");
            DateTime? releaseDate = null;
            try
            {
                releaseDate = DateTime.Parse(Console.ReadLine());
            }
            catch (FormatException ex)
            {

            }

            Album newAlbum = new Album()
            {
                Title = title,
                Producer = producer,
                Year = releaseDate ?? DateTime.MinValue,
            };

            Console.WriteLine("As Json(1) Or XML(2)? ");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                var sent = reqConsumer.CreateAsJson<Album>(newAlbum, controller);
                return sent;
            }
            else
            {
                var sent = reqConsumer.CreateAsXML<Album>(newAlbum, controller);
                return sent;
            }
        }

        private static string UpdateAlbum(RequestConsumer reqConsumer, string controller)
        {
            Console.Write("Enter id: ");
            var inputId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter title: ");
            string title = Console.ReadLine();
            Console.WriteLine("Enter producer(optional): ");
            string producer = Console.ReadLine();
            Console.WriteLine("Enter release date(optional): ");
            DateTime? releaseDate = null;
            try
            {
                releaseDate = DateTime.Parse(Console.ReadLine());
            }
            catch (FormatException ex)
            {

            }

            Console.WriteLine("Artist Name(optional): ");
            string artistName = Console.ReadLine();


            MusicStoreEntities db = new MusicStoreEntities();

            var artist = (from a in db.Artists
                          where a.Name == artistName
                          select a
                        ).ToList();

            Album newAlbum;

            if (artist == null)
            {
                newAlbum = new Album()
                {
                    Title = title,
                    Producer = producer,
                    Year = releaseDate ?? DateTime.MinValue
                };
            }
            else
            {
                List<Artist> artists = new List<Artist>();
                foreach (var art in artist)
                {
                    artists.Add(CreateArtistObject(artist[0].Name, artist[0].DateOfBirth));
                }

                newAlbum = new Album()
                {

                    Title = title,
                    Producer = producer,
                    Year = releaseDate ?? DateTime.MinValue,
                    Artists = artists
                };
            }

            Console.WriteLine("As Json(1) Or XML(2)? ");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                var sent = reqConsumer.UpdateAsJson<Album>(newAlbum, controller, inputId.ToString());
                return sent;
            }
            else
            {
                var sent = reqConsumer.UpdateAsXML<Album>(newAlbum, controller, inputId.ToString());
                return sent;
            }
        }

        private static string EnterSong(RequestConsumer reqConsumer, string controller)
        {
            Console.WriteLine("Enter title: ");
            string title = Console.ReadLine();
            Console.WriteLine("Enter genre(optional): ");
            string genre = Console.ReadLine();
            Console.WriteLine("Enter release date(optional): ");
            DateTime? releaseDate = null;
            try
            {
                releaseDate = DateTime.Parse(Console.ReadLine());
            }
            catch (FormatException ex)
            {

            }

            MusicStoreEntities db = new MusicStoreEntities();

            Console.WriteLine("Artist Name(optional): ");
            string artistName = Console.ReadLine();

            var artist = (from a in db.Artists
                          where a.Name == artistName
                          select a
                        ).FirstOrDefault();

            Song newSong = new Song()
            {
                Title = title,
                Genre = genre,
                Year = releaseDate ?? DateTime.MinValue
            };

            newSong.Artist = CreateArtistObject(artist.Name, artist.DateOfBirth);

            Console.WriteLine("As Json(1) Or XML(2)? ");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                var sent = reqConsumer.CreateAsJson<Song>(newSong, controller);
                return sent;
            }
            else
            {
                var sent = reqConsumer.CreateAsXML<Song>(newSong, controller);
                return sent;
            }
        }

        private static string UpdateSong(RequestConsumer reqConsumer, string controller)
        {
            Console.Write("Enter id: ");
            var inputId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter title: ");
            string title = Console.ReadLine();
            Console.WriteLine("Enter genre(optional): ");
            string genre = Console.ReadLine();
            Console.WriteLine("Enter release date(optional): ");
            DateTime? releaseDate = null;
            try
            {
                releaseDate = DateTime.Parse(Console.ReadLine());
            }
            catch (FormatException ex)
            {

            }

            MusicStoreEntities db = new MusicStoreEntities();

            Console.WriteLine("Artist Name(optional): ");
            string artistName = Console.ReadLine();




            var artist = (Artist)(from a in db.Artists
                                  where a.Name == artistName
                                  select a
                        ).FirstOrDefault();
            Song newSong;

            if (artist == null)
            {
                newSong = new Song()
                {
                    Id = inputId,
                    Title = title,
                    Genre = genre,
                    Year = releaseDate ?? DateTime.MinValue
                };
            }
            else
            {
                newSong = new Song()
                {
                    Id = inputId,
                    Title = title,
                    Genre = genre,
                    Year = releaseDate ?? DateTime.MinValue,
                    Artist = CreateArtistObject(artist.Name, artist.DateOfBirth)
                };
            }

            Console.WriteLine("As Json(1) Or XML(2)? ");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                var sent = reqConsumer.UpdateAsJson<Song>(newSong, controller, inputId.ToString());
                return sent;
            }
            else
            {
                var sent = reqConsumer.UpdateAsXML<Song>(newSong, controller, inputId.ToString());
                return sent;
            }
        }

        static string PrintCurrentPath(string controller)
        {
            string path = baseUrl + controller;
            Console.WriteLine(path);

            return path;
        }

        static void PrintMenu()
        {
            Console.WriteLine("Enter corresponding number for each option:\n1. Artist\n2. Album\n3. Song\n4. End");
        }

        static void PrintCRUDOperationsChoices()
        {
            Console.WriteLine("1. Create\n2. Read\n3. Update\n4. Delete\n5. Read with Id");
        }

        static void PrintEndOperationsCycle()
        {
            Console.WriteLine("\n========================\n");
        }
    }
}
            // XML
            //  <?xml version="1.0" encoding="UTF-8" ?>
            //  <Album xmlns:i="http://www.w3.org/2001/XMLSchema-instance" xmlns="http://schemas.datacontract.org/2004/07/MusicStore.Data">
            //      <Producer>DJ Hype</Producer>
            //      <Title>DJ Hype</Title>
            //      <Year>2012-01-01T00:00:00</Year>
            //  </Album>

            // JSON
            //            {
            //    "Songs": [
            //        {
            //            "Album": {
            //                "Songs": [],
            //                "Artists": [],
            //                "Id": 2,
            //                "Title": "Funky Beats",
            //                "Year": "2002-01-01T00:00:00",
            //                "Producer": "Гошо23"
            //            },
            //            "Id": 1,
            //            "Title": "Billy Hollyday",
            //            "Year": "1964-01-01T00:00:00",
            //            "Genre": "Jazz",
            //            "ArtistId": 3,
            //            "AlbumId": 2
            //        }
            //    ],
            //    "Albums": [
            //        {
            //            "Songs": [
            //                {
            //                    "Id": 1,
            //                    "Title": "Billy Hollyday",
            //                    "Year": "1964-01-01T00:00:00",
            //                    "Genre": "Jazz",
            //                    "ArtistId": 3,
            //                    "AlbumId": 2
            //                }
            //            ],
            //            "Artists": [],
            //            "Id": 2,
            //            "Title": "Funky Beats",
            //            "Year": "2002-01-01T00:00:00",
            //            "Producer": "Гошо23"
            //        }
            //    ],
            //    "Id": 3,
            //    "Name": "Funky DL",
            //    "DateOfBirth": "1982-11-05T00:00:00"
            //}

