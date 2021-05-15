using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Task_4._1._1
{
    public class BackupTool : IDisposable
    {
        public string MainDirectoryPath { get; private set; }

        public string StoragePath { get; private set; }
                

        private FileSystemWatcher _watcher;

        public BackupTool(string directoryPath)
        {
            MainDirectoryPath = directoryPath;
            _watcher = new FileSystemWatcher(MainDirectoryPath);
        }
        public void Start()
        {
            _watcher.Filter = "*.txt";
            _watcher.IncludeSubdirectories = true;
            _watcher.EnableRaisingEvents = true;

            _watcher.NotifyFilter = NotifyFilters.Attributes
                                 | NotifyFilters.DirectoryName
                                 | NotifyFilters.FileName
                                 | NotifyFilters.LastWrite;

            _watcher.Changed += CopyToStorage;
            _watcher.Created += CopyToStorage;
            _watcher.Deleted += CopyToStorage;
            _watcher.Renamed += CopyToStorage;
            _watcher.Error += OnError;

            Console.WriteLine("Активирован режим наблюдения.");
            Console.WriteLine("Нажмите enter, чтобы вернуться.");
            Console.ReadLine();
        }

        public void Dispose()
        {
            _watcher?.Dispose();
        }

        public void CopyToStorage(object sender, FileSystemEventArgs e)
        {
            try
            {
                StoragePath = @"E:\epam\Task 4\4.1\Task 4.1.1\Storage\";
                string _storageItemPath = StoragePath + DateTime.Now.ToString().Replace(':', '-');

                DirectoryCopy(MainDirectoryPath, _storageItemPath);
            }
            catch (Exception)
            {
                throw;
            }            
        }

        public static void DirectoryCopy(string sourceDirName, string destDirName)
        {

            if (!Directory.Exists(sourceDirName))
            {
                throw new NullReferenceException("Source directory doesn't exists");
            }

            DirectoryInfo _sourceDir = new(sourceDirName);

            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            ClearDirectory(destDirName);

            DirectoryInfo[] _sourceDirs = _sourceDir.GetDirectories();

            FileInfo[] _sourceFiles = _sourceDir.GetFiles();

            foreach (var file in _sourceFiles)
            {
                string _fileStoragePath = Path.Combine(destDirName, file.Name);
                file.CopyTo(_fileStoragePath, false);
            }

            foreach (var dir in _sourceDirs)
            {               
                string _dirStoragePath = Path.Combine(destDirName, dir.Name);
                DirectoryCopy(dir.FullName, _dirStoragePath);
            }

        }

        public void OnError(object sender, ErrorEventArgs e)
        {
            Console.WriteLine(e.GetException().Message);
        }

        public static void ClearDirectory(string dirPath)
        {
            DirectoryInfo dirInfo = new(dirPath);

            if (Directory.Exists(dirPath))
            {
                foreach (var file in dirInfo.GetFiles())
                {
                    file.Delete();
                }
            }

            foreach (var dir in dirInfo.GetDirectories())
            {
                ClearDirectory(dir.FullName);
                dir.Delete();
            }          
        }
    }
}
