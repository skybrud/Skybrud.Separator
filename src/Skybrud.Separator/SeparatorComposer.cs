using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.DependencyInjection;
using Umbraco.Cms.Core.WebAssets;

namespace Skybrud.Separator {
    
    public class SeparatorComposer : IComposer {
        
        public void Compose(IUmbracoBuilder builder) {
            
            builder.BackOfficeAssets().Append<SeparatorAssetFile>();

        }

    }

    public class SeparatorAssetFile : IAssetFile {
        
        public string FilePath { get; set; }
        
        public AssetType DependencyType => AssetType.Css;

        public SeparatorAssetFile() {
            FilePath = "/App_Plugins/Skybrud.Separator/Styles/Default.css";
        }

    }

}