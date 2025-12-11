using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace UCNLNMEA
{    
    /// <summary>
    /// Talkers identifiers
    /// </summary>
    public enum TalkerIdentifiers
    {
        AI, // 07-NOV-2025 added for !AIVDM/AIVDO AIS sentences parsing
        AG,
        AP,
        CD,
        CR,
        CS,
        CT,
        CV,
        CX,
        DE,
        DF,       
        EC,
        EP,
        ER,
        GA, // 03-JUN-2020
        GB, // 02-JUN-2020
        GL,
        GP,
        GN,
        HC,
        HE,
        HN,
        II,
        IN,
        LA,
        LC,
        OM,
        P,
        RA,
        SD,
        SN,
        TR,
        SS,
        TI,
        VD,
        DM,
        VW,
        WI,
        YX,
        ZA,
        ZC,
        ZQ,
        ZV,
        unknown
    }

    /// <summary>
    /// Sentences identifiers
    /// </summary>
    public enum SentenceIdentifiers
    {
        AAM,
        ALM,
        APA,
        APB,
        ASD,
        BEC,
        BOD,
        BWC,
        BWR,
        BWW,
        DBK,
        DBS,
        DBT,
        DCN,
        DPT,
        DSC,
        DSE,
        DSI,
        DSR,
        DTM,
        FSI,
        GBS,
        GGA,
        GLC,
        GLL,
        GNS,
        GRS,
        GST,
        GSA,
        GSV,
        GTD,
        GXA,
        HDG,
        HDM,
        HDT,
        HEV,
        HSC,
        LCD,
        MSK,
        MSS,
        MWD,
        MTW,
        MWV,
        OLN,
        OSD,
        ROO,
        RMA,
        RMB,
        RMC,
        ROT,
        RPM,
        RSA,
        RSD,
        RTE,
        SFI,
        STN,
        TLL,
        TRF,
        TTM,
        TXT,
        VBW,
        VDR,
        VDM,
        VDO,
        VHW,
        VLW,
        VPW,
        VTG,
        VWR,
        WCV,
        WDC,
        WDR,
        WNC,
        WPL,
        XDR,
        XTE,
        XTR,
        ZDA,
        ZDL,
        ZFO,
        ZTG,
        unknown
    }

    /// <summary>
    /// Manufacturers codes
    /// </summary>
    public enum ManufacturerCodes
    {
        AAR,
        ACE,
        ACR,
        ACS,
        ACT,
        AGI,
        AHA,
        AIP,
        ALD,
        AMR,
        AMT,
        ANS,
        ANX,
        ANZ,
        APC,
        APL,
        APN,
        APX,
        AQC,
        AQD,
        AQM,
        ASP,
        ATE,
        ATM,
        ATR,
        ATV,
        AVN,
        AWA,
        AZM,
        BAT,
        BBL,
        BBR,
        BDV,
        BEC,
        BGS,
        BGT,
        BHE,
        BHR,
        BLB,
        BME,
        BNI,
        BNS,
        BRM,
        BRY,
        BTH,
        BTK,
        BTS,
        BXA,
        CAT,
        CBN,
        CCA,
        CCC,
        CCL,
        CCM,
        CDC,
        CEC,
        CHI,
        CKM,
        CMA,
        CMC,
        CME,
        CMP,
        CMS,
        CMV,
        CNV,
        CNX,
        CPL,
        CPN,
        CPS,
        CPT,
        CRE,
        CRO,
        CRY,
        CSI,
        CSM,
        CST,
        CSV,
        CTA,
        CTB,
        CTC,
        CTE,
        CTL,
        CNI,
        CWD,
        CWV,
        CYZ,
        DBG,
        DCC,
        DEB,
        DFI,
        DGC,
        DME,
        DMI,
        DNS,
        DNT,
        DPS,
        DRL,
        DSC,
        DYN,
        DYT,
        EBC,
        ECT,
        EEV,
        EFC,
        ELD,
        EMC,
        EMS,
        ENA,
        ENC,
        EPM,
        EPT,
        ERC,
        ESA,
        FDN,
        FEC,
        FHE,
        FJN,
        FMM,
        FNT,
        FRC,
        FTG,
        FUJ,        
        FUG,
        FUR,
        GAM,
        GCA,
        GES,
        GFC,
        GIS,
        GPI,
        GRM,
        GSC,
        GTO,
        GVE,
        GVT,
        HAL,
        HAR,
        HDN,
        HIG,
        HIT,
        HPK,
        HRC,
        HRT,
        HTI,
        HUL,
        HWM,
        ICO,
        IFD,
        IFI,
        IME,
        IMI,
        IMM,
        IMP,
        IMT,
        INC,
        INM,
        INT,
        IRT,
        IST,
        ITM,
        ITR,
        JAN,
        JFR,
        JMT,
        JRC,
        JRI,
        JTC,
        JTR,
        KBE,
        KBM,
        KLA,
        KMR,
        KNG,
        KOD,
        KRP,
        KVH,
        KYI,
        LAT,
        LEC,
        LMM,
        LNA,
        LRD,
        LSE,
        LSP,
        LTF,
        LWR,
        MCL,
        MCP,
        MDL,
        MEC,
        MEG,
        MFR,
        MFW,
        MGN,
        MGS,
        MIE,
        MIM,
        MLE,
        MLN,
        MLP,
        MLT,
        MMB,
        MME,
        MMP,
        MMS,
        MNI,
        MNT,
        MNX,
        MOT,
        MPN,
        MQS,
        MRC,
        MRE,
        MRP,
        MRR,
        MRS,
        MSB,
        MSE,
        MSM,
        MST,
        MTA,
        MTG,
        MTK,
        MTR,
        MTS,
        MUR,
        MVX,
        MXX,
        MES,        
        NEF,
        NMR,
        NGS,
        NOM,
        NOV,
        NSM,
        NTK,
        NVC,
        NVL,
        NVS,
        NVO,
        OAR,
        ODE,
        ODN,
        OIN,
        OKI,
        OLY,
        OMN,
        ORE,
        OTK,
        PCE,
        PCH,
        PDM,
        PLA,
        PLI,
        PMI,
        PMP,
        PRK,
        PSM,
        PTC,
        PTG,
        PTH,
        RAC,
        RAE,
        RAY,
        RCA,
        RCH,
        RCI,
        RDI,
        RDM,
        REC,
        RFP,
        RGC,
        RGY,
        RLF,
        RMR,
        RPH,
        RSL,
        RSM,
        RWE,
        RWI,
        RWL,
        RME,
        RTN,
        SAI,
        SBR,
        SCR,
        SEA,
        SEC,
        SEP,
        SFN,
        SGC,        
        SIG,
        SIM,
        SKA,
        SKP,
        SLI,
        SME,
        SMF,
        SML,
        SMI,
        SNV,
        SOM,
        SOV,
        SPL,
        SPT,
        SRD,
        SRF, // added 08 december 2013
        SRS,
        SRT,
        SSI,
        STC,
        STI,
        STM,
        SVY,
        SWI,
        TBB,
        TCN,
        TDL,
        THR,
        TLS,
        TMT,
        TNL,
        TNT,
        TRC,
        TSI,
        TTK,
        TTS,
        TWC,
        TXI,
        UCN,
        UME,
        UNA,
        UNI,
        UNP,
        UNF,
        UNV,
        UWV,
        VAN,
        VAR,
        VCM,
        VEX,
        VIS,
        VLB,
        VMR,
        VSN,
        WAL,
        WBG,
        WEC,
        WHA,
        WMM,
        WMR,
        WNG,
        WSE,
        WTC,
        WST,
        YAS,
        ZMA,
        any,
        unknown
    }

    /// <summary>
    /// Earth hemisperes cardinals
    /// </summary>
    [Flags]
    public enum Cardinals
    {
        North,
        South,
        East,
        West,
        undefined
    }

    /// <summary>
    /// Structure represents geographical dimension
    /// </summary>
    public struct GeographicDimension
    {
        public Cardinals Cardinal;
        public double Angle;

        public override string ToString()
        {
            int degree = (int)Math.Floor(Angle);
            int minutes = (int)Math.Floor((Angle - degree) * 60.0);
            double seconds = (Angle - degree) * 3600 - minutes * 60.0;

            return string.Format(CultureInfo.InvariantCulture, "{0}°{1}\'{2:F04}\" {3}", degree, minutes, seconds, Cardinal);
        }

        public GeographicDimension(double angle, Cardinals cardinal)
        {
            Angle = angle;
            Cardinal = cardinal;
        }

        public static double AsSignedAngle(GeographicDimension dimension)
        {
            double result = dimension.Angle;

            if ((dimension.Cardinal == Cardinals.North) || (dimension.Cardinal == Cardinals.West))
                result = -dimension.Angle;

            return result;
        }
    }

    /// <summary>
    /// Struct represents geographical position
    /// </summary>
    public struct GeographicPosition
    {
        public GeographicDimension Latitude;
        public GeographicDimension Longitude;

        public override string ToString()
        {
            return string.Format("{0}, {1}", Latitude.ToString(), Longitude.ToString());
        }
    }

    /// <summary>
    /// NMEA0183 2.0 Sentences parser/builder
    /// (C) Aleksander Dikarev, 2011-2023
    /// </summary>
    public static class NMEAParser
    {
        #region Properties

        #region Commons

        #region expression delimiters

        public static readonly string StandartID = "NMEA 0183 2.0";
        public static readonly int MaxFullSentenceLength = 4255;//82;
        public static readonly int MaxSentenceLength = 4252;//79;
        public static readonly char SentenceStartDelimiter = '$';
        public static readonly string SentenceStartAISDelemiter = "!A";
        public static readonly char AISStart1 = '!';
        public static readonly char AISStart2 = 'A';
        public static readonly string SentenceEndDelimiter = "\r\n";
        public static readonly char FieldDelimiter = ',';
        public static readonly char CheckSumFieldDelimiter = '*';

        private static char[] arrayBrackets = new char[] { '[', ']' };
        public static string arrayOpenBracket = "[";
        public static string arrayCloseBracket = "]";
        public static char[] formatTokenDelimiters = new char[] { ',' };
        public static char[] formatEnumDelimiters = new char[] { '|' };
        private static string formatEnumPairDelimiter = "=";
        public static char[] formatEnumPairDelimiters = new char[] { '=' };
        private static string etcFormat = "...";

        #endregion

        #region Talker descriptions

        private static Dictionary<TalkerIdentifiers, string> TalkerDescriptions = 
            new Dictionary<TalkerIdentifiers, string>() { 
                { TalkerIdentifiers.AI, "AIS"},                                                          
                { TalkerIdentifiers.AG, "Autopilot - General" },
                { TalkerIdentifiers.AP, "Autopilot - Magnetic" },
                { TalkerIdentifiers.CD, "Communications - Digital Selective Calling (DSC)" },
                { TalkerIdentifiers.CR, "Communications - Receiver / Beacon Receiver" },
                { TalkerIdentifiers.CS, "Communications - Sattelite" },
                { TalkerIdentifiers.CT, "Communications - Radio-Telephone (MF/HF)" },
                { TalkerIdentifiers.CV, "Communications - Radio-Telephone (VHF)" },
                { TalkerIdentifiers.CX, "Communications - Scanning Receiver" },
                { TalkerIdentifiers.DF, "Direction Finder" },
                { TalkerIdentifiers.EC, "Electronic Chart Display & Information System (ECDIS)" },
                { TalkerIdentifiers.EP, "Emergency Position Indicating Beacon (EPIRB)" },
                { TalkerIdentifiers.ER, "Engine Room Monitoring Systems" },
                { TalkerIdentifiers.GP, "Global Positioning System (GPS)" },
                { TalkerIdentifiers.HC, "Heading - Magnetic Compass" },
                { TalkerIdentifiers.HE, "Heading - North Seeking Gyro" },
                { TalkerIdentifiers.HN, "Heading - Non North Seeking Gyro" },
                { TalkerIdentifiers.II, "Integrated instrumentation" },
                { TalkerIdentifiers.IN, "Integrated Navigation" },
                { TalkerIdentifiers.LC, "Loran C" },
                { TalkerIdentifiers.P, "Proprietary Code" },
                { TalkerIdentifiers.RA, "RADAR and/or ARPA" },
                { TalkerIdentifiers.SD, "Sounder, Depth" },
                { TalkerIdentifiers.SN, "Electronic Positioning System, other/general" },
                { TalkerIdentifiers.SS, "Souder, Scanning" },
                { TalkerIdentifiers.TI, "Turn Rate Indicator" },
                { TalkerIdentifiers.VD, "Velocity Sensor, Doppler, other/general" },
                { TalkerIdentifiers.DM, "Velocity Sensor, Speed Log, Water, Magnetic" },
                { TalkerIdentifiers.VW, "Velocity Sensor, Speed Log, Water, Mechanical" },
                { TalkerIdentifiers.WI, "Weather Instruments" },
                { TalkerIdentifiers.YX, "Transduser" },
                { TalkerIdentifiers.ZA, "Timekeeper - Atomic Clock" },
                { TalkerIdentifiers.ZC, "Timekeeper - Chronometer" },
                { TalkerIdentifiers.ZQ, "Timekeeper - Quartz" },
                { TalkerIdentifiers.ZV, "Radio Update, WWV or WWVH" }                                                              
            };

        #endregion

        #region Sentences descriptions

        private static Dictionary<SentenceIdentifiers, string> SentencesDescriptions =
            new Dictionary<SentenceIdentifiers, string>() {
                { SentenceIdentifiers.AAM, "Waypoint Arrival Alarm" },
                { SentenceIdentifiers.ALM, "GPS Almanac Data" },
                { SentenceIdentifiers.APB, "Autopilot Sentence \"B\"" },
                { SentenceIdentifiers.APA, "Autopilot Sentence \"A\"" },
                { SentenceIdentifiers.ASD, "Autopilot System Data" },
                { SentenceIdentifiers.BEC, "Bearing & Distance to Waypoint, Dead reckoning" },
                { SentenceIdentifiers.BOD, "Bearing, Origin to Destination" },
                { SentenceIdentifiers.BWC, "Bearing & Distance to Waypoint, Great Circle" },
                { SentenceIdentifiers.BWR, "Bearing & Distance to Waypoint, Rhumb Line" },
                { SentenceIdentifiers.BWW, "Bearing, Waypoint to Waypoint" },
                { SentenceIdentifiers.DBK, "Depth Below Keel" },
                { SentenceIdentifiers.DBS, "Depth Below Surface" },
                { SentenceIdentifiers.DBT, "Depth Below Transduser" },
                { SentenceIdentifiers.DCN, "[Obsolete] Decca Position" },
                { SentenceIdentifiers.DPT, "Depth" },
                { SentenceIdentifiers.DSC, "Digital Selective Calling Information" },
                { SentenceIdentifiers.DSE, "Extended DSC" },
                { SentenceIdentifiers.DSI, "DSC Transponder Initiate" },
                { SentenceIdentifiers.DSR, "DSC Transponder Response" },
                { SentenceIdentifiers.DTM, "Datum Reference" },
                { SentenceIdentifiers.FSI, "Frequency Set Information" },
                { SentenceIdentifiers.GBS, "GBS Satellite Fault Detection" },
                { SentenceIdentifiers.GGA, "Global Positioning System Fix Data" },
                { SentenceIdentifiers.GLC, "Geographic Position, Loran-C" },
                { SentenceIdentifiers.GLL, "Geographic Position, Latitude/Longitude" },
                { SentenceIdentifiers.GRS, "GPS Range Residuals" },
                { SentenceIdentifiers.GSA, "GPS DOP and Active Satellites" },
                { SentenceIdentifiers.GST, "GPS Pseudorange Noise Statistics" },
                { SentenceIdentifiers.GSV, "GPS Sattelites in View" },
                { SentenceIdentifiers.GTD, "Geograpic Location in Time Differences" },
                { SentenceIdentifiers.GXA, "Transit Position" },
                { SentenceIdentifiers.HDG, "Heading, Deviation & Variation" },
                { SentenceIdentifiers.HDM, "Heading, Magnetic" },
                { SentenceIdentifiers.HDT, "Heading, True" },
                { SentenceIdentifiers.HSC, "Heading Steering Command" },
                { SentenceIdentifiers.LCD, "Loran-C Signal Data" },
                { SentenceIdentifiers.MSK, "MSK Receiver Interface (for DGPS Beacon Receivers)" },
                { SentenceIdentifiers.MSS, "MSK Receiver Signal Status" },
                { SentenceIdentifiers.MTW, "Water Temperature" },
                { SentenceIdentifiers.MWD, "Wind Direction & Speed" },
                { SentenceIdentifiers.MWV, "Wind Speed & Angle" },
                { SentenceIdentifiers.OLN, "[Obsolete] Omega Line Numbers" },
                { SentenceIdentifiers.OSD, "Own Ship Data" },
                { SentenceIdentifiers.RMA, "Recommend Minimum Specific Loran-C Data" },
                { SentenceIdentifiers.RMB, "Recommend Minimum Navigation Information" },
                { SentenceIdentifiers.RMC, "Recommend Minimum Specific GPS/TRANSIT Data" },
                { SentenceIdentifiers.ROO, "Waypoints in Active Route" },
                { SentenceIdentifiers.ROT, "Rate of Turn" },
                { SentenceIdentifiers.RPM, "Revolutions" },
                { SentenceIdentifiers.RSA, "Rudder Sensor Angle" },
                { SentenceIdentifiers.RSD, "RADAR System Data" },
                { SentenceIdentifiers.RTE, "Routes" },
                { SentenceIdentifiers.SFI, "Scanning Frequency Information" },
                { SentenceIdentifiers.STN, "Multiple Data ID" },
                { SentenceIdentifiers.TLL, "Target Latitude & Longitude" },
                { SentenceIdentifiers.TRF, "[Obsolete] TRANSIT Fix Data" },
                { SentenceIdentifiers.TTM, "Tracked Target Message" },
                { SentenceIdentifiers.VBW, "Dual Ground/Water Speed" },
                { SentenceIdentifiers.VDR, "Set and Drift" },
                { SentenceIdentifiers.VDM, "AIS VDM"},
                { SentenceIdentifiers.VDO, "AIS VDO"},
                { SentenceIdentifiers.VHW, "Water Speed and Heading" },
                { SentenceIdentifiers.VLW, "Distance Traveled through Water" },
                { SentenceIdentifiers.VPW, "Speed, Measured Parallel to Wind" },
                { SentenceIdentifiers.VTG, "Track Made Good and Ground Speed" },
                { SentenceIdentifiers.VWR, "Relative Wind Speed & Angle" },
                { SentenceIdentifiers.WCV, "Waypoint Closure Velocity" },
                { SentenceIdentifiers.WDC, "Distance to Waypoint, Great Circle" },
                { SentenceIdentifiers.WDR, "Distance to Waypoint, Rhumb Line" },
                { SentenceIdentifiers.WNC, "Distance, Waypoint to Waypoint" },
                { SentenceIdentifiers.WPL, "Waypoint Location" },
                { SentenceIdentifiers.XDR, "Transducer Measurement" },
                { SentenceIdentifiers.XTE, "Cross-Track Error, Measured" },
                { SentenceIdentifiers.XTR, "Cross-Track Error, Dead Reckoning" },
                { SentenceIdentifiers.ZDA, "Time & Date" },
                { SentenceIdentifiers.ZDL, "Time & Distance to Variable Point" },
                { SentenceIdentifiers.ZFO, "UTC & Time from Origin Waypoint" },
                { SentenceIdentifiers.ZTG, "UTC & Time to Destination Waypoint" }
            };

        #endregion        

        #region Datum dictionary

        private static Dictionary<int, string> Datums = new Dictionary<int, string>()
        {
            { 0, "WGS1984 (International)" },
            { 1, "Tokyo (Japan)" },
            { 2, "Tokyo (Mean for Japan, South Korea, Okinawa)" },
            { 3, "User setting" },
            { 4, "Adindan (Burkina Faso)" },
            { 5, "Adindan (Cameroon)" },
            { 6, "Adindan (Ethiopia)" },
            { 7, "Adindan (Mali)" },
            { 8, "Adindan (Mean for Ethiopia, Sudan)" },
            { 9, "Adindan (Senegal)" },
            { 10, "Adindan (Sudan)" },
            { 11, "Afgooye (Somalia)" },
            { 12, "Ain El Abd1970 (Bahrain)" },
            { 13, "Ain El Abd1970 (Saudi Arabia)" },
            { 14, "American Samoa1962 (American Samoa islands)" },
            { 15, "Anna 1 Astro1965 (Cocos Island)" },
            { 16, "Antigua Island Astro1943 (Antigua (Leeward Islands))" },
            { 17, "Arc1950 (Botswana)" },
            { 18, "Arc1950 (Burundi)" },
            { 19, "Arc1950 (Lesotho)" },
            { 20, "Arc1950 (Malawi)" },
            { 21, "Arc1950 (Mean for Botswana, Lesotho, Malawi, Swaziland, Zaire, Zambia, Zimbabwe)" },
            { 22, "Arc1950 (Swaziland)" },
            { 23, "Arc1950 (Zaire)" },
            { 24, "Arc1950 (Zambia)" },
            { 25, "Arc1950 (Zimbabwe)" },
            { 26, "Arc1960 (Mean for Kenya Tanzania)" },
            { 27, "Arc1960 (Kenya)" },
            { 28, "Arc1960 (Tanzania)" },
            { 29, "Ascension Island 1958 (Ascension Island)" },
            { 30, "Astro Beacon E 1945 (Iwo Jima)" },
            { 31, "Astro Dos 71/4 (St Helena Island)" },
            { 32, "Astro Tern Island (FRIG) 1961 (Tern Island)" },
            { 33, "Astronomical Station 1952 (Marcus Island)" },
            { 34, "Australian Geodetic 1966 (Mercus Island)" },
            { 35, "Australian Geodetic 1984 (Australia, Tasmania)" },
            { 36, "Ayabelle Lighthouse (Djibouti)" },
            { 37, "Bellevue (IGN) (Efate and Erromango Islands)" },
            { 38, "Bermuda 1957 (Bermuda)" },
            { 39, "Bissau (Guuinea-Bissau)" },
            { 40, "Bogota Observatory (Colombia)" },
            { 41, "Bukit Rimpah (Indonesia (Bangka and Belitung Ids))" },
            { 42, "Camp Area Astro (Antarctica (McMurdi Camp Area))" },
            { 43, "Campo Inchauspe (Argentina)" },
            { 44, "Canton Astro1966 (Phoenix Island)" },
            { 45, "Cape (South Africa)" },
            { 46, "Cape Canaveral (Bahamas, Florida)" },
            { 47, "Carthage (Tunisia)" },
            { 48, "Chatham Island Astro1971 (New Zealand(Chatham Island))" },
            { 49, "Chua Astro (Paraguay)" },
            { 50, "Corrego Alegre (Brazil)" },
            { 51, "Dabola (Guinea)" },
            { 52, "Deception Island (Deception Island, Antarctica)" },
            { 53, "Djakarta (Batavia) (Indonesia (Sumatra))" },
            { 54, "Dos 1968 (New Georgia Islands (Gizo Island)" },
            { 55, "Easter Island 1967 (Easter Island)" },
            { 56, "Estonia Coordinate System 1937 (Estonia)" },
            { 57, "European 1950 (Cyprus)" },
            { 58, "European 1950 (Egypt)" },
            { 59, "European 1950 (England, Channel Isnalds, Scotland, Shetland Islands)" },
            { 60, "European 1950 (England, Ireland, Scotland, Shetland Islands)" },
            { 61, "European 1950 (Finland, Norway" },
            { 62, "European 1950 (Greece)" },
            { 63, "European 1950 (Iran)" },
            { 64, "European 1950 (Italy (Sardinia))" },
            { 65, "European 1950 (Italy (Sicily))" },
            { 66, "European 1950 (Malta)" },
            { 67, "European 1950 (Mean for Austria, Belgium, Danmark, Finland, France, W. Germany, Gibraltar, Greece, Italy, Luxemburg, Netherlands, Norway, Portugal, Spain, Sweden, Switzerland)" },
            { 68, "European 1950 (Mean for Austria, Denmark, France, W. Germany, Netherland, Switzerland)" },
            { 69, "European 1950 (Mean for Iraq, Israel, Jordan, Lebanon, Kuwait, Saudi Arabia, Syria)" },
            { 70, "European 1950 (Portugal, Spain)" },
            { 71, "European 1950 (Tunisia)" },
            { 72, "European 1950 (Mean for Austria, Finland, Netherlands, Norway, Spain, Sweden, Switzerland)" },
            { 73, "Fort Thomas 1955 (Nevis St. Kitts (Leeward Islands))" },
            { 74, "Gan 1970 (Republic of Maldives)" },
            { 75, "Geodetic Datum 1970 (New Zeland)" },
            { 76, "Graciosa Base SW1948 (Azores (Fial, Graciosa, Pico, Sao, Jorge, Terceria))" },
            { 77, "Guam1963 (Guam)" },
            { 78, "Gunung Segara (Indonesia (Kalimantan))" },
            { 79, "Gux I Astro (Guadalcanal Island)" },
            { 80, "Herat North (Afganistan)" },
            { 81, "Hermannskogel Datum (Croatia-Serbia, Bosnia-Herzegovina)" },
            { 82, "Hjorsey 1955 (Iceland)" },
            { 83, "Hongkong 1963 (Hongkong)" },
            { 84, "Hu Tzu Shan (Taiwan)" },
            { 85, "Indian (Bangladesh)" },
            { 86, "Indian (India, Nepal)" },
            { 87, "Indian (Pakistan)" },
            { 88, "Indian 1954 (Thailand)" },
            { 89, "Indian 1960 (Vietnam (Con Son Island)" },
            { 90, "Indian 1960 (Vietnam (Near 16 deg N))" },
            { 91, "Indian 1975 (Thailand)" },
            { 92, "Indonesian 1974 (Indonesian)" },
            { 93, "Ireland 1965 (Ireland)" },
            { 94, "ISTS 061 Astro 1968 (South Georgia Islands)" },
            { 95, "ISTS 073 Astro 1969 (Diego Garcia)" },
            { 96, "Johnston Island 1961 (Johnston Island)" },
            { 97, "Kandawala (Sri Lanka)" },
            { 98, "Kerguelen Island 1949 (Kerguelen Island)" },
            { 99, "Kertau 1948 (West Malaysia and Singapore)" },
            { 100, "Kusaie Astro 1951 (Caroline Island)" },
            { 101, "Korean Geodetic System (South Korea)" },
            { 102, "LC5 Astro 1961 (Cayman Brac Island)" },
            { 103, "Leigon (Ghana)" },
            { 104, "Liberia 1964 (Liberia)" },
            { 105, "Luzon (Philippines (Excluding Mindanao))" },
            { 106, "Luzon (Philippines (Mindanao))" },
            { 107, "M\'Poraloko (Gabon)" },
            { 108, "Mahe 1971 (Mahe Island)" },
            { 109, "Massawa (Ethopia (Eritrea))" },
            { 110, "Merchich (Morocco)" },
            { 111, "Midway Astro 1961 (Midway Islands)" },
            { 112, "Minna (Cameroon)" },
            { 113, "Minna (Nigeria)" },
            { 114, "Montserrat Island Astro 1958 (Monserat (Leeward Island))" },
            { 115, "Nahrwan (Oman (Masirah Island))" },
            { 116, "Nahrwan (Saudi Arabia)" },
            { 117, "Nahrwan (United Arab Emirates)" },
            { 118, "Naparima BWI (Trinidad and Tobago)" },
            { 119, "North American 1927 (Alaska (Excluding Aleutian Islands))" },
            { 120, "North American 1927 (Alaska (Aleutian Islands East of 180 deg. W)" },
            { 121, "North American 1927 (Alaska (Aleutian Islands West of 180 deg. W)" },
            { 122, "North American 1927 (Bahamas (Except San Salvador Islands))" },
            { 123, "North American 1927 (Bahamas (San Salvador Islands))" },
            { 124, "North American 1927 (Canada (Alberta, British Columbia))" },
            { 125, "North American 1927 (Canada (Manitoba, Ontario))" },
            { 126, "North American 1927 (Canada (New Brunswick, Newfoundland, Nova Scotia, Quebec))" },
            { 127, "North American 1927 (Canada (Northwest Territories, Saskatchewan))" },
            { 128, "North American 1927 (Canada (Youkon))" },
            { 129, "North American 1927 (Canal Zone)" },
            { 130, "North American 1927 (Cuba)" },
            { 131, "North American 1927 (Greenland (Hayes Peninsula))" },
            { 132, "North American 1927 (Mean for Antigua, Barbados, Barbuda, Caicos Islands, Cuba, Dominican, Grand Cayman, Jamaica, Turks Islands)" },
            { 133, "North American 1927 (Mean for Belize, Costa Rica, El Salvador, Guatemala, Honduras, Nicaragua)" },
            { 134, "North American 1927 (Mean for Canada)" },
            { 135, "North American 1927 (Mean for Conus)" },
            { 136, "North American 1927 (Mean for Conus (East of Mississippi, River Including Louisiana, Missouri, Minnesota)" },
            { 137, "North American 1927 (Mean for Conus (West of Mississippi, River Excluding Louisiana, Missouri, Minnesota)" },
            { 138, "North American 1927 (Mexico)" },
            { 139, "North American 1983 (Alaska (Excluding Aleutian Islands))" },
            { 140, "North American 1983 (Aleutian Islands)" },
            { 141, "North American 1983 (Canada)" },
            { 142, "North American 1983 (Conus)" },
            { 143, "North American 1983 (Hahawii)" },
            { 144, "North American 1983 (Mexico, Central America)" },
            { 145, "North Sahara 1959 (Algeria)" },
            { 146, "Observatorio Meteorologico 1939 (Azores (Corvo and Flores Islands))" },
            { 147, "Old Egyptian 1907 (Egypt)" },
            { 148, "Old Hawaiian (Hawaii)" },
            { 149, "Old Hawaiian (Kauai)" },
            { 150, "Old Hawaiian (Maui)" },
            { 151, "Old Hawaiian (Mean for Hawaii, Kauai, Maui, Oahu)" },
            { 152, "Old Hawaiian (Oahu)" },
            { 153, "Oman (Oman)" },
            { 154, "Ordnance Survey Great Britain 1936 (England)" },
            { 155, "Ordnance Survey Great Britain 1936 (England, Isle of Man, Wales)" },
            { 156, "Ordnance Survey Great Britain 1936 (Mean for England, Isle of Man, Scotland, Shetland Islands, Wales)" },
            { 157, "Ordnance Survey Great Britain 1936 (Scotland, Shetland Islands)" },
            { 158, "Ordnance Survey Great Britain 1936 (Wales)" },
            { 159, "Pico de las Nieves (Canary Islands)" },
            { 160, "Pitcairn Astro 1967 (Pitcairn Island)" },
            { 161, "Point 58 (Mean for Burkina Faso and Niger)" },
            { 162, "Pointe Noire 1948 (Congo)" },
            { 163, "Porto Santo 1936 (Porto Santo, Maderia Islands)" },
            { 164, "Provisional South American 1956 (Bolivia)" },
            { 165, "Provisional South American 1956 (Chilie (Norther Near 19 deg S))" },
            { 166, "Provisional South American 1956 (Chilie (Southern Near 43 deg S))" },
            { 167, "Provisional South American 1956 (Colombia)" },
            { 168, "Provisional South American 1956 (Ecuador)" },
            { 169, "Provisional South American 1956 (Guyana)" },
            { 170, "Provisional South American 1956 (Mean for Bolivia, Chilie, Colombia, Ecuador, Guyana, Peru, Venezuela)" },
            { 171, "Provisional South American 1956 (Peru)" },
            { 172, "Provisional South American 1956 (Venezuela)" },
            { 173, "Provisional South Chilean 1963 (Chilie (Near 53 deg S) (Hito XVIII))" },
            { 174, "Puerto Rico (Puerto Rico, Virgin Islands)" },
            { 175, "Pulkovo 1942 (Russia)" },
            { 176, "Quatar National (Quatar)" },
            { 177, "Qornoq (Greenland (South))" },
            { 178, "Reunion (Mascarene Island)" },
            { 179, "Rome 1940 (Italy (Sardinia))" },
            { 180, "S-42 (Pulkovo 1942) (Hungary)" },
            { 181, "S-42 (Pulkovo 1942) (Poland)" },
            { 182, "S-42 (Pulkovo 1942) (Czechoslavakia)" },
            { 183, "S-42 (Pulkovo 1942) (Latvia)" },
            { 184, "S-42 (Pulkovo 1942) (Kazakhstan)" },
            { 185, "S-42 (Pulkovo 1942) (Albania)" },
            { 186, "S-42 (Pulkovo 1942) (Romania)" },
            { 187, "S-JTSK (Czechoslavakia (Prior 1 Jan 1993))" },
            { 188, "Santo (Dos) 1965 (Espirito Santo Island)" },
            { 189, "Sao Braz (Azores (San Miguel, Santa Maria Islands))" },
            { 190, "Sapper Hill" },
            { 191, "Schwarzeck (Namibia)" },
            { 192, "Selvagem Grande 1938 (Salvage Islands)" },
            { 193, "Sierra Leone 1960 (Sierra Leone)" },
            { 194, "South American 1969 (Argentina)" },
            { 195, "South American 1969 (Bolivia)" },
            { 196, "South American 1969 (Brazil)" },
            { 197, "South American 1969 (Chilie)" },
            { 198, "South American 1969 (Colombia)" },
            { 199, "South American 1969 (Ecuador)" },
            { 200, "South American 1969 (Ecuador (Baltra, Galapagos))" },
            { 201, "South American 1969 (Guyana)" },
            { 202, "South American 1969 (Mean for Argentina, Bolivia, Brazil, Chilie, Colombia, Ecuador, Guayana, Paraguay, Peru, Trinidad and Tobago, Venezuela)" },
            { 203, "South American 1969 (Paraguay)" },
            { 204, "South American 1969 (Peru)" },
            { 205, "South American 1969 (Trinidad and Tobago)" },
            { 206, "South American 1969 (Venezuela)" },
            { 207, "South Asia (Singapore)" },
            { 208, "Tananarive Observatory 1925 (Madagascar)" },
            { 209, "Timbalai 1948 (Brunei, E. Malaysia (Sabah Sarawak))" },
            { 210, "Tokyo (Japan)" },
            { 211, "Tokyo (Mean for Japan, South Korea, Okinawa)" },
            { 212, "Tokyo (Okinawa)" },
            { 213, "Tokyo (South Korea)" },
            { 214, "Tristan Astro 1968 (Tristam Da Cunha)" },
            { 215, "Viti Levu 1916 (Fiji (Viti Levu Island))" },
            { 216, "Voirol 1960 (Algeria)" },
            { 217, "Wake Island Astro 1952 (Wake Atoll)" },
            { 218, "Wake-Eniwetok 1960 (Marshall Islands)" },
            { 219, "WGS 1972 (Global Definition)" },
            { 220, "WGS 1984 (Global Definition)" },
            { 221, "Yacare (Uruguay)" },
            { 222, "Zanderij (Suriname)" }
        };

        #endregion

        #region Sentences formats

        /// <summary>
        /// Format string for sentences must be as "param_1_format, param_2_format, ..."
        /// valid formats are:
        /// x - integer
        /// x.x - double
        /// c--c - ASCII char string
        /// hh - hexadecimal byte
        /// hhhh - hexadecimal short int 
        /// hhhhhhhh - hexadecimal int
        /// hhmmss.ss - time: hours, minutes, seconds, fractional part of seconds
        /// llll.ll - longitude
        /// yyyyy.yy - latitude
        /// </summary>

        #region Standard sentences

        private static Dictionary<SentenceIdentifiers, string> SentencesFormats =
            new Dictionary<SentenceIdentifiers, string>() {
                { SentenceIdentifiers.AAM, "A=Arrival circled entered|V=V,A=Perpendicular passed at way point|V=V,x.x,N=nm|K=km,c--c" },
                { SentenceIdentifiers.ALM, "x.x,x.x,xx,x.x,hh,hhhh,hh,hhhh,hhhhhh,hhhhhh,hhhhhh,hhhhhh,hhh,hhh" },
                { SentenceIdentifiers.APB, "V=Loran-C Blink or SNR warning|A=general warning flag,V=Loran-C Cycle Lock warning flag|A=OK or not used,x.x,R=Right|L=Left,N=nm|K=km,A=Arrival circled entered|V=Invalid,A=Perpendicular passed at way point|V=Invalid,x.x,M=Magnetic|T=True,c--c,x.x,M=Magnetic|T=True,x.x,M=Magnetic|T=True" },
                { SentenceIdentifiers.APA, "V=Loran-C Blink or SNR warning|A=general warning flag,V=Loran-C Cycle Lock warning flag|A=OK or not used,x.xx,R=Right|L=Left,N=nm|K=km,A=Arrival circled entered|V=Invalid,A=Perpendicular passed at way point|V=Invalid,xxx,M=Magnetic|T=True,c---c" },
                { SentenceIdentifiers.ASD, "" },
                { SentenceIdentifiers.BEC, "hhmmss.ss,llll.ll,N=N|S=S,yyyyy.y,N=N|S=S,x.x,E=E|W=W,x.x,T=True|M=Magnetic,x.x,N=nm|K=km,c--c" },
                { SentenceIdentifiers.BOD, "x.x,T=True|M=Magnetic,x.x,T=True|M=Magnetic,c--c,c--c" },
                { SentenceIdentifiers.BWC, "hhmmss.ss,llll.ll,N=N|S=S,yyyyy.yy,E=E|W=W,x.x,T=True|M=Magnetic,x.x,T=True|M=Magnetic,x.x,N=nm|K=km,c--c" },
                { SentenceIdentifiers.BWR, "hhmmss.ss,llll.ll,N=N|S=S,yyyyy.yy,E=E|W=W,x.x,T=True|M=Magnetic,x.x,T=True|M=Magnetic,x.x,N=nm|K=km,c--c" },
                { SentenceIdentifiers.BWW, "x.x,T=True|M=Magnetic,x.x,T=True|M=Magnetic,c--c,c--c" },
                { SentenceIdentifiers.DBK, "x.x,f=ft|M=m,x.x,f=ft|M=m,x.x,F" },
                { SentenceIdentifiers.DBS, "x.x,f=ft|M=m,x.x,f=ft|M=m,x.x,F" },
                { SentenceIdentifiers.DBT, "x.x,f=ft|M=m,x.x,f=ft|M=m,x.x,F" },
                { SentenceIdentifiers.DCN, "xx,cc,x.x,A,cc,x.x,A,cc,x.x,A,A,A,A,x.x,N=nm|K=km,1=Normal pattern|2=Lane identification pattern|3=Lane identification transmissions" },
                { SentenceIdentifiers.DPT, "x.x,x.x" },
                { SentenceIdentifiers.DSC, "" },
                { SentenceIdentifiers.DSE, "" },
                { SentenceIdentifiers.DSI, "" },
                { SentenceIdentifiers.DSR, "" },
                { SentenceIdentifiers.DTM, "xxx,x,xx.xxxx,x,xx.xxxx,x,c--c,xxx" },
                { SentenceIdentifiers.FSI, "xxxxxx,xxxxxx,c,x" },
                { SentenceIdentifiers.GBS, "hhmmss.ss,x.x,x.x,x.x,x.x,x.x,x.x,x.x" },
                { SentenceIdentifiers.GGA, "hhmmss.ss,llll.ll,a,yyyyy.yy,a,0=Fix not availible|1=GPS fix|2=DGPS fix,xx,x.x,x.x,M,x.x,M,x.x,xxxx" },
                { SentenceIdentifiers.GLC, "xxxx,x.x,a,x.x,a,x.x,a,x.x,a,x.x,a,x.x,B=Blink|C=Cycle|S=SNR|A=Valid" },
                { SentenceIdentifiers.GLL, "llll.ll,N=N|S=S,yyyyy.yy,E=E|W=W,hhmmss.ss,A=Valid|V=Invalid,A=Valid|V=Invalid" },
                { SentenceIdentifiers.GNS, "hhmmss.ss,llll.ll,a,yyyyy.yy,a,с--с,xx,x.x,x.x,x.x,x.x,x,a" },
                { SentenceIdentifiers.GRS, "hhmmss,x,x.x,x.x,x.x,x.x,x.x,x.x,x.x,x.x,x.x,x.x,x.x,x.x" },

                /// Missed last paramter in the sentence description, 27 APR 2022
                // $GNGSA,A,                    3,01,03,04,22,31,09,06,  ,  ,  ,  ,  ,1.57,0.82,1.34,1*05
                //    GSA,"M=Manual|A=Automatic,x,xx,xx,xx,xx,xx,xx,xx,xx,xx,xx,xx,xx,x.x ,x.x ,x.x,x" },
                { SentenceIdentifiers.GSA, "M=Manual|A=Automatic,x,xx,xx,xx,xx,xx,xx,xx,xx,xx,xx,xx,xx,x.x,x.x,x.x,x" }, //
                { SentenceIdentifiers.GST, "hhmmss.ss,x.x,x.x,x.x,x.x,x.x,x.x,x.x" },
                { SentenceIdentifiers.GSV, "x,x,xx,xx,xx,xxx,xx,xx,xx,xxx,xx,xx,xx,xxx,xx,xx,xx,xxx,xx," },
                { SentenceIdentifiers.GTD, "x.x,x.x,x.x,x.x,x.x" },
                { SentenceIdentifiers.GXA, "hhmmss.ss,llll.ll,a,yyyyy.yy,a,c--c,x" },
                { SentenceIdentifiers.HDG, "x.x,x.x,a,x.x,a" },
                { SentenceIdentifiers.HDM, "x.x,M" },
                { SentenceIdentifiers.HDT, "x.x,T" },
                { SentenceIdentifiers.HEV, "x.x,A" },
                { SentenceIdentifiers.HSC, "x.x,T,x.x,M" },
                { SentenceIdentifiers.LCD, "xxxx,xxx,xxx,xxx,xxx,xxx,xxx,xxx,xxx,xxx,xxx,xxx,xxx" },
                { SentenceIdentifiers.MSK, "xxx.x,xx,xxx,xx,N" },
                { SentenceIdentifiers.MSS, "" },
                { SentenceIdentifiers.MTW, "x.x,C=C|K=K|F=F" },
                { SentenceIdentifiers.MWD, "" },
                { SentenceIdentifiers.MWV, "x.x,a,x.x,a,A" },
                { SentenceIdentifiers.OLN, "aa,xxx,xxx,aa,xxx,xxx,aa,xxx,xxx" },
                { SentenceIdentifiers.OSD, "x.x,A,x.x,a,x.x,a,x.x,x.x,a" },
                { SentenceIdentifiers.RMA, "A,llll.ll,N=N|S=S,yyyyy.yy,E=E|W=W,x.x,x.x,x.x,x.x,x.x,a" },
                { SentenceIdentifiers.RMB, "A,x.x,a,c--c,c--c,llll.ll,a,yyyyy.yy,a,x.x,x.x,x.x,A,A" },
                { SentenceIdentifiers.RMC, "hhmmss.ss,A=Valid|V=Invalid,llll.ll,N=N|S=S,yyyyy.yy,E=E|W=W,x.x,x.x,ddmmyy,x.x,a,a,..." },
                { SentenceIdentifiers.ROO, "c---c,...." }, // TODO: !!!
                { SentenceIdentifiers.ROT, "x.x,A" },
                { SentenceIdentifiers.RPM, "a,x,x.x,x.x,A" },
                { SentenceIdentifiers.RSA, "x.x,A,x.x,A" },
                { SentenceIdentifiers.RSD, "x.x,x.x,x.x,x.x,x.x,x.x,x.x,x.x,x.x,x.x,x.x,a,a" },
                { SentenceIdentifiers.RTE, "x.x,x.x,a,c--c,c--c,..." },
                { SentenceIdentifiers.SFI, "x.x,x.x,xxxxxx,c,xxxxxx,c" },
                { SentenceIdentifiers.STN, "xx" },
                { SentenceIdentifiers.TLL, "xx,llll.lll,a,yyyyy.yyy,a,c--c,hhmmss.ss,a,a" },
                { SentenceIdentifiers.TRF, "hhmmss.ss,xxxxxx,llll.ll,a,yyyyy.yy,a,x.x,x.x,x.x,x.x,xxx,A" },
                { SentenceIdentifiers.TTM, "xx,x.x,x.x,T=True|R=Relative,x.x,x.x,T=True|R=Relative,x.x,x.x,K=Km|N=Knots|S=Statue miles,c--c,L=Lost|Q=Query|T=Tracking,a,hhmmss.ss,A=Automatic|M=Manual" },
                { SentenceIdentifiers.TXT, "x,x,x,c--c" },
                { SentenceIdentifiers.VBW, "x.x,x.x,A,x.x,x.x,A" },
                { SentenceIdentifiers.VDM, "x,x,c--c,c--c,c--c,x" },
                { SentenceIdentifiers.VDO, "x,x,c--c,c--c,c--c,x" },
                { SentenceIdentifiers.VDR, "x.x,T,x.x,M,x.x,N" },
                { SentenceIdentifiers.VHW, "x.x,T,x.x,M,x.x,N,x.x,K" },
                { SentenceIdentifiers.VLW, "x.x,N,x.x,N" },
                { SentenceIdentifiers.VPW, "x.x,N,x.x,M" },
                { SentenceIdentifiers.VTG, "x.x,T,x.x,M,x.x,N=nk/h,x.x,K=Km/h,a" },
                { SentenceIdentifiers.VWR, "x.x,a,x.x,N,x.x,M,x.x,K" },
                { SentenceIdentifiers.WCV, "x.x,N,c--c" },
                { SentenceIdentifiers.WDC, "" },
                { SentenceIdentifiers.WDR, "" },
                { SentenceIdentifiers.WNC, "x.x,N,x.x,K,c--c,c--c" },
                { SentenceIdentifiers.WPL, "llll.ll,a,yyyyy.yy,a,c--c" },
                { SentenceIdentifiers.XDR, "a,x.x,a,c--c,a,x.x,a,c--c" },
                { SentenceIdentifiers.XTE, "A,A,x.x,a,N" },
                { SentenceIdentifiers.XTR, "x.x,a,N" },
                { SentenceIdentifiers.ZDA, "hhmmss.ss,xx,xx,xxxx,xx,xx" },
                { SentenceIdentifiers.ZDL, "hhmmss.ss,hhmmss.ss,c--c" },
                { SentenceIdentifiers.ZFO, "hhmmss.ss,hhmmss.ss,c--c" },
                { SentenceIdentifiers.ZTG, "hhmmss.ss,hhmmss.ss,c--c" }
            };

        #endregion

        #region Known proprietary sentences

        private static Dictionary<ManufacturerCodes, Dictionary<string, string>> ProprietarySentencesFormats =
            new Dictionary<ManufacturerCodes, Dictionary<string, string>>()
            {
                #region Garmin corporation

                {   
                    ManufacturerCodes.GRM, // Garmin corporation
                    new Dictionary<string, string>() 
                    { 
                        {"B", "x.x,x,x,x,x.x,a,0=Check Wiring|1=No Signal|2=Tuning|3=Receiving|4=Scanning,R=RTCM|W=WAAS|N=Non DGPS fix,A=Automatic|W=WAAS Only|R=RTCM Only|N=None"},
                        {"E", "x.x,a,x.x,a,x.x,a"},
                        {"F", "x,x,ddmmyy,hhmmss,x,dddmm.mmmm,N=N|S=S,dddmm.mmmm,E=E|W=W,M=Maual|A=Automatic,0=NoFix|1=2DFix|2=3DFix,x.x,x.x,x.x,x.x"},
                        {"M", "c--c"},
                        {"T", "c--c,P=Pass|F=Fail,P=Pass|F=Fail,R=Retained|L=Lost,R=Retained|L=Lost,P=Pass|F=Excessive Drift Detected,C=Collecting|Null=Not Collecting,x.x,R=Retained|L=Lost"},
                        {"V", "x.x,x.x,x.x"},
                        {"Z", "x.x,F=Feet,2=User Altitude|3=GPS Altitude"},
                        {"C", "A=Automatic|2=2D Exclusively|3=3D Exclusively,x.x,x,x.x,x,x,x,x,A=Automatic|D=Only Output Differential Fixes,1=1200|2=2400|3=4800|4=9600|5=19200|6=300|7=600,x,1=None|2=1Hz,x,x.x"},
                        {"CE", ""},
                        {"C1", "x,1=Off|2=On,1=Off|2=On,x.x,x,1=Off|2=On,1=Off|2=On,A=Automatic|W=WAAS Only|R=RTCM Only|N=None,P=Activated|N=Normal"},
                        {"C1E", ""},
                        {"I", "dddmm.mmm,N=N|S=S,dddmm.mmm,N=N|S=S,ddmmyy,hhmmss,A=Autolocate|R=Unit Reset"},
                        {"IE", ""},
                        {"O", "c--c,0=Disable|1=Enable|2=Disable All Except PSLIB|3=Enable All Except GPALM|4=Restore Defaults"}
                    }
                },

                #endregion                

                #region Martech Inc.

                {
                    ManufacturerCodes.MTK, // Martech, Inc.
                    new Dictionary<string, string>()
                    {
                        {"001", "c--c,0=Invalid|1=Unsupported|2=Valid, action failed|3=Valid, action succeeded" }, // 001 PMTK ACK (Acknowledge command)
                        {"101", "" }, /// Hot restart: use all available data in the NV Store
                        {"102", "" }, /// Warm restart: don't use Ephemeris at re-start
                        {"103", "" }, /// Cold restart: don't use Time, Position, Almanacs and Ephemeris data at re-start
                        {"104", "" }, /// Full cold restart: it's essentially a Cold Restart, but additionaly clear system/user config at re-start
                                      /// That is, reset the receiver to the factory status
                        {"251", "x"}, /// Set NMEA port baudrate, 0 means default, availible values: 4800, 9600, 14400, 19200, 38400, 57600, 115200
                        {"300", "x,x,x,x,x"}, /// API_Set_Fix_Ctl, this parameter controls the rate of position fixing activity,
                        {"301","0=No DGPS source|1=RTCM|2=WAAS"}, /// API_Set_Dgps_Mode, DGPS correction data source mode.
                        {"313","0=Disable|1=Enable"}, /// API_Set_Sbas_Enabled. Enable to search a SBAS stellite or not.
                        {"314","x,x,x,x,x,x,x,x,x,x,x,x,x,x,x,x,x,x,x"}, /// API_Set_NMEA_Out (NMEA sentence output frequencies)                                                                         
                        {"320","0=False|1=True"}, // API_Set_Pwr_Sav_Mode
                        {"390","x,x,x,x,x,x,x,x,x,x,x,0=Disable|1=RTCM|2=SBAS"}, /// API_Set_Flash_User_Option
                        {"420",""}, // API_Query_Pwr_Sav_Mode, return: PMTK520
                        {"490",""}, // API_Get_Flash_User_Option, return: PMTK590
                        {"520","0=False|1=True"}, // Power saving operation mode 
                        {"590","x,x,x,x,x,x,x,x,x,x,x,x,0=Disable|1=RTCM|2=SBAS,x"},                                                                            
                        {"605",""}, /// Query the firmware release information, return: PMTK705
                        {"705","c--c,c--c,c--c"} /// Firmware release version
                    }
                },

                #endregion

                #region Trimble Navigation

                {
                    ManufacturerCodes.TNL, // Trimble Navigation
                    new Dictionary<string, string>()
                    {
                        {"DG", "x.x,x.x,x.x,x,x,0=Idle|1=Wideband FFT search|2=Searching for signal|3=Channel has acquired signal|4=Channel has locked signal|5=Channel disabled,0=False|1=True,x"}, /// DGPS receiver status
                        {"EV", "hhmmss.ss,x"}, /// Event marker
                        {",GGK", "hhmmss.ss,ddmmyy,llll.ll,N=North|S=South,dddmm.mm,E=East|W=West,0=Fix unavailible or invalid|1=Autonomous GPS fix|2=RTK float solution|3=RTK fixed solution|4=DGPS,x,x.x,c--c,M=m|f=ft"}, /// Time, Position, Position type, DOP                                                                                                                                                                                                                            
                        {"ID", "c--c,c--c,x,x,dd/mm/yy"}, /// Trimble receiver ID                                                         
                        {"SM", "xxxx,c--c"}, /// RTCM Special                                            
                        {",AVR", "hhmmss.ss,x.x,c--c,x.x,c--c,c--c,c--c,x.x,0=Not availible|1=Autonomous GNSS|2=Dif. carrier phase solution RTK (float)|3=Dif. carrier phase solution RTK (fix)|4=Dif. code-based solution (DGNSS),c--c,x" }, /// Time and attitude info (needs 2 receivers in vactor mode)
                        {",BPQ", "hhmmss.ss,ddmmyy,llll.ll,N=North|S=South,yyyyy.yy,E=East|W=West,c--c,M=m|f=ft,0=Not availible|1=Autonomous GNSS fix|2=DGNSS or OmniSTART VBS fix|4=RTK fixed|5=OmniSTAR HP/XP/G2/Float RTK" }, /// Base station position and its quality
                        {",PJK", "hhmmss.ss,ddmmyy,x.x,N=North,x.x,E=East,0=Not availible|1=Autonomous GNSS|2=RTK float|3=RTK fix|4=Dif. code-based solution (DGNSS)|5=SBAS|6=RTK float 3D|7=RTK fixed 3D|8=RTK float 2D|9=RTK fix 2D|10=OmniSTAR HP/XP/G2|11=OmniSTAR VBS|12=Location RTK|13=Beacon DGNSS,x,c--c,EHTx.x,M=m|f=ft"}, /// Time, Date and position in ENU format
                        {",PJT", "c--c,c--c"}, /// Receiver projection
                        {",VGK", "hhmmss.ss,ddmmyy,x.x,x.x,x.x,0=Not availible|1=Autonomous GNSS|2=RTK float|3=RTK fix|4=Dif. code-based solution (DGNSS)|5=SBAS|6=RTK float 3D|7=RTK fixed 3D|8=RTK float 2D|9=RTK fix 2D|10=OmniSTAR HP/XP/G2|11=OmniSTAR VBS|12=Location RTK|13=Beacon DGNSS,x,c--c,M=m|f=ft"}, /// Vector information
                        {",VHD", "hhmmss.ss,ddmmyy,yyyyy.yy,x.x,lllll.ll,x.x,x.x,x.x,0=Not availible|1=Autonomous GNSS|2=RTK float|3=RTK fix|4=Dif. code-based solution (DGNSS)|5=SBAS|6=RTK float 3D|7=RTK fixed 3D|8=RTK float 2D|9=RTK fix 2D|10=OmniSTAR HP/XP/G2|11=OmniSTAR VBS|12=Location RTK|13=Beacon DGNSS,x,c--c"}, /// Heading information
                    }
                },

                #endregion

                #region Fugro

                {
                    ManufacturerCodes.FUG,
                    new Dictionary<string, string>()
                    {
                        { "DP", "GP=GPS|GL=GLONASS|GN=GNSS,hhmmss.ss,llll.ll,N=North|S=South,yyyyy.yy,E=East|W=West,x,x,x.x,x.x,x.x,x.x" }, /// Positioning system type info
                    }
                },

                #endregion

                #region Magellan

                {
                    ManufacturerCodes.MGN,
                    new Dictionary<string, string>()
                    {
                        { "CMD", "c--c,..." }, /// CMD, first parameter "VERSION" or "TRACK", see manufacturer's documentation
                        { "CSM", "hh" }, /// In handshake mode is used to acknowledge succsessful. Parameter - checksum for the last last message received
                        { "DRT", "xx" }, /// Delete route from memory. Paramter - zero based route number
                        { "DWP", "c--c,xx" }, /// Delete waypoint from memory. 
                        { "RTE", "xx,xx,c,x,c--c,..." }, /// Route information
                        { "TRK", "llll.ll,N=North|S=South,yyyyy.yy,E=East|W=West,xxxxx,f=Ft|M=m,hhmmss.ss,A=Valid|V=Invalid,c--c,ddmmyy" }, /// Track information
                        { "VER", "x,x,c--c,c--c,c--c"}, /// Version information
                        { "WPL", "llll.ll,N=North|S=South,yyyyy.yy,W=West|E=East,xxxx,M=m|f=ft,c--c,c--c,c--c,xx" }, /// Waypoint info
                        { "ST", "c--c,2=2D|3=3D,T=True|F=False,x,x.x,x,x" }, /// Status information
                    }
                },

                #endregion

                #region Motorola

                {
                    ManufacturerCodes.MOT,
                    new Dictionary<string, string>()
                    {
                        {"G", "c--c,x"} /// Sentence frequency control
                    }
                },

                #endregion

                #region Rockwell International

                {
                    ManufacturerCodes.RWI,
                    new Dictionary<string, string>()
                    {
                        {"RID", "x,x.x,c--c,mm/dd/yy,hhhh"}, /// ?
                        {"ILOG", "c--c,A=activate|V=deactivate,T=cyclic,x,x"} /// ?
                    }
                },

                #endregion

                #region Starlink

                {
                    ManufacturerCodes.SLI,
                    new Dictionary<string, string>()
                    {
                       {"B", "x.x,x,c--c,J=Status request|K=Configuration request|=tuning message"}, // 
                    }
                },

                #endregion

                #region SRF (update 08 dec 2013)
                
                {
                    ManufacturerCodes.SRF,
                    new Dictionary<string, string>()
                    {
                       {"100", "0=BIN|1=NMEA,x,x,x,0=None|1=Even|2=Odd"}, // protocol type: 0 - binary, 1 - nmea
                                                                          // baudrate: 1200, 2400, 4800, 9600, 19200, 38400
                                                                          // data bits: 8, 7 (BIN protocol requires 8)
                                                                          // stop bits: 0, 1
                                                                          // parity: 0 - none, 1 - even, 2 - odd
                       {"101", "x,x,x,x,x,x,x,x,x"}, // position X-coordinate
                                                     // position Y-coordinate
                                                     // position Z-coordinate
                                                     // GPS receiver clock offset, Hz: 0 means last save value
                                                     // Time of GPS week
                                                     // Number of GPS week
                                                     // Number of channels to use: 1..12
                                                     // Bitmask: 0x01 - data valid, warm start = 1
                                                     //          0x02 - clear ephemeris, warm start = 1
                                                     //          0x04 - clear memory, cold start = 1
                       {"102", "x,x,x,x"}, // baudrate: 1200, 2400, 4800, 9600, 19200, 38400
                                           // data bits: 8
                                           // stop bits: 0, 1
                                           // parity: 0 - none, 1 - even, 2 - odd
                       {"103", "0=GGA|1=GLL|2=GSA|3=GSV|4=RMC|5=VTG,x,x,x"}, // message type
                                                                             // mode: 0 - periodically, 1 - by request
                                                                             // rate: 0..255 (0 - means turned off)
                                                                             // 0 - checksum disabled, 1 - checksum enabled
                       {"104", "x.x,x.x,x.x,x,x,x,x,x"}, // latitude (signed)
                                                         // longitude (signed)
                                                         // altitude (signed)
                                                         // GPS receiver clock offset (0 - means use last saved value)
                                                         // time of GPS week
                                                         // number of GPS week
                                                         // Channels to use 1..12
                                                         // bitmask: 0x01 - data valid, warm/hot start = 1
                                                         //          0x02 - clear ephemeris, warm start = 1
                                                         //          0x04 - clear memory, cold start = 1
                       {"105", "x"} // 0 - switch debug mode off, 1 - switch debug mode on
                    }
                },
                
                #endregion

                #region Furuno

                {
                    ManufacturerCodes.FEC,
                    new Dictionary<string, string>()
                    {
                        // $PFEC,hdcom,N,Er,0010
                        { ",hdcom", "c--c,c--c,xxxx" }, // no data for the sentence :(
                    }
                },

                #endregion
            };

        #endregion

        #region Formatters

#if FRAMEWORK_LOWER_35

        private delegate object ParserDelegate(string source);
        private static Dictionary<string, ParserDelegate> parsers = new Dictionary<string, ParserDelegate>()
        {
            { "x", x => int.Parse(x) },
            { "xx", x => int.Parse(x) },
            { "xxx", x => int.Parse(x) },
            { "xxxx", x => int.Parse(x) },
            { "xxxxx", x => int.Parse(x) },
            { "xxxxxx", x => int.Parse(x) },
            { "hh", x => Convert.ToByte(x, 16) },
            { "hhhh", x => Convert.ToUInt16(x, 16) },
            { "hhhhhh", x => Convert.ToUInt32(x, 16) },
            { "hhhhhhhh", x => Convert.ToUInt32(x, 16) },
            { "h--h", x => ParseByteArray(x) },
            { "x.x", x => double.Parse(x, CultureInfo.InvariantCulture) },
            { "c--c", x => x },
            { "llll.ll", x => ParseLatitude(x) },
            { "yyyyy.yy", x => ParseLongitude(x) },
            { "hhmmss", x => ParseCommonTime(x) },
            { "hhmmss.ss", x => ParseCommonTime(x) },
            { "ddmmyy", x => ParseCommonDate(x) },
            { "dd/mm/yy", x => ParseDateSlashes(x) },
            { "dddmm.mmm", x => ParseCommonDegrees(x) }

        };

        private delegate string FormatterDelegate(object source);
        private static Dictionary<string, FormatterDelegate> formatters = new Dictionary<string, FormatterDelegate>()
        {
            { "x", x => ((int)(x)).ToString() },
            { "xx", x => ((int)(x)).ToString("D2") },
            { "xxx", x => ((int)(x)).ToString("D3") },
            { "xxxx", x => ((int)(x)).ToString("D4") },
            { "xxxxx", x => ((int)(x)).ToString("D5") },
            { "xxxxxx", x => x.ToString() },
            { "hh", x => ((byte)x).ToString("X2") },
            { "hhhh", x => ((ushort)x).ToString("X4") },
            { "hhhhhh", x => ((uint)x).ToString("X6") },
            { "hhhhhhhh", x => ((uint)x).ToString("X8") },
            { "h--h", x => FormatByteArray((byte[])x) },
            { "x.x", x => ((double)x).ToString("F04", CultureInfo.InvariantCulture).TrimEnd(new char[] {'0'}) },
            { "c--c", x => x.ToString() },
            { "llll.ll", x => FormatLatitude((double)x) },
            { "yyyyy.yy", x => FormatLongitude((double)x) },
            { "hhmmss", x => FormatTime((DateTime)x, false) },
            { "hhmmss.ss", x => FormatTime((DateTime)x, true) },
            { "ddmmyy", x => FormatDate((DateTime)x) },
            { "dd/mm/yy", x => FormatDateSlashes((DateTime)x) },
            { "dddmm.mmm", x => FormatDegree((double)x) }
        };

#else
        private static Dictionary<string, Func<string, object>> parsers = new Dictionary<string, Func<string, object>>()
        {
            { "x", x => int.Parse(x) },
            { "xx", x => int.Parse(x) },
            { "xxx", x => int.Parse(x) },
            { "xxxx", x => int.Parse(x) },
            { "xxxxx", x => int.Parse(x) },
            { "xxxxxx", x => int.Parse(x) },
            { "hh", x => Convert.ToByte(x, 16) },
            { "hhhh", x => Convert.ToUInt16(x, 16) },
            { "hhhhhh", x => Convert.ToUInt32(x, 16) },
            { "hhhhhhhh", x => Convert.ToUInt32(x, 16) },
            { "h--h", x => ParseByteArray(x) },
            { "x.x", x => double.Parse(x, CultureInfo.InvariantCulture) },
            { "c--c", x => x },
            { "llll.ll", x => ParseLatitude(x) },
            { "yyyyy.yy", x => ParseLongitude(x) },
            { "hhmmss", x => ParseCommonTime(x) },
            { "hhmmss.ss", x => ParseCommonTime(x) },
            { "ddmmyy", x => ParseCommonDate(x) },
            { "dddmm.mmmm", x => ParseCommonDegrees(x) }//,
            //{ "ddd.dddd", x => ParseDecDegrees(x) }
        };

        private static Dictionary<string, Func<object, string>> formatters = new Dictionary<string, Func<object, string>>()
        {            
            { "x", x => ((int)(x)).ToString() },
            { "xx", x => ((int)(x)).ToString("D2") },
            { "xxx", x => ((int)(x)).ToString("D3") },
            { "xxxx", x => ((int)(x)).ToString("D4") },
            { "xxxxx", x => ((int)(x)).ToString("D5") },
            { "xxxxxx", x => x.ToString() },
            { "hh", x => ((byte)x).ToString("X2") },
            { "hhhh", x => ((ushort)x).ToString("X4") },
            { "hhhhhh", x => ((uint)x).ToString("X6") },
            { "hhhhhhhh", x => ((uint)x).ToString("X8") },
            { "h--h", x => FormatByteArray((byte[])x) },
            { "x.x", x => ((double)x).ToString("F06", CultureInfo.InvariantCulture).TrimEnd(new char[] {'0'}) },
            { "c--c", x => x.ToString() },
            { "llll.ll", x => FormatLatitude((double)x) },
            { "yyyyy.yy", x => FormatLongitude((double)x) },
            { "hhmmss", x => FormatTime((DateTime)x, false) },
            { "hhmmss.ss", x => FormatTime((DateTime)x, true) },
            { "ddmmyy", x => FormatDate((DateTime)x) },
            { "dd/mm/yy", x => FormatDateSlashes((DateTime)x) },
            { "dddmm.mmmm", x => FormatDegree((double)x) },
            { "ddd.dddd", x => FormatDecDegree((double)x) }
        };
#endif

        #endregion

        #endregion

        #region Checksum

#if FRAMEWORK_LOWER_35
        public delegate byte CheckSumEvaluatorDelegate(string source);
        public static CheckSumEvaluatorDelegate CheckSumEvaluator = new CheckSumEvaluatorDelegate(GetCheckSum);
#else
        public static Func<string, byte> CheckSumEvaluator = new Func<string, byte>(GetCheckSum);
#endif

        #endregion

        #endregion

        #endregion

        #region Methods

        #region Sentence building

        /// <summary>
        /// Builds sentence by talker & sentence IDs and parameters, specified as object[]
        /// </summary>
        /// <param name="talkerID">Talker identifier</param>
        /// <param name="sentenceID">Sentence identifier</param>
        /// <param name="parameters">Sentence parameters</param>
        /// <returns>NMEA0183 sentence as string</returns>
        public static string BuildSentence(TalkerIdentifiers talkerID, SentenceIdentifiers sentenceID, object[] parameters)
        {
            var formatter = SentencesFormats[sentenceID];

            StringBuilder sb = new StringBuilder();
            sb.Append(talkerID.ToString());
            sb.Append(sentenceID.ToString());
            sb.Append(FieldDelimiter);
            sb.Append(BuildParametersList(parameters, formatter));

            var checkSum = GetCheckSum(sb.ToString());

            sb.Append(CheckSumFieldDelimiter);
            sb.Append(checkSum.ToString("X2"));
            sb.Append(SentenceEndDelimiter);

            sb.Insert(0, SentenceStartDelimiter);

            return sb.ToString();            
        }

        /// <summary>
        /// Builds proprietary sentence
        /// </summary>
        /// <param name="manufacturerID">Manufacturer ID</param>
        /// <param name="sentenceIDString">Sentence ID string</param>
        /// <param name="parameters">Sentence parameters</param>
        /// <returns>NMEA0182 sentence as string</returns>
        public static string BuildProprietarySentence(ManufacturerCodes manufacturerID, string sentenceIDString, object[] parameters)
        {
            var formatter = ProprietarySentencesFormats[manufacturerID][sentenceIDString];

            StringBuilder sb = new StringBuilder();
            sb.Append(TalkerIdentifiers.P.ToString());
            sb.Append(manufacturerID.ToString());
            sb.Append(sentenceIDString);
            sb.Append(FieldDelimiter);
            sb.Append(BuildParametersList(parameters, formatter));

            var checkSum = GetCheckSum(sb.ToString());

            sb.Append(CheckSumFieldDelimiter);
            sb.Append(checkSum.ToString("X2"));
            sb.Append(SentenceEndDelimiter);

            sb.Insert(0, SentenceStartDelimiter);

            return sb.ToString();
        }

        private static string BuildParametersList(object[] items, string formatter)
        {
            var splits = formatter.Split(formatTokenDelimiters);

            if ((splits.Length >= items.Length) || (formatter.Contains(etcFormat)))
            {
                StringBuilder sb = new StringBuilder();

                string previousFormat = "c--c";
                for (int i = 0; i < items.Length; i++)
                {
                    if (splits.Length <= i)
                    {
                        sb.Append(FormatToken(items[i], previousFormat));
                    }
                    else
                    {
                        sb.Append(FormatToken(items[i], splits[i]));
                        previousFormat = splits[i];
                    }

                    if (i != items.Length - 1)
                        sb.Append(FieldDelimiter);
                }

                return sb.ToString();
            }
            else
            {
                throw new ArgumentException("Specified parameters list and formatting string incompatible");
            }
        }

        private static string FormatToken(object item, string format)
        {
            if (item == null)
                return string.Empty;

            if (format.Contains(formatEnumPairDelimiter))
            {
                var items = format.Split(formatEnumDelimiters);
                Dictionary<string, string> enumDictionary = new Dictionary<string, string>();

                for (int i = 0; i < items.Length; i++)
                {
                    var pair = items[i].Split(formatEnumPairDelimiters);
                    if (pair.Length == 2)
                    {
                        enumDictionary.Add(pair[1], pair[0]);
                    }
                    else
                    {
                        throw new ArgumentException(string.Format("Error in format token \"{0}\"", format));
                    }
                }

                if (enumDictionary.ContainsKey(item.ToString()))
                {
                    return enumDictionary[item.ToString()];
                }
                else
                {
                    throw new ArgumentException(string.Format("Specified object \"{0}\" cannot be formatter with format string \"{1}\"", item.ToString(), format));
                }
            }
            else
            {
                if (format.StartsWith(arrayOpenBracket) && format.EndsWith(arrayCloseBracket))
                {
                    return FormatArray(item, format.Trim(arrayBrackets));
                }
                else
                {
                    if (formatters.ContainsKey(format))
                    {
                        return formatters[format](item);
                    }
                    else
                    {
                        return item.ToString();
                    }
                }
            }
        }

        #region Heuristic formatters

        private static string FormatArray(object item, string format)
        {
            if (item is Array)
            {
                Array array = item as Array;
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < array.Length; i++)
                {
                    sb.Append(FormatToken(array.GetValue(i), format));

                    if (i < array.Length - 1)
                        sb.Append(formatEnumDelimiters[0]);
                }

                return sb.ToString();
            }
            else
            {
                throw new ArgumentException(string.Format("Unable cast \"{0}\" to array", item.GetType().Name));
            }
        }

        private static string FormatLatitude(double x)
        {
            StringBuilder sb = new StringBuilder();

            double degrees = Math.Floor(x);
            double minutes = Math.Floor((x - degrees) * 60.0);
            double seconds = (x - degrees) * 3600 - minutes * 60.0;

            minutes += seconds / 60.0;

            sb.Append(degrees.ToString("00"));
            sb.Append(minutes.ToString("00.0000", CultureInfo.InvariantCulture).TrimEnd(new char['0']));

            return sb.ToString();
        }

        private static string FormatLongitude(double x)
        {
            StringBuilder sb = new StringBuilder();

            double degrees = Math.Floor(x);
            double minutes = Math.Floor((x - degrees) * 60.0);
            double seconds = (x - degrees) * 3600 - minutes * 60.0;

            minutes += seconds / 60.0;

            sb.Append(degrees.ToString("000"));
            sb.Append(minutes.ToString("00.0000", CultureInfo.InvariantCulture).TrimEnd(new char['0']));

            return sb.ToString();
        }

        private static string FormatTime(DateTime dt, bool isMilliseconds)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(dt.Hour.ToString("00"));
            sb.Append(dt.Minute.ToString("00"));
            sb.Append(dt.Second.ToString("00"));

            if (isMilliseconds)
            {
                sb.Append('.');
                sb.Append(dt.Millisecond.ToString());
            }

            return sb.ToString();
        }

        private static string FormatDate(DateTime dt)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(dt.Day.ToString("00"));
            sb.Append(dt.Month.ToString("00"));
            sb.Append((dt.Year - 2000).ToString("00"));
            return sb.ToString();
        }

        private static string FormatDateSlashes(DateTime dt)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(dt.Day.ToString("00"));
            sb.Append('/');
            sb.Append(dt.Month.ToString("00"));
            sb.Append('/');
            sb.Append((dt.Year - 2000).ToString("00"));

            return sb.ToString();
        }

        private static string FormatDegree(double x)
        {
            StringBuilder sb = new StringBuilder();

            double degrees = Math.Floor(x);
            double minutes = Math.Floor((x - degrees) * 60.0);
            double seconds = (x - degrees) * 3600 - minutes * 60.0;

            minutes += seconds / 60.0;

            sb.Append(degrees.ToString("000"));
            sb.Append(minutes.ToString("00.0000", CultureInfo.InvariantCulture).TrimEnd(new char['0']));

            return sb.ToString();
        }

        private static string FormatDecDegree(double x)
        {
            return x.ToString("000.0000", CultureInfo.InvariantCulture);
        }

        public static string FormatByteArray(byte[] bytes)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("0x");

            for (int i = 0; i < bytes.Length; i++)
                sb.Append(bytes[i].ToString("X2"));

            return sb.ToString();
        }

        #endregion

        #endregion

        #region Sentence parsing

        /// <summary>
        /// Parse NMEA0183 sentence
        /// </summary>
        /// <param name="sourceString">string to parse</param>
        /// <returns>Parsed sentence as NMEASentese</returns>
        public static NMEASentence Parse(string sourceString)
        {            
            if (!sourceString.EndsWith(SentenceEndDelimiter))
            {
                throw new ArgumentException(string.Format("{0} sentence must ends with valid sentence end delimiter \"{1}\"", StandartID, @"\r\n"));
            }

            var source = sourceString.TrimEnd(SentenceEndDelimiter.ToCharArray());

            if (source.StartsWith(SentenceStartAISDelemiter))
                source = source.Replace(SentenceStartAISDelemiter, SentenceStartDelimiter.ToString());

            if (source.Length > MaxSentenceLength)
                throw new ArgumentException(string.Format("Specified string \"{0}\" length exceeds {1} characters", source.Length, MaxSentenceLength));

            if (!source.StartsWith(SentenceStartDelimiter.ToString()))
                throw new ArgumentException(string.Format("{0} sentence must starts with valid sentence start delimiterы \"{1}\" or \"{2}\"", 
                    StandartID, SentenceStartDelimiter, SentenceStartAISDelemiter));

            try
            {
                string sentence;
                string checkSumString;
                SplitSentence(source, out sentence, out checkSumString);

                if (!string.IsNullOrEmpty(checkSumString))
                {
                    byte declaredCheckSum;
                    if (byte.TryParse(checkSumString, System.Globalization.NumberStyles.HexNumber, CultureInfo.InvariantCulture, out declaredCheckSum))
                    {
                        byte realCheckSum = GetCheckSum(sentence);

                        if (realCheckSum == declaredCheckSum)
                        {
                            return ParseSentence(sentence);
                        }
                        else
                        {
                            throw new ArgumentException(string.Format("Integrity error in sentese \"{0}\" (declared: {1}, real: {2})", sentence, declaredCheckSum, realCheckSum));
                        }
                    }
                    else
                    {
                        throw new ArgumentException(string.Format("Unable parse chesksum field from \"{0}\"", checkSumString));
                    }
                }
                else
                {
                    return ParseSentence(sentence);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static NMEAProprietarySentence ParseProprietary(string manufacturerIDString, string sentenceID, List<string> parameters)
        {
            ManufacturerCodes manufacturerID = ManufacturerCodes.unknown;
            try
            {
                manufacturerID = (ManufacturerCodes)Enum.Parse(typeof(ManufacturerCodes), manufacturerIDString);
            }
            catch
            {
                throw new ArgumentException(string.Format("Unknown manufacturer \"{0}\" in proprietary sentence", manufacturerIDString));
            }

            if (ProprietarySentencesFormats.ContainsKey(manufacturerID))
            {
                if (ProprietarySentencesFormats[manufacturerID].ContainsKey(sentenceID))
                {
                    NMEAProprietarySentence result = new NMEAProprietarySentence();
                    result.Manufacturer = manufacturerID;
                    result.SentenceIDString = sentenceID;

                    var formatter = ProprietarySentencesFormats[manufacturerID][sentenceID];
                    result.parameters = ParseParameters(parameters, formatter);

                    return result;
                }
                else
                {
                    throw new ArgumentException(string.Format("Unknown proprietary sentese \"{0}\", manufacturerID: \"{1}\"", sentenceID, manufacturerID));
                }
            }
            else
            {
                throw new ArgumentException(string.Format("Unknown manufacturerID \"{0}\", sentenceID: \"{1}\"", manufacturerID, sentenceID));
            }
        }

        private static NMEAStandartSentence ParseSentence(TalkerIdentifiers talkerID, string sentenceIDString, List<string> parameters)
        {
            SentenceIdentifiers sentenceID = SentenceIdentifiers.unknown;
            try
            {
                sentenceID = (SentenceIdentifiers)Enum.Parse(typeof(SentenceIdentifiers), sentenceIDString);
            }
            catch
            {
                throw new ArgumentException(string.Format("Undefined sentence ID \"{0}\" from takler \"{1}\"", sentenceIDString, talkerID));
            }

            var formatter = SentencesFormats[sentenceID];
            if (string.IsNullOrEmpty(formatter))
            {
                throw new ArgumentException(string.Format("Specified sentence \"{0}\" from talker \"{1}\" is unknown", sentenceID, talkerID));
            }

            NMEAStandartSentence result = new NMEAStandartSentence();
            result.TalkerID = talkerID;
            result.SentenceID = sentenceID;

            result.parameters = ParseParameters(parameters, formatter);

            return result;
        }

        private static NMEASentence ParseSentence(string source)
        {
            var splits = source.Split(FieldDelimiter.ToString().ToCharArray());
            List<string> parameters = new List<string>();

            if (splits.Length > 1)
            {
                var sentenceDescription = splits[0];
                if (sentenceDescription.Length >= 4)
                {
                    string talkerIDString;
                    string sentenceIDString;
                    
                    if (sentenceDescription.StartsWith(TalkerIdentifiers.P.ToString()))
                    {
                        // Proprietary code
                        string manufacturerIDString = string.Empty;
                        manufacturerIDString = sentenceDescription.Substring(1, 3);

                        int start = 1;
                        if (sentenceDescription.Length == 4)
                        {
                            sentenceDescription += FieldDelimiter + splits[1];                                
                            start = 2;
                        }

                        sentenceIDString = sentenceDescription.Substring(4);

                        for (int i = start; i < splits.Length; i++)
                        {
                            parameters.Add(splits[i]);
                        }

                        return ParseProprietary(manufacturerIDString, sentenceIDString, parameters);
                    }
                    else
                    {
                        // Not a proprietary code
                        TalkerIdentifiers talkerID = TalkerIdentifiers.unknown;
                        talkerIDString = sentenceDescription.Substring(0, 2);
                        sentenceIDString = sentenceDescription.Substring(2, 3);

                        try
                        {
                            talkerID = (TalkerIdentifiers)Enum.Parse(typeof(TalkerIdentifiers), talkerIDString);
                        }
                        catch
                        {
                            throw new ArgumentException(string.Format("Undefined takler ID \"{0}\"", talkerIDString));
                        }

                        for (int i = 1; i < splits.Length; i++)
                        {
                            parameters.Add(splits[i]);
                        }

                        return ParseSentence(talkerID, sentenceIDString, parameters);
                    }                                        
                }
                else
                {
                    throw new ArgumentException(string.Format("Wrong sentence description: \"{0}\"", sentenceDescription));
                }
            }
            else
            {
                throw new ArgumentException(string.Format("No field delimiters in specified sentence \"{0}\"", source));
            }            
        }

        private static void SplitSentence(string source, out string sentence, out string checkSumString)
        {
            var temp = source.TrimStart(SentenceStartDelimiter.ToString().ToCharArray());

            if (source.Contains(CheckSumFieldDelimiter.ToString()))
            {

                var splits = temp.Split(CheckSumFieldDelimiter.ToString().ToCharArray());

                if (splits.Length == 2)
                {
                    sentence = splits[0];
                    checkSumString = splits[1];
                }
                else
                {
                    throw new ArgumentException(string.Format("Specified string \"{0}\" not in correct {1} format", source, StandartID));
                }
            }
            else
            {
                sentence = temp;
                checkSumString = string.Empty;
            }
        }

        private static object ParseToken(string token, string format)
        {
            if (string.IsNullOrEmpty(token))
                return null;

            if (format.Contains(formatEnumPairDelimiter))
            {
                var items = format.Split(formatEnumDelimiters);
                Dictionary<string, string> enumDictionary = new Dictionary<string, string>();

                for (int i = 0; i < items.Length; i++)
                {
                    var pair = items[i].Split(formatEnumPairDelimiters);
                    if (pair.Length == 2)
                    {
                        enumDictionary.Add(pair[0], pair[1]);
                    }
                    else
                    {
                        throw new ArgumentException(string.Format("Error in format token \"{0}\"", format));
                    }
                }

                if (enumDictionary.ContainsKey(token))
                {
                    return enumDictionary[token];
                }
                else
                {
                    return token;
                }
            }
            else
            {
                if (format.StartsWith(arrayOpenBracket) && token.EndsWith(arrayCloseBracket))
                {
                    return ParseArray(token, format.Trim(arrayBrackets));
                }
                else
                {
                    if (parsers.ContainsKey(format))
                    {
                        return parsers[format](token);
                    }
                    else
                    {
                        return token;
                    }
                }
            }            
        }

        private static object[] ParseParameters(List<string> parameters, string formatString)
        {
            var formatTokens = formatString.Split(formatTokenDelimiters);
            if ((formatTokens.Length >= parameters.Count) || (formatString.Contains(etcFormat)))
            {
                List<object> results = new List<object>();

                string previousFormatter = "c--c";
                for (int i = 0; i < parameters.Count; i++)
                {
                    if (formatTokens.Length <= i)
                        results.Add(ParseToken(parameters[i], previousFormatter));
                    else
                    {
                        results.Add(ParseToken(parameters[i], formatTokens[i]));
                        previousFormatter = formatTokens[i];
                    }
                }

                return results.ToArray();
            }
            else
            {
                throw new ArgumentException("Specified parameters list and formatting string incompatible");
            }
        }

        #region Heuristic parsers

        private static object[] ParseArray(string token, string format)
        {
            var splits = token.Split(formatEnumDelimiters);
            List<object> result = new List<object>();

            for (int i = 0; i < splits.Length; i++)
                result.Add(ParseToken(splits[i], format));

            return result.ToArray();
        }

        private static DateTime ParseCommonTime(string token)
        {
            double temp = double.Parse(token, CultureInfo.InvariantCulture);

            int sss = (int)((temp - (int)temp) * 1000.0);
            int hh = (int)((int)temp / 10000.0);
            int mm = (int)(((int)temp - hh * 10000.0) / 100.0);
            int ss = (int)((int)temp - hh * 10000.0 - mm * 100.0);

            DateTime now = DateTime.Now;
            return new DateTime(now.Year, now.Month, now.Day, hh, mm, ss, sss);
        }

        private static DateTime ParseCommonDate(string token)
        {
            if (token.Length == 6)
            {
                int date = Convert.ToInt32(token.Substring(0, 2));
                int month = Convert.ToInt32(token.Substring(2, 2));
                int year = Convert.ToInt32(token.Substring(4, 2)) + 2000;

                return new DateTime(year, month, date);
            }
            else
            {
                throw new ArgumentException(string.Format("Date format incorrect in \"{0}\" (must be ddmmyy)", token));
            }
        }

        private static DateTime ParseDateSlashes(string token)
        {
            var splits = token.Split("/".ToCharArray());

            if (splits.Length == 3)
            {
                DateTime result = DateTime.Now;

                int date = int.Parse(splits[0]);
                int month = int.Parse(splits[1]);
                int year = int.Parse(splits[2]) + 2000;

                return new DateTime(year, month, date);
            }
            else
            {
                throw new ArgumentException(string.Format("Date format incorrect in \"{0}\" (must be dd/mm/yy)", token));
            }
        }

        private static double ParseLatitude(string token)
        {
            double temp = double.Parse(token, CultureInfo.InvariantCulture);

            double degree = (int)((int)temp / 100.0);
            double minutes = ((int)temp - degree * 100.0);
            double seconds = (temp - (int)temp) * 60.0;

            return degree + minutes / 60.0 + seconds / 3600.0;
        }

        private static double ParseLongitude(string token)
        {
            double temp = double.Parse(token, CultureInfo.InvariantCulture);

            double degree = (int)((int)temp / 100.0);
            double minutes = ((int)temp - degree * 100.0);
            double seconds = (temp - (int)temp) * 60.0;

            return degree + minutes / 60.0 + seconds / 3600.0;
        }

        private static double ParseCommonDegrees(string token)
        {
            double temp = double.Parse(token, CultureInfo.InvariantCulture);

            double degree = (int)((int)temp / 100.0);
            double minutes = ((int)temp - degree * 100.0);
            double seconds = (temp - (int)temp) * 60.0;

            return degree + minutes / 60.0 + seconds / 3600.0;
        }

        private static byte[] ParseByteArray(string source)
        {
            if (source.StartsWith("0x"))
            {
                if (source.Length % 2 == 0)
                {
                    byte[] result = new byte[(source.Length - 2) / 2];

                    for (int i = 1; i < source.Length / 2; i++)
                        result[i - 1] = byte.Parse(source.Substring(i * 2, 2), NumberStyles.AllowHexSpecifier);

                    return result;
                }
                else
                {
                    throw new ArgumentException("Specified string must has even length");
                }
            }
            else
            {
                throw new ArgumentException(string.Format("Specified string \"{0}\" do not starts with \"{1}\"", source, "0x"));
            }
        }

        #endregion        

        #endregion

        #region Utils

        #region database related

        /// <summary>
        /// Gets sentence description by specified sentenceID
        /// </summary>
        /// <param name="sentenceID">Sentence identified</param>
        /// <returns>String that reptesents sentence desctiption</returns>
        public static string GetSentenceDescription(SentenceIdentifiers sentenceID)
        {
            if (SentencesDescriptions.ContainsKey(sentenceID))
            {
                return SentencesDescriptions[sentenceID];
            }
            else
            {
                throw new ArgumentException(string.Format("Unknown sentence ID: \"{0}\"", sentenceID));
            }
        }

        /// <summary>
        /// Gets talker description by specified taklerID
        /// </summary>
        /// <param name="talkerID">Talker identidier</param>
        /// <returns>String that represents talker description</returns>
        public static string GetTalkerDescription(TalkerIdentifiers talkerID)
        {
            if (TalkerDescriptions.ContainsKey(talkerID))
            {
                return TalkerDescriptions[talkerID];
            }
            else
            {
                throw new ArgumentException(string.Format("Unknown talker ID: \"{0}\"", talkerID));
            }
        }

        /// <summary>
        /// Adds manufacturer node to base
        /// </summary>
        /// <param name="manufacturer">Manufacturer ID to add</param>
        public static void AddManufacturerToProprietarySentencesBase(ManufacturerCodes manufacturer)
        {
            if (!ProprietarySentencesFormats.ContainsKey(manufacturer))
            {
                ProprietarySentencesFormats.Add(manufacturer, new Dictionary<string, string>());
            }
            else
            {
                throw new ArgumentException(string.Format("Base already contais manufacturer \"{0}\"", manufacturer));
            }
        }

        /// <summary>
        /// Adds proprietary sentence description to base
        /// </summary>
        /// <param name="manufacturer">Manufacturer identifier</param>
        /// <param name="sentenceIDString">proprietary sentence ID string</param>
        /// <param name="formatString">formatting string for specified sentence</param>
        public static void AddProprietarySentenceDescription(ManufacturerCodes manufacturer, string sentenceIDString, string formatString)
        {
            if (ProprietarySentencesFormats.ContainsKey(manufacturer))
            {
                if (!ProprietarySentencesFormats[manufacturer].ContainsKey(sentenceIDString))
                {
                    ProprietarySentencesFormats[manufacturer].Add(sentenceIDString, formatString);
                }
                else
                {
                    throw new ArgumentException(string.Format("Specified sentence ID \"{0}\" already exists in \"{1}\" sentences list", sentenceIDString, manufacturer));
                }
            }
            else
            {
                throw new ArgumentException(string.Format("Specified manufacturer \"{0}\" not exists in base, add it first", manufacturer));
            }
        }

        public static string GetDatumDescription(int datumKey)
        {
            if (Datums.ContainsKey(datumKey))
            {
                return Datums[datumKey];
            }
            else
            {
                return string.Empty;
            }
        }

        #endregion

        /// <summary>
        /// Calculates NMEA0183 checksum (byte-by-byte XOR) for specified string
        /// </summary>
        /// <param name="source">string to calculate checksum</param>
        /// <returns></returns>
        public static byte GetCheckSum(string source)
        {
            byte result = 0;
            byte[] bytes = Encoding.ASCII.GetBytes(source);

            for (int i = 0; i < bytes.Length; i++)
                result = (byte)(result ^ bytes[i]);

            return result;
        }

        /// <summary>
        /// Converts marine bend to meters per second
        /// </summary>
        /// <param name="speedBends">Speed in bends</param>
        /// <returns>Speed in meters per second</returns>
        public static double Bend2MpS(double speedBends)
        {
            return speedBends * 0.5144;
        }

        /// <summary>
        /// Converts distance in miles to kilometers
        /// </summary>
        /// <param name="nMiles">Distance in miles</param>
        /// <returns>Distance in kilometers</returns>
        public static double NM2Km(double nMiles)
        {
            return nMiles * 1.852;
        }

        /// <summary>
        /// Converts distance in feets to meters
        /// </summary>
        /// <param name="feets">Distance in feets</param>
        /// <returns>Distance in meters</returns>
        public static double Ft2M(double feets)
        {
            return feets * 0.3048;
        }

        #endregion

        #endregion
    }
}