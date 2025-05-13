/**
 * Talkers identifiers
 */
const TalkerIdentifiers = {
    AG: 'AG',
    AP: 'AP',
    CD: 'CD',
    CR: 'CR',
    CS: 'CS',
    CT: 'CT',
    CV: 'CV',
    CX: 'CX',
    DE: 'DE',
    DF: 'DF',
    EC: 'EC',
    EP: 'EP',
    ER: 'ER',
    GA: 'GA', 
    GB: 'GB', 
	GI: 'GI',
    GL: 'GL',
	GN: 'GN',
    GP: 'GP',
    GQ: 'GQ',
    HC: 'HC',
    HE: 'HE',
    HN: 'HN',
    II: 'II',
    IN: 'IN',
    LA: 'LA',
    LC: 'LC',
    OM: 'OM',
    P: 'P',
    RA: 'RA',
    SD: 'SD',
    SN: 'SN',
    TR: 'TR',
    SS: 'SS',
    TI: 'TI',
    VD: 'VD',
    DM: 'DM',
    VW: 'VW',
    WI: 'WI',
    YX: 'YX',
    ZA: 'ZA',
    ZC: 'ZC',
    ZQ: 'ZQ',
    ZV: 'ZV',
    unknown: 'unknown'
};

/**
 * Sentences identifiers
 */
const SentenceIdentifiers = {
    AAM: 'AAM',
    ALM: 'ALM',
    APA: 'APA',
    APB: 'APB',
    ASD: 'ASD',
    BEC: 'BEC',
    BOD: 'BOD',
    BWC: 'BWC',
    BWR: 'BWR',
    BWW: 'BWW',
    DBK: 'DBK',
    DBS: 'DBS',
    DBT: 'DBT',
    DCN: 'DCN',
    DPT: 'DPT',
    DSC: 'DSC',
    DSE: 'DSE',
    DSI: 'DSI',
    DSR: 'DSR',
    DTM: 'DTM',
    FSI: 'FSI',
    GBS: 'GBS',
    GGA: 'GGA',
    GLC: 'GLC',
    GLL: 'GLL',
    GNS: 'GNS',
    GRS: 'GRS',
    GST: 'GST',
    GSA: 'GSA',
    GSV: 'GSV',
    GTD: 'GTD',
    GXA: 'GXA',
    HDG: 'HDG',
    HDM: 'HDM',
    HDT: 'HDT',
    HEV: 'HEV',
    HSC: 'HSC',
    LCD: 'LCD',
    MSK: 'MSK',
    MSS: 'MSS',
    MWD: 'MWD',
    MTW: 'MTW',
    MWV: 'MWV',
    OLN: 'OLN',
    OSD: 'OSD',
    ROO: 'ROO',
    RMA: 'RMA',
    RMB: 'RMB',
    RMC: 'RMC',
    ROT: 'ROT',
    RPM: 'RPM',
    RSA: 'RSA',
    RSD: 'RSD',
    RTE: 'RTE',
    SFI: 'SFI',
    STN: 'STN',
    TLL: 'TLL',
    TRF: 'TRF',
    TTM: 'TTM',
    TXT: 'TXT',
    VBW: 'VBW',
    VDR: 'VDR',
    VHW: 'VHW',
    VLW: 'VLW',
    VPW: 'VPW',
    VTG: 'VTG',
    VWR: 'VWR',
    WCV: 'WCV',
    WDC: 'WDC',
    WDR: 'WDR',
    WNC: 'WNC',
    WPL: 'WPL',
    XDR: 'XDR',
    XTE: 'XTE',
    XTR: 'XTR',
    ZDA: 'ZDA',
    ZDL: 'ZDL',
    ZFO: 'ZFO',
    ZTG: 'ZTG',
    unknown: 'unknown'
};

/**
 * Manufacturers codes
 */
const ManufacturerCodes = {
    AAR: 'AAR',
    ACE: 'ACE',
    ACR: 'ACR',
    ACS: 'ACS',
    ACT: 'ACT',
    AGI: 'AGI',
    AHA: 'AHA',
    AIP: 'AIP',
    ALD: 'ALD',
    AMR: 'AMR',
    AMT: 'AMT',
    ANS: 'ANS',
    ANX: 'ANX',
    ANZ: 'ANZ',
    APC: 'APC',
    APL: 'APL',
    APN: 'APN',
    APX: 'APX',
    AQC: 'AQC',
    AQD: 'AQD',
    AQM: 'AQM',
    ASP: 'ASP',
    ATE: 'ATE',
    ATM: 'ATM',
    ATR: 'ATR',
    ATV: 'ATV',
    AVN: 'AVN',
    AWA: 'AWA',
    AZM: 'AZM',
    BAT: 'BAT',
    BBL: 'BBL',
    BBR: 'BBR',
    BDV: 'BDV',
    BEC: 'BEC',
    BGS: 'BGS',
    BGT: 'BGT',
    BHE: 'BHE',
    BHR: 'BHR',
    BLB: 'BLB',
    BME: 'BME',
    BNI: 'BNI',
    BNS: 'BNS',
    BRM: 'BRM',
    BRY: 'BRY',
    BTH: 'BTH',
    BTK: 'BTK',
    BTS: 'BTS',
    BXA: 'BXA',
    CAT: 'CAT',
    CBN: 'CBN',
    CCA: 'CCA',
    CCC: 'CCC',
    CCL: 'CCL',
    CCM: 'CCM',
    CDC: 'CDC',
    CEC: 'CEC',
    CHI: 'CHI',
    CKM: 'CKM',
    CMA: 'CMA',
    CMC: 'CMC',
    CME: 'CME',
    CMP: 'CMP',
    CMS: 'CMS',
    CMV: 'CMV',
    CNV: 'CNV',
    CNX: 'CNX',
    CPL: 'CPL',
    CPN: 'CPN',
    CPS: 'CPS',
    CPT: 'CPT',
    CRE: 'CRE',
    CRO: 'CRO',
    CRY: 'CRY',
    CSI: 'CSI',
    CSM: 'CSM',
    CST: 'CST',
    CSV: 'CSV',
    CTA: 'CTA',
    CTB: 'CTB',
    CTC: 'CTC',
    CTE: 'CTE',
    CTL: 'CTL',
    CNI: 'CNI',
    CWD: 'CWD',
    CWV: 'CWV',
    CYZ: 'CYZ',
    DBG: 'DBG',
    DCC: 'DCC',
    DEB: 'DEB',
    DFI: 'DFI',
    DGC: 'DGC',
    DME: 'DME',
    DMI: 'DMI',
    DNS: 'DNS',
    DNT: 'DNT',
    DPS: 'DPS',
    DRL: 'DRL',
    DSC: 'DSC',
    DYN: 'DYN',
    DYT: 'DYT',
    EBC: 'EBC',
    ECT: 'ECT',
    EEV: 'EEV',
    EFC: 'EFC',
    ELD: 'ELD',
    EMC: 'EMC',
    EMS: 'EMS',
    ENA: 'ENA',
    ENC: 'ENC',
    EPM: 'EPM',
    EPT: 'EPT',
    ERC: 'ERC',
    ESA: 'ESA',
    FDN: 'FDN',
    FEC: 'FEC',
    FHE: 'FHE',
    FJN: 'FJN',
    FMM: 'FMM',
    FNT: 'FNT',
    FRC: 'FRC',
    FTG: 'FTG',
    FUJ: 'FUJ',
    FUG: 'FUG',
    FUR: 'FUR',
    GAM: 'GAM',
    GCA: 'GCA',
    GES: 'GES',
    GFC: 'GFC',
    GIS: 'GIS',
    GPI: 'GPI',
    GRM: 'GRM',
    GSC: 'GSC',
    GTO: 'GTO',
    GVE: 'GVE',
    GVT: 'GVT',
    HAL: 'HAL',
    HAR: 'HAR',
    HDN: 'HDN',
    HIG: 'HIG',
    HIT: 'HIT',
    HPK: 'HPK',
    HRC: 'HRC',
    HRT: 'HRT',
    HTI: 'HTI',
    HUL: 'HUL',
    HWM: 'HWM',
    ICO: 'ICO',
    IFD: 'IFD',
    IFI: 'IFI',
    IME: 'IME',
    IMI: 'IMI',
    IMM: 'IMM',
    IMP: 'IMP',
    IMT: 'IMT',
    INM: 'INM',
    INT: 'INT',
    IRT: 'IRT',
    IST: 'IST',
    ITM: 'ITM',
    ITR: 'ITR',
    JAN: 'JAN',
    JFR: 'JFR',
    JMT: 'JMT',
    JRC: 'JRC',
    JRI: 'JRI',
    JTC: 'JTC',
    JTR: 'JTR',
    KBE: 'KBE',
    KBM: 'KBM',
    KLA: 'KLA',
    KMR: 'KMR',
    KNG: 'KNG',
    KOD: 'KOD',
    KRP: 'KRP',
    KVH: 'KVH',
    KYI: 'KYI',
    LAT: 'LAT',
    LEC: 'LEC',
    LMM: 'LMM',
    LNA: 'LNA',
    LRD: 'LRD',
    LSE: 'LSE',
    LSP: 'LSP',
    LTF: 'LTF',
    LWR: 'LWR',
    MCL: 'MCL',
    MCP: 'MCP',
    MDL: 'MDL',
    MEC: 'MEC',
    MEG: 'MEG',
    MFR: 'MFR',
    MFW: 'MFW',
    MGN: 'MGN',
    MGS: 'MGS',
    MIE: 'MIE',
    MIM: 'MIM',
    MLE: 'MLE',
    MLN: 'MLN',
    MLP: 'MLP',
    MLT: 'MLT',
    MMB: 'MMB',
    MME: 'MME',
    MMP: 'MMP',
    MMS: 'MMS',
    MNI: 'MNI',
    MNT: 'MNT',
    MNX: 'MNX',
    MOT: 'MOT',
    MPN: 'MPN',
    MQS: 'MQS',
    MRC: 'MRC',
    MRE: 'MRE',
    MRP: 'MRP',
    MRR: 'MRR',
    MRS: 'MRS',
    MSB: 'MSB',
    MSE: 'MSE',
    MSM: 'MSM',
    MST: 'MST',
    MTA: 'MTA',
    MTG: 'MTG',
    MTK: 'MTK',
    MTR: 'MTR',
    MTS: 'MTS',
    MUR: 'MUR',
    MVX: 'MVX',
    MXX: 'MXX',
    MES: 'MES',
    NEF: 'NEF',
    NMR: 'NMR',
    NGS: 'NGS',
    NOM: 'NOM',
    NOV: 'NOV',
    NSM: 'NSM',
    NTK: 'NTK',
    NVC: 'NVC',
    NVL: 'NVL',
    NVS: 'NVS',
    NVO: 'NVO',
    OAR: 'OAR',
    ODE: 'ODE',
    ODN: 'ODN',
    OIN: 'OIN',
    OKI: 'OKI',
    OLY: 'OLY',
    OMN: 'OMN',
    ORE: 'ORE',
    OTK: 'OTK',
    PCE: 'PCE',
    PCH: 'PCH',
    PDM: 'PDM',
    PLA: 'PLA',
    PLI: 'PLI',
    PMI: 'PMI',
    PMP: 'PMP',
    PRK: 'PRK',
    PSM: 'PSM',
    PTC: 'PTC',
    PTG: 'PTG',
    PTH: 'PTH',
    RAC: 'RAC',
    RAE: 'RAE',
    RAY: 'RAY',
    RCA: 'RCA',
    RCH: 'RCH',
    RCI: 'RCI',
    RDI: 'RDI',
    RDM: 'RDM',
    REC: 'REC',
    RFP: 'RFP',
    RGC: 'RGC',
    RGY: 'RGY',
    RLF: 'RLF',
    RMR: 'RMR',
    RPH: 'RPH',
    RSL: 'RSL',
    RSM: 'RSM',
    RWE: 'RWE',
    RWI: 'RWI',
    RWL: 'RWL',
    RME: 'RME',
    RTN: 'RTN',
    SAI: 'SAI',
    SBR: 'SBR',
    SCR: 'SCR',
    SEA: 'SEA',
    SEC: 'SEC',
    SEP: 'SEP',
    SFN: 'SFN',
    SGC: 'SGC',
    SIG: 'SIG',
    SIM: 'SIM',
    SKA: 'SKA',
    SKP: 'SKP',
    SLI: 'SLI',
    SME: 'SME',
    SMF: 'SMF',
    SML: 'SML',
    SMI: 'SMI',
    SNV: 'SNV',
    SOM: 'SOM',
    SOV: 'SOV',
    SPL: 'SPL',
    SPT: 'SPT',
    SRD: 'SRD',
    SRF: 'SRF',
    SRS: 'SRS',
    SRT: 'SRT',
    SSI: 'SSI',
    STC: 'STC',
    STI: 'STI',
    STM: 'STM',
    SVY: 'SVY',
    SWI: 'SWI',
    TBB: 'TBB',
    TCN: 'TCN',
    TDL: 'TDL',
    THR: 'THR',
    TLS: 'TLS',
    TMT: 'TMT',
    TNL: 'TNL',
    TNT: 'TNT',
    TRC: 'TRC',
    TSI: 'TSI',
    TTK: 'TTK',
    TTS: 'TTS',
    TWC: 'TWC',
    TXI: 'TXI',
    UCN: 'UCN',
    UME: 'UME',
    UNA: 'UNA',
    UNI: 'UNI',
    UNP: 'UNP',
    UNF: 'UNF',
    UNV: 'UNV',
    UWV: 'UWV',
    VAN: 'VAN',
    VAR: 'VAR',
    VCM: 'VCM',
    VEX: 'VEX',
    VIS: 'VIS',
    VLB: 'VLB',
    VMR: 'VMR',
    VSN: 'VSN',
    WAL: 'WAL',
    WBG: 'WBG',
    WEC: 'WEC',
    WHA: 'WHA',
    WMM: 'WMM',
    WMR: 'WMR',
    WNG: 'WNG',
    WSE: 'WSE',
    WTC: 'WTC',
    WST: 'WST',
    YAS: 'YAS',
    ZMA: 'ZMA',
    any: 'any',
    unknown: 'unknown'
};

class NMEASentence {
    constructor() {
        this.parameters = [];
    }
}

class NMEAStandardSentence extends NMEASentence {
    constructor() {
        super();
        this.TalkerID = TalkerIdentifiers.unknown;
        this.SentenceID = SentenceIdentifiers.unknown;
    }
}

class NMEAProprietarySentence extends NMEASentence {
    constructor() {
        super();
        this.SentenceIDString = '';
        this.Manufacturer = ManufacturerCodes.unknown;
    }
}

class UCNLNMEAParser {
    // Constants
    static StandardID = "NMEA 0183 2.0";
    static MaxFullSentenceLength = 4255;
    static MaxSentenceLength = 4252;
    static SentenceStartDelimiter = '$';
    static SentenceEndDelimiter = "\r\n";
    static FieldDelimiter = ',';
    static CheckSumFieldDelimiter = '*';

    static arrayBrackets = ['[', ']'];
    static arrayOpenBracket = "[";
    static arrayCloseBracket = "]";
    static formatTokenDelimiters = [','];
    static formatEnumDelimiters = ['|'];
    static formatEnumPairDelimiter = "=";
    static formatEnumPairDelimiters = ['='];
    static etcFormat = "...";

    // Talker descriptions
    static TalkerDescriptions = {
        [TalkerIdentifiers.AG]: "Autopilot - General",
        [TalkerIdentifiers.AP]: "Autopilot - Magnetic",
        [TalkerIdentifiers.CD]: "Communications - Digital Selective Calling (DSC)",
        [TalkerIdentifiers.CR]: "Communications - Receiver / Beacon Receiver",
        [TalkerIdentifiers.CS]: "Communications - Sattelite",
        [TalkerIdentifiers.CT]: "Communications - Radio-Telephone (MF/HF)",
        [TalkerIdentifiers.CV]: "Communications - Radio-Telephone (VHF)",
        [TalkerIdentifiers.CX]: "Communications - Scanning Receiver",
        [TalkerIdentifiers.DF]: "Direction Finder",
        [TalkerIdentifiers.EC]: "Electronic Chart Display & Information System (ECDIS)",
        [TalkerIdentifiers.EP]: "Emergency Position Indicating Beacon (EPIRB)",
        [TalkerIdentifiers.ER]: "Engine Room Monitoring Systems",
		[TalkerIdentifiers.GA]: "Galileo Positioning System",
		[TalkerIdentifiers.GB]: "BDS (BeiDou System)",
		[TalkerIdentifiers.GI]: "NavIC (IRNSS)",
		[TalkerIdentifiers.GL]: "GLONASS Receiver",
		[TalkerIdentifiers.GN]: "Global Navigation Satellite System (GNSS)",
        [TalkerIdentifiers.GP]: "Global Positioning System (GPS)",
		[TalkerIdentifiers.GQ]: "QZSS",
        [TalkerIdentifiers.HC]: "Heading - Magnetic Compass",
        [TalkerIdentifiers.HE]: "Heading - North Seeking Gyro",
        [TalkerIdentifiers.HN]: "Heading - Non North Seeking Gyro",
        [TalkerIdentifiers.II]: "Integrated instrumentation",
        [TalkerIdentifiers.IN]: "Integrated Navigation",
        [TalkerIdentifiers.LC]: "Loran C",
        [TalkerIdentifiers.P]: "Proprietary Code",
        [TalkerIdentifiers.RA]: "RADAR and/or ARPA",
        [TalkerIdentifiers.SD]: "Sounder, Depth",
        [TalkerIdentifiers.SN]: "Electronic Positioning System, other/general",
        [TalkerIdentifiers.SS]: "Souder, Scanning",
        [TalkerIdentifiers.TI]: "Turn Rate Indicator",
        [TalkerIdentifiers.VD]: "Velocity Sensor, Doppler, other/general",
        [TalkerIdentifiers.DM]: "Velocity Sensor, Speed Log, Water, Magnetic",
        [TalkerIdentifiers.VW]: "Velocity Sensor, Speed Log, Water, Mechanical",
        [TalkerIdentifiers.WI]: "Weather Instruments",
        [TalkerIdentifiers.YX]: "Transduser",
        [TalkerIdentifiers.ZA]: "Timekeeper - Atomic Clock",
        [TalkerIdentifiers.ZC]: "Timekeeper - Chronometer",
        [TalkerIdentifiers.ZQ]: "Timekeeper - Quartz",
        [TalkerIdentifiers.ZV]: "Radio Update, WWV or WWVH"
    };

    // Sentences descriptions
    static SentencesDescriptions = {
        [SentenceIdentifiers.AAM]: "Waypoint Arrival Alarm",
        [SentenceIdentifiers.ALM]: "GPS Almanac Data",
        [SentenceIdentifiers.APB]: "Autopilot Sentence \"B\"",
        [SentenceIdentifiers.APA]: "Autopilot Sentence \"A\"",
        [SentenceIdentifiers.ASD]: "Autopilot System Data",
        [SentenceIdentifiers.BEC]: "Bearing & Distance to Waypoint, Dead reckoning",
        [SentenceIdentifiers.BOD]: "Bearing, Origin to Destination",
        [SentenceIdentifiers.BWC]: "Bearing & Distance to Waypoint, Great Circle",
        [SentenceIdentifiers.BWR]: "Bearing & Distance to Waypoint, Rhumb Line",
        [SentenceIdentifiers.BWW]: "Bearing, Waypoint to Waypoint",
        [SentenceIdentifiers.DBK]: "Depth Below Keel",
        [SentenceIdentifiers.DBS]: "Depth Below Surface",
        [SentenceIdentifiers.DBT]: "Depth Below Transduser",
        [SentenceIdentifiers.DCN]: "[Obsolete] Decca Position",
        [SentenceIdentifiers.DPT]: "Depth",
        [SentenceIdentifiers.DSC]: "Digital Selective Calling Information",
        [SentenceIdentifiers.DSE]: "Extended DSC",
        [SentenceIdentifiers.DSI]: "DSC Transponder Initiate",
        [SentenceIdentifiers.DSR]: "DSC Transponder Response",
        [SentenceIdentifiers.DTM]: "Datum Reference",
        [SentenceIdentifiers.FSI]: "Frequency Set Information",
        [SentenceIdentifiers.GBS]: "GBS Satellite Fault Detection",
        [SentenceIdentifiers.GGA]: "Global Positioning System Fix Data",
        [SentenceIdentifiers.GLC]: "Geographic Position, Loran-C",
        [SentenceIdentifiers.GLL]: "Geographic Position, Latitude/Longitude",
        [SentenceIdentifiers.GRS]: "GPS Range Residuals",
        [SentenceIdentifiers.GSA]: "GPS DOP and Active Satellites",
        [SentenceIdentifiers.GST]: "GPS Pseudorange Noise Statistics",
        [SentenceIdentifiers.GSV]: "GPS Sattelites in View",
        [SentenceIdentifiers.GTD]: "Geograpic Location in Time Differences",
        [SentenceIdentifiers.GXA]: "Transit Position",
        [SentenceIdentifiers.HDG]: "Heading, Deviation & Variation",
        [SentenceIdentifiers.HDM]: "Heading, Magnetic",
        [SentenceIdentifiers.HDT]: "Heading, True",
        [SentenceIdentifiers.HSC]: "Heading Steering Command",
        [SentenceIdentifiers.LCD]: "Loran-C Signal Data",
        [SentenceIdentifiers.MSK]: "MSK Receiver Interface (for DGPS Beacon Receivers)",
        [SentenceIdentifiers.MSS]: "MSK Receiver Signal Status",
        [SentenceIdentifiers.MTW]: "Water Temperature",
        [SentenceIdentifiers.MWD]: "Wind Direction & Speed",
        [SentenceIdentifiers.MWV]: "Wind Speed & Angle",
        [SentenceIdentifiers.OLN]: "[Obsolete] Omega Line Numbers",
        [SentenceIdentifiers.OSD]: "Own Ship Data",
        [SentenceIdentifiers.RMA]: "Recommend Minimum Specific Loran-C Data",
        [SentenceIdentifiers.RMB]: "Recommend Minimum Navigation Information",
        [SentenceIdentifiers.RMC]: "Recommend Minimum Specific GPS/TRANSIT Data",
        [SentenceIdentifiers.ROO]: "Waypoints in Active Route",
        [SentenceIdentifiers.ROT]: "Rate of Turn",
        [SentenceIdentifiers.RPM]: "Revolutions",
        [SentenceIdentifiers.RSA]: "Rudder Sensor Angle",
        [SentenceIdentifiers.RSD]: "RADAR System Data",
        [SentenceIdentifiers.RTE]: "Routes",
        [SentenceIdentifiers.SFI]: "Scanning Frequency Information",
        [SentenceIdentifiers.STN]: "Multiple Data ID",
        [SentenceIdentifiers.TLL]: "Target Latitude & Longitude",
        [SentenceIdentifiers.TRF]: "[Obsolete] TRANSIT Fix Data",
        [SentenceIdentifiers.TTM]: "Tracked Target Message",
        [SentenceIdentifiers.VBW]: "Dual Ground/Water Speed",
        [SentenceIdentifiers.VDR]: "Set and Drift",
        [SentenceIdentifiers.VHW]: "Water Speed and Heading",
        [SentenceIdentifiers.VLW]: "Distance Traveled through Water",
        [SentenceIdentifiers.VPW]: "Speed, Measured Parallel to Wind",
        [SentenceIdentifiers.VTG]: "Track Made Good and Ground Speed",
        [SentenceIdentifiers.VWR]: "Relative Wind Speed & Angle",
        [SentenceIdentifiers.WCV]: "Waypoint Closure Velocity",
        [SentenceIdentifiers.WDC]: "Distance to Waypoint, Great Circle",
        [SentenceIdentifiers.WDR]: "Distance to Waypoint, Rhumb Line",
        [SentenceIdentifiers.WNC]: "Distance, Waypoint to Waypoint",
        [SentenceIdentifiers.WPL]: "Waypoint Location",
        [SentenceIdentifiers.XDR]: "Transducer Measurement",
        [SentenceIdentifiers.XTE]: "Cross-Track Error, Measured",
        [SentenceIdentifiers.XTR]: "Cross-Track Error, Dead Reckoning",
        [SentenceIdentifiers.ZDA]: "Time & Date",
        [SentenceIdentifiers.ZDL]: "Time & Distance to Variable Point",
        [SentenceIdentifiers.ZFO]: "UTC & Time from Origin Waypoint",
        [SentenceIdentifiers.ZTG]: "UTC & Time to Destination Waypoint"
    };

// Datums dictionary
   static Datums = {
    0: "WGS1984 (International)",
    1: "Tokyo (Japan)",
    2: "Tokyo (Mean for Japan, South Korea, Okinawa)",
    3: "User setting",
    4: "Adindan (Burkina Faso)",
    5: "Adindan (Cameroon)",
    6: "Adindan (Ethiopia)",
    7: "Adindan (Mali)",
    8: "Adindan (Mean for Ethiopia, Sudan)",
    9: "Adindan (Senegal)",
    10: "Adindan (Sudan)",
    11: "Afgooye (Somalia)",
    12: "Ain El Abd1970 (Bahrain)",
    13: "Ain El Abd1970 (Saudi Arabia)",
    14: "American Samoa1962 (American Samoa islands)",
    15: "Anna 1 Astro1965 (Cocos Island)",
    16: "Antigua Island Astro1943 (Antigua (Leeward Islands))",
    17: "Arc1950 (Botswana)",
    18: "Arc1950 (Burundi)",
    19: "Arc1950 (Lesotho)",
    20: "Arc1950 (Malawi)",
    21: "Arc1950 (Mean for Botswana, Lesotho, Malawi, Swaziland, Zaire, Zambia, Zimbabwe)",
    22: "Arc1950 (Swaziland)",
    23: "Arc1950 (Zaire)",
    24: "Arc1950 (Zambia)",
    25: "Arc1950 (Zimbabwe)",
    26: "Arc1960 (Mean for Kenya Tanzania)",
    27: "Arc1960 (Kenya)",
    28: "Arc1960 (Tanzania)",
    29: "Ascension Island 1958 (Ascension Island)",
    30: "Astro Beacon E 1945 (Iwo Jima)",
    31: "Astro Dos 71/4 (St Helena Island)",
    32: "Astro Tern Island (FRIG) 1961 (Tern Island)",
    33: "Astronomical Station 1952 (Marcus Island)",
    34: "Australian Geodetic 1966 (Mercus Island)",
    35: "Australian Geodetic 1984 (Australia, Tasmania)",
    36: "Ayabelle Lighthouse (Djibouti)",
    37: "Bellevue (IGN) (Efate and Erromango Islands)",
    38: "Bermuda 1957 (Bermuda)",
    39: "Bissau (Guuinea-Bissau)",
    40: "Bogota Observatory (Colombia)",
    41: "Bukit Rimpah (Indonesia (Bangka and Belitung Ids))",
    42: "Camp Area Astro (Antarctica (McMurdi Camp Area))",
    43: "Campo Inchauspe (Argentina)",
    44: "Canton Astro1966 (Phoenix Island)",
    45: "Cape (South Africa)",
    46: "Cape Canaveral (Bahamas, Florida)",
    47: "Carthage (Tunisia)",
    48: "Chatham Island Astro1971 (New Zealand(Chatham Island))",
    49: "Chua Astro (Paraguay)",
    50: "Corrego Alegre (Brazil)",
    51: "Dabola (Guinea)",
    52: "Deception Island (Deception Island, Antarctica)",
    53: "Djakarta (Batavia) (Indonesia (Sumatra))",
    54: "Dos 1968 (New Georgia Islands (Gizo Island)",
    55: "Easter Island 1967 (Easter Island)",
    56: "Estonia Coordinate System 1937 (Estonia)",
    57: "European 1950 (Cyprus)",
    58: "European 1950 (Egypt)",
    59: "European 1950 (England, Channel Isnalds, Scotland, Shetland Islands)",
    60: "European 1950 (England, Ireland, Scotland, Shetland Islands)",
    61: "European 1950 (Finland, Norway",
    62: "European 1950 (Greece)",
    63: "European 1950 (Iran)",
    64: "European 1950 (Italy (Sardinia))",
    65: "European 1950 (Italy (Sicily))",
    66: "European 1950 (Malta)",
    67: "European 1950 (Mean for Austria, Belgium, Danmark, Finland, France, W. Germany, Gibraltar, Greece, Italy, Luxemburg, Netherlands, Norway, Portugal, Spain, Sweden, Switzerland)",
    68: "European 1950 (Mean for Austria, Denmark, France, W. Germany, Netherland, Switzerland)",
    69: "European 1950 (Mean for Iraq, Israel, Jordan, Lebanon, Kuwait, Saudi Arabia, Syria)",
    70: "European 1950 (Portugal, Spain)",
    71: "European 1950 (Tunisia)",
    72: "European 1950 (Mean for Austria, Finland, Netherlands, Norway, Spain, Sweden, Switzerland)",
    73: "Fort Thomas 1955 (Nevis St. Kitts (Leeward Islands))",
    74: "Gan 1970 (Republic of Maldives)",
    75: "Geodetic Datum 1970 (New Zeland)",
    76: "Graciosa Base SW1948 (Azores (Fial, Graciosa, Pico, Sao, Jorge, Terceria))",
    77: "Guam1963 (Guam)",
    78: "Gunung Segara (Indonesia (Kalimantan))",
    79: "Gux I Astro (Guadalcanal Island)",
    80: "Herat North (Afganistan)",
    81: "Hermannskogel Datum (Croatia-Serbia, Bosnia-Herzegovina)",
    82: "Hjorsey 1955 (Iceland)",
    83: "Hongkong 1963 (Hongkong)",
    84: "Hu Tzu Shan (Taiwan)",
    85: "Indian (Bangladesh)",
    86: "Indian (India, Nepal)",
    87: "Indian (Pakistan)",
    88: "Indian 1954 (Thailand)",
    89: "Indian 1960 (Vietnam (Con Son Island)",
    90: "Indian 1960 (Vietnam (Near 16 deg N))",
    91: "Indian 1975 (Thailand)",
    92: "Indonesian 1974 (Indonesian)",
    93: "Ireland 1965 (Ireland)",
    94: "ISTS 061 Astro 1968 (South Georgia Islands)",
    95: "ISTS 073 Astro 1969 (Diego Garcia)",
    96: "Johnston Island 1961 (Johnston Island)",
    97: "Kandawala (Sri Lanka)",
    98: "Kerguelen Island 1949 (Kerguelen Island)",
    99: "Kertau 1948 (West Malaysia and Singapore)",
    100: "Kusaie Astro 1951 (Caroline Island)",
    101: "Korean Geodetic System (South Korea)",
    102: "LC5 Astro 1961 (Cayman Brac Island)",
    103: "Leigon (Ghana)",
    104: "Liberia 1964 (Liberia)",
    105: "Luzon (Philippines (Excluding Mindanao))",
    106: "Luzon (Philippines (Mindanao))",
    107: "M'Poraloko (Gabon)",
    108: "Mahe 1971 (Mahe Island)",
    109: "Massawa (Ethopia (Eritrea))",
    110: "Merchich (Morocco)",
    111: "Midway Astro 1961 (Midway Islands)",
    112: "Minna (Cameroon)",
    113: "Minna (Nigeria)",
    114: "Montserrat Island Astro 1958 (Monserat (Leeward Island))",
    115: "Nahrwan (Oman (Masirah Island))",
    116: "Nahrwan (Saudi Arabia)",
    117: "Nahrwan (United Arab Emirates)",
    118: "Naparima BWI (Trinidad and Tobago)",
    119: "North American 1927 (Alaska (Excluding Aleutian Islands))",
    120: "North American 1927 (Alaska (Aleutian Islands East of 180 deg. W)",
    121: "North American 1927 (Alaska (Aleutian Islands West of 180 deg. W)",
    122: "North American 1927 (Bahamas (Except San Salvador Islands))",
    123: "North American 1927 (Bahamas (San Salvador Islands))",
    124: "North American 1927 (Canada (Alberta, British Columbia))",
    125: "North American 1927 (Canada (Manitoba, Ontario))",
    126: "North American 1927 (Canada (New Brunswick, Newfoundland, Nova Scotia, Quebec))",
    127: "North American 1927 (Canada (Northwest Territories, Saskatchewan))",
    128: "North American 1927 (Canada (Youkon))",
    129: "North American 1927 (Canal Zone)",
    130: "North American 1927 (Cuba)",
    131: "North American 1927 (Greenland (Hayes Peninsula))",
    132: "North American 1927 (Mean for Antigua, Barbados, Barbuda, Caicos Islands, Cuba, Dominican, Grand Cayman, Jamaica, Turks Islands)",
    133: "North American 1927 (Mean for Belize, Costa Rica, El Salvador, Guatemala, Honduras, Nicaragua)",
    134: "North American 1927 (Mean for Canada)",
    135: "North American 1927 (Mean for Conus)",
    136: "North American 1927 (Mean for Conus (East of Mississippi, River Including Louisiana, Missouri, Minnesota)",
    137: "North American 1927 (Mean for Conus (West of Mississippi, River Excluding Louisiana, Missouri, Minnesota)",
    138: "North American 1927 (Mexico)",
    139: "North American 1983 (Alaska (Excluding Aleutian Islands))",
    140: "North American 1983 (Aleutian Islands)",
    141: "North American 1983 (Canada)",
    142: "North American 1983 (Conus)",
    143: "North American 1983 (Hahawii)",
    144: "North American 1983 (Mexico, Central America)",
    145: "North Sahara 1959 (Algeria)",
    146: "Observatorio Meteorologico 1939 (Azores (Corvo and Flores Islands))",
    147: "Old Egyptian 1907 (Egypt)",
    148: "Old Hawaiian (Hawaii)",
    149: "Old Hawaiian (Kauai)",
    150: "Old Hawaiian (Maui)",
    151: "Old Hawaiian (Mean for Hawaii, Kauai, Maui, Oahu)",
    152: "Old Hawaiian (Oahu)",
    153: "Oman (Oman)",
    154: "Ordnance Survey Great Britain 1936 (England)",
    155: "Ordnance Survey Great Britain 1936 (England, Isle of Man, Wales)",
    156: "Ordnance Survey Great Britain 1936 (Mean for England, Isle of Man, Scotland, Shetland Islands, Wales)",
    157: "Ordnance Survey Great Britain 1936 (Scotland, Shetland Islands)",
    158: "Ordnance Survey Great Britain 1936 (Wales)",
    159: "Pico de las Nieves (Canary Islands)",
    160: "Pitcairn Astro 1967 (Pitcairn Island)",
    161: "Point 58 (Mean for Burkina Faso and Niger)",
    162: "Pointe Noire 1948 (Congo)",
    163: "Porto Santo 1936 (Porto Santo, Maderia Islands)",
    164: "Provisional South American 1956 (Bolivia)",
    165: "Provisional South American 1956 (Chilie (Norther Near 19 deg S))",
    166: "Provisional South American 1956 (Chilie (Southern Near 43 deg S))",
    167: "Provisional South American 1956 (Colombia)",
    168: "Provisional South American 1956 (Ecuador)",
    169: "Provisional South American 1956 (Guyana)",
    170: "Provisional South American 1956 (Mean for Bolivia, Chilie, Colombia, Ecuador, Guyana, Peru, Venezuela)",
    171: "Provisional South American 1956 (Peru)",
    172: "Provisional South American 1956 (Venezuela)",
    173: "Provisional South Chilean 1963 (Chilie (Near 53 deg S) (Hito XVIII))",
    174: "Puerto Rico (Puerto Rico, Virgin Islands)",
    175: "Pulkovo 1942 (Russia)",
    176: "Quatar National (Quatar)",
    177: "Qornoq (Greenland (South))",
    178: "Reunion (Mascarene Island)",
    179: "Rome 1940 (Italy (Sardinia))",
    180: "S-42 (Pulkovo 1942) (Hungary)",
    181: "S-42 (Pulkovo 1942) (Poland)",
    182: "S-42 (Pulkovo 1942) (Czechoslavakia)",
    183: "S-42 (Pulkovo 1942) (Latvia)",
    184: "S-42 (Pulkovo 1942) (Kazakhstan)",
    185: "S-42 (Pulkovo 1942) (Albania)",
    186: "S-42 (Pulkovo 1942) (Romania)",
    187: "S-JTSK (Czechoslavakia (Prior 1 Jan 1993))",
    188: "Santo (Dos) 1965 (Espirito Santo Island)",
    189: "Sao Braz (Azores (San Miguel, Santa Maria Islands))",
    190: "Sapper Hill",
    191: "Schwarzeck (Namibia)",
    192: "Selvagem Grande 1938 (Salvage Islands)",
    193: "Sierra Leone 1960 (Sierra Leone)",
    194: "South American 1969 (Argentina)",
    195: "South American 1969 (Bolivia)",
    196: "South American 1969 (Brazil)",
    197: "South American 1969 (Chilie)",
    198: "South American 1969 (Colombia)",
    199: "South American 1969 (Ecuador)",
    200: "South American 1969 (Ecuador (Baltra, Galapagos))",
    201: "South American 1969 (Guyana)",
    202: "South American 1969 (Mean for Argentina, Bolivia, Brazil, Chilie, Colombia, Ecuador, Guayana, Paraguay, Peru, Trinidad and Tobago, Venezuela)",
    203: "South American 1969 (Paraguay)",
    204: "South American 1969 (Peru)",
    205: "South American 1969 (Trinidad and Tobago)",
    206: "South American 1969 (Venezuela)",
    207: "South Asia (Singapore)",
    208: "Tananarive Observatory 1925 (Madagascar)",
    209: "Timbalai 1948 (Brunei, E. Malaysia (Sabah Sarawak))",
    210: "Tokyo (Japan)",
    211: "Tokyo (Mean for Japan, South Korea, Okinawa)",
    212: "Tokyo (Okinawa)",
    213: "Tokyo (South Korea)",
    214: "Tristan Astro 1968 (Tristam Da Cunha)",
    215: "Viti Levu 1916 (Fiji (Viti Levu Island))",
    216: "Voirol 1960 (Algeria)",
    217: "Wake Island Astro 1952 (Wake Atoll)",
    218: "Wake-Eniwetok 1960 (Marshall Islands)",
    219: "WGS 1972 (Global Definition)",
    220: "WGS 1984 (Global Definition)",
    221: "Yacare (Uruguay)",
    222: "Zanderij (Suriname)"
};

    // Sentences formats
static SentencesFormats = {
    [SentenceIdentifiers.AAM]: "A=Arrival circled entered|V=V,A=Perpendicular passed at way point|V=V,x.x,N=nm|K=km,c--c",
    [SentenceIdentifiers.ALM]: "x.x,x.x,xx,x.x,hh,hhhh,hh,hhhh,hhhhhh,hhhhhh,hhhhhh,hhhhhh,hhh,hhh",
    [SentenceIdentifiers.APB]: "V=Loran-C Blink or SNR warning|A=general warning flag,V=Loran-C Cycle Lock warning flag|A=OK or not used,x.x,R=Right|L=Left,N=nm|K=km,A=Arrival circled entered|V=Invalid,A=Perpendicular passed at way point|V=Invalid,x.x,M=Magnetic|T=True,c--c,x.x,M=Magnetic|T=True,x.x,M=Magnetic|T=True",
    [SentenceIdentifiers.APA]: "V=Loran-C Blink or SNR warning|A=general warning flag,V=Loran-C Cycle Lock warning flag|A=OK or not used,x.xx,R=Right|L=Left,N=nm|K=km,A=Arrival circled entered|V=Invalid,A=Perpendicular passed at way point|V=Invalid,xxx,M=Magnetic|T=True,c---c",
    [SentenceIdentifiers.ASD]: "",
    [SentenceIdentifiers.BEC]: "hhmmss.ss,llll.ll,N=N|S=S,yyyyy.y,N=N|S=S,x.x,E=E|W=W,x.x,T=True|M=Magnetic,x.x,N=nm|K=km,c--c",
    [SentenceIdentifiers.BOD]: "x.x,T=True|M=Magnetic,x.x,T=True|M=Magnetic,c--c,c--c",
    [SentenceIdentifiers.BWC]: "hhmmss.ss,llll.ll,N=N|S=S,yyyyy.yy,E=E|W=W,x.x,T=True|M=Magnetic,x.x,T=True|M=Magnetic,x.x,N=nm|K=km,c--c",
    [SentenceIdentifiers.BWR]: "hhmmss.ss,llll.ll,N=N|S=S,yyyyy.yy,E=E|W=W,x.x,T=True|M=Magnetic,x.x,T=True|M=Magnetic,x.x,N=nm|K=km,c--c",
    [SentenceIdentifiers.BWW]: "x.x,T=True|M=Magnetic,x.x,T=True|M=Magnetic,c--c,c--c",
    [SentenceIdentifiers.DBK]: "x.x,f=ft|M=m,x.x,f=ft|M=m,x.x,F",
    [SentenceIdentifiers.DBS]: "x.x,f=ft|M=m,x.x,f=ft|M=m,x.x,F",
    [SentenceIdentifiers.DBT]: "x.x,f=ft|M=m,x.x,f=ft|M=m,x.x,F",
    [SentenceIdentifiers.DCN]: "xx,cc,x.x,A,cc,x.x,A,cc,x.x,A,A,A,A,x.x,N=nm|K=km,1=Normal pattern|2=Lane identification pattern|3=Lane identification transmissions",
    [SentenceIdentifiers.DPT]: "x.x,x.x",
    [SentenceIdentifiers.DSC]: "",
    [SentenceIdentifiers.DSE]: "",
    [SentenceIdentifiers.DSI]: "",
    [SentenceIdentifiers.DSR]: "",
    [SentenceIdentifiers.DTM]: "xxx,x,xx.xxxx,x,xx.xxxx,x,c--c,xxx",
    [SentenceIdentifiers.FSI]: "xxxxxx,xxxxxx,c,x",
    [SentenceIdentifiers.GBS]: "hhmmss.ss,x.x,x.x,x.x,x.x,x.x,x.x,x.x",
    [SentenceIdentifiers.GGA]: "hhmmss.ss,llll.ll,a,yyyyy.yy,a,0=Fix not availible|1=GPS fix|2=DGPS fix,xx,x.x,x.x,M,x.x,M,x.x,xxxx",
    [SentenceIdentifiers.GLC]: "xxxx,x.x,a,x.x,a,x.x,a,x.x,a,x.x,a,x.x,B=Blink|C=Cycle|S=SNR|A=Valid",
    [SentenceIdentifiers.GLL]: "llll.ll,N=N|S=S,yyyyy.yy,E=E|W=W,hhmmss.ss,A=Valid|V=Invalid,A=Valid|V=Invalid",
    [SentenceIdentifiers.GNS]: "hhmmss.ss,llll.ll,a,yyyyy.yy,a,с--с,xx,x.x,x.x,x.x,x.x,x,a",
    [SentenceIdentifiers.GRS]: "hhmmss,x,x.x,x.x,x.x,x.x,x.x,x.x,x.x,x.x,x.x,x.x,x.x,x.x,x.x",
    [SentenceIdentifiers.GSA]: "M=Manual|A=Automatic,x,xx,xx,xx,xx,xx,xx,xx,xx,xx,xx,xx,xx,x.x,x.x,x.x,x",
    [SentenceIdentifiers.GST]: "hhmmss.ss,x.x,x.x,x.x,x.x,x.x,x.x,x.x",
    [SentenceIdentifiers.GSV]: "x,x,xx,xx,xx,xxx,xx,xx,xx,xxx,xx,xx,xx,xxx,xx,xx,xx,xxx,xx,",
    [SentenceIdentifiers.GTD]: "x.x,x.x,x.x,x.x,x.x",
    [SentenceIdentifiers.GXA]: "hhmmss.ss,llll.ll,a,yyyyy.yy,a,c--c,x",
    [SentenceIdentifiers.HDG]: "x.x,x.x,a,x.x,a",
    [SentenceIdentifiers.HDM]: "x.x,M",
    [SentenceIdentifiers.HDT]: "x.x,T",
    [SentenceIdentifiers.HEV]: "x.x,A",
    [SentenceIdentifiers.HSC]: "x.x,T,x.x,M",
    [SentenceIdentifiers.LCD]: "xxxx,xxx,xxx,xxx,xxx,xxx,xxx,xxx,xxx,xxx,xxx,xxx,xxx",
    [SentenceIdentifiers.MSK]: "xxx.x,xx,xxx,xx,N",
    [SentenceIdentifiers.MSS]: "",
    [SentenceIdentifiers.MTW]: "x.x,C=C|K=K|F=F",
    [SentenceIdentifiers.MWD]: "",
    [SentenceIdentifiers.MWV]: "x.x,a,x.x,a,A",
    [SentenceIdentifiers.OLN]: "aa,xxx,xxx,aa,xxx,xxx,aa,xxx,xxx",
    [SentenceIdentifiers.OSD]: "x.x,A,x.x,a,x.x,a,x.x,x.x,a",
    [SentenceIdentifiers.RMA]: "A,llll.ll,N=N|S=S,yyyyy.yy,E=E|W=W,x.x,x.x,x.x,x.x,x.x,a",
    [SentenceIdentifiers.RMB]: "A,x.x,a,c--c,c--c,llll.ll,a,yyyyy.yy,a,x.x,x.x,x.x,A,A",
    [SentenceIdentifiers.RMC]: "hhmmss.ss,A=Valid|V=Invalid,llll.ll,N=N|S=S,yyyyy.yy,E=E|W=W,x.x,x.x,ddmmyy,x.x,a,a,...",
    [SentenceIdentifiers.ROO]: "c---c,....",
    [SentenceIdentifiers.ROT]: "x.x,A",
    [SentenceIdentifiers.RPM]: "a,x,x.x,x.x,A",
    [SentenceIdentifiers.RSA]: "x.x,A,x.x,A",
    [SentenceIdentifiers.RSD]: "x.x,x.x,x.x,x.x,x.x,x.x,x.x,x.x,x.x,x.x,x.x,a,a",
    [SentenceIdentifiers.RTE]: "x.x,x.x,a,c--c,c--c,...",
    [SentenceIdentifiers.SFI]: "x.x,x.x,xxxxxx,c,xxxxxx,c",
    [SentenceIdentifiers.STN]: "xx",
    [SentenceIdentifiers.TLL]: "xx,llll.lll,a,yyyyy.yyy,a,c--c,hhmmss.ss,a,a",
    [SentenceIdentifiers.TRF]: "hhmmss.ss,xxxxxx,llll.ll,a,yyyyy.yy,a,x.x,x.x,x.x,x.x,xxx,A",
    [SentenceIdentifiers.TTM]: "xx,x.x,x.x,T=True|R=Relative,x.x,x.x,T=True|R=Relative,x.x,x.x,K=Km|N=Knots|S=Statue miles,c--c,L=Lost|Q=Query|T=Tracking,a,hhmmss.ss,A=Automatic|M=Manual",
    [SentenceIdentifiers.TXT]: "x,x,x,c--c",
    [SentenceIdentifiers.VBW]: "x.x,x.x,A,x.x,x.x,A",
    [SentenceIdentifiers.VDR]: "x.x,T,x.x,M,x.x,N",
    [SentenceIdentifiers.VHW]: "x.x,T,x.x,M,x.x,N,x.x,K",
    [SentenceIdentifiers.VLW]: "x.x,N,x.x,N",
    [SentenceIdentifiers.VPW]: "x.x,N,x.x,M",
    [SentenceIdentifiers.VTG]: "x.x,T,x.x,M,x.x,N=nk/h,x.x,K=Km/h,a",
    [SentenceIdentifiers.VWR]: "x.x,a,x.x,N,x.x,M,x.x,K",
    [SentenceIdentifiers.WCV]: "x.x,N,c--c",
    [SentenceIdentifiers.WDC]: "",
    [SentenceIdentifiers.WDR]: "",
    [SentenceIdentifiers.WNC]: "x.x,N,x.x,K,c--c,c--c",
    [SentenceIdentifiers.WPL]: "llll.ll,a,yyyyy.yy,a,c--c",
    [SentenceIdentifiers.XDR]: "a,x.x,a,c--c,a,x.x,a,c--c",
    [SentenceIdentifiers.XTE]: "A,A,x.x,a,N",
    [SentenceIdentifiers.XTR]: "x.x,a,N",
    [SentenceIdentifiers.ZDA]: "hhmmss.ss,xx,xx,xxxx,xx,xx",
    [SentenceIdentifiers.ZDL]: "hhmmss.ss,hhmmss.ss,c--c",
    [SentenceIdentifiers.ZFO]: "hhmmss.ss,hhmmss.ss,c--c",
    [SentenceIdentifiers.ZTG]: "hhmmss.ss,hhmmss.ss,c--c"
};
    // Known proprietary sentences
    static ProprietarySentencesFormats = {
    // Garmin corporation
    [ManufacturerCodes.GRM]: {
        "B": "x.x,x,x,x,x.x,a,0=Check Wiring|1=No Signal|2=Tuning|3=Receiving|4=Scanning,R=RTCM|W=WAAS|N=Non DGPS fix,A=Automatic|W=WAAS Only|R=RTCM Only|N=None",
        "E": "x.x,a,x.x,a,x.x,a",
        "F": "x,x,ddmmyy,hhmmss,x,dddmm.mmmm,N=N|S=S,dddmm.mmmm,E=E|W=W,M=Maual|A=Automatic,0=NoFix|1=2DFix|2=3DFix,x.x,x.x,x.x,x.x",
        "M": "c--c",
        "T": "c--c,P=Pass|F=Fail,P=Pass|F=Fail,R=Retained|L=Lost,R=Retained|L=Lost,P=Pass|F=Excessive Drift Detected,C=Collecting|Null=Not Collecting,x.x,R=Retained|L=Lost",
        "V": "x.x,x.x,x.x",
        "Z": "x.x,F=Feet,2=User Altitude|3=GPS Altitude",
        "C": "A=Automatic|2=2D Exclusively|3=3D Exclusively,x.x,x,x.x,x,x,x,x,A=Automatic|D=Only Output Differential Fixes,1=1200|2=2400|3=4800|4=9600|5=19200|6=300|7=600,x,1=None|2=1Hz,x,x.x",
        "CE": "",
        "C1": "x,1=Off|2=On,1=Off|2=On,x.x,x,1=Off|2=On,1=Off|2=On,A=Automatic|W=WAAS Only|R=RTCM Only|N=None,P=Activated|N=Normal",
        "C1E": "",
        "I": "dddmm.mmm,N=N|S=S,dddmm.mmm,N=N|S=S,ddmmyy,hhmmss,A=Autolocate|R=Unit Reset",
        "IE": "",
        "O": "c--c,0=Disable|1=Enable|2=Disable All Except PSLIB|3=Enable All Except GPALM|4=Restore Defaults"
    },

    // Martech, Inc.
    [ManufacturerCodes.MTK]: {
        "001": "c--c,0=Invalid|1=Unsupported|2=Valid, action failed|3=Valid, action succeeded",
        "101": "",
        "102": "",
        "103": "",
        "104": "",
        "251": "x",
        "300": "x,x,x,x,x",
        "301": "0=No DGPS source|1=RTCM|2=WAAS",
        "313": "0=Disable|1=Enable",
        "314": "x,x,x,x,x,x,x,x,x,x,x,x,x,x,x,x,x,x,x",
        "320": "0=False|1=True",
        "390": "x,x,x,x,x,x,x,x,x,x,x,0=Disable|1=RTCM|2=SBAS",
        "420": "",
        "490": "",
        "520": "0=False|1=True",
        "590": "x,x,x,x,x,x,x,x,x,x,x,x,0=Disable|1=RTCM|2=SBAS,x",
        "605": "",
        "705": "c--c,c--c,c--c"
    },

    // Trimble Navigation
    [ManufacturerCodes.TNL]: {
        "DG": "x.x,x.x,x.x,x,x,0=Idle|1=Wideband FFT search|2=Searching for signal|3=Channel has acquired signal|4=Channel has locked signal|5=Channel disabled,0=False|1=True,x",
        "EV": "hhmmss.ss,x",
        ",GGK": "hhmmss.ss,ddmmyy,llll.ll,N=North|S=South,dddmm.mm,E=East|W=West,0=Fix unavailible or invalid|1=Autonomous GPS fix|2=RTK float solution|3=RTK fixed solution|4=DGPS,x,x.x,c--c,M=m|f=ft",
        "ID": "c--c,c--c,x,x,dd/mm/yy",
        "SM": "xxxx,c--c",
        ",AVR": "hhmmss.ss,x.x,c--c,x.x,c--c,c--c,c--c,x.x,0=Not availible|1=Autonomous GNSS|2=Dif. carrier phase solution RTK (float)|3=Dif. carrier phase solution RTK (fix)|4=Dif. code-based solution (DGNSS),c--c,x",
        ",BPQ": "hhmmss.ss,ddmmyy,llll.ll,N=North|S=South,yyyyy.yy,E=East|W=West,c--c,M=m|f=ft,0=Not availible|1=Autonomous GNSS fix|2=DGNSS or OmniSTART VBS fix|4=RTK fixed|5=OmniSTAR HP/XP/G2/Float RTK",
        ",PJK": "hhmmss.ss,ddmmyy,x.x,N=North,x.x,E=East,0=Not availible|1=Autonomous GNSS|2=RTK float|3=RTK fix|4=Dif. code-based solution (DGNSS)|5=SBAS|6=RTK float 3D|7=RTK fixed 3D|8=RTK float 2D|9=RTK fix 2D|10=OmniSTAR HP/XP/G2|11=OmniSTAR VBS|12=Location RTK|13=Beacon DGNSS,x,c--c,EHTx.x,M=m|f=ft",
        ",PJT": "c--c,c--c",
        ",VGK": "hhmmss.ss,ddmmyy,x.x,x.x,x.x,0=Not availible|1=Autonomous GNSS|2=RTK float|3=RTK fix|4=Dif. code-based solution (DGNSS)|5=SBAS|6=RTK float 3D|7=RTK fixed 3D|8=RTK float 2D|9=RTK fix 2D|10=OmniSTAR HP/XP/G2|11=OmniSTAR VBS|12=Location RTK|13=Beacon DGNSS,x,c--c,M=m|f=ft",
        ",VHD": "hhmmss.ss,ddmmyy,yyyyy.yy,x.x,lllll.ll,x.x,x.x,x.x,0=Not availible|1=Autonomous GNSS|2=RTK float|3=RTK fix|4=Dif. code-based solution (DGNSS)|5=SBAS|6=RTK float 3D|7=RTK fixed 3D|8=RTK float 2D|9=RTK fix 2D|10=OmniSTAR HP/XP/G2|11=OmniSTAR VBS|12=Location RTK|13=Beacon DGNSS,x,c--c"
    },

    // Fugro
    [ManufacturerCodes.FUG]: {
        "DP": "GP=GPS|GL=GLONASS|GN=GNSS,hhmmss.ss,llll.ll,N=North|S=South,yyyyy.yy,E=East|W=West,x,x,x.x,x.x,x.x,x.x"
    },

    // Magellan
    [ManufacturerCodes.MGN]: {
        "CMD": "c--c,...",
        "CSM": "hh",
        "DRT": "xx",
        "DWP": "c--c,xx",
        "RTE": "xx,xx,c,x,c--c,...",
        "TRK": "llll.ll,N=North|S=South,yyyyy.yy,E=East|W=West,xxxxx,f=Ft|M=m,hhmmss.ss,A=Valid|V=Invalid,c--c,ddmmyy",
        "VER": "x,x,c--c,c--c,c--c",
        "WPL": "llll.ll,N=North|S=South,yyyyy.yy,W=West|E=East,xxxx,M=m|f=ft,c--c,c--c,c--c,xx",
        "ST": "c--c,2=2D|3=3D,T=True|F=False,x,x.x,x,x"
    },

    // Motorola
    [ManufacturerCodes.MOT]: {
        "G": "c--c,x"
    },

    // Rockwell International
    [ManufacturerCodes.RWI]: {
        "RID": "x,x.x,c--c,mm/dd/yy,hhhh",
        "ILOG": "c--c,A=activate|V=deactivate,T=cyclic,x,x"
    },

    // Starlink
    [ManufacturerCodes.SLI]: {
        "B": "x.x,x,c--c,J=Status request|K=Configuration request|=tuning message"
    },

    // SRF (update 08 dec 2013)
    [ManufacturerCodes.SRF]: {
        "100": "0=BIN|1=NMEA,x,x,x,0=None|1=Even|2=Odd",
        "101": "x,x,x,x,x,x,x,x,x",
        "102": "x,x,x,x",
        "103": "0=GGA|1=GLL|2=GSA|3=GSV|4=RMC|5=VTG,x,x,x",
        "104": "x.x,x.x,x.x,x,x,x,x,x",
        "105": "x"
    },

    // Furuno
    [ManufacturerCodes.FEC]: {
        ",hdcom": "c--c,c--c,xxxx"
    }
};

    // Formatters
    static parsers = {
        "x": x => parseInt(x),
        "xx": x => parseInt(x),
        "xxx": x => parseInt(x),
        "xxxx": x => parseInt(x),
        "xxxxx": x => parseInt(x),
        "xxxxxx": x => parseInt(x),
        "hh": x => parseInt(x, 16),
        "hhhh": x => parseInt(x, 16),
        "hhhhhh": x => parseInt(x, 16),
        "hhhhhhhh": x => parseInt(x, 16),
        "h--h": x => UCNLNMEAParser.ParseByteArray(x),
        "x.x": x => parseFloat(x),
        "c--c": x => x,
        "llll.ll": x => UCNLNMEAParser.ParseLatitude(x),
        "yyyyy.yy": x => UCNLNMEAParser.ParseLongitude(x),
        "hhmmss": x => UCNLNMEAParser.ParseCommonTime(x),
        "hhmmss.ss": x => UCNLNMEAParser.ParseCommonTime(x),
        "ddmmyy": x => UCNLNMEAParser.ParseCommonDate(x),
        "dddmm.mmmm": x => UCNLNMEAParser.ParseCommonDegrees(x)
    };

    static formatters = {
        "x": x => x.toString(),
        "xx": x => x.toString().padStart(2, '0'),
        "xxx": x => x.toString().padStart(3, '0'),
        "xxxx": x => x.toString().padStart(4, '0'),
        "xxxxx": x => x.toString().padStart(5, '0'),
        "xxxxxx": x => x.toString(),
        "hh": x => x.toString(16).padStart(2, '0').toUpperCase(),
        "hhhh": x => x.toString(16).padStart(4, '0').toUpperCase(),
        "hhhhhh": x => x.toString(16).padStart(6, '0').toUpperCase(),
        "hhhhhhhh": x => x.toString(16).padStart(8, '0').toUpperCase(),
        "h--h": x => UCNLNMEAParser.FormatByteArray(x),
        "x.x": x => parseFloat(x).toFixed(6).replace(/\.?0+$/, ''),
        "c--c": x => x.toString(),
        "llll.ll": x => UCNLNMEAParser.FormatLatitude(x),
        "yyyyy.yy": x => UCNLNMEAParser.FormatLongitude(x),
        "hhmmss": x => UCNLNMEAParser.FormatTime(x, false),
        "hhmmss.ss": x => UCNLNMEAParser.FormatTime(x, true),
        "ddmmyy": x => UCNLNMEAParser.FormatDate(x),
        "dd/mm/yy": x => UCNLNMEAParser.FormatDateSlashes(x),
        "dddmm.mmmm": x => UCNLNMEAParser.FormatDegree(x),
        "ddd.dddd": x => UCNLNMEAParser.FormatDecDegree(x)
    };

    // Sentence building methods
    static BuildSentence(talkerID, sentenceID, parameters) {
        const formatter = UCNLNMEAParser.SentencesFormats[sentenceID];

        let sb = talkerID.toString() + sentenceID.toString() + UCNLNMEAParser.FieldDelimiter;
        sb += UCNLNMEAParser.BuildParametersList(parameters, formatter);

        const checkSum = UCNLNMEAParser.GetCheckSum(sb);

        sb += UCNLNMEAParser.CheckSumFieldDelimiter + checkSum.toString(16).padStart(2, '0').toUpperCase();
        sb += UCNLNMEAParser.SentenceEndDelimiter;

        return UCNLNMEAParser.SentenceStartDelimiter + sb;
    }

    static BuildProprietarySentence(manufacturerID, sentenceIDString, parameters) {
        const formatter = UCNLNMEAParser.ProprietarySentencesFormats[manufacturerID][sentenceIDString];

        let sb = TalkerIdentifiers.P.toString() + manufacturerID.toString() + sentenceIDString;
        sb += UCNLNMEAParser.FieldDelimiter;
        sb += UCNLNMEAParser.BuildParametersList(parameters, formatter);

        const checkSum = UCNLNMEAParser.GetCheckSum(sb);

        sb += UCNLNMEAParser.CheckSumFieldDelimiter + checkSum.toString(16).padStart(2, '0').toUpperCase();
        sb += UCNLNMEAParser.SentenceEndDelimiter;

        return UCNLNMEAParser.SentenceStartDelimiter + sb;
    }

    static BuildParametersList(items, formatter) {
        const splits = formatter.split(UCNLNMEAParser.formatTokenDelimiters[0]);

        if ((splits.length >= items.length) || (formatter.includes(UCNLNMEAParser.etcFormat))) {
            let sb = [];
            let previousFormat = "c--c";
            
            for (let i = 0; i < items.length; i++) {
                const format = splits.length <= i ? previousFormat : splits[i];
                sb.push(UCNLNMEAParser.FormatToken(items[i], format));
                previousFormat = format;
            }

            return sb.join(UCNLNMEAParser.FieldDelimiter);
        } else {
            throw new Error("Specified parameters list and formatting string incompatible");
        }
    }

    static FormatToken(item, format) {
        if (item == null) return '';

        if (format.includes(UCNLNMEAParser.formatEnumPairDelimiter)) {
            const items = format.split(UCNLNMEAParser.formatEnumDelimiters[0]);
            const enumDictionary = {};

            for (let i = 0; i < items.length; i++) {
                const pair = items[i].split(UCNLNMEAParser.formatEnumPairDelimiters[0]);
                if (pair.length === 2) {
                    enumDictionary[pair[1]] = pair[0];
                } else {
                    throw new Error(`Error in format token "${format}"`);
                }
            }

            if (enumDictionary[item.toString()]) {
                return enumDictionary[item.toString()];
            } else {
                throw new Error(`Specified object "${item}" cannot be formatted with format string "${format}"`);
            }
        } else {
            if (format.startsWith(UCNLNMEAParser.arrayOpenBracket) && format.endsWith(UCNLNMEAParser.arrayCloseBracket)) {
                return UCNLNMEAParser.FormatArray(item, format.slice(1, -1));
            } else {
                if (UCNLNMEAParser.formatters[format]) {
                    return UCNLNMEAParser.formatters[format](item);
                } else {
                    return item.toString();
                }
            }
        }
    }

    // Heuristic formatters
    static FormatArray(item, format) {
        if (Array.isArray(item)) {
            return item.map(x => UCNLNMEAParser.FormatToken(x, format)).join(UCNLNMEAParser.formatEnumDelimiters[0]);
        } else {
            throw new Error(`Unable cast "${typeof item}" to array`);
        }
    }

    static FormatLatitude(x) {
        const degrees = Math.floor(x);
        const minutes = Math.floor((x - degrees) * 60);
        const seconds = (x - degrees) * 3600 - minutes * 60;
        const totalMinutes = minutes + seconds / 60;
        return degrees.toString().padStart(2, '0') + totalMinutes.toFixed(4).padStart(7, '0').replace(/\.?0+$/, '');
    }

    static FormatLongitude(x) {
        const degrees = Math.floor(x);
        const minutes = Math.floor((x - degrees) * 60);
        const seconds = (x - degrees) * 3600 - minutes * 60;
        const totalMinutes = minutes + seconds / 60;
        return degrees.toString().padStart(3, '0') + totalMinutes.toFixed(4).padStart(7, '0').replace(/\.?0+$/, '');
    }

    static FormatTime(dt, isMilliseconds) {
        let sb = dt.getHours().toString().padStart(2, '0') +
                dt.getMinutes().toString().padStart(2, '0') +
                dt.getSeconds().toString().padStart(2, '0');
        
        if (isMilliseconds) {
            sb += '.' + dt.getMilliseconds().toString();
        }
        
        return sb;
    }

    static FormatDate(dt) {
        return dt.getDate().toString().padStart(2, '0') +
               (dt.getMonth() + 1).toString().padStart(2, '0') +
               (dt.getFullYear() - 2000).toString().padStart(2, '0');
    }

    static FormatDateSlashes(dt) {
        return dt.getDate().toString().padStart(2, '0') + '/' +
               (dt.getMonth() + 1).toString().padStart(2, '0') + '/' +
               (dt.getFullYear() - 2000).toString().padStart(2, '0');
    }

    static FormatDegree(x) {
        const degrees = Math.floor(x);
        const minutes = Math.floor((x - degrees) * 60);
        const seconds = (x - degrees) * 3600 - minutes * 60;
        const totalMinutes = minutes + seconds / 60;
        return degrees.toString().padStart(3, '0') + totalMinutes.toFixed(4).padStart(7, '0').replace(/\.?0+$/, '');
    }

    static FormatDecDegree(x) {
        return x.toFixed(4).padStart(8, '0');
    }

    static FormatByteArray(bytes) {
        return '0x' + bytes.map(b => b.toString(16).padStart(2, '0')).join('').toUpperCase();
    }

    // Sentence parsing methods
    static Parse(sourceString) {
        if (!sourceString.endsWith(UCNLNMEAParser.SentenceEndDelimiter)) {
            throw new Error(`${UCNLNMEAParser.StandardID} sentence must end with valid sentence end delimiter "\\r\\n"`);
        }

        const source = sourceString.slice(0, -UCNLNMEAParser.SentenceEndDelimiter.length);

        if (source.length > UCNLNMEAParser.MaxSentenceLength) {
            throw new Error(`Specified string length ${source.length} exceeds ${UCNLNMEAParser.MaxSentenceLength} characters`);
        }

        if (!source.startsWith(UCNLNMEAParser.SentenceStartDelimiter)) {
            throw new Error(`${UCNLNMEAParser.StandardID} sentence must start with valid sentence start delimiter "${UCNLNMEAParser.SentenceStartDelimiter}"`);
        }

        try {
            const { sentence, checkSumString } = UCNLNMEAParser.SplitSentence(source);

            if (checkSumString) {
                const declaredCheckSum = parseInt(checkSumString, 16);
                const realCheckSum = UCNLNMEAParser.GetCheckSum(sentence);

                if (realCheckSum === declaredCheckSum) {
                    return UCNLNMEAParser.ParseSentence1(sentence);
                } else {
                    throw new Error(`Integrity error in sentence "${sentence}" (declared: ${declaredCheckSum}, real: ${realCheckSum})`);
                }
            } else {
                return UCNLNMEAParser.ParseSentence1(sentence);
            }
        } catch (ex) {
            throw ex;
        }
    }

    static ParseProprietary(manufacturerIDString, sentenceID, parameters) {
        let manufacturerID = ManufacturerCodes.unknown;
        try {
            manufacturerID = ManufacturerCodes[manufacturerIDString];
        } catch {
            throw new Error(`Unknown manufacturer "${manufacturerIDString}" in proprietary sentence`);
        }

        if (UCNLNMEAParser.ProprietarySentencesFormats[manufacturerID]) {
            if (UCNLNMEAParser.ProprietarySentencesFormats[manufacturerID][sentenceID]) {
                const result = new NMEAProprietarySentence();
                result.Manufacturer = manufacturerID;
                result.SentenceIDString = sentenceID;

                const formatter = UCNLNMEAParser.ProprietarySentencesFormats[manufacturerID][sentenceID];
                result.parameters = UCNLNMEAParser.ParseParameters(parameters, formatter);

                return result;
            } else {
                throw new Error(`Unknown proprietary sentence "${sentenceID}", manufacturerID: "${manufacturerID}"`);
            }
        } else {
            throw new Error(`Unknown manufacturerID "${manufacturerID}", sentenceID: "${sentenceID}"`);
        }
    }

    static ParseSentence3(talkerID, sentenceIDString, parameters) {
        let sentenceID = SentenceIdentifiers.unknown;
        try {
            sentenceID = SentenceIdentifiers[sentenceIDString];
        } catch {
            throw new Error(`Undefined sentence ID "${sentenceIDString}" from talker "${talkerID}"`);
        }

        const formatter = UCNLNMEAParser.SentencesFormats[sentenceID];
        if (!formatter) {
            throw new Error(`Specified sentence "${sentenceID}" from talker "${talkerID}" is unknown`);
        }

        const result = new NMEAStandardSentence();
        result.TalkerID = talkerID;
        result.SentenceID = sentenceID;

        result.parameters = UCNLNMEAParser.ParseParameters(parameters, formatter);

        return result;
    }

    static ParseSentence1(source) {
        const splits = source.split(UCNLNMEAParser.FieldDelimiter);
        const parameters = [];

        if (splits.length > 1) {
            const sentenceDescription = splits[0];
            if (sentenceDescription.length >= 4) {
                if (sentenceDescription.startsWith(TalkerIdentifiers.P.toString())) {
                    // Proprietary code
                    const manufacturerIDString = sentenceDescription.substring(1, 4);

                    let start = 1;
                    let sentenceIDString;
                    if (sentenceDescription.length === 4) {
                        sentenceDescription += UCNLNMEAParser.FieldDelimiter + splits[1];
                        start = 2;
                    }

                    sentenceIDString = sentenceDescription.substring(4);

                    for (let i = start; i < splits.length; i++) {
                        parameters.push(splits[i]);
                    }

                    return UCNLNMEAParser.ParseProprietary(manufacturerIDString, sentenceIDString, parameters);
                } else {
                    // Not a proprietary code
                    const talkerIDString = sentenceDescription.substring(0, 2);
                    const sentenceIDString = sentenceDescription.substring(2, 5);

                    let talkerID = TalkerIdentifiers.unknown;
                    try {
                        talkerID = TalkerIdentifiers[talkerIDString];
                    } catch {
                        throw new Error(`Undefined talker ID "${talkerIDString}"`);
                    }

                    for (let i = 1; i < splits.length; i++) {
                        parameters.push(splits[i]);
                    }

                    return UCNLNMEAParser.ParseSentence3(talkerID, sentenceIDString, parameters);
                }
            } else {
                throw new Error(`Wrong sentence description: "${sentenceDescription}"`);
            }
        } else {
            throw new Error(`No field delimiters in specified sentence "${source}"`);
        }
    }

    static SplitSentence(source) {

    const temp = source.substring(1);

    if (source.includes(UCNLNMEAParser.CheckSumFieldDelimiter)) {
        const splits = temp.split(UCNLNMEAParser.CheckSumFieldDelimiter);

        if (splits.length === 2) {
            return {
                sentence: splits[0],
                checkSumString: splits[1]
            };
        } else {
            throw new Error(`Specified string "${source}" not in correct ${UCNLNMEAParser.StandardID} format`);
        }
    } else {
        return {
            sentence: temp,
            checkSumString: ''
        };
    }
}

    static ParseToken(token, format) {
        if (!token) return null;

        if (format.includes(UCNLNMEAParser.formatEnumPairDelimiter)) {
            const items = format.split(UCNLNMEAParser.formatEnumDelimiters[0]);
            const enumDictionary = {};

            for (let i = 0; i < items.length; i++) {
                const pair = items[i].split(UCNLNMEAParser.formatEnumPairDelimiters[0]);
                if (pair.length === 2) {
                    enumDictionary[pair[0]] = pair[1];
                } else {
                    throw new Error(`Error in format token "${format}"`);
                }
            }

            if (enumDictionary[token]) {
                return enumDictionary[token];
            } else {
                return token;
            }
        } else {
            if (format.startsWith(UCNLNMEAParser.arrayOpenBracket) && token.endsWith(UCNLNMEAParser.arrayCloseBracket)) {
                return UCNLNMEAParser.ParseArray(token, format.slice(1, -1));
            } else {
                if (UCNLNMEAParser.parsers[format]) {
                    return UCNLNMEAParser.parsers[format](token);
                } else {
                    return token;
                }
            }
        }
    }

    static ParseParameters(parameters, formatString) {
        const formatTokens = formatString.split(UCNLNMEAParser.formatTokenDelimiters[0]);
        if ((formatTokens.length >= parameters.length) || (formatString.includes(UCNLNMEAParser.etcFormat))) {
            const results = [];
            let previousFormatter = "c--c";

            for (let i = 0; i < parameters.length; i++) {
                const format = formatTokens.length <= i ? previousFormatter : formatTokens[i];
                results.push(UCNLNMEAParser.ParseToken(parameters[i], format));
                previousFormatter = format;
            }

            return results;
        } else {
            throw new Error("Specified parameters list and formatting string incompatible");
        }
    }

    // Heuristic parsers
    static ParseArray(token, format) {
        const splits = token.split(UCNLNMEAParser.formatEnumDelimiters[0]);
        return splits.map(x => UCNLNMEAParser.ParseToken(x, format));
    }

    static ParseCommonTime(token) {
        const temp = parseFloat(token);
        const sss = Math.round((temp - Math.floor(temp)) * 1000);
        const hh = Math.floor(temp / 10000);
        const mm = Math.floor((temp - hh * 10000) / 100);
        const ss = Math.floor(temp - hh * 10000 - mm * 100);

        const now = new Date();
        return new Date(now.getFullYear(), now.getMonth(), now.getDate(), hh, mm, ss, sss);
    }

    static ParseCommonDate(token) {
        if (token.length === 6) {
            const date = parseInt(token.substring(0, 2));
            const month = parseInt(token.substring(2, 4)) - 1;
            const year = parseInt(token.substring(4, 6)) + 2000;

            return new Date(year, month, date);
        } else {
            throw new Error(`Date format incorrect in "${token}" (must be ddmmyy)`);
        }
    }

    static ParseDateSlashes(token) {
        const splits = token.split('/');
        if (splits.length === 3) {
            const date = parseInt(splits[0]);
            const month = parseInt(splits[1]) - 1;
            const year = parseInt(splits[2]) + 2000;

            return new Date(year, month, date);
        } else {
            throw new Error(`Date format incorrect in "${token}" (must be dd/mm/yy)`);
        }
    }

    static ParseLatitude(token) {
        const temp = parseFloat(token);
        const degree = Math.floor(temp / 100);
        const minutes = Math.floor(temp - degree * 100);
        const seconds = (temp - Math.floor(temp)) * 60;

        return degree + minutes / 60 + seconds / 3600;
    }

    static ParseLongitude(token) {
        const temp = parseFloat(token);
        const degree = Math.floor(temp / 100);
        const minutes = Math.floor(temp - degree * 100);
        const seconds = (temp - Math.floor(temp)) * 60;

        return degree + minutes / 60 + seconds / 3600;
    }

    static ParseCommonDegrees(token) {
        const temp = parseFloat(token);
        const degree = Math.floor(temp / 100);
        const minutes = Math.floor(temp - degree * 100);
        const seconds = (temp - Math.floor(temp)) * 60;

        return degree + minutes / 60 + seconds / 3600;
    }

    static ParseByteArray(source) {
        if (source.startsWith("0x")) {
            if (source.length % 2 === 0) {
                const result = new Uint8Array((source.length - 2) / 2);

                for (let i = 1; i < source.length / 2; i++) {
                    result[i - 1] = parseInt(source.substring(i * 2, i * 2 + 2), 16);
                }

                return result;
            } else {
                throw new Error("Specified string must have even length");
            }
        } else {
            throw new Error(`Specified string "${source}" does not start with "0x"`);
        }
    }

    // Utils
    static GetSentenceDescription(sentenceID) {
        if (UCNLNMEAParser.SentencesDescriptions[sentenceID]) {
            return UCNLNMEAParser.SentencesDescriptions[sentenceID];
        } else {
            throw new Error(`Unknown sentence ID: "${sentenceID}"`);
        }
    }

    static GetTalkerDescription(talkerID) {
        if (UCNLNMEAParser.TalkerDescriptions[talkerID]) {
            return UCNLNMEAParser.TalkerDescriptions[talkerID];
        } else {
            throw new Error(`Unknown talker ID: "${talkerID}"`);
        }
    }

    static AddManufacturerToProprietarySentencesBase(manufacturer) {
        if (!UCNLNMEAParser.ProprietarySentencesFormats[manufacturer]) {
            UCNLNMEAParser.ProprietarySentencesFormats[manufacturer] = {};
        } else {
            throw new Error(`Base already contains manufacturer "${manufacturer}"`);
        }
    }

    static AddProprietarySentenceDescription(manufacturer, sentenceIDString, formatString) {
        if (UCNLNMEAParser.ProprietarySentencesFormats[manufacturer]) {
            if (!UCNLNMEAParser.ProprietarySentencesFormats[manufacturer][sentenceIDString]) {
                UCNLNMEAParser.ProprietarySentencesFormats[manufacturer][sentenceIDString] = formatString;
            } else {
                throw new Error(`Specified sentence ID "${sentenceIDString}" already exists in "${manufacturer}" sentences list`);
            }
        } else {
            throw new Error(`Specified manufacturer "${manufacturer}" not exists in base, add it first`);
        }
    }

    static GetDatumDescription(datumKey) {
        return UCNLNMEAParser.Datums[datumKey] || '';
    }

    static GetCheckSum(source) {
        let result = 0;
        for (let i = 0; i < source.length; i++) {
            result ^= source.charCodeAt(i);
        }
        return result;
    }
}