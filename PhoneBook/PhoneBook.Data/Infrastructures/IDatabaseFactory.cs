using System;

namespace PhoneBook.Data.Infrastructures
{
   public interface IDatabaseFactory: IDisposable
   {
       PhoneBookDbContext GetDbContext();
   }
}