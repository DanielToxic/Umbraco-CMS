// Copyright (c) Umbraco.
// See LICENSE for more details.

using System.Collections.Generic;
using Umbraco.Cms.Core.Events;
using Umbraco.Cms.Core.Models;

namespace Umbraco.Cms.Infrastructure.Services.Notifications
{
    public class TemplateSavedNotification : SavedNotification<ITemplate>
    {
        public TemplateSavedNotification(ITemplate target, EventMessages messages) : base(target, messages)
        {
        }

        public TemplateSavedNotification(IEnumerable<ITemplate> target, EventMessages messages) : base(target, messages)
        {
        }

        public bool? CreateTemplateForContentType
        {
            get
            {
                State.TryGetValue("CreateTemplateForContentType", out var result);
                return result as bool?;
            }
            set => State["CreateTemplateForContentType"] = value;
        }

        public string ContentTypeAlias
        {
            get
            {
                State.TryGetValue("ContentTypeAlias", out var result);
                return result as string;
            }
            set => State["ContentTypeAlias"] = value;
        }
    }
}
