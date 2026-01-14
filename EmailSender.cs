using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Configuration;
using MimeKit;

public class EmailService
{
    private readonly IConfiguration _configuration;

    public EmailService(IConfiguration configuration)
    {
        _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
    }

    public async Task SendEmailAsync(List<MailboxAddress> recipient, string subject, string htmlBody)
    {
        var emailSettings = _configuration.GetSection("EmailSettings");

        var message = new MimeMessage();
        message.From.Add(new MailboxAddress(
            emailSettings["FromName"],
            emailSettings["FromEmail"]));
        message.To.AddRange(recipient);
        message.Subject = subject;
        message.Headers.Add("X-Mailer", "AIT Notification System");
        message.Headers.Add("Precedence", "bulk");

        var builder = new BodyBuilder
        {
            TextBody = "This is an automated notification from AIT system.",
            HtmlBody = htmlBody
        };
        message.Body = builder.ToMessageBody();
         
        using var client = new SmtpClient();

        client.ServerCertificateValidationCallback = (sender, certificate, chain, errors) =>
        {
            // Accept the invalid certificate
            return true;
        };
        try
        {
            await client.ConnectAsync(
                emailSettings["SmtpServer"],
                int.Parse(emailSettings["SmtpPort"]),
                SecureSocketOptions.StartTls);

            await client.SendAsync(message);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        finally
        {
            await client.DisconnectAsync(true);
        }
    }
}
