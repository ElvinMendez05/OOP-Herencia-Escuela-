

namespace Principios_de_Diseños.Class
{
    public class NotificationService
    {
        List<string> emails = new List<string>();
        List<string> sms = new List<string>();
        public void LogNotification(string menssage)
        {
            emails.Add(menssage);
            sms.Add(menssage);
            Console.WriteLine($"Logging notification: {menssage}");
        }

    }
}
