using System;
using System.Collections.Generic;

namespace CommandSimulator
{
    public class CommandSimulator
    {
        public static IEnumerable<string> Simulate(string[] strInput)
        {
            string strCurrentPath = "/";

            foreach (var strCommand in strInput)
            {
                if (strCommand.StartsWith("cd"))
                    strCurrentPath = FindPath(strCurrentPath, strCommand.Substring(3));
                else if (strCommand == "pwd")
                    yield return strCurrentPath; 
            }
        }

        private static string FindPath(string strCurrentPath, string strNewPath)
        {
            if (string.IsNullOrWhiteSpace(strNewPath)) 
            { 
            return strCurrentPath;
            }

            List<string> Directories = new List<string>();

            if (!strNewPath.StartsWith("/"))
            {
                foreach (var strChunk in strCurrentPath.Split('/'))
                {
                    if (string.IsNullOrEmpty(strChunk))
                    {
                        continue;
                    }
                    Directories.Add(strChunk);
                }
            }

            foreach (var strChunk in strNewPath.Split('/'))
            {
                
                if (string.IsNullOrEmpty(strChunk) || (strChunk == "."))
                {
                    continue;
                }
                else if (strChunk == ".." && Directories.Count>0)
                {
                    Directories.RemoveAt(Directories.Count - 1);
                }
                else
                {
                    Directories.Add(strChunk);
                }
            }
            var result = "/" + string.Join("/", Directories) + "/";
            return result == "" ? "/" : result;
        }

    }
}
