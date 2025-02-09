﻿using System.Collections.Generic;

namespace Bot.Clockify.Models
{
    public class TimeEntryDo
    {
        public string Id { get; set; }
        public string ProjectId { get; set; }
        public string TaskId { get; set; }
        public string UserId { get; set; }
        public bool? Billable { get; set; }
        public List<string?> TagIds { get; set; }
        public TimeInterval TimeInterval { get; set; }
    }
}