using Pustok.Contracts;
using Pustok.Database.Abstracts;
using System.Collections.Generic;
using System;
using System.Linq;
using MimeKit;

namespace Pustok.Database.DomainModels
{
    public class Email : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public User SenderUser { get; set; }
        public int SenderUserId { get; set; }
        public User ReceiverUser { get; set; }
        public int ReceiverUserId { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<MailboxAddress> To { get; set; }
        public Email(IEnumerable<string> to, string title, string content) 
        {
            To = new List<MailboxAddress>();
            To.AddRange(to.Select(x => new MailboxAddress(x,x)));
            Title = title;
            Content = content;
            SenderUser = SenderUser;
            SenderUserId = SenderUserId;
        }
    }

    public class MailBoxAdress
    {
    }
}
