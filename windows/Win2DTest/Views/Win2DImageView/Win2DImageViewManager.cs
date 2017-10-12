using ReactNative.UIManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win2DTest.Views.Win2DImageView
{
    class Win2DImageViewManager : SimpleViewManager<Win2DImageView>
    {
        public override string Name => "Win2DImageView";

        protected override Win2DImageView CreateViewInstance(ThemedReactContext reactContext)
        {
            return new Win2DImageView();
        }
    }
}
