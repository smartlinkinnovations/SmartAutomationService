using System.Collections.Generic;

namespace SmartAutomationService.Model.Data
{
    public class SmartMail
    {
        public string Subject { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
        public List<string> ReplyTo { get; set; } = new List<string>();
        public string DisplayName { get; set; } = string.Empty;
        public List<string> SendTo { get; set; } = new List<string>();
        public bool IsAttachment { get; set; } = false;
        public List<string> AttachmentList { get; set; } = new List<string>();
    }
}