using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceFilesNames
{
    class Worker
    {
        public static string generalPath = "d:\\Dev\\CurrentProjects\\Vlodke\\Content\\Images\\All";
        public string[] directoriesName;
        public void getFoldersName()
        {
            directoriesName = System.IO.Directory.GetDirectories(generalPath);
            foreach(string s in directoriesName)
            {
                string[] subdirectory;
                var part_1 = new System.IO.DirectoryInfo(s).Name;
                subdirectory = System.IO.Directory.GetDirectories(s);
                foreach(string str in subdirectory)
                {
                    string[] files;
                    string part_2 = part_1 + "-" + new System.IO.DirectoryInfo(str).Name;
                    files = System.IO.Directory.GetFiles(str);
                    foreach(string st in files)
                    {
                        string currentName;
                        string currentFormat;
                        string newName;
                        currentName = System.IO.Path.GetFileNameWithoutExtension(st);
                        currentFormat = st.Substring(st.LastIndexOf(".") + 1);
                        newName = currentName + "-" + part_2 + "." + currentFormat;
                        System.IO.File.Move(st, str + "\\" + newName);
                    }
                }
            }

        }
    }
}
