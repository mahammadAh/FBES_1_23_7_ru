using EF_CodeFirst.Models;
using EF_CodeFirst.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool endProgram = false;
            while (!endProgram)
            {
                Console.WriteLine("1.Create User \n2.Create Id Card \n3.Add Note \n4.Add Image \n5.Add Image to Note\n6.Get Users\n7.Get Id Cards \n9.End\n");
                int selected = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n\n");
                UserRepository userRepository = new UserRepository();
                IdCardRepository idCardRepository = new IdCardRepository();
                Console.Clear();
                switch (selected)
                {
                    case 1:
                      

                        Console.WriteLine("Name : ");
                        var name = Console.ReadLine();
                        Console.WriteLine("Surname : ");
                        var surname = Console.ReadLine();
                        Console.WriteLine("Login : ");
                        var login = Console.ReadLine();
                        Console.WriteLine("Password : ");
                        var password = Console.ReadLine();
      

                        var newUser = new User
                        {
                            Name = name,
                            Surname = surname,
                            Login = login,
                            Password = password,
                        };

                        userRepository.Add(newUser);
                        break;
                    case 2:

                  

                        Console.WriteLine("FIN : ");
                        var finCode = Console.ReadLine();
                        Console.WriteLine("User Id : ");
                        var userId = Convert.ToInt32(Console.ReadLine());
                        var newIdCard = new IdCard
                        {
                            FIN = finCode,
                            UserId = userId
                        };

                        idCardRepository.Add(newIdCard);

                        break;


                    case 3:
                        NoteRepository noteRepository = new NoteRepository();


                        Console.WriteLine("Note : ");
                        var note = Console.ReadLine();
                        Console.WriteLine("User Id : ");
                        var noteUserId = Convert.ToInt32(Console.ReadLine());
                        var newNote = new Note
                        {
                            Text = note,
                            UserId = noteUserId
                        };

                        noteRepository.Add(newNote);

                        break;

                    case 4:
                        ImageRepository imageRepository = new ImageRepository();

                        Console.WriteLine("Image Url : ");
                        var imageUrl = Console.ReadLine();
                        var image = new Image
                        {
                            ImageUrl = imageUrl,
                        };

                        imageRepository.Add(image);

                        break;
                    case 5:
                        NotesImagesRepository notesImagesRepository = new NotesImagesRepository();

                        Console.WriteLine("NoteId : ");
                        var noteId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("ImageId : ");
                        var imageId = Convert.ToInt32(Console.ReadLine());

                        var notesImages = new NotesImages
                        {
                           NoteId = noteId,
                           ImageId = imageId
                        };

                        notesImagesRepository.Add(notesImages);

                        break;
                    case 6:
                        var users = userRepository.GetAll();


                        foreach (var user in users)
                        {
                            Console.WriteLine(user);
                            //Console.WriteLine(user.idCard?.FIN);
                        }

                        break;
                    case 7:
                        var idCards = idCardRepository.GetAll();


                        foreach (var idCard in idCards)
                        {
                            Console.WriteLine(idCard.FIN);
                            Console.WriteLine(idCard.User);
                        }

                        break;
                    case 9:
                        endProgram = true;
                        break;
                }
                Console.WriteLine("\n\n");
            }
        }
    }
}
