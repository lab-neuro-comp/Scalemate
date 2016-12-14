using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scalemate
{
    public interface IDataAccessLayer
    {
        string[] Load(string path);
        void Save(string where, string what);
        bool FileExists(string path);
        string GetKindsPath();
        string GetInventoryPath(string test);
        string GetResultsPath(string test);
        string GetInstructionsPath(string test);
        string GetInformationPath(string test);
        string GetFinishInstrutionsPath(string test);
        string GenerateResultsPath(string patient, string test);
    }
}
