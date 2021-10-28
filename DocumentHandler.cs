using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectEcho
{
    class DocumentHandler
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

            if(openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach(string fileName in openFileDialog.FileNames)
                {
                    path = Path.GetFullPath(fileName);

                    string separatedFileName = Path.GetFileName(fileName); //gets only the file name + extension
                    string extension = Path.GetExtension(fileName); //gets only the file extension                    

                    //gets task part name (i.e. task 1 part "A")
                    string currentTab = "x";
                    currentTab = currentPart;
                    char currentTabLetter = currentTab[currentTab.Length - 1];

                    //creates name of folder based on current task and part (i.e. taskUpload1A)
                    //NOTE: have the folder 
                    string uploadedFile = "taskUpload" + currentTask + currentTabLetter;

                    //create user task folder

                    string taskUploadsPath = Environment.CurrentDirectory + "\\UserUploads\\" + uploadedFile;
                    try
                    {
                        //If the directory doesn't exist, create it
                        if(!Directory.Exists(taskUploadsPath))
                        {
                            Directory.CreateDirectory(taskUploadsPath);
                        }
                    }
                    catch(Exception)
                    {
                        //fail silently
                    }

                    string targetPath = Path.Combine(Environment.CurrentDirectory, @"UserUploads\", uploadedFile, separatedFileName); //path to upload the user's file
                    //MessageBox.Show("\nUPLOADED: " + separatedFileName + "\nFROM: " + fileName + "\nTO: " + targetPath +"\n"+ uploadedFile); //shows paths for testing

                    


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

        public void addToDirectory()
        {

        }
    }
    
}
