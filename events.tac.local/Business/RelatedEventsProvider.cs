using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using events.tac.local.Models;
using events.tac.local.Interfaces;
using events.tac.local.Sitecore;

namespace events.tac.local.Business
{
    public class RelatedEventsProvider
    {
        private readonly IRenderingContext _context;

        public RelatedEventsProvider() : this(SitecoreRenderingContext.Create())
        {
        }

        public RelatedEventsProvider(IRenderingContext context)
        {
            _context = context;
        }

        public IEnumerable<NavigationItem> GetRelatedEvents()
        {
            return _context
                .ContextItem
                .GetMultilistFieldItems("RelatedEvents")
                .Select(i => new NavigationItem
                (
                    title: i.DisplayName,
                    url: i.Url
                ));
        }
    }
}