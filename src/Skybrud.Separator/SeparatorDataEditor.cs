using Umbraco.Cms.Core.PropertyEditors;

namespace Skybrud.Separator {

    /// <summary>
    /// Represents a separator property editor.
    /// </summary>
    [DataEditor(EditorAlias, EditorType.PropertyValue, "Skybrud Separator", EditorView, Group = "Skybrud.dk", Icon = "icon-navigation-horizontal", HideLabel = true)]
    public class SeparatorDataEditor : DataEditor {

        internal const string EditorAlias = "Skybrud.Separator";

        internal const string EditorView = "/App_plugins/Skybrud.Separator/Views/Separator.html";

        public SeparatorDataEditor(IDataValueEditorFactory dataValueEditorFactory) : base(dataValueEditorFactory) { }

    }

}