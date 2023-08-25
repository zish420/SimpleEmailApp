namespace SimpleEmailApp.Models
{
    public class EmailDto
    {
        public string To { get; set; } = string.Empty;
        public string subject { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
    }
}
