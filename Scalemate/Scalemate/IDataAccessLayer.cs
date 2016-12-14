namespace Scalemate
{
    public interface IDataAccessLayer
    {
        /// <summary>
        /// Loads a file into its lines.
        /// </summary>
        string[] Load(string path);
        /// <summary>
        /// Save a string into a file.
        /// </summary>
        /// <param name="where">The path to save the file</param>
        /// <param name="what">The content to be saved</param>
        void Save(string where, string what);
        /// <summary>
        /// Checks if the given file exist
        /// </summary>
        bool FileExists(string path);
        /// <summary>
        /// Gets the path to the file containing the available tests and their codes.
        /// </summary>
        string GetKindsPath();
        /// <summary>
        /// Gets the path to the inventory file based on the test name.
        /// </summary>
        string GetInventoryPath(string test);
        /// <summary>
        /// Gets the path to the file describing how to score a given test.
        /// </summary>
        string GetResultsPath(string test);
        /// <summary>
        /// Gets the path to the file containing the instructions to be given based on the test id.
        /// </summary>
        string GetInstructionsPath(string test);
        /// <summary>
        /// Gets the path to the file indicating which questions to survey to the user before
        /// the test's beginning.
        /// </summary>
        string GetInformationPath(string test);
        /// <summary>
        /// Gets the file where the finish instructions are written.
        /// </summary>
        string GetFinishInstrutionsPath(string test);
        /// <summary>
        /// Creates a path to the file containing the results of the test based on the
        /// test code and on the patient name.
        /// </summary>
        string GenerateResultsPath(string patient, string test);
    }
}
