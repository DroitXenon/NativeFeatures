using System;
using NativeFeatures.Droid;
[assembly: Xamarin.Forms.Dependency(typeof(PlatformDetails))]
namespace NativeFeatures.Droid
{
    public class PlatformDetails : IMyInterface
    {
        public PlatformDetails()
        {
        }
        public string GetPlatformName()
        {
            return "I am Android!";
        }
    }
}
