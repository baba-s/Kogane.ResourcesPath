using System.Text.RegularExpressions;

namespace Kogane
{
    public static class ResourcesPath
    {
        private static readonly Regex REGEX = new( @"^.*Resources/(.*)\..*" );

        public static string Get( string assetPath )
        {
            return REGEX.Replace( assetPath, "$1" );
        }
    }
}