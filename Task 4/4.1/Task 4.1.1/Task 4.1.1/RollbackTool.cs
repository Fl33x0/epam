using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4._1._1
{
    class RollbackTool : IDisposable
    {
        public RollbackTool() { }


        public static void RollBack(string backupStorageFolder, string mainFolder)
        {
            Console.WriteLine("Введите дату и время, на которые нужно откатиться, в формате \"дд.мм.гггг чч:мм:сс\"");

            string _input = Console.ReadLine();

            if (!DateTime.TryParse(_input, out DateTime _parsedDateTime))
            {
                Console.WriteLine("Введено некорректное значение");
                return;
            }

            DirectoryInfo _backupStorageDirInfo = new(backupStorageFolder);
            DirectoryInfo[] _backupStorageDirs = _backupStorageDirInfo.GetDirectories();


            string _storageFolderName = string.Empty;

            var _sortedDirs = _backupStorageDirs.OrderBy(i => i.CreationTime).ToArray();

            foreach (var dir in _sortedDirs)
            {       
                if (dir.CreationTime <= _parsedDateTime.AddSeconds(1))
                {                   
                    _storageFolderName = dir.FullName;
                }                
            }

            if (_storageFolderName == string.Empty)
            {
                Console.WriteLine("Во введенное время еще не было создано ни одного бэкапа");
                return;
            }

            BackupTool.DirectoryCopy(_storageFolderName, mainFolder);

            Console.WriteLine("Откат произведен. Нажмите enter для выхода");
            Console.ReadLine();
        }

        public void Dispose()
        {
            this?.Dispose();
        }
    }
}
