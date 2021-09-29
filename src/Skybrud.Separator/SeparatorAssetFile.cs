using Umbraco.Cms.Core.WebAssets;

namespace Skybrud.Separator {
    
    public class SeparatorAssetFile : IAssetFile {
        
        public string FilePath { get; set; }
        
        public AssetType DependencyType => AssetType.Css;

        public SeparatorAssetFile() {
            FilePath = "/App_Plugins/Skybrud.Separator/Styles/Default.css";
        }

    }

}