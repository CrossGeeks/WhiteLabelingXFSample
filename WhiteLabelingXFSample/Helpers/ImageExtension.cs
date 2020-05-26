using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WhiteLabelingXFSample
{
    [ContentProperty("Source")]
    public class ImageExtension : IMarkupExtension
    {
        public string Source { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Source == null)
                return null;

            return $"{Source}{WhiteLabelingConfig.Instance.ImageSufixName}";
        }
    }
 }
