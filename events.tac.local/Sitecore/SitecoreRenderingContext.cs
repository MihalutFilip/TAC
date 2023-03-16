using Sitecore.Mvc.Presentation;
using Sitecore;
using System;
using events.tac.local.Interfaces;

namespace events.tac.local.Sitecore
{
    public class SitecoreRenderingContext : IRenderingContext
    {
        private SitecoreRenderingContext() { }

        public static IRenderingContext Create()
        {
            return new SitecoreRenderingContext();
        }

        public IItem HomeItem => new SitecoreItem(Context.Site.StartPath, Context.Database.Name);

        public IItem DatasourceOrContextItem => new SitecoreItem(RenderingContext.Current.Rendering.Item);

        public IItem ContextItem => new SitecoreItem(RenderingContext.Current.ContextItem);

        public bool IsExperienceEditorEditing => Context.PageMode.IsExperienceEditorEditing;

        public string Parameter(string key)
        {
            return RenderingContext.Current.Rendering.Parameters[key];
        }
    }
}