using System;
namespace ScadaSchemeEditor
{
    public class AppDirectories
    {
        public static string DefaultPath => Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

        public AppDirectories()
        {
        }
    }
}
