
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Documenti.Interop
{
    [ComEvents(typeof(CLSMG_REGDOC_EventSink), CLSMG_REGDOC_EventSink.InterfaceID)]
    internal interface CLSMG_REGDOC_Events
    {
        event BeforeBeginTransactionEventHandler BeforeBeginTransaction;
        event AfterBeginTransactionEventHandler AfterBeginTransaction;
        event BeforeCommitTransactionEventHandler BeforeCommitTransaction;
        event AfterCommitTransactionEventHandler AfterCommitTransaction;
        event ErrorsOccurredEventHandler ErrorsOccurred;
		event OnConfermaBloccoModificaEventHandler OnConfermaBloccoModifica;
        event WarningOccurredEventHandler WarningOccurred;
		event InteractionOccurredEventHandler InteractionOccurred;
		event WarningIVA21OccurredEventHandler WarningIVA21Occurred;
		event WarningIVA22OccurredEventHandler WarningIVA22Occurred;
		event WarningAntiriciclaggioOccurredEventHandler WarningAntiriciclaggioOccurred;
		event WarningCartaCreditoOccurredEventHandler WarningCartaCreditoOccurred;
		event WarningEsigibilitaDifferitaEventHandler WarningEsigibilitaDifferita;
        event AvanzamentoEventHandler Avanzamento;
		event DisconnectRecordsetsEventHandler DisconnectRecordsets;
		event ReconnectRecordsetsEventHandler ReconnectRecordsets;        
		event EventHandler TestataChanged;
        event EventHandler CorpoChanged;
        event EventHandler OnRollback;
		event DatiCauzioniEventHandler DatiCauzioni;
		event SelezioneLetteraIntentoEventHandler SelezioneLetteraIntento;
		event ShowEsplosoKitEventHandler ShowEsplosoKit;
		event ShowEsplosoKit2EventHandler ShowEsplosoKit2;
		event EventHandler AggiuntaRigaDaKit;
		event BeforeRichiestaAttivazionePromozioniEventHandler BeforeRichiestaAttivazionePromozioni;
		event EventHandler OnAbilitaNumerazioneAutofattura;
		event EventHandler OnDisabilitaNumerazioneAutofattura;
    }

    [ComImport, Guid(CLSMG_REGDOC_EventSink.InterfaceID), InterfaceType(ComInterfaceType.InterfaceIsIDispatch), TypeLibType(TypeLibTypeFlags.FDispatchable)]
    internal interface UCOMICLSMG_REGDOC_Events
    {
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime), DispId(0x0004)]
        void BeforeBeginTransaction(ref bool Cancel);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(0x0005)]
        void AfterBeginTransaction(ref bool Cancel);
        
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(0x0006)]
        void BeforeCommitTransaction(ref bool Cancel);
        
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(0x0007)]
        void AfterCommitTransaction(ref bool Cancel);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(0x0001)]
        void ErrorsOccurred(ref string ErrorDetail, ref bool ShowMsgBox, ref VbMsgBoxStyle MessageStyle, ref VbMsgBoxResult MessageResult);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(0x0011)]
		void OnConfermaBloccoModifica(ref EnumCauseBloccoModifica TipoBlocco, bool fbolBloccoEliminabile, ref bool CancellaBlocco);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(0x0002)]
        void WarningOccurred(ref string WarningDetail, ref bool ShowMsgBox, ref VbMsgBoxStyle MessageStyle, ref VbMsgBoxResult MessageResult);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(0x0013)]
		void InteractionOccurred(ref string InteractionDetail, ref bool ShowMsgBox, ref VbMsgBoxStyle MessageStyle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(0x0012)]
		void WarningIVA21Occurred(ref string Numreg, ref string WarningDetail, ref bool ShowMsgBox, ref VbMsgBoxStyle MessageStyle, ref VbMsgBoxResult MessageResult);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(0x0018)]
		void WarningIVA22Occurred(ref string Numreg, ref string WarningDetail, ref bool ShowMsgBox, ref VbMsgBoxStyle MessageStyle, ref VbMsgBoxResult MessageResult);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(0x0015)]
		void WarningAntiriciclaggioOccurred(ref string Numreg, ref string WarningDetail, ref bool ShowMsgBox, ref VbMsgBoxStyle MessageStyle, ref VbMsgBoxResult MessageResult);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(0x001A)]
		void WarningCartaCreditoOccurred(ref string Numreg, ref string WarningDetail, ref bool ShowMsgBox, ref VbMsgBoxStyle MessageStyle, ref VbMsgBoxResult MessageResult);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(0x001B)]
		void WarningEsigibilitaDifferita(ref string Numreg, ref string WarningDetail, ref bool ShowMsgBox, ref VbMsgBoxStyle MessageStyle, ref VbMsgBoxResult MessageResult);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(0x0003)]
        void Avanzamento(int Step, int TotalSteps, string Description);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(0x0008)]
		void DisconnectRecordsets(bool ExecCancelUpdate, bool DisconnectTestata, bool DisconnectTestataChilds, bool DisconnectCorpo, bool DisconnectCorpoChilds);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(0x0009)]
		void ReconnectRecordsets(bool ExecReOpen, bool ReconnectTestata, bool ReconnectTestataChilds, bool ReconnectCorpo, bool ReconnectCorpoChilds);

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(0x000a)]
        void TestataChanged();

        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(0x000b)]
        void CorpoChanged();
        
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(0x000c)]
        void OnRollback();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(0x000D)]
		void DatiCauzioni(object CodiceArticoloCauzione, object OpzioneCauzione, object ImportoCauzione);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(0x000E)]
		void SelezioneLetteraIntento(ref bool Cancel, object TipoCF, object Clifor, object DataRiferimento, ref object LettereIntento, ref object IDSelezionato);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(0x000F)]
		void ShowEsplosoKit(ref object frstEsplosioneKit, ref object fvarBookmarkRigaDaEsplodere, ref bool fbolEseguiEsplosioneKit, ref string fstrEsclSt1Padre, ref string fstrEsclSt2Padre, ref string fstrEsclSt3Padre, ref string fstrEsclSt4Padre, ref string fstrEsclSt1Figli, ref string fstrEsclSt2Figli, ref string fstrEsclSt3Figli, ref string fstrEsclSt4Figli);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(0x0019)]
		void ShowEsplosoKit2(ref object frstEsplosioneKit, ref object fvarBookmarkRigaDaEsplodere, ref bool fbolEseguiEsplosioneKit, ref bool fbolRicalcolaPrezzoKitPadre, ref string fstrEsclSt1Padre, ref string fstrEsclSt2Padre, ref string fstrEsclSt3Padre, ref string fstrEsclSt4Padre, ref string fstrEsclSt1Figli, ref string fstrEsclSt2Figli, ref string fstrEsclSt3Figli, ref string fstrEsclSt4Figli);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(0x0010)]
		void AggiuntaRigaDaKit();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(0x0014)]
		void BeforeRichiestaAttivazionePromozioni(ref object RstPromozioni, ref object RstPromozioniPotenziali, ref bool Cancel);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(0x0016)]
		void OnAbilitaNumerazioneAutofattura();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(0x0017)]
		void OnDisabilitaNumerazioneAutofattura();
    }

    [ClassInterface(ClassInterfaceType.None)]
    internal sealed class CLSMG_REGDOC_EventSink : ComEventSink, UCOMICLSMG_REGDOC_Events
    {
		internal const string InterfaceID = "90615C71-5CDA-4BDC-8C67-8778D7DECA47";

        static readonly object BeforeBeginTransactionEvent = new object();
        static readonly object AfterBeginTransactionEvent = new object();
        static readonly object BeforeCommitTransactionEvent = new object();
        static readonly object AfterCommitTransactionEvent = new object();
        static readonly object ErrorsOccurredEvent = new object();
		static readonly object OnConfermaBloccoModificaEvent = new object();
        static readonly object WarningOccurredEvent = new object();
		static readonly object InteractionOccurredEvent = new object();
		static readonly object WarningIVA21OccurredEvent = new object();
		static readonly object WarningIVA22OccurredEvent = new object();
		static readonly object WarningAntiriciclaggioOccurredEvent = new object();
		static readonly object WarningCartaCreditoOccurredEvent = new object();
		static readonly object WarningEsigibilitaDifferitaEvent = new object();
        static readonly object AvanzamentoEvent = new object();
		static readonly object DisconnectRecordsetsEvent = new object();
		static readonly object ReconnectRecordsetsEvent = new object();
        static readonly object TestataChangedEvent = new object();
        static readonly object CorpoChangedEvent = new object();
        static readonly object OnRollbackEvent = new object();
		static readonly object DatiCauzioniEvent = new object();
		static readonly object SelezioneLetteraIntentoEvent = new object();
		static readonly object ShowEsplosoKitEvent = new object();
		static readonly object ShowEsplosoKit2Event = new object();
		static readonly object AggiuntaRigaDaKitEvent = new object();
		static readonly object BeforeRichiestaAttivazionePromozioniEvent = new object();
		static readonly object OnAbilitaNumerazioneAutofatturaEvent = new object();
		static readonly object OnDisabilitaNumerazioneAutofatturaEvent = new object();

        public void BeforeBeginTransaction(ref bool Cancel)
        {
            BeforeBeginTransactionEventArgs e = new BeforeBeginTransactionEventArgs(Cancel);
            RaiseEvent(BeforeBeginTransactionEvent, Sender, e);
            Cancel = e.Cancel;
        }

        public void AfterBeginTransaction(ref bool Cancel)
        {
            AfterBeginTransactionEventArgs e = new AfterBeginTransactionEventArgs(Cancel);
            RaiseEvent(AfterBeginTransactionEvent, Sender, e);
            Cancel = e.Cancel;
        }

        public void BeforeCommitTransaction(ref bool Cancel)
        {
            BeforeCommitTransactionEventArgs e = new BeforeCommitTransactionEventArgs(Cancel);
            RaiseEvent(BeforeCommitTransactionEvent, Sender, e);
            Cancel = e.Cancel;
        }

        public void AfterCommitTransaction(ref bool Cancel)
        {
            AfterCommitTransactionEventArgs e = new AfterCommitTransactionEventArgs(Cancel);
            RaiseEvent(AfterCommitTransactionEvent, Sender, e);
            Cancel = e.Cancel;
        }

        public void ErrorsOccurred(ref string ErrorDetail, ref bool ShowMsgBox, ref VbMsgBoxStyle MessageStyle, ref VbMsgBoxResult MessageResult)
        {
            ErrorsOccurredEventArgs e = new ErrorsOccurredEventArgs(ErrorDetail, ShowMsgBox, MessageStyle, MessageResult);
            RaiseEvent(ErrorsOccurredEvent, Sender, e);
            ErrorDetail = e.ErrorDetail;
            ShowMsgBox = e.ShowMsgBox;
            MessageStyle = e.MessageStyle;
            MessageResult = e.MessageResult;
        }

		public void OnConfermaBloccoModifica(ref EnumCauseBloccoModifica TipoBlocco, bool fbolBloccoEliminabile, ref bool CancellaBlocco)
		{
			OnConfermaBloccoModificaEventArgs e = new OnConfermaBloccoModificaEventArgs(TipoBlocco, fbolBloccoEliminabile, CancellaBlocco);
			RaiseEvent(OnConfermaBloccoModificaEvent, Sender, e);
			TipoBlocco = e.TipoBlocco;
			CancellaBlocco = e.CancellaBlocco;
		}

        public void WarningOccurred(ref string WarningDetail, ref bool ShowMsgBox, ref VbMsgBoxStyle MessageStyle, ref VbMsgBoxResult MessageResult)
        {
            WarningOccurredEventArgs e = new WarningOccurredEventArgs(WarningDetail, ShowMsgBox, MessageStyle, MessageResult);
            RaiseEvent(ErrorsOccurredEvent, Sender, e);
            WarningDetail = e.WarningDetail;
            ShowMsgBox = e.ShowMsgBox;
            MessageStyle = e.MessageStyle;
            MessageResult = e.MessageResult;
        }

		public void InteractionOccurred(ref string InteractionDetail, ref bool ShowMsgBox, ref VbMsgBoxStyle MessageStyle)
		{
			InteractionOccurredEventArgs e = new InteractionOccurredEventArgs(InteractionDetail, ShowMsgBox, MessageStyle);
			RaiseEvent(InteractionOccurredEvent, Sender, e);
			InteractionDetail = e.InteractionDetail;
			ShowMsgBox = e.ShowMsgBox;
			MessageStyle = e.MessageStyle;
		}

		public void WarningIVA21Occurred(ref string Numreg, ref string WarningDetail, ref bool ShowMsgBox, ref VbMsgBoxStyle MessageStyle, ref VbMsgBoxResult MessageResult)
		{
			WarningIVA21OccurredEventArgs e = new WarningIVA21OccurredEventArgs(Numreg, WarningDetail, ShowMsgBox, MessageStyle, MessageResult);
			RaiseEvent(WarningIVA21OccurredEvent, Sender, e);
			Numreg = e.Numreg;
			WarningDetail = e.WarningDetail;
			ShowMsgBox = e.ShowMsgBox;
			MessageStyle = e.MessageStyle;
			MessageResult = e.MessageResult;
		}

		public void WarningIVA22Occurred(ref string Numreg, ref string WarningDetail, ref bool ShowMsgBox, ref VbMsgBoxStyle MessageStyle, ref VbMsgBoxResult MessageResult)
		{
			WarningIVA22OccurredEventArgs e = new WarningIVA22OccurredEventArgs(Numreg, WarningDetail, ShowMsgBox, MessageStyle, MessageResult);
			RaiseEvent(WarningIVA22OccurredEvent, Sender, e);
			Numreg = e.Numreg;
			WarningDetail = e.WarningDetail;
			ShowMsgBox = e.ShowMsgBox;
			MessageStyle = e.MessageStyle;
			MessageResult = e.MessageResult;
		}

		public void WarningAntiriciclaggioOccurred(ref string Numreg, ref string WarningDetail, ref bool ShowMsgBox, ref VbMsgBoxStyle MessageStyle, ref VbMsgBoxResult MessageResult)
		{
			WarningAntiriciclaggioOccurredEventArgs e = new WarningAntiriciclaggioOccurredEventArgs(Numreg, WarningDetail, ShowMsgBox, MessageStyle, MessageResult);
			RaiseEvent(WarningAntiriciclaggioOccurredEvent, Sender, e);
			Numreg = e.Numreg;
			WarningDetail = e.WarningDetail;
			ShowMsgBox = e.ShowMsgBox;
			MessageStyle = e.MessageStyle;
			MessageResult = e.MessageResult;
		}

		public void WarningCartaCreditoOccurred(ref string Numreg, ref string WarningDetail, ref bool ShowMsgBox, ref VbMsgBoxStyle MessageStyle, ref VbMsgBoxResult MessageResult)
		{
			WarningCartaCreditoOccurredEventArgs e = new WarningCartaCreditoOccurredEventArgs(Numreg, WarningDetail, ShowMsgBox, MessageStyle, MessageResult);
			RaiseEvent(WarningCartaCreditoOccurredEvent, Sender, e);
			Numreg = e.Numreg;
			WarningDetail = e.WarningDetail;
			ShowMsgBox = e.ShowMsgBox;
			MessageStyle = e.MessageStyle;
			MessageResult = e.MessageResult;
		}

		public void WarningEsigibilitaDifferita(ref string Numreg, ref string WarningDetail, ref bool ShowMsgBox, ref VbMsgBoxStyle MessageStyle, ref VbMsgBoxResult MessageResult)
		{
			WarningEsigibilitaDifferitaEventArgs e = new WarningEsigibilitaDifferitaEventArgs(Numreg, WarningDetail, ShowMsgBox, MessageStyle, MessageResult);
			RaiseEvent(WarningEsigibilitaDifferitaEvent, Sender, e);
			Numreg = e.Numreg;
			WarningDetail = e.WarningDetail;
			ShowMsgBox = e.ShowMsgBox;
			MessageStyle = e.MessageStyle;
			MessageResult = e.MessageResult;
		}

        public void Avanzamento(int Step, int TotalSteps, string Description)
        {
            AvanzamentoEventArgs e = new AvanzamentoEventArgs(Step, TotalSteps, Description);
            RaiseEvent(AvanzamentoEvent, Sender, e);
        }

		public void DisconnectRecordsets(bool ExecCancelUpdate, bool DisconnectTestata, bool DisconnectTestataChilds, bool DisconnectCorpo, bool DisconnectCorpoChilds)
		{
			DisconnectRecordsetsEventArgs e = new DisconnectRecordsetsEventArgs(ExecCancelUpdate, DisconnectTestata, DisconnectTestataChilds, DisconnectCorpo, DisconnectCorpoChilds);
			RaiseEvent(DisconnectRecordsetsEvent, Sender, e);
		}

		public void ReconnectRecordsets(bool ExecReOpen, bool ReconnectTestata, bool ReconnectTestataChilds, bool ReconnectCorpo, bool ReconnectCorpoChilds)
		{
			ReconnectRecordsetsEventArgs e = new ReconnectRecordsetsEventArgs(ExecReOpen, ReconnectTestata, ReconnectTestataChilds, ReconnectCorpo, ReconnectCorpoChilds);
			RaiseEvent(ReconnectRecordsetsEvent, Sender, e);
		}

        public void TestataChanged()
        {
            EventArgs e = new EventArgs();
            RaiseEvent(TestataChangedEvent, Sender, e);
        }

        public void CorpoChanged()
        {
            EventArgs e = new EventArgs();
            RaiseEvent(CorpoChangedEvent, Sender, e);
        }

        public void OnRollback()
        {
            EventArgs e = new EventArgs();
            RaiseEvent(OnRollbackEvent, Sender, e);
        }

		public void DatiCauzioni(object CodiceArticoloCauzione, object OpzioneCauzione, object ImportoCauzione)
		{
			DatiCauzioniEventArgs e = new DatiCauzioniEventArgs(CodiceArticoloCauzione, OpzioneCauzione, ImportoCauzione);
			RaiseEvent(DatiCauzioniEvent, Sender, e);
		}

		public void SelezioneLetteraIntento(ref bool Cancel, object TipoCF, object Clifor, object DataRiferimento, ref object LettereIntento, ref object IDSelezionato)
		{
			SelezioneLetteraIntentoEventArgs e = new SelezioneLetteraIntentoEventArgs(Cancel, TipoCF, Clifor, DataRiferimento, LettereIntento, IDSelezionato);
			RaiseEvent(SelezioneLetteraIntentoEvent, Sender, e);
			Cancel = e.Cancel;
			LettereIntento = e.LettereIntento;
			IDSelezionato = e.IDSelezionato;
		}

		public void ShowEsplosoKit(ref object frstEsplosioneKit, ref object fvarBookmarkRigaDaEsplodere, ref bool fbolEseguiEsplosioneKit, ref string fstrEsclSt1Padre, ref string fstrEsclSt2Padre, ref string fstrEsclSt3Padre, ref string fstrEsclSt4Padre, ref string fstrEsclSt1Figli, ref string fstrEsclSt2Figli, ref string fstrEsclSt3Figli, ref string fstrEsclSt4Figli)
		{
			ShowEsplosoKitEventArgs e = new ShowEsplosoKitEventArgs(frstEsplosioneKit, fvarBookmarkRigaDaEsplodere, fbolEseguiEsplosioneKit, fstrEsclSt1Padre, fstrEsclSt2Padre, fstrEsclSt3Padre, fstrEsclSt4Padre, fstrEsclSt1Figli, fstrEsclSt2Figli, fstrEsclSt3Figli, fstrEsclSt4Figli);
			RaiseEvent(ShowEsplosoKitEvent, Sender, e);
			frstEsplosioneKit = e.frstEsplosioneKit;
			fvarBookmarkRigaDaEsplodere = e.fvarBookmarkRigaDaEsplodere;
			fbolEseguiEsplosioneKit = e.fbolEseguiEsplosioneKit;
			fstrEsclSt1Padre = e.fstrEsclSt1Padre;
			fstrEsclSt2Padre = e.fstrEsclSt2Padre;
			fstrEsclSt3Padre = e.fstrEsclSt3Padre;
			fstrEsclSt4Padre = e.fstrEsclSt4Padre;
			fstrEsclSt1Figli = e.fstrEsclSt1Figli;
			fstrEsclSt2Figli = e.fstrEsclSt2Figli;
			fstrEsclSt3Figli = e.fstrEsclSt3Figli;
			fstrEsclSt4Figli = e.fstrEsclSt4Figli;
		}

		public void ShowEsplosoKit2(ref object frstEsplosioneKit, ref object fvarBookmarkRigaDaEsplodere, ref bool fbolEseguiEsplosioneKit, ref bool fbolRicalcolaPrezzoKitPadre, ref string fstrEsclSt1Padre, ref string fstrEsclSt2Padre, ref string fstrEsclSt3Padre, ref string fstrEsclSt4Padre, ref string fstrEsclSt1Figli, ref string fstrEsclSt2Figli, ref string fstrEsclSt3Figli, ref string fstrEsclSt4Figli)
		{
			ShowEsplosoKit2EventArgs e = new ShowEsplosoKit2EventArgs(frstEsplosioneKit, fvarBookmarkRigaDaEsplodere, fbolEseguiEsplosioneKit, fbolRicalcolaPrezzoKitPadre, fstrEsclSt1Padre, fstrEsclSt2Padre, fstrEsclSt3Padre, fstrEsclSt4Padre, fstrEsclSt1Figli, fstrEsclSt2Figli, fstrEsclSt3Figli, fstrEsclSt4Figli);
			RaiseEvent(ShowEsplosoKit2Event, Sender, e);
			frstEsplosioneKit = e.frstEsplosioneKit;
			fvarBookmarkRigaDaEsplodere = e.fvarBookmarkRigaDaEsplodere;
			fbolEseguiEsplosioneKit = e.fbolEseguiEsplosioneKit;
			fbolRicalcolaPrezzoKitPadre = e.fbolRicalcolaPrezzoKitPadre;
			fstrEsclSt1Padre = e.fstrEsclSt1Padre;
			fstrEsclSt2Padre = e.fstrEsclSt2Padre;
			fstrEsclSt3Padre = e.fstrEsclSt3Padre;
			fstrEsclSt4Padre = e.fstrEsclSt4Padre;
			fstrEsclSt1Figli = e.fstrEsclSt1Figli;
			fstrEsclSt2Figli = e.fstrEsclSt2Figli;
			fstrEsclSt3Figli = e.fstrEsclSt3Figli;
			fstrEsclSt4Figli = e.fstrEsclSt4Figli;
		}

		public void AggiuntaRigaDaKit()
		{
			EventArgs e = new EventArgs();
			RaiseEvent(AggiuntaRigaDaKitEvent, Sender, e);
		}

		public void BeforeRichiestaAttivazionePromozioni(ref object RstPromozioni, ref object RstPromozioniPotenziali, ref bool Cancel)
		{
			BeforeRichiestaAttivazionePromozioniEventArgs e = new BeforeRichiestaAttivazionePromozioniEventArgs(RstPromozioni, RstPromozioniPotenziali, Cancel);
			RaiseEvent(BeforeRichiestaAttivazionePromozioniEvent, Sender, e);
			RstPromozioni = e.RstPromozioni;
			RstPromozioniPotenziali = e.RstPromozioniPotenziali;
			Cancel = e.Cancel;
		}

		public void OnAbilitaNumerazioneAutofattura()
		{
			EventArgs e = new EventArgs();
			RaiseEvent(OnAbilitaNumerazioneAutofatturaEvent, Sender, e);
		}

		public void OnDisabilitaNumerazioneAutofattura()
		{
			EventArgs e = new EventArgs();
			RaiseEvent(OnDisabilitaNumerazioneAutofatturaEvent, Sender, e);
		}
    }

    // BeforeBeginTransaction event
    internal class BeforeBeginTransactionEventArgs : EventArgs
    {
        bool _Cancel;

        public BeforeBeginTransactionEventArgs(bool Cancel)
        {
            _Cancel = Cancel;
        }

        public bool Cancel
        {
            get { return _Cancel; }
            set { _Cancel = value;  }
        }
    }

    internal delegate void BeforeBeginTransactionEventHandler(object sender, BeforeBeginTransactionEventArgs e);

    // AfterBeginTransaction event
    internal class AfterBeginTransactionEventArgs : EventArgs
    { 
        bool _Cancel;

        public AfterBeginTransactionEventArgs(bool Cancel)
        {
            _Cancel = Cancel;
        }

        public bool Cancel
        {
            get { return _Cancel; }
			set { _Cancel = value; }
        }
    }

    internal delegate void AfterBeginTransactionEventHandler(object sender, AfterBeginTransactionEventArgs e);

    // BeforeCommitTransaction event
    internal class BeforeCommitTransactionEventArgs : EventArgs
    {
        bool _Cancel;

        public BeforeCommitTransactionEventArgs(bool Cancel)
        {
            _Cancel = Cancel;
        }

        public bool Cancel
        {
            get { return _Cancel; }
			set { _Cancel = value; }	
        }
    }

    internal delegate void BeforeCommitTransactionEventHandler(object sender, BeforeCommitTransactionEventArgs e);

    // AfterCommitTransaction event
    internal class AfterCommitTransactionEventArgs : EventArgs
    {
        bool _Cancel;

        public AfterCommitTransactionEventArgs(bool Cancel)
        {
            _Cancel = Cancel;
        }

        public bool Cancel
        {
            get { return _Cancel; }
			set { _Cancel = value; }
        }
    }

    internal delegate void AfterCommitTransactionEventHandler(object sender, AfterCommitTransactionEventArgs e);

    // ErrorsOccurred event
    internal class ErrorsOccurredEventArgs : EventArgs
    {
        string _ErrorDetail;
        bool _ShowMsgBox;
        VbMsgBoxStyle _MessageStyle;
        VbMsgBoxResult _MessageResult;

        internal ErrorsOccurredEventArgs(string ErrorDetail, bool ShowMsgBox, VbMsgBoxStyle MessageStyle, VbMsgBoxResult MessageResult)
        {
            _ErrorDetail = ErrorDetail;
            _ShowMsgBox = ShowMsgBox;
            _MessageStyle = MessageStyle;
            _MessageResult = MessageResult;
        }

        public string ErrorDetail
        {
            get { return _ErrorDetail; }
			set { _ErrorDetail = value; }
        }
        
        public bool ShowMsgBox
        {
            get { return _ShowMsgBox; }
			set { _ShowMsgBox = value; }
        }

        internal VbMsgBoxStyle MessageStyle
        {
            get { return _MessageStyle; }
			set { _MessageStyle = value; }
        }

        internal VbMsgBoxResult MessageResult
        {
            get { return _MessageResult; }
			set { _MessageResult = value; }
        }
    }

    internal delegate void ErrorsOccurredEventHandler(object sender, ErrorsOccurredEventArgs e);

    internal class OnConfermaBloccoModificaEventArgs : EventArgs
	{
		EnumCauseBloccoModifica _TipoBlocco;
		bool _fbolBloccoEliminabile;
		bool _CancellaBlocco;

		public OnConfermaBloccoModificaEventArgs(EnumCauseBloccoModifica TipoBlocco, bool fbolBloccoEliminabile, bool CancellaBlocco)
		{
			_TipoBlocco = TipoBlocco;
			_fbolBloccoEliminabile = fbolBloccoEliminabile;
			_CancellaBlocco = CancellaBlocco;
		}

		public EnumCauseBloccoModifica TipoBlocco
		{
			get { return _TipoBlocco; }
			set { _TipoBlocco = value; }
		}

		public bool fbolBloccoEliminabile
		{
			get { return _fbolBloccoEliminabile; }
			set { _fbolBloccoEliminabile = value; }
		}

		public bool CancellaBlocco
		{
			get { return _CancellaBlocco; }
			set { _CancellaBlocco = value; }
		}
	}

    internal delegate void OnConfermaBloccoModificaEventHandler(object sender, OnConfermaBloccoModificaEventArgs e);

    // WarningOccurred event
    internal class WarningOccurredEventArgs : EventArgs
    {
        string _WarningDetail;
        bool _ShowMsgBox;
        VbMsgBoxStyle _MessageStyle;
        VbMsgBoxResult _MessageResult;

        public WarningOccurredEventArgs(string WarningDetail, bool ShowMsgBox, VbMsgBoxStyle MessageStyle, VbMsgBoxResult MessageResult)
        {
            _WarningDetail = WarningDetail;
            _ShowMsgBox = ShowMsgBox;
            _MessageStyle = MessageStyle;
            _MessageResult = MessageResult;
        }

        public string WarningDetail
        {
            get { return _WarningDetail; }
			set { _WarningDetail = value; }
        }

        public bool ShowMsgBox
        {
            get { return _ShowMsgBox; }
			set { _ShowMsgBox = value; }
        }

        public VbMsgBoxStyle MessageStyle
        {
            get { return _MessageStyle; }
			set { _MessageStyle = value; }
        }

        public VbMsgBoxResult MessageResult
        {
            get { return _MessageResult; }
			set { _MessageResult = value; }
        }
    }

    internal delegate void WarningOccurredEventHandler(object sender, WarningOccurredEventArgs e);

    internal class InteractionOccurredEventArgs : EventArgs
	{
		string _InteractionDetail;
		bool _ShowMsgBox;
		VbMsgBoxStyle _MessageStyle;

		public InteractionOccurredEventArgs(string InteractionDetail, bool ShowMsgBox, VbMsgBoxStyle MessageStyle)
		{
			_InteractionDetail = InteractionDetail;
			_ShowMsgBox = ShowMsgBox;
			_MessageStyle = MessageStyle;
		}

		public string InteractionDetail
		{
			get { return _InteractionDetail; }
			set { _InteractionDetail = value; }
		}

		public bool ShowMsgBox
		{
			get { return _ShowMsgBox; }
			set { _ShowMsgBox = value; }
		}

		public VbMsgBoxStyle MessageStyle
		{
			get { return _MessageStyle; }
			set { _MessageStyle = value; }
		}
	}

    internal delegate void InteractionOccurredEventHandler(object sender, InteractionOccurredEventArgs e);

    internal class WarningIVA21OccurredEventArgs : EventArgs
	{
		string _Numreg;
		string _WarningDetail;
		bool _ShowMsgBox;
		VbMsgBoxStyle _MessageStyle;
		VbMsgBoxResult _MessageResult;

		public WarningIVA21OccurredEventArgs(string Numreg, string WarningDetail, bool ShowMsgBox, VbMsgBoxStyle MessageStyle, VbMsgBoxResult MessageResult)
		{
			_Numreg = Numreg;
			_WarningDetail = WarningDetail;
			_ShowMsgBox = ShowMsgBox;
			_MessageStyle = MessageStyle;
			_MessageResult = MessageResult;
		}

		public string Numreg
		{
			get { return _Numreg; }
			set { _Numreg = value; }
		}

		public string WarningDetail
		{
			get { return _WarningDetail; }
			set { _WarningDetail = value; }
		}

		public bool ShowMsgBox
		{
			get { return _ShowMsgBox; }
			set { _ShowMsgBox = value; }
		}

		public VbMsgBoxStyle MessageStyle
		{
			get { return _MessageStyle; }
			set { _MessageStyle = value; }
		}

		public VbMsgBoxResult MessageResult
		{
			get { return _MessageResult; }
			set { _MessageResult = value; }
		}
	}

    internal delegate void WarningIVA21OccurredEventHandler(object sender, WarningIVA21OccurredEventArgs e);

    internal class WarningIVA22OccurredEventArgs : EventArgs
	{
		string _Numreg;
		string _WarningDetail;
		bool _ShowMsgBox;
		VbMsgBoxStyle _MessageStyle;
		VbMsgBoxResult _MessageResult;

		public WarningIVA22OccurredEventArgs(string Numreg, string WarningDetail, bool ShowMsgBox, VbMsgBoxStyle MessageStyle, VbMsgBoxResult MessageResult)
		{
			_Numreg = Numreg;
			_WarningDetail = WarningDetail;
			_ShowMsgBox = ShowMsgBox;
			_MessageStyle = MessageStyle;
			_MessageResult = MessageResult;
		}

		public string Numreg
		{
			get { return _Numreg; }
			set { _Numreg = value; }
		}

		public string WarningDetail
		{
			get { return _WarningDetail; }
			set { _WarningDetail = value; }
		}

		public bool ShowMsgBox
		{
			get { return _ShowMsgBox; }
			set { _ShowMsgBox = value; }
		}

		public VbMsgBoxStyle MessageStyle
		{
			get { return _MessageStyle; }
			set { _MessageStyle = value; }
		}

		public VbMsgBoxResult MessageResult
		{
			get { return _MessageResult; }
			set { _MessageResult = value; }
		}
	}

    internal delegate void WarningIVA22OccurredEventHandler(object sender, WarningIVA22OccurredEventArgs e);

    internal class WarningAntiriciclaggioOccurredEventArgs : EventArgs
	{
		string _Numreg;
		string _WarningDetail;
		bool _ShowMsgBox;
		VbMsgBoxStyle _MessageStyle;
		VbMsgBoxResult _MessageResult;

		public WarningAntiriciclaggioOccurredEventArgs(string Numreg, string WarningDetail, bool ShowMsgBox, VbMsgBoxStyle MessageStyle, VbMsgBoxResult MessageResult)
		{
			_Numreg = Numreg;
			_WarningDetail = WarningDetail;
			_ShowMsgBox = ShowMsgBox;
			_MessageStyle = MessageStyle;
			_MessageResult = MessageResult;
		}

		public string Numreg
		{
			get { return _Numreg; }
			set { _Numreg = value; }
		}

		public string WarningDetail
		{
			get { return _WarningDetail; }
			set { _WarningDetail = value; }
		}

		public bool ShowMsgBox
		{
			get { return _ShowMsgBox; }
			set { _ShowMsgBox = value; }
		}

		public VbMsgBoxStyle MessageStyle
		{
			get { return _MessageStyle; }
			set { _MessageStyle = value; }
		}

		public VbMsgBoxResult MessageResult
		{
			get { return _MessageResult; }
			set { _MessageResult = value; }
		}
	}

    internal delegate void WarningAntiriciclaggioOccurredEventHandler(object sender, WarningAntiriciclaggioOccurredEventArgs e);

    internal class WarningCartaCreditoOccurredEventArgs : EventArgs
	{
		string _Numreg;
		string _WarningDetail;
		bool _ShowMsgBox;
		VbMsgBoxStyle _MessageStyle;
		VbMsgBoxResult _MessageResult;

		public WarningCartaCreditoOccurredEventArgs(string Numreg, string WarningDetail, bool ShowMsgBox, VbMsgBoxStyle MessageStyle, VbMsgBoxResult MessageResult)
		{
			_Numreg = Numreg;
			_WarningDetail = WarningDetail;
			_ShowMsgBox = ShowMsgBox;
			_MessageStyle = MessageStyle;
			_MessageResult = MessageResult;
		}

		public string Numreg
		{
			get { return _Numreg; }
			set { _Numreg = value; }
		}

		public string WarningDetail
		{
			get { return _WarningDetail; }
			set { _WarningDetail = value; }
		}

		public bool ShowMsgBox
		{
			get { return _ShowMsgBox; }
			set { _ShowMsgBox = value; }
		}

		public VbMsgBoxStyle MessageStyle
		{
			get { return _MessageStyle; }
			set { _MessageStyle = value; }
		}

		public VbMsgBoxResult MessageResult
		{
			get { return _MessageResult; }
			set { _MessageResult = value; }
		}
	}

    internal delegate void WarningCartaCreditoOccurredEventHandler(object sender, WarningCartaCreditoOccurredEventArgs e);

    internal class WarningEsigibilitaDifferitaEventArgs : EventArgs
	{
		string _Numreg;
		string _WarningDetail;
		bool _ShowMsgBox;
		VbMsgBoxStyle _MessageStyle;
		VbMsgBoxResult _MessageResult;

		public WarningEsigibilitaDifferitaEventArgs(string Numreg, string WarningDetail, bool ShowMsgBox, VbMsgBoxStyle MessageStyle, VbMsgBoxResult MessageResult)
		{
			_Numreg = Numreg;
			_WarningDetail = WarningDetail;
			_ShowMsgBox = ShowMsgBox;
			_MessageStyle = MessageStyle;
			_MessageResult = MessageResult;
		}

		public string Numreg
		{
			get { return _Numreg; }
			set { _Numreg = value; }
		}

		public string WarningDetail
		{
			get { return _WarningDetail; }
			set { _WarningDetail = value; }
		}

		public bool ShowMsgBox
		{
			get { return _ShowMsgBox; }
			set { _ShowMsgBox = value; }
		}

		public VbMsgBoxStyle MessageStyle
		{
			get { return _MessageStyle; }
			set { _MessageStyle = value; }
		}

		public VbMsgBoxResult MessageResult
		{
			get { return _MessageResult; }
			set { _MessageResult = value; }
		}
	}

    internal delegate void WarningEsigibilitaDifferitaEventHandler(object sender, WarningEsigibilitaDifferitaEventArgs e);

    internal class AvanzamentoEventArgs : EventArgs
	{
		int _Step;
		int _TotalSteps;
		string _Description;

		public AvanzamentoEventArgs(int Step, int TotalSteps, string Description)
		{
			_Step = Step;
			_TotalSteps = TotalSteps;
			_Description = Description;
		}

		public int Step
		{
			get { return _Step; }
			set { _Step = value; }
		}

		public int TotalSteps
		{
			get { return _TotalSteps; }
			set { _TotalSteps = value; }
		}

		public string Description
		{
			get { return _Description; }
			set { _Description = value; }
		}
	}

    internal delegate void AvanzamentoEventHandler(object sender, AvanzamentoEventArgs e);

    internal class DisconnectRecordsetsEventArgs : EventArgs
	{
		bool _ExecCancelUpdate;
		bool _DisconnectTestata;
		bool _DisconnectTestataChilds;
		bool _DisconnectCorpo;
		bool _DisconnectCorpoChilds;

		public DisconnectRecordsetsEventArgs(bool ExecCancelUpdate, bool DisconnectTestata, bool DisconnectTestataChilds, bool DisconnectCorpo, bool DisconnectCorpoChilds)
		{
			_ExecCancelUpdate = ExecCancelUpdate;
			_DisconnectTestata = DisconnectTestata;
			_DisconnectTestataChilds = DisconnectTestataChilds;
			_DisconnectCorpo = DisconnectCorpo;
			_DisconnectCorpoChilds = DisconnectCorpoChilds;
		}

		public bool ExecCancelUpdate
		{
			get { return _ExecCancelUpdate; }
			set { _ExecCancelUpdate = value; }
		}

		public bool DisconnectTestata
		{
			get { return _DisconnectTestata; }
			set { _DisconnectTestata = value; }
		}

		public bool DisconnectTestataChilds
		{
			get { return _DisconnectTestataChilds; }
			set { _DisconnectTestataChilds = value; }
		}

		public bool DisconnectCorpo
		{
			get { return _DisconnectCorpo; }
			set { _DisconnectCorpo = value; }
		}

		public bool DisconnectCorpoChilds
		{
			get { return _DisconnectCorpoChilds; }
			set { _DisconnectCorpoChilds = value; }
		}
	}

    internal delegate void DisconnectRecordsetsEventHandler(object sender, DisconnectRecordsetsEventArgs e);

    internal class ReconnectRecordsetsEventArgs : EventArgs
	{
		bool _ExecReOpen;
		bool _ReconnectTestata;
		bool _ReconnectTestataChilds;
		bool _ReconnectCorpo;
		bool _ReconnectCorpoChilds;

		public ReconnectRecordsetsEventArgs(bool ExecReOpen, bool ReconnectTestata, bool ReconnectTestataChilds, bool ReconnectCorpo, bool ReconnectCorpoChilds)
		{
			_ExecReOpen = ExecReOpen;
			_ReconnectTestata = ReconnectTestata;
			_ReconnectTestataChilds = ReconnectTestataChilds;
			_ReconnectCorpo = ReconnectCorpo;
			_ReconnectCorpoChilds = ReconnectCorpoChilds;
		}

		public bool ExecReOpen
		{
			get { return _ExecReOpen; }
			set { _ExecReOpen = value; }
		}

		public bool ReconnectTestata
		{
			get { return _ReconnectTestata; }
			set { _ReconnectTestata = value; }
		}

		public bool ReconnectTestataChilds
		{
			get { return _ReconnectTestataChilds; }
			set { _ReconnectTestataChilds = value; }
		}

		public bool ReconnectCorpo
		{
			get { return _ReconnectCorpo; }
			set { _ReconnectCorpo = value; }
		}

		public bool ReconnectCorpoChilds
		{
			get { return _ReconnectCorpoChilds; }
			set { _ReconnectCorpoChilds = value; }
		}
	}

    internal delegate void ReconnectRecordsetsEventHandler(object sender, ReconnectRecordsetsEventArgs e);

	internal class DatiCauzioniEventArgs : EventArgs
	{
		object _CodiceArticoloCauzione;
		object _OpzioneCauzione;
		object _ImportoCauzione;

		public DatiCauzioniEventArgs(object CodiceArticoloCauzione, object OpzioneCauzione, object ImportoCauzione)
		{
			_CodiceArticoloCauzione = CodiceArticoloCauzione;
			_OpzioneCauzione = OpzioneCauzione;
			_ImportoCauzione = ImportoCauzione;
		}

		public object CodiceArticoloCauzione
		{
			get { return _CodiceArticoloCauzione; }
			set { _CodiceArticoloCauzione = value; }
		}

		public object OpzioneCauzione
		{
			get { return _OpzioneCauzione; }
			set { _OpzioneCauzione = value; }
		}

		public object ImportoCauzione
		{
			get { return _ImportoCauzione; }
			set { _ImportoCauzione = value; }
		}
	}

    internal delegate void DatiCauzioniEventHandler(object sender, DatiCauzioniEventArgs e);

    internal class SelezioneLetteraIntentoEventArgs : EventArgs
	{
		bool _Cancel;
		object _TipoCF;
		object _Clifor;
		object _DataRiferimento;
		object _LettereIntento;
		object _IDSelezionato;

		public SelezioneLetteraIntentoEventArgs(bool Cancel, object TipoCF, object Clifor, object DataRiferimento, object LettereIntento, object IDSelezionato)
		{
			_Cancel = Cancel;
			_TipoCF = TipoCF;
			_Clifor = Clifor;
			_DataRiferimento = DataRiferimento;
			_LettereIntento = LettereIntento;
			_IDSelezionato = IDSelezionato;
		}

		public bool Cancel
		{
			get { return _Cancel; }
			set { _Cancel = value; }
		}

		public object TipoCF
		{
			get { return _TipoCF; }
			set { _TipoCF = value; }
		}

		public object Clifor
		{
			get { return _Clifor; }
			set { _Clifor = value; }
		}

		public object DataRiferimento
		{
			get { return _DataRiferimento; }
			set { _DataRiferimento = value; }
		}

		public object LettereIntento
		{
			get { return _LettereIntento; }
			set { _LettereIntento = value; }
		}

		public object IDSelezionato
		{
			get { return _IDSelezionato; }
			set { _IDSelezionato = value; }
		}
	}

    internal delegate void SelezioneLetteraIntentoEventHandler(object sender, SelezioneLetteraIntentoEventArgs e);

    internal class ShowEsplosoKitEventArgs : EventArgs
	{
		object _frstEsplosioneKit;
		object _fvarBookmarkRigaDaEsplodere;
		bool _fbolEseguiEsplosioneKit;
		string _fstrEsclSt1Padre;
		string _fstrEsclSt2Padre;
		string _fstrEsclSt3Padre;
		string _fstrEsclSt4Padre;
		string _fstrEsclSt1Figli;
		string _fstrEsclSt2Figli;
		string _fstrEsclSt3Figli;
		string _fstrEsclSt4Figli;

		public ShowEsplosoKitEventArgs(object frstEsplosioneKit, object fvarBookmarkRigaDaEsplodere, bool fbolEseguiEsplosioneKit, string fstrEsclSt1Padre, string fstrEsclSt2Padre, string fstrEsclSt3Padre, string fstrEsclSt4Padre, string fstrEsclSt1Figli, string fstrEsclSt2Figli, string fstrEsclSt3Figli, string fstrEsclSt4Figli)
		{
			_frstEsplosioneKit = frstEsplosioneKit;
			_fvarBookmarkRigaDaEsplodere = fvarBookmarkRigaDaEsplodere;
			_fbolEseguiEsplosioneKit = fbolEseguiEsplosioneKit;
			_fstrEsclSt1Padre = fstrEsclSt1Padre;
			_fstrEsclSt2Padre = fstrEsclSt2Padre;
			_fstrEsclSt3Padre = fstrEsclSt3Padre;
			_fstrEsclSt4Padre = fstrEsclSt4Padre;
			_fstrEsclSt1Figli = fstrEsclSt1Figli;
			_fstrEsclSt2Figli = fstrEsclSt2Figli;
			_fstrEsclSt3Figli = fstrEsclSt3Figli;
			_fstrEsclSt4Figli = fstrEsclSt4Figli;
		}

		public object frstEsplosioneKit
		{
			get { return _frstEsplosioneKit; }
			set { _frstEsplosioneKit = value; }
		}

		public object fvarBookmarkRigaDaEsplodere
		{
			get { return _fvarBookmarkRigaDaEsplodere; }
			set { _fvarBookmarkRigaDaEsplodere = value; }
		}

		public bool fbolEseguiEsplosioneKit
		{
			get { return _fbolEseguiEsplosioneKit; }
			set { _fbolEseguiEsplosioneKit = value; }
		}

		public string fstrEsclSt1Padre
		{
			get { return _fstrEsclSt1Padre; }
			set { _fstrEsclSt1Padre = value; }
		}

		public string fstrEsclSt2Padre
		{
			get { return _fstrEsclSt2Padre; }
			set { _fstrEsclSt2Padre = value; }
		}

		public string fstrEsclSt3Padre
		{
			get { return _fstrEsclSt3Padre; }
			set { _fstrEsclSt3Padre = value; }
		}

		public string fstrEsclSt4Padre
		{
			get { return _fstrEsclSt4Padre; }
			set { _fstrEsclSt4Padre = value; }
		}

		public string fstrEsclSt1Figli
		{
			get { return _fstrEsclSt1Figli; }
			set { _fstrEsclSt1Figli = value; }
		}

		public string fstrEsclSt2Figli
		{
			get { return _fstrEsclSt2Figli; }
			set { _fstrEsclSt2Figli = value; }
		}

		public string fstrEsclSt3Figli
		{
			get { return _fstrEsclSt3Figli; }
			set { _fstrEsclSt3Figli = value; }
		}

		public string fstrEsclSt4Figli
		{
			get { return _fstrEsclSt4Figli; }
			set { _fstrEsclSt4Figli = value; }
		}
	}

    internal delegate void ShowEsplosoKitEventHandler(object sender, ShowEsplosoKitEventArgs e);

    internal class ShowEsplosoKit2EventArgs : EventArgs
	{
		object _frstEsplosioneKit;
		object _fvarBookmarkRigaDaEsplodere;
		bool _fbolEseguiEsplosioneKit;
		bool _fbolRicalcolaPrezzoKitPadre;
		string _fstrEsclSt1Padre;
		string _fstrEsclSt2Padre;
		string _fstrEsclSt3Padre;
		string _fstrEsclSt4Padre;
		string _fstrEsclSt1Figli;
		string _fstrEsclSt2Figli;
		string _fstrEsclSt3Figli;
		string _fstrEsclSt4Figli;

		public ShowEsplosoKit2EventArgs(object frstEsplosioneKit, object fvarBookmarkRigaDaEsplodere, bool fbolEseguiEsplosioneKit, bool fbolRicalcolaPrezzoKitPadre, string fstrEsclSt1Padre, string fstrEsclSt2Padre, string fstrEsclSt3Padre, string fstrEsclSt4Padre, string fstrEsclSt1Figli, string fstrEsclSt2Figli, string fstrEsclSt3Figli, string fstrEsclSt4Figli)
		{
			_frstEsplosioneKit = frstEsplosioneKit;
			_fvarBookmarkRigaDaEsplodere = fvarBookmarkRigaDaEsplodere;
			_fbolEseguiEsplosioneKit = fbolEseguiEsplosioneKit;
			_fbolRicalcolaPrezzoKitPadre = fbolRicalcolaPrezzoKitPadre;
			_fstrEsclSt1Padre = fstrEsclSt1Padre;
			_fstrEsclSt2Padre = fstrEsclSt2Padre;
			_fstrEsclSt3Padre = fstrEsclSt3Padre;
			_fstrEsclSt4Padre = fstrEsclSt4Padre;
			_fstrEsclSt1Figli = fstrEsclSt1Figli;
			_fstrEsclSt2Figli = fstrEsclSt2Figli;
			_fstrEsclSt3Figli = fstrEsclSt3Figli;
			_fstrEsclSt4Figli = fstrEsclSt4Figli;
		}

		public object frstEsplosioneKit
		{
			get { return _frstEsplosioneKit; }
			set { _frstEsplosioneKit = value; }
		}

		public object fvarBookmarkRigaDaEsplodere
		{
			get { return _fvarBookmarkRigaDaEsplodere; }
			set { _fvarBookmarkRigaDaEsplodere = value; }
		}

		public bool fbolEseguiEsplosioneKit
		{
			get { return _fbolEseguiEsplosioneKit; }
			set { _fbolEseguiEsplosioneKit = value; }
		}

		public bool fbolRicalcolaPrezzoKitPadre
		{
			get { return _fbolRicalcolaPrezzoKitPadre; }
			set { _fbolRicalcolaPrezzoKitPadre = value; }
		}

		public string fstrEsclSt1Padre
		{
			get { return _fstrEsclSt1Padre; }
			set { _fstrEsclSt1Padre = value; }
		}

		public string fstrEsclSt2Padre
		{
			get { return _fstrEsclSt2Padre; }
			set { _fstrEsclSt2Padre = value; }
		}

		public string fstrEsclSt3Padre
		{
			get { return _fstrEsclSt3Padre; }
			set { _fstrEsclSt3Padre = value; }
		}

		public string fstrEsclSt4Padre
		{
			get { return _fstrEsclSt4Padre; }
			set { _fstrEsclSt4Padre = value; }
		}

		public string fstrEsclSt1Figli
		{
			get { return _fstrEsclSt1Figli; }
			set { _fstrEsclSt1Figli = value; }
		}

		public string fstrEsclSt2Figli
		{
			get { return _fstrEsclSt2Figli; }
			set { _fstrEsclSt2Figli = value; }
		}

		public string fstrEsclSt3Figli
		{
			get { return _fstrEsclSt3Figli; }
			set { _fstrEsclSt3Figli = value; }
		}

		public string fstrEsclSt4Figli
		{
			get { return _fstrEsclSt4Figli; }
			set { _fstrEsclSt4Figli = value; }
		}
	}

    internal delegate void ShowEsplosoKit2EventHandler(object sender, ShowEsplosoKit2EventArgs e);

    internal class BeforeRichiestaAttivazionePromozioniEventArgs : EventArgs
	{
		object _RstPromozioni;
		object _RstPromozioniPotenziali;
		bool _Cancel;

		public BeforeRichiestaAttivazionePromozioniEventArgs(object RstPromozioni, object RstPromozioniPotenziali, bool Cancel)
		{
			_RstPromozioni = RstPromozioni;
			_RstPromozioniPotenziali = RstPromozioniPotenziali;
			_Cancel = Cancel;
		}

		public object RstPromozioni
		{
			get { return _RstPromozioni; }
			set { _RstPromozioni = value; }
		}

		public object RstPromozioniPotenziali
		{
			get { return _RstPromozioniPotenziali; }
			set { _RstPromozioniPotenziali = value; }
		}

		public bool Cancel
		{
			get { return _Cancel; }
			set { _Cancel = value; }
		}
	}

    internal delegate void BeforeRichiestaAttivazionePromozioniEventHandler(object sender, BeforeRichiestaAttivazionePromozioniEventArgs e);

}