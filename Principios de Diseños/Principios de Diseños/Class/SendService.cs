
namespace Principios_de_Diseños.Class
{
    public class SendService
    {
        public void SendEmail(string email, string menssage)
        {
            Console.WriteLine($"Sending Email to: {email}: {menssage}");
        }

        public void SendSMS(string phoneNumber, string menssage)
        {
            Console.WriteLine($"Sending SMS to: {phoneNumber}: {menssage}");
        }
    }
}
 