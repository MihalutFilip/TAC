namespace events.tac.local.Interfaces
{
    public interface IRenderingContext
    {
        IItem HomeItem { get; }
        IItem DatasourceOrContextItem { get; }
        IItem ContextItem { get; }
        string Parameter(string key);
        bool IsExperienceEditorEditing { get; }
    }
}