# UCNLNMEA
## NMEA 0183 protocol support library

> This repository is a supported version of a library I posted back in 2011 at [CodeProject](https://www.codeproject.com/Articles/279647/NMEA-0183-sentence-parser-builder)

The library is able to parse and build any NMEA0183-sentences. Common used standard sentences are supported 'from the box'.
The parser/builder is made as a static class.  
To use it, just:  
* Add UCNLNMEA to your project's references list.
* Add a propriate using declaration: ```using UCNLNMEA;```

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
    lat, "North",            // Position latitude, degrees
    lon, "East",             // Position longitude, degrees
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
