﻿using System;
using System.Collections.Generic;

namespace EvoltingStore.Entity
{
    public partial class Comment
    {
        public int CommentId { get; set; }
        public int UserId { get; set; }
        public int GameId { get; set; }
        public string Content { get; set; } = null!;
        public DateTime PostTime { get; set; }

        public virtual Game Game { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
