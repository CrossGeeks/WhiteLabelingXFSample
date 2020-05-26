using WhiteLabelingXFSample.Styles;
using Xamarin.Forms;

namespace WhiteLabelingXFSample
{
    public sealed class WhiteLabelingConfig
    {
        private readonly static WhiteLabelingConfig _instance = new WhiteLabelingConfig();

        public static WhiteLabelingConfig Instance
        {
            get
            {
                return _instance;
            }
        }

        public void Init()
        {
            LoadAppStyles();
        }

        void LoadAppStyles()
        {
#if APP1
            Application.Current.Resources.MergedDictionaries.Add(new App1Style());
#elif APP2
                Application.Current.Resources.MergedDictionaries.Add(new App2Style());;
#endif
            Application.Current.Resources.MergedDictionaries.Add(new GeneralStyle());
        }

        public string AppResourceFile
        {
            get
            {
#if APP1
                return "WhiteLabelingXFSample.Resources.App1Resources";
#elif APP2
          return "WhiteLabelingXFSample.Resources.App2Resources";
#endif
            }
        }

        public string ImageSufixName
        {
            get
            {
#if APP1
                return "App1";
#elif APP2
          return "App2";
#endif
            }
        }

        public string ApiUrl
        {
            get
            {
#if APP1
                return "https:MyApi1";
#elif APP2
            return "https:MyApi2";
#endif
            }
        }
    }
}
