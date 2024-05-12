using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtaghMan.App.Classes.BackEnd
{
    public static class FileWorker
    {
        public static string PicAddressGenerator(string imagePath)
        {
            string dirPath = Application.StartupPath + "/Images/Rooms";
            string finalPath;
            string uniqueFileName;
            if (!Directory.Exists(dirPath))
            {
                Directory.CreateDirectory(dirPath);

            }
            uniqueFileName = Guid.NewGuid() + Path.GetExtension(imagePath);
            finalPath = dirPath + '/' + uniqueFileName;
            File.Copy(imagePath, finalPath);


            return finalPath;

        }
    }
}
