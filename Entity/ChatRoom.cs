﻿using System;

namespace Entity
{
    public class ChatRoom
    {
        public int Id { get; set; }
        public int FromUserId { get; set; }
        public string FromUserName { get; set; }
        public int ToUserId { get; set; }
        public string ToUserName { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
