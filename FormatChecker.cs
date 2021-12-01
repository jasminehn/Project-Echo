using Microsoft.Office.Interop.Word;
using System;

namespace ProjectEcho
{
    /**
	 *
	 *
	 * Author(s): C. Segrue
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
        public string pageNumFB = "Document length: ";

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

            //1 inch = 72 points
            float leftMargin = document.PageSetup.LeftMargin / 72;
            float rightMargin = document.PageSetup.RightMargin / 72;
            float topMargin = document.PageSetup.TopMargin / 72;
            float bottomMargin = document.PageSetup.BottomMargin / 72;

            leftMarginFB = "Left margin: " + leftMargin.ToString() + "\"";
            rightMarginFB = "Right margin: " + rightMargin.ToString() + "\"";
            topMarginFB = "Top margin: " + topMargin.ToString() + "\"";
            bottomMarginFB = "Bottom margin: " + bottomMargin.ToString() + "\"";

            //if any margins are not one inch
            if((leftMargin != correctMargin) || (rightMargin != correctMargin) || (topMargin != correctMargin) || (bottomMargin != correctMargin))
            {
                return false;
            }

            progress += 25;
            return true;
        }

        public Boolean checkFontSize(Document document)
        {
            fontSizeFB = "Font size: " + document.Content.Font.Size.ToString() + "pt";
            if(document.Content.Font.Size != 11)
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
                        //System.Windows.Forms.MessageBox.Show(para.Range.Font.Name);
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
            pageNumFB = "Document length: " + document.Content.get_Information(Microsoft.Office.Interop.Word.WdInformation.wdNumberOfPagesInDocument).ToString() + " page(s)";
            progress += 25;
            return document.Content.get_Information(Microsoft.Office.Interop.Word.WdInformation.wdNumberOfPagesInDocument);
        }
    }
}