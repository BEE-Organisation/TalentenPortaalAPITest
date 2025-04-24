namespace TalentBackend.Validation
{
    public class HelpersBase64
    {

        public static string GetFileNameFromPath(string path)
        {
            string[] splittedPath = SplitPathOrFilename(path, "/");
            int lastPartOfPaths = splittedPath.Length - 1;
            return splittedPath[lastPartOfPaths];
        }

        public static string GetFileExtension(string path)
        {
            string[] splittedPath = SplitPathOrFilename(path, "/");
            int lastPartOfPaths = splittedPath.Length - 1;
            string fileName = splittedPath[lastPartOfPaths];

            string[] splittedAtDots = SplitPathOrFilename(fileName, ".");
            int lastPartOfDot = splittedAtDots.Length - 1;

            return splittedAtDots[lastPartOfDot];
        }


        private static string[] SplitPathOrFilename(string path, string separator)
        {
            return path.Split(separator);
        }

    }
}
