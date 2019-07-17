using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanityArchiver
{
    class FileUtils
    {
        public void Archive(FileInfo fileToArchive, string path)
        {
            using (FileStream input = fileToArchive.OpenRead())
            {
                FileStream output = File.Create(path + @"\" + fileToArchive.Name + ".gz");
                GZipStream compressor = new GZipStream(output, CompressionMode.Compress);
                int b = input.ReadByte();

                while (b != -1)
                {
                    compressor.WriteByte((byte)b);
                    b = input.ReadByte();
                }
            }
        }

        public void Extract(FileInfo file, string path)
        {
            using (FileStream originalFileStream = file.OpenRead())
            {
                string currentFileName = file.FullName;
                string newFileName = Path.Combine(path, file.Name.Substring(0, file.Name.Length - 3));

                using (FileStream decompressedFileStream = File.Create(newFileName))
                {
                    using (GZipStream decompressionStream = new GZipStream(originalFileStream, CompressionMode.Decompress))
                    {
                        decompressionStream.CopyTo(decompressedFileStream);
                    }
                }
            }
        }

        public void Encrypt(FileInfo file)
        {
            File.Encrypt(file.FullName);
        }

        public void Decrypt(FileInfo file)
        {
            File.Decrypt(file.FullName);
        }

        public void Copy()
        {

        }

        public void Move()
        {

        }

        public void EditAttributes()
        {

        }
    }
}
