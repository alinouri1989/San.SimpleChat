using San.SimpleChat.Core.Entities;
using San.SimpleChat.Core.Enums;

namespace San.SimpleChat.Core.Model
{
    public class MessageDeleteModel
    {
        public string DeleteType { get; set; }
        public Message Message { get; set; }
        public string DeletedUserId { get; set; }
    }
}
