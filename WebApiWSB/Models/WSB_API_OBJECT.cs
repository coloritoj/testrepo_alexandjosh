using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApiWSB.Models
{
    public class WSB_API_OBJECT
    {
        public int id { get; set; }
        public int no_of_comments { get; set; }
        public string sentiment { get; set; }
        public decimal sentiment_score { get; set; }
        public string ticker { get; set; }

        public static List<WSB_API_OBJECT> getWsbObjects()
        {
            using (WSBContext context = new WSBContext())
            {
                List<WSB_API_OBJECT> listOfObjects = context.wsbObjects.ToList();
                return listOfObjects;
            }
        }

        public static WSB_API_OBJECT addWsbObject(WSB_API_OBJECT newObject)
        {
            using (WSBContext context = new WSBContext())
            {
                context.Add(newObject);
                context.SaveChanges();
                return newObject;
            }
        }

        public static bool deleteWsbObject(int id)
        {
            using (WSBContext context = new WSBContext())
            {
                WSB_API_OBJECT theObject = new WSB_API_OBJECT();
                theObject.id = id;
                context.Remove(theObject);
                context.SaveChanges();
                return true;
            }
        }
    }

    public class WSBContext : DbContext
    {
        public DbSet<WSB_API_OBJECT> wsbObjects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {                                                       // *DON'T FORGET TO CHANGE DATABASE NAME* //
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=wsbtest;Integrated Security=SSPI;");
        }
    }
}
