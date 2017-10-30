using System;

namespace SampleLibrary
{
    public static class SampleDateFormat
    {
        public static string GetDateTime() => DateTime.Now.ToString(format: "yyyy-MM-dd hh:mm:ss tt");
    }
}
