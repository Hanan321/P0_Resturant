using System;
using Microsoft.EntityFrameWorkCore;
using Microsoft.Extensions.Configuration;


namespace UI
{
    class Program
    {

       
        static void Main(string[] args)
        {
             //*** db connection code start***//

 //connect to database through my link in the (json) file
 var configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json")
    .Build();

//get the connection string 
    string connectionString = configuration.GetConnectionString("hananmydb");
//(I must review fils names)
    DbContextOptions<hananmydbContext> options = new DbContextOptionsBuilder<hananmydbContext>()
    .UseSqlServer(ConnectionString)
    .options;

    var context = new hananmydbContext(options);//our instance of database
    
            //***End of the db connection code***//

            
            
            IMenu menu = new MainMenu();
            menu.start();
            
        }
    }
}
