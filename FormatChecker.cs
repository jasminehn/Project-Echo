using Microsoft.Office.Interop.Word;
using System;
using System.Collections;

namespace ProjectEcho
{
    internal class FormatChecker
    {
		//public static Application ap = new Application();
		public int progress = 0;
		public Boolean[] runFormatCheck(String path, int correctLength)
		{
			Application ap = new Application();

			//path = @"C:\Users\ceseg\Desktop\AlterEgo.docx";
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
			Boolean[] isFormatted = {isAligned, isArial, isFontSize, isCorrectLength};

			document.Close();
			
			ap.Quit();

			/*if (ap != null)
				System.Runtime.InteropServices.Marshal.ReleaseComObject(ap);

			ap = null;*/

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

			//if any margins are not one inch
			if ((leftMargin != correctMargin) || (rightMargin != correctMargin) || (topMargin != correctMargin) || (bottomMargin != correctMargin))
            {
				System.Windows.Forms.MessageBox.Show("Left margin: "+leftMargin.ToString());
				return false;
            }
			//System.Windows.Forms.MessageBox.Show("Left margin (YAY): " + document.PageSetup.LeftMargin.ToString());
			progress += 25;
			return true;
		}

		public Boolean checkFontSize(Document document)
		{
			if(document.Content.Font.Size != 11)
            {
				System.Windows.Forms.MessageBox.Show(document.Content.Font.Size.ToString());
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
			foreach(Microsoft.Office.Interop.Word.Paragraph para in document.Paragraphs)
			{
				//System.Windows.Forms.MessageBox.Show(para.)
				if(para.Range.Font.Name.CompareTo(correct.Name) != 0)
				{
                    if(para.Range.Font.Name.CompareTo(blank.Name) != 0)
                    {
						System.Windows.Forms.MessageBox.Show(para.Range.Font.Name);
						isCorrectFont = false;
						break;
					} 
				}
			}
			progress += 25;
			return isCorrectFont;
		}

		public int checkLength(Document document)
		{
			System.Windows.Forms.MessageBox.Show(document.Content.get_Information(Microsoft.Office.Interop.Word.WdInformation.wdNumberOfPagesInDocument).ToString());
			progress += 25;
			return document.Content.get_Information(Microsoft.Office.Interop.Word.WdInformation.wdNumberOfPagesInDocument);
		}
	}
}
