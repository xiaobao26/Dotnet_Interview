// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


#region Constructor Injection
// public class UserController
// {
//     private readonly IUserRepository _repo;
//     public UserController(IUserRepository repo)
//     {
//         _repo = repo;
//     }
//     // …
// }
#endregion

#region Property Injection
// public class ReportGenerator
// {
//     [Inject]        // pseudo-attribute or configured in container
//     public ILogger Logger { get; set; }
//     // …
// }
//
#endregion

#region Method Injection
// public class NotificationManager
// {
//     public void SendAlert(string message, IAlertService alertSvc)
//     {
//         alertSvc.Send(message);
//     }
// }
#endregion

#region Wiring it up in .NET Core (Injection into Container)
// services.AddTransient<IEmailService, SmtpEmailService>();
// services.AddScoped<IUserRepository, UserRepository>();
// services.AddSingleton<ILogger, ConsoleLogger>();
#endregion