using Microsoft.AspNetCore.Http;

namespace Mailing_Utility.Models
{
    public class MailViewModel
    {
        public string[] EmailGroup { get; set; }
        public string Format { get; set; }
        public string Status { get; set; }
        public string Subject { get; set; }
        public IFormFile Filename { get; set; }
    }

    public class SendMailViewModel
    {
        public string[] EmailGroup { get; set; }
        public string Format { get; set; }
        public string Status { get; set; }
        public string Subject { get; set; }
        public string Filename { get; set; }
        public List<EmailDirectory> EmailGroups { get; set; }
    }
}