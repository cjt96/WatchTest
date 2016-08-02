using Android.Views;
using Android.Support.Wearable.Views;

namespace WatchTest
{
    public class DynamicPage
    {
        public string TitleText;
        public string InformationText;
        public int IconResource;
        public GravityFlags CardGravity = GravityFlags.Bottom;
        public bool ExpansionEnabled = true;
        public float ExpansionFactor = 1;
        public int ExpansionDirection = CardFragment.ExpandDown;

        public DynamicPage(string titleText, string informationText, bool expansion)
        {
            TitleText = titleText;
            InformationText = informationText;
            ExpansionEnabled = expansion;
        }
    }
}