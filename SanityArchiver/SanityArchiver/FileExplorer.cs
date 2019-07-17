using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanityArchiver
{
    public class FileExplorer
    {
        public FileExplorer(string sourcePath)
        {
            SourcePath = sourcePath;
            Directories = new DirectoryInfo(sourcePath).GetDirectories();
            Files = new DirectoryInfo(sourcePath).GetFiles();
        }

        public string SourcePath { get; set; }
        public DirectoryInfo[] Directories { get; set; }
        public FileInfo[] Files { get; set; }

        public string FormatFileSize(long bytes)
        {
            string[] suffixes = { "Bytes", "KB", "MB", "GB", "TB"};
            int counter = 0;
            decimal number = bytes;

            while (Math.Round(number / 1024) >= 1)
            {
                number = number / 1024;
                counter ++;
            }

            return string.Format("{0:n1}{1}", number, suffixes[counter]);
        }

        public long GetDirectorySize(DirectoryInfo directory)
        {
            string[] suffixes = { "Bytes", "KB", "MB", "GB", "TB" };
            long size = 0;

            foreach (FileInfo file in GetFilesFrom(directory, true))
            {
                size += file.Length;
            }

            return size;
        }

        public FileInfo[] GetFilesFrom(DirectoryInfo dir, bool recursive)
        {
            List<FileInfo> files = new List<FileInfo>();

            FileInfo[] tempFiles = { };

            try
            {
                tempFiles = dir.GetFiles();
            }
            catch
            { }

            files.AddRange(tempFiles);

            if (recursive)
            {
                DirectoryInfo[] tempDirs = { };

                try
                {
                    tempDirs = dir.GetDirectories();
                }
                catch { }

                for (int i = 0; i < tempDirs.Length; i ++)
                    files.AddRange(GetFilesFrom(tempDirs[i], recursive));
            }

            return files.ToArray();
        }
    }
}
