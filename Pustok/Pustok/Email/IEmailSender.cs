namespace Pustok.Email
{
    public interface IEmailSender
    {
        void SendEmail(Message message);
    }
}
