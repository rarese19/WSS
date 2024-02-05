using WSS.Models;

namespace WSS.Services.MailServices
{
    public interface IMailServices
    {
        void SendEmail(Message message);
    }
}
