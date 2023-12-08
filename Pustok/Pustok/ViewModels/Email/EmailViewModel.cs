namespace Pustok.ViewModels.Email
{
    public class EmailViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string FromEmail { get; set; }
        public string TargetEmail { get; set; }

        public EmailViewModel(int id, string title, string fromEmail, string targetEmail)
        {
            Id = id;
            Title = title;
            FromEmail = fromEmail;
            TargetEmail = targetEmail;
        }
    }
}
