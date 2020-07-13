using ClientDependency.Core;
using Umbraco.Core.Logging;
using Umbraco.Core.PropertyEditors;
using Umbraco.Web.PropertyEditors;

namespace Skybrud.Separator {

    /// <summary>
    /// Represents a separator property editor.
    /// </summary>
    [PropertyEditorAsset(ClientDependencyType.Css, "/App_Plugins/Skybrud.Separator/Styles/Default.css")]
    [DataEditor(EditorAlias, EditorType.PropertyValue, "Skybrud Separator", EditorView, Group = "Skybrud.dk", Icon = "icon-navigation-horizontal", HideLabel = true)]
    public class SeparatorDataEditor : DataEditor {

        internal const string EditorAlias = "Skybrud.Separator";

        internal const string EditorView = "/App_plugins/Skybrud.Separator/Views/Separator.html";

        public SeparatorDataEditor(ILogger logger) : base(logger) { }

    }

}