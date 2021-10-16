using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectEcho
{
    class FileHandler
    {
        public static String OpenFile()
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
                    //uploadButton.Text = Path.GetFileName(fileName);
                    //path = openFileDialog.File.FullName;
                    //string sourcePath = @"C:\Users\Public\TestFolder";
                    //string targetPath = @"C:\Users\Public\TestFolder\SubDir";
                    //System.IO.File.Copy(fileName, destFile, true);

                    //string separatedFileName = Path.GetFileName(fileName); //gets only the file name + extension
                    //string extension = Path.GetExtension(fileName); //gets only the file extension
                    
                    
                    //LOOOKKK BELLLOOOWWWW

                    
                    
                    
                    //uploadInfo.Text = "Uploaded: " + separatedFileName; //concats new file name

                    
                    
                    
                    
                    //create useruploads data text file (not needed right now)
                    /*string userUploadsDataPath = Environment.CurrentDirectory + "\\UserUploads" + "\\uploadsData.txt";
                    try
                    {
                        //if the file doesn't exist, create it
                        if (!File.Exists(userUploadsDataPath))
                        {
                            File.Create(userUploadsDataPath);
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("File \"{0}\" already exists", separatedFileName);
                        return;
                    }*/

                    //gets task part name (i.e. task 1 part "A")
                    //string currentTab = "x";
                    //currentTab = this.tabControl1.SelectedTab.Text;
                    //char currentTabLetter = currentTab[currentTab.Length - 1];

                    //creates name of file based on current task and part (i.e. taskUpload1A) so that when they reupload a file with a different name, it still overwrites the stored file
                    //int i = Array.IndexOf(contextPanels, currentPanel);
                    //string uploadedFile = "taskUpload" + i + currentTabLetter;

                    //create user task folder
                    //string taskUploadsPath = Environment.CurrentDirectory + "\\UserUploads\\" + uploadedFile;
                    //try
                    //{
                        //If the directory doesn't exist, create it
                    //   if(!Directory.Exists(taskUploadsPath))
                    //    {
                    //        Directory.CreateDirectory(taskUploadsPath);
                    //    }
                    //}
                    //catch(Exception)
                    //{
                        //fail silently
                    //}

                    //string targetPath = Path.Combine(Environment.CurrentDirectory, @"UserUploads\", uploadedFile, separatedFileName); //path to upload the user's file
                    //MessageBox.Show("\nUPLOADED: " + separatedFileName + "\nFROM: " + fileName + "\nTO: " + targetPath +"\n"+ uploadedFile); //shows paths for testing
                    //File.Copy(fileName, targetPath, true); //saves a copy of the user's file; the 'true' means that it will overwrite existing files of the same name

                    //writes data enty to file (given file name, original file name, given file path, original file path (not needed right now)
                    /*string userDataEntry = uploadedFile + ',' + separatedFileName + ',' + targetPath + ',' + fileName;
                    File.AppendAllText(userUploadsDataPath, userDataEntry + Environment.NewLine);*/
                }
            }
            return path;
        }
    }
}
