using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TailPic
{

    class TailPictureBox : PictureBox
    {
        FileSystemWatcher watcher;

        public void Watch(string path)
        {
            watcher = new FileSystemWatcher(Path.GetDirectoryName(path), Path.GetFileName(path));
            watcher.NotifyFilter = NotifyFilters.LastWrite;
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.EnableRaisingEvents = true;

            loadPictureToWatch(path);
        }

        private void OnChanged(object source, FileSystemEventArgs e)
        {
            watcher.EnableRaisingEvents = false;
            loadPictureToWatch(e.FullPath);
            watcher.EnableRaisingEvents = true;
        }

        delegate void LoadPictureCallback(string path);

        private void loadPictureToWatch(string path)
        {

            if (this.InvokeRequired)
            {
                LoadPictureCallback d = new LoadPictureCallback(loadPictureToWatch);
                this.Invoke(d, new object[] { path });
            }
            else
            {
                while (IsFileLocked(path))
                {
                    System.Threading.Thread.Sleep(50);
                }

                FileStream fs;
                fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                this.Image = System.Drawing.Image.FromStream(fs);
                fs.Close();
            }
        }

        protected virtual bool IsFileLocked(string path)
        {
            FileStream stream = null;

            try
            {
                stream = new FileStream(path, FileMode.Open, FileAccess.Read);
            }
            catch (IOException)
            {
                //the file is unavailable because it is:
                //still being written to
                //or being processed by another thread
                //or does not exist (has already been processed)
                return true;
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }

            //file is not locked
            return false;
        }

    }
}
