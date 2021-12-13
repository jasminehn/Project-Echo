using Microsoft.Office.Interop.Word;
using System;

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

        //feedback variables
        public string leftMarginFB = "Left margin: ";
        public string rightMarginFB = "Right margin: ";
        public string topMarginFB = "Top margin: ";
        public string bottomMarginFB = "Bottom margin: ";
        public string fontTypeFB = "Font type: ";
        public string fontSizeFB = "Font size: ";
        public string pageNumFB = "Length: ";

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
            if(correctLength == actualLength || actualLength < correctLength)
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
            if((leftMargin != correctMargin) || (rightMargin != correctMargin) || (topMargin != correctMargin) || (bottomMargin != correctMargin))
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
            
            if(fontSize != 11)
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
            foreach(Microsoft.Office.Interop.Word.Paragraph para in document.Paragraphs)
            {
                currentFont = para.Range.Font.Name;

                if(para.Range.Font.Name.CompareTo(correct.Name) != 0)
                {
                    if(para.Range.Font.Name.CompareTo(blank.Name) != 0)
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

        public Boolean[] runMediaFormatCheck(String path, int correctLength)
        {
            Boolean[] isFormatted = { false, false };

            return isFormatted;
        }
        /*
        public string checkMediaLength()
        {
            if (args.Length < 1)
            {
                Console.WriteLine("Usage: ConsoleApplication1.exe [Filename to test]");
                return;
            }

            string file = args[0];
            ShellFile so = ShellFile.FromFilePath(file);
            double nanoseconds;
            double.TryParse(so.Properties.System.Media.Duration.Value.ToString(),
            out nanoseconds);
            Console.WriteLine("NanaoSeconds: {0}", nanoseconds);
            if (nanoseconds > 0)
            {
                double seconds = Convert100NanosecondsToMilliseconds(nanoseconds) / 1000;
                Console.WriteLine(seconds.ToString());
            }
        }
        */

        public static double Convert100NanosecondsToMilliseconds(double nanoseconds)
        {
            // One million nanoseconds in 1 millisecond, 
            // but we are passing in 100ns units...
            return nanoseconds * 0.0001;
        }
    }
}