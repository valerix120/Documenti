
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Documenti.Interop
{
    [ComEvents(typeof(CLSMG_REGTRASFODC_EventSink), CLSMG_REGTRASFODC_EventSink.InterfaceID)]
    internal interface CLSMG_REGTRASFODC_Events
    {
        event EventHandler ChiusuraGenerazioneDocumenti;
  
    }

    [ComImport, Guid(CLSMG_REGTRASFODC_EventSink.InterfaceID), InterfaceType(ComInterfaceType.InterfaceIsIDispatch), TypeLibType(TypeLibTypeFlags.FDispatchable)]
    internal interface UCOMICLSMG_REGTRASFODC_Events
    {
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x0004)]
        void ChiusuraGenerazioneDocumenti();
    }

    [ClassInterface(ClassInterfaceType.None)]
    internal sealed class CLSMG_REGTRASFODC_EventSink : ComEventSink, UCOMICLSMG_REGTRASFODC_Events
    {
		internal const string InterfaceID = "49F8AB90-152F-4FA6-B387-970333AE02BE";

        static readonly object ChiusuraGenerazioneDocumentiEvent = new object();
        public void ChiusuraGenerazioneDocumenti()
        {

			EventArgs e = new EventArgs();
			RaiseEvent(ChiusuraGenerazioneDocumentiEvent, Sender, e);

		}
	}

}