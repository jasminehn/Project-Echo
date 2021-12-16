using Microsoft.Office.Interop.Word;
using System;
using Microsoft.WindowsAPICodePack.Shell;
using WMPLib;
using System.IO;

namespace ProjectEcho
{
    /**
	 *
	 *
	 * Author(s): C. Segrue, J. Nelson
	 */

    internal class FormatChecker
    {
        public int progress = 0;

        //Document feedback output variables
        public string leftMarginFB = "Left margin: ";
        public string rightMarginFB = "Right margin: ";
        public string topMarginFB = "Top margin: ";
        public string bottomMarginFB = "Bottom margin: ";
        public string fontTypeFB = "Font type: ";
        public string fontSizeFB = "Font size: ";
        public string pageNumFB = "Length: ";

        //Media feedback output variables
        public string mediaLengthFB = "Length: ";
        public string mediaSizeFB = "Size: ";

        int medialength = 0;

        public Boolean[] runFormatCheck(String path, int correctLength)
        {
            Application ap = new Application();

            Document document = ap.Documents.Open(FileName: path, Visible: false, ReadOnly: false);

            /**
			 *                                 ConfirmConversions: false,
                                               ReadOnly: false,
                                               AddToRecentFiles: true,
                                               PasswordDocument: null,
                                               PasswordTemplate: null,
                                               Revert: null,
                                               WritePasswordDocument: null,
                                               WritePasswordTemplate: null,
                                               Format: null,
                                               Encoding: 20127,
                                               Visible: false,
                                               OpenAndRepair: false,
                                               DocumentDirection: 0,
                                               NoEncodingDialog: false,
                                               XMLTransform: null
			 *
			 *
			 */

            Boolean isAligned = checkAlignment(document);
            Boolean isArial = checkFont(document);
            Boolean isFontSize = checkFontSize(document);
            Boolean isCorrectLength = false;

            int actualLength = checkLength(document);
            if (correctLength == actualLength || actualLength < correctLength)
            {
                isCorrectLength = true;
            }
            Boolean[] isFormatted = { isAligned, isArial, isFontSize, isCorrectLength };

            document.Close();
            ap.Quit();
            return isFormatted;
        }

        public Boolean checkAlignment(Document document)
        {
            int correctMargin = 1;

            //Gets left, right, top, and bottom margins (return value is in points, 1 inch = 72 points)
            float leftMargin = document.PageSetup.LeftMargin / 72;
            float rightMargin = document.PageSetup.RightMargin / 72;
            float topMargin = document.PageSetup.TopMargin / 72;
            float bottomMargin = document.PageSetup.BottomMargin / 72;

            leftMarginFB = "Left margin: " + leftMargin.ToString() + "\"";
            rightMarginFB = "Right margin: " + rightMargin.ToString() + "\"";
            topMarginFB = "Top margin: " + topMargin.ToString() + "\"";
            bottomMarginFB = "Bottom margin: " + bottomMargin.ToString() + "\"";

            //If any margins are not one inch, return false
            if ((leftMargin != correctMargin) || (rightMargin != correctMargin) || (topMargin != correctMargin) || (bottomMargin != correctMargin))
            {
                return false;
            }

            progress += 25;
            return true;
        }

        public Boolean checkFontSize(Document document)
        {
            float fontSize = document.Content.Font.Size;

            // When the file has more than one font type, it returns 9999999. Instead, this will return a warning message
            if (fontSize == 9999999)
            {
                fontSizeFB = "Font size: Multiple fonts detected";
            }
            else
            {
                fontSizeFB = "Font size: " + fontSize.ToString() + "pt";
            }

            if (fontSize != 11)
            {
                return false;
            }
            progress += 25;
            return true;
        }

        public Boolean checkFont(Document document)
        {
            Boolean isCorrectFont = true;
            Font correct = new Font();
            correct.Name = "Arial";
            Font blank = new Font();
            string currentFont = "";
            foreach (Microsoft.Office.Interop.Word.Paragraph para in document.Paragraphs)
            {
                currentFont = para.Range.Font.Name;

                if (para.Range.Font.Name.CompareTo(correct.Name) != 0)
                {
                    if (para.Range.Font.Name.CompareTo(blank.Name) != 0)
                    {
                        isCorrectFont = false;
                        break;
                    }
                }
            }

            fontTypeFB = "Font type: " + currentFont;
            progress += 25;
            return isCorrectFont;
        }

        public int checkLength(Document document)
        {
            int numPages = document.Content.get_Information(Microsoft.Office.Interop.Word.WdInformation.wdNumberOfPagesInDocument);
            pageNumFB = "Length: " + numPages.ToString() + " page(s)";
            progress += 25;
            return numPages;
        }

        public Boolean[] runMediaFormatCheck(String path, double correctSize, int correctMaxLength, int correctMinLength)
        {
            Boolean isCorrentSize = checkMediaSize(path, correctSize);
            Boolean isCorrectMaxLength = checkMediaLength(path, correctMaxLength);
            Boolean isCorrectMinLength = checkMinLength(path, correctMinLength);

            Boolean[] isFormatted = { isCorrentSize, isCorrectMaxLength, isCorrectMinLength };

            return isFormatted;
        }

        public Boolean checkMediaSize(string inputFile, double requiredFileSize)
        {
            string[] sizes = { "B", "KB", "MB", "GB", "TB" };
            double len = new FileInfo(inputFile).Length;
            int order = 0;
            while (len >= 1024 && order < sizes.Length - 1)
            {
                order++;
                len = len / 1024;
            }

            string result = String.Format("{0:0.##} {1}", len, sizes[order]);
            mediaSizeFB = "Size: " + result;

            //compare
            if (len > requiredFileSize)
            {
                return false;
            }

            return true;
        }

        public Boolean checkMediaLength(string inputFile, int requiredFileLength)
        {
            //get input length
            var player = new WindowsMediaPlayer();
            var clip = player.newMedia(inputFile);
            var inputFileLength = TimeSpan.FromSeconds(clip.duration);
            string fileLength = inputFileLength.ToString();
            //Console.WriteLine("MEDIA DURATION: " + inputFileLength.ToString());
            mediaLengthFB = "Length: " + fileLength;

            //get required length
            double minToSec = requiredFileLength * 60;
            var desiredlength = TimeSpan.FromSeconds(minToSec);

            //compare
            if (inputFileLength > desiredlength)
            {
                return false;
            }

            return true;
        }

        public Boolean checkMinLength(string inputFile, int requiredFileLength)
        {
            //get input length
            var player = new WindowsMediaPlayer();
            var clip = player.newMedia(inputFile);
            var inputFileLength = TimeSpan.FromSeconds(clip.duration);
            string fileLength = inputFileLength.ToString();
            //Console.WriteLine("MEDIA DURATION: " + inputFileLength.ToString());
            mediaLengthFB = "Length: " + fileLength;

            //get required length
            double minToSec = requiredFileLength * 60;
            var desiredlength = TimeSpan.FromSeconds(minToSec);

            //compare
            if (inputFileLength < desiredlength)
            {
                return false;
            }

            return true;
        }

        

    }
}