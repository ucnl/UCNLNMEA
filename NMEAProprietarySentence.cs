
namespace UCNLNMEA
{
    public sealed class NMEAProprietarySentence : NMEASentence
    {
        public string SentenceIDString { get; set; }
        public ManufacturerCodes Manufacturer { get; set; }
    }
}
