using Microsoft.Office.Interop.Word;
using System;

namespace ProjectEcho
{
    internal class FormatChecker
    {
		public static Application ap = new Application();
		public Boolean[] runFormatCheck(String path, int correctLength)
		{
			path = @"C:\Users\ceseg\Desktop\AlterEgo.docx";
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

			Boolean isAligned = checkAlignment(path);
			Boolean isFontSize = checkFontSize(path);
			Boolean isArial = checkFont(path);
			Boolean isCorrectLength = false;
			int actualLength = checkLength(path);
			if(correctLength == actualLength || actualLength < correctLength)
            {
				isCorrectLength = true;
            }
			Boolean[] isFormatted = {isAligned, isArial, isFontSize, isCorrectLength};

			document.Close();
			//ap.Quit();
			return isFormatted;
		}

		public Boolean checkAlignment(String path)
		{

			return true;
		}

		public Boolean checkFontSize(String path)
		{

			return true;
		}

		public Boolean checkFont(String path)
		{

			return true;
		}

		public int checkLength(String path)
		{
			return 0;
		}
	}
}
