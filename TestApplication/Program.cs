using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

    //Проблема бизнеса:
    //Существует клиентское приложение, которому требуются данные о продажах в разрезе клиентов.
    //Должна быть возможность получать как всю информацию, так и с фильтрацией по датам продаж, клиентам.

    //Постановка задачи:
    //Разработать web api, реализующий функционал получения продаж в разрезе клиентов.
    //API поддерживает получение всей доступной информации по всем клиентам, по конкретному клиенту, по датам продаж.

namespace TestApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }
}