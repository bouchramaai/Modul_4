using TodoProject.Data;
using TodoProject.Data.Entities;
using Faker;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Globalization;
using Microsoft.VisualBasic;
using System.Reflection.Metadata;

namespace TodoProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using var context = new ApplicationDbContext();




            //for (int i = 0; i < 20; i++)
            //{

            //    UserEntity userEntity = new UserEntity
            //    {
            //        FirstName = Name.First(),
            //        LastName = Name.Last(),
            //        Email = Internet.Email(),
            //        Address = new AddressEntity
            //        {

            //            Street = Address.StreetName(),
            //            HouseNumber = (i * 3).ToString(),
            //            City = Address.City(),
            //            ZipCode = Address.ZipCode(),
            //            Country = Address.Country()

            //        },
            //        Todos = new List<TodoEntity>
            //        {
            //             new TodoEntity {
            //                 Titel=Lorem.GetFirstWord(),
            //                 IsDone = true,
            //                 Description=Lorem.Sentence(),
            //                 DueDate = (DateTime.UtcNow.AddDays(4)).ToString()



            //            },
            //              new TodoEntity {

            //                Titel=Lorem.GetFirstWord(),
            //                 IsDone = false,
            //                 Description=Lorem.Sentence(),
            //                 DueDate = (DateTime.UtcNow.AddDays(4)).ToString()




            //            }
            //        }



            //    };


            //    context.Users.Add(userEntity);

            //}

            //context.SaveChanges();

           // var user = context.Users.Where(x => x.Todos.Any(y => y.Titel == "s")); // sache suchen 


            //foreach (var x in user)
            //{
            //    Console.WriteLine(x.FirstName);

            //}

            // löschen 
            var todoList = context.Todos.Where(x => x.Description== null);

            foreach (var todo in todoList)
            {
                context.Remove(todo);
            }
            context.SaveChanges();
        }
    }
}