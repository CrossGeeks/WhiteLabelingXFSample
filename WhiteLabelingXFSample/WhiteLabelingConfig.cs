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
#elif APP3
                Application.Current.Resources.MergedDictionaries.Add(new App3Style());;

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
#elif APP3
          return "WhiteLabelingXFSample.Resources.App3Resources";
#endif
                return string.Empty;
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
#elif APP3
          return "App3";
#endif
                return string.Empty;
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
#elif APP3
            return "https:MyApi3";
#endif
                return string.Empty;
            }
        }
    }
}
