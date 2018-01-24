﻿using System;
using SimpleCms.Core;

namespace SimpleCms.BlogContext.Core.Domain
{
    public class BlogSettingChanged : IDomainEvent
    {
        public BlogSettingChanged(Guid oldBlogSettingId)
        {
            OldBlogSettingId = oldBlogSettingId;
        }

        public Guid OldBlogSettingId { get; private set; }
        public int EventVersion { get; set; }
        public DateTime OccurredOn { get; set; }
    }
}