using System;
using System.IO;
using System.Windows.Forms;

namespace ProjectEcho
{
    /**
     *
     *
     *
     * Author(s): J. Nelson
     */

    internal class DocumentHandler
    {
        public String uploadDocument(int currentTask, string currentPart)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.AddExtension = true;
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "Document Files(*.doc; *.docx)|*.doc; *.docx";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            String path = "";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (string fileName in openFileDialog.FileNames)
                {
                    path = Path.GetFullPath(fileName);

                    string separatedFileName = Path.GetFileName(fileName); //gets only the file name + extension
                    string extension = Path.GetExtension(fileName); //gets only the file extension

                    //gets task part name (i.e. task 1 part "A")
                    string currentTab = "x"; //placeholder
                    currentTab = currentPart;
                    char currentTabLetter = currentTab[currentTab.Length - 1];

                    //creates name of folder based on current task and part (i.e. taskUpload1A)
                    string uploadedFile = "taskUpload" + currentTask + currentTabLetter;

                    //create user task folder
                    string taskUploadsPath = Environment.CurrentDirectory + "\\UserUploads\\" + uploadedFile;
                    try
                    {
                        //If the directory doesn't exist, create it
                        if (!Directory.Exists(taskUploadsPath))
                        {
                            Directory.CreateDirectory(taskUploadsPath);
                        }
                    }
                    catch (Exception)
                    {
                        //fail silently
                    }

                    string targetPath = Path.Combine(Environment.CurrentDirectory, @"UserUploads\", uploadedFile, separatedFileName); //path to upload the user's file

                    //deletes all files in task/part folder
                    DirectoryInfo di = new DirectoryInfo(taskUploadsPath);
                    foreach (FileInfo file in di.GetFiles())
                    {
                        file.Delete();
                    }

                    File.Copy(fileName, targetPath, true); //saves a copy of the user's file; the 'true' means that it will overwrite existing files of the same name
                }
            }
            return path;
        }

        public String uploadMultipleDocuments(int currentTask, string currentPart, string docType)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.AddExtension = true;
            openFileDialog.Multiselect = false;

            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            //doctypes: document, video, or media
            if (docType == "document")
            {
                openFileDialog.Filter = "Document Files(*.doc; *.docx)|*.doc; *.docx";
            }
            else if (docType == "video")
            {
                openFileDialog.Filter = "Video Files(*.mp4; *.mov; *.mp3)|*.mp3; *.mp4; *.mov";
            }
            else //media files
            {
                openFileDialog.Filter = "Video Files(*.mp4; *.mov; *.mp3)|*.mp3; *.mp4; *.mov|Audio Files(*.mp3; *.mp4; *.m4a; *.wav)|*.mp3; *.mp4; *.m4a; *.wav";
            }

            String path = "";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (string fileName in openFileDialog.FileNames)
                {
                    path = Path.GetFullPath(fileName);

                    string separatedFileName = Path.GetFileName(fileName); //gets only the file name + extension
                    string extension = Path.GetExtension(fileName); //gets only the file extension

                    //gets task part name (i.e. task 1 part "A")
                    string currentTab = "x"; //placeholder
                    currentTab = currentPart;
                    char currentTabLetter = currentTab[currentTab.Length - 1];

                    //creates name of folder based on current task and part (i.e. taskUpload1A)
                    string uploadedFile = "taskUpload" + currentTask + currentTabLetter;

                    //create user task folder
                    string taskUploadsPath = Environment.CurrentDirectory + "\\UserUploads\\" + uploadedFile + "\\" + docType; //i.e. useruploads\taskUpload1a\media
                    try
                    {
                        //If the directory doesn't exist, create it
                        if (!Directory.Exists(taskUploadsPath))
                        {
                            Directory.CreateDirectory(taskUploadsPath);
                        }
                    }
                    catch (Exception)
                    {
                        //fail silently
                    }

                    string targetPath = Path.Combine(Environment.CurrentDirectory, @"UserUploads\", uploadedFile, docType, separatedFileName); //path to upload the user's file


                    File.Copy(fileName, targetPath, true); //saves a copy of the user's file; the 'true' means that it will overwrite existing files of the same name
                }
            }
            return path;
        }

        //DELETE LATER
        public String uploadVideo(int currentTask, string currentPart)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.AddExtension = true;
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "Document Files(*.doc; *.docx)|*.doc; *.docx";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            String path = "";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (string fileName in openFileDialog.FileNames)
                {
                    path = Path.GetFullPath(fileName);

                    string separatedFileName = Path.GetFileName(fileName); //gets only the file name + extension
                    string extension = Path.GetExtension(fileName); //gets only the file extension

                    //gets task part name (i.e. task 1 part "A")
                    string currentTab = "x"; //placeholder
                    currentTab = currentPart;
                    char currentTabLetter = currentTab[currentTab.Length - 1];

                    //creates name of folder based on current task and part (i.e. taskUpload1A)
                    string uploadedFile = "taskUpload" + currentTask + currentTabLetter;

                    //create user task folder
                    string taskUploadsPath = Environment.CurrentDirectory + "\\UserUploads\\" + uploadedFile;
                    try
                    {
                        //If the directory doesn't exist, create it
                        if (!Directory.Exists(taskUploadsPath))
                        {
                            Directory.CreateDirectory(taskUploadsPath);
                        }
                    }
                    catch (Exception)
                    {
                        //fail silently
                    }

                    string targetPath = Path.Combine(Environment.CurrentDirectory, @"UserUploads\", uploadedFile, separatedFileName); //path to upload the user's file

                    //deletes all files in task/part folder
                    DirectoryInfo di = new DirectoryInfo(taskUploadsPath);
                    foreach (FileInfo file in di.GetFiles())
                    {
                        file.Delete();
                    }

                    File.Copy(fileName, targetPath, true); //saves a copy of the user's file; the 'true' means that it will overwrite existing files of the same name
                }
            }
            return path;
        }

        //displays the documents already uploaded, remains when they close and reopen the app
        public String displayDocuments(int currentTask, string currentPart)
        {
            string str = "";
            string currentTab = "x";
            currentTab = currentPart;
            char currentTabLetter = currentTab[currentTab.Length - 1];

            string uploadedFile = "taskUpload" + currentTask + currentTabLetter; //generates folder name based on currently selected task/part (i.e. taskUpload1A)
            string taskUploadsPath = Environment.CurrentDirectory + "\\UserUploads\\" + uploadedFile; //finds correct folder path for current section
            //Console.WriteLine(taskUploadsPath); //test
            try
            {
                //if the directory exists, read all files from it
                if (Directory.Exists(taskUploadsPath))
                {
                    DirectoryInfo d = new DirectoryInfo(taskUploadsPath); //set directory
                    FileInfo[] Files = d.GetFiles(); //get all files from the folder
                    //string str = "";

                    foreach (FileInfo file in Files)
                    {
                        str = str + "\n" + file.Name; //adds each file name to the string
                    }
                }
            }
            catch (Exception)
            {
                //do nothing
            }
            return str;
        }

        public String displayMultipleDocuments(int currentTask, string currentPart, string docType)
        {
            string str = "";
            string currentTab = "x";
            currentTab = currentPart;
            char currentTabLetter = currentTab[currentTab.Length - 1];

            string uploadedFile = "taskUpload" + currentTask + currentTabLetter; //generates folder name based on currently selected task/part (i.e. taskUpload1A)
            string taskUploadsPath = Environment.CurrentDirectory + "\\UserUploads\\" + uploadedFile + "\\" + docType; //finds correct folder path for current section
            //Console.WriteLine(taskUploadsPath); //test
            try
            {
                //if the directory exists, read all files from it
                if (Directory.Exists(taskUploadsPath))
                {
                    DirectoryInfo d = new DirectoryInfo(taskUploadsPath); //set directory
                    FileInfo[] Files = d.GetFiles(); //get all files from the folder
                    //string str = "";

                    foreach (FileInfo file in Files)
                    {
                        str = str + "\n" + file.Name; //adds each file name to the string
                    }
                }
            }
            catch (Exception)
            {
                //do nothing
            }
            return str;
        }



    }
}