

namespace Documenti.Interop
{
    internal enum VbMsgBoxStyle
    {
        vbOKOnly = 0, // Display OK button only (this is the default). 
        vbOKCancel = 1, // Display OK and Cancel buttons. 
        vbAbortRetryIgnore = 2, // Display Abort, Retry, and Ignore buttons. 
        vbYesNoCancel = 3, // Display Yes, No, and Cancel buttons. 
        vbYesNo = 4, // Display Yes and No buttons. 
        vbRetryCancel = 5, // Display Retry and Cancel buttons. 
        vbCritical = 16, // Display Critical Message icon.  
        vbQuestion = 32, // Display Warning Query icon. 
        vbExclamation = 48, // Display Warning Message icon. 
        vbInformation = 64, // Display Information Message icon. 
        vbDefaultButton1 = 0, // First button is default. 
        vbDefaultButton2 = 256, // Second button is default. 
        vbDefaultButton3 = 512, // Third button is default. 
        vbDefaultButton4 = 768, // Fourth button is default. 
    }

    internal enum VbMsgBoxResult
    {
        vbOk = 1,
        vbCancel = 2,
        vbAbort = 3,
        vbRetry = 4,
        vbIgnore = 5,
        vbYes = 6,
        vbNo = 7
    }
}
