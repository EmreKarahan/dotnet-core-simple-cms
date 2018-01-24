﻿using System;
using SimpleCms.Core;

namespace SimpleCms.BlogContext.Core.Domain
{
    public class BlogStatusChanged : IDomainEvent
    {
        public BlogStatusChanged(Guid id, BlogStatus status)
        {
            BlogId = id;
            Status = status;
        }

        public Guid BlogId { get; }
        public BlogStatus Status { get; }
        public int EventVersion { get; set; }
        public DateTime OccurredOn { get; set; }
    }
}