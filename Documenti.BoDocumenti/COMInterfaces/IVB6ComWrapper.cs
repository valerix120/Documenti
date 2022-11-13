using System;

namespace Documenti.Interop 
{
    [ComProgId("COMWRAPPER.CLSFW_COMWRAPPER")]
    internal interface IVB6ComWrapper : IDisposable 
    {
        int Initialize(string serverName,
                        string databaseName,
                        string databaseUserId,
                        string databasePassword,
                        string applicationName,
                        string applicationUserId,
                        string applicationPassword,
                        long applicationCodiceAzienda);

        string CustomerID { set; }

        int Terminate();

        object GetGlobalObject(string globalPropertyName);

        object CreateCOMObject(string progId, string key, string activeInterfacePropertyName = "", string connectionPropertyName = "");

        int AssignSessionProperty(string dictionaryKey, string sessionPropertyName, string propertyNameToAssign);

        int AssignSessionObject(string dictionaryKey, string sessionObjectName, string propertyObjectToAssign);

        object GetCOMObject(string dictionaryKey);

        int SetNothingInCOMObject(string dictionaryKey, string propertyObjectToRemove);

        int SetObjectInCOMObject(string dictionaryKey, string propertyObjectToAssign, object objectToAssign);

        int ReleaseCOMObject(string dictionaryKey);

        int COMSleep(int millisecs);

        void RaiseCOMException(int exNumber);

        string COMEcho(string message);

        void TestSaas();

        ISBUSActionResult ExecuteSBUSAction(int actionCode, string param);
    }

    [ComProgId("COMWRAP.CLSFW_SBUSACTIONRET")]
    internal interface ISBUSActionResult
    {
        bool IsError { get; set; }
        string Message { get; set; }
        string ActionResult { get; set; }
    }
}