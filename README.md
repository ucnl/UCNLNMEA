# UCNLNMEA
## NMEA 0183 protocol support library

> This repository is a supported version of a library I posted back in 2011 at [CodeProject](https://www.codeproject.com/Articles/279647/NMEA-0183-sentence-parser-builder)

The library is able to parse and build **any** NMEA0183-sentences. Common used standard sentences are supported 'from the box'.

## If you looking for a *tiny* and *fast* **C/Arduino** code for parsing NMEA0183-sentences, please, refer to [UCNL_ALibs library](https://github.com/ucnl/UCNL_ALibs/blob/main/src/libs/ucnl_nmea.cpp)

The parser/builder is made as a static class.  
To use it, just:  
* Add UCNLNMEA to your project's references list.
* Add a propriate using declaration: ```using UCNLNMEA;```

## List of supported standard sentences

| Sentence ID | Description |
| :---: | :--- |
| AAM | Waypoint Arrival Alarm |
| ALM | GPS Almanac Data |
| APB | Autopilot Sentence \"B\" |
| APA | Autopilot Sentence \"A\" |
| ASD | Autopilot System Data |
| BEC | Bearing & Distance to Waypoint, Dead reckoning |
| BOD | Bearing, Origin to Destination |
| BWC | Bearing & Distance to Waypoint, Great Circle |
| BWR | Bearing & Distance to Waypoint, Rhumb Line |
| BWW | Bearing, Waypoint to Waypoint |
| DBK | Depth Below Keel |
| DBS | Depth Below Surface |
| DBT | Depth Below Transduser |
| DCN | *Obsolete* Decca Position |
| DPT | Depth |
| DSC | Digital Selective Calling Information |
| DSE | Extended DSC |
| DSI | DSC Transponder Initiate |
| DSR | DSC Transponder Response |
| DTM | Datum Reference |
| FSI | Frequency Set Information |
| GBS | GBS Satellite Fault Detection |
| GGA | Global Positioning System Fix Data |
| GLC | Geographic Position, Loran-C |
| GLL | Geographic Position, Latitude/Longitude |
| GRS | GPS Range Residuals |
| GSA | GPS DOP and Active Satellites |
| GST | GPS Pseudorange Noise Statistics |
| GSV | GPS Sattelites in View |
| GTD | Geograpic Location in Time Differences |
| GXA | Transit Position |
| HDG | Heading, Deviation & Variation |
| HDM | Heading, Magnetic |
| HDT | Heading, True |
| HSC | Heading Steering Command |
| LCD | Loran-C Signal Data |
| MSK | MSK Receiver Interface (for DGPS Beacon Receivers) |
| MSS | MSK Receiver Signal Status |
| MTW | Water Temperature |
| MWD | Wind Direction & Speed |
| MWV | Wind Speed & Angle |
| OLN | *Obsolete* Omega Line Numbers |
| OSD | Own Ship Data |
| RMA | Recommend Minimum Specific Loran-C Data |
| RMB | Recommend Minimum Navigation Information |
| RMC | Recommend Minimum Specific GPS/TRANSIT Data |
| ROO | Waypoints in Active Route |
| ROT | Rate of Turn |
| RPM | Revolutions |
| RSA | Rudder Sensor Angle |
| RSD | RADAR System Data |
| RTE | Routes |
| SFI | Scanning Frequency Information |
| STN | Multiple Data ID |
| TLL | Target Latitude & Longitude |
| TRF | *Obsolete* TRANSIT Fix Data |
| TTM | Tracked Target Message |
| VBW | Dual Ground/Water Speed |
| VDR | Set and Drift |
| VHW | Water Speed and Heading |
| VLW | Distance Traveled through Water |
| VPW | Speed, Measured Parallel to Wind |
| VTG | Track Made Good and Ground Speed |
| VWR | Relative Wind Speed & Angle |
| WCV | Waypoint Closure Velocity |
| WDC | Distance to Waypoint, Great Circle |
| WDR | Distance to Waypoint, Rhumb Line |
| WNC | Distance, Waypoint to Waypoint |
| WPL | Waypoint Location |
| XDR | Transducer Measurement |
| XTE | Cross-Track Error, Measured |
| XTR | Cross-Track Error, Dead Reckoning |
| ZDA | Time & Date |
| ZDL | Time & Distance to Variable Point |
| ZFO | UTC & Time from Origin Waypoint |
| ZTG | UTC & Time to Destination Waypoint |

## List of known Talkers

| Talker ID | Description |
| :---: | :--- |
| AG | Autopilot - General |
| AP | Autopilot - Magnetic |
| CD | Communications - Digital Selective Calling (DSC) |
| CR | Communications - Receiver / Beacon Receiver |,
| CS | Communications - Sattelite |
| CT | Communications - Radio-Telephone (MF/HF) |,
| CV | Communications - Radio-Telephone (VHF) |
| CX | Communications - Scanning Receiver |
| DF | Direction Finder |
| EC | Electronic Chart Display & Information System (ECDIS) |
| EP | Emergency Position Indicating Beacon (EPIRB) |
| ER | Engine Room Monitoring Systems |
| GA | Gallileo |
| GB | BeiDou|
| GL | GLONASS |        
| GP | Global Positioning System (GPS) |
| GN | Mixed satellite fix |
| HC | Heading - Magnetic Compass |
| HE | Heading - North Seeking Gyro |
| HN | Heading - Non North Seeking Gyro |
| II | Integrated instrumentation |
| IN | Integrated Navigation |
| LC | Loran C |
| P | Proprietary Code |
| RA | RADAR and/or ARPA |
| SD | Sounder, Depth |
| SN | Electronic Positioning System, other/general |
| SS | Souder, Scanning |
| TI | Turn Rate Indicator |
| VD | Velocity Sensor, Doppler, other/general |
| DM | Velocity Sensor, Speed Log, Water, Magnetic |
| VW | Velocity Sensor, Speed Log, Water, Mechanical |
| WI | Weather Instruments |
| YX | Transduser |
| ZA | Timekeeper - Atomic Clock |
| ZC | Timekeeper - Chronometer |
| ZQ | Timekeeper - Quartz |
| ZV | Radio Update, WWV or WWVH | 


## Standard sentences examples

### Building & parsing of a HDT sentence (Heading from True North)
```
double shipHeading = 48.123;
string hdt_sentence = NMEAParser.BuildSentence(
   TalkerIdentifiers.GN,    // Talker identifier = GN (GPS + GLONASS)
   SentenceIdentifiers.HDT, // Sentense identifier = HDT (Heading from True North)
   new object[]             // Parameters list
    {
        shipHeading, // Heading value in degrees
        "T"          // T stands for True
    }));
```
after that, ```hdt_sentence``` will has a value ```"$GNHDT,48.123,T*17\r\n"```  
  
To parse new built sentence, one can use following code:
```
// parseResult can be NMEAStandardSentence or NMEAProprietarySentence
// to use it, you have to check type of the result and make a cast
try parseResult = NMEAParser.Parse(hdt_sentence);

if (parseResult is NMEAStandardSentence) // check if it is a standard sentence
{   
   // sentence parameters are stored in 'paramters' field, which is an object[]
   // accoring to HDT sentence format, the first parameter (index = 0) is a double value for heading
   Console.WriteLine(string.Format("Heading: {0:F03}", (parseResult as NMEAStandardSentence).parameters[0]));
}

```

### Building & parsing of a RMC sentence (Recommended minimum, sentence C)
```
double lat = 48.50963056;
double lon = 44.55977778;
double speedKmh = 0.5;

string rmc_sentence = NMEAParser.BuildSentence(
   TalkerIdentifiers.GN,     // Talker identifier = GN (GPS + GLONASS)
   SentenceIdentifiers.RMC,  // Sentence identifier = RMC
   new object[]              // Parameters list
 {
    DateTime.Now,            // UTC time
    "Valid",                 // Time is valid
    lat, "N",                // Position latitude, degrees
    lon, "E",                // Position longitude, degrees
    speedKmh.Value / 0.5144, // Speed
    null,                    // track true  
    DateTime.Now,            // UTC date
    null,                    // magnetic variation
    null,                    // magnetic variation direction
    "D",                     // Positioning system mode indicator, D = differential
});
```

after that, ```rmc_sentence``` will has value ```$GNRMC,233843.698,A,4830.5778,N,04433.5867,E,0.972006,,270719,,,D*6F\r\n```

To parse it, use following code:

```
// parseResult can be NMEAStandardSentence or NMEAProprietarySentence
// to use it, you have to check type of the result and make a cast
try parseResult = NMEAParser.Parse(rmc_sentence);

if (parseResult is NMEAStandardSentence) // check if it is a standard sentence
{   
   // sentence parameters are stored in 'paramters' field, which is an object[]
   var rmcResult = (parseResult as NMEAStandardSentence);
   Console.WriteLine(string.Format("Lat: {0:F06}, Lon: {1:F06}", 
      rmcResult.parameters[2], // latitude value as double
      rmcResult.parameters[4]  // longitude value as double
      // ... etc
   ));    
}
```

### Proprietary sentence definition, building & parsing example

Dealing with proprietary sentences is pretty the same process as with standard ones, except few diffirencies:
First, you should add a description for a sentence. 
Consider we need an ACK sentence, which should has single integer parameter - error code. 

```
NMEAParser.AddManufacturerToProprietarySentencesBase(ManufacturerCodes.UWV); // Add new entry to proprietary sentences descriptor

// message identifier "0", parameters: integer, double, string and a byte array
// parameters go as a string, where items are separated with commas
// x stands for an integer value
// x.x stands for double 
// c--c stands for string
// h--h stands for a hex string or a byte array (e.g. "ff0123aa4d5a")
NMEAParser.AddProprietarySentenceDescription(ManufacturerCodes.UWV, "0", "x,x.x,c--c,h--h");
```

Now we can build and parse sentence $PUWV0 as follows:

```
int int_parameter = 12345;
double double_parameter = 3.1415;
string string_parameter = "this is a string parameter";
byte[] byte_array_parameter = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

var uwv0_sentence = NMEAParser.BuildSentence(
   ManufacturerCodes.UWV, 
   "0", 
   new object[] {
     int_parameter,
     double_parameter,
     string_parameter,
     byte_array_parameter
   });
```

After the call, ```uwv0_sentence``` will has value "```$PUWV0,12345,3.1415,this is a string parameter,0x010203040506070809*51\r\n```"

Parsing this proprietary sentence is as follows:

```
var pResult = NMEAParser.Parse(uwv0_sentence);

if (pResult is NMEAProprietarySentence)
{
   var prop_sentence = (pResult as NMEAProprietarySentence);
   
   // here we can check:
   // Manufacturer identifier, by accessing prop_sentence.Manufacturer
   // Sentence identifier, by accessing prop_sentence.SentenceID
   
   // and all the parameters, as with standard sentences:
   int_parameter = (int)prop_sentence.parameters[0];
   double_parameter = (double)prop_sentence.parameters[1];
   string_parameter = (string)prop_sentence.parameters[2];
   byte_array_parameter = (byte[])prop_sentence.parameters[3];   
}
```
