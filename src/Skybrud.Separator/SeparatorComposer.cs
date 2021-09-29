using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.DependencyInjection;

namespace Skybrud.Separator {
    
    public class SeparatorComposer : IComposer {
        
        public void Compose(IUmbracoBuilder builder) {
            
            builder.BackOfficeAssets().Append<SeparatorAssetFile>();

        }

    }

}