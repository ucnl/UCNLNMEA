/*
Copyright (C) 2017-23, Underwater communication & navigation laboratory
All rights reserved.

www.unavlab.com
hello@unavlab.com
*/


#ifndef _UCNL_NMEA_
#define _UCNL_NMEA_

#include "stdint.h"
#include "stdbool.h"

#define NMEA_SNT_STR              '$'
#define NMEA_SNT_END              '\n'
#define NMEA_SNT_END1             '\r'
#define NMEA_PAR_SEP              ','
#define NMEA_CHK_SEP              '*'
#define NMEA_SNT_PFX              (uint8_t*)"*00\r\n\0"

#define NMEA_DATA_NOT_VALID       'V'
#define NMEA_SOUTH_SIGN           'S'
#define NMEA_WEST_SIGN            'W'
#define NMEA_TD_VALID             'A'
#define NMEA_PSENTENCE_SYMBOL     'P'
#define NMEA_PMODE_DATA_NOT_VALID 'N'

#define NMEA_MIN_LEN              (8)

#define GSA_PRNS_NUM              (12)
#define GSV_SATS_NUM              (4)

typedef struct {
  uint8_t* buffer;
  uint8_t  buffer_size;
  uint8_t  idx;
  bool  isReady;
  bool  isStarted;
  bool  isPSentence;
  uint8_t  chk_act;
  uint8_t  chk_dcl;
  uint8_t  chk_dcl_idx;
  bool  chk_present;
  uint16_t  tkrID;
  uint32_t  sntID;
  uint32_t* sntIDs;
  uint8_t  sntIDs_size;

} NMEA_State_Struct;

typedef enum {
  NMEA_RESULT_PACKET_READY          = 0,
  NMEA_RESULT_BYPASS_BYTE           = 1,
  NMEA_RESULT_PACKET_STARTED        = 2,
  NMEA_RESULT_PACKET_PROCESS        = 3,
  NMEA_RESULT_PACKET_CHECKSUM_ERROR = 4,
  NMEA_RESULT_PACKET_TOO_BIG        = 5,
  NMEA_RESULT_PACKET_SKIPPING       = 6,
  NMEA_RESULT_UNKNOWN
} NMEA_Result_Enum;

typedef enum {
  GGA_QTY_NO_FIX              = 0,
  GGA_QTY_SINGLE_POINT        = 1,
  GGA_QTY_PRANGE_DIFFERENTIAL = 2,
  GGA_QTY_RTK_FIXED           = 4,
  GGA_QTY_RTK_FLOATING        = 5,
  GGA_QTY_DEAD_RECKONING      = 6,
  GGA_QTY_MANUAL              = 7,
  GGA_QTY_SIMULATOR           = 8,
  GGA_QTY_WAAS_SBAS           = 9,
  GGA_QTY_UNKNOWN
} NMEA_GGA_QTY_IND_Enum;

typedef enum {
  NMEA_PSMODE_AUTONOMOUS     = 'A',
  NMEA_PSMODE_DIFFERENTIAL   = 'D',
  NMEA_PSMODE_DEAD_RECKONING = 'E',
  NMEA_PSMODE_MANUAL         = 'M',
  NMEA_PSMODE_INVALID        = 'N',
  NMEA_PSMODE_UNKNOWN
} NMEA_PSMODE_IND_Enum;

// Standard known sentences result structures
typedef struct {
  bool isValid;
  uint8_t hour;
  uint8_t minute;
  float second;
  uint8_t date;
  uint8_t month;
  uint8_t year;
  float latitude_deg;
  float longitude_deg;
  float speed_kmh;
  float course_deg;
} NMEA_RMC_RESULT_Struct;

typedef struct {
  bool isValid;
  uint8_t hour;
  uint8_t minute;
  float second;
  float latitude_deg;
  float longitude_deg;
  float hdop;
  float gsep;
  float dgps_rec_age;
  uint8_t sats_in_use;
  uint8_t gnss_qly_ind;
  float orth_height;
  uint8_t datumID;
} NMEA_GGA_RESULT_Struct;

typedef struct {
  bool isValid;
  uint8_t hour;
  uint8_t minute;
  float second;
  float latitude_deg;
  float longitude_deg;
} NMEA_GLL_RESULT_Struct;

typedef struct {
  bool isValid;
  uint8_t mode;
  uint8_t fix_type;
  uint8_t prns[GSA_PRNS_NUM];
  float pdop;
  float hdop;
  float vdop;
  uint8_t systemID;
} NMEA_GSA_RESULT_Struct;

typedef struct {
  bool isValid;
  uint8_t total_messages;
  uint8_t current_message;
  uint8_t sats_in_view;

  int16_t PRNNumbers[GSV_SATS_NUM];
  int16_t Elevations[GSV_SATS_NUM];
  int16_t Azimuths[GSV_SATS_NUM];
  int16_t SNRs[GSV_SATS_NUM];

  uint8_t satDataNum;

} NMEA_GSV_RESULT_Struct;

typedef struct {
  bool isValid;
  float track_true_deg;
  bool is_magnetic;
  float track_magnetic_deg;
  float speed_knots;
  float speed_kmh;
} NMEA_VTG_RESULT_Struct;

typedef struct {
  bool isValid;
  float track_true_deg;
} NMEA_HDT_RESULT_Struct;

typedef struct {
  bool isValid;
  float magnetic_heading_deg;
  bool is_magnetic_variation;
  float magnetic_variation;
} NMEA_HDG_RESULT_Struct;

typedef struct {
  bool isValid;
  uint8_t hour;
  uint8_t minute;
  float second;
  uint8_t day; // 01..31
  uint8_t month;
  uint16_t year; // 4-digit
  int16_t t_zone_offset_hours; // +/- 13 hours
  uint8_t t_zone_offset_minutes; // 0..59
} NMEA_ZDA_RESULT_Struct;

typedef struct {
  bool isValid;
  float mean_water_temperature_c;
} NMEA_MTW_RESULT_Struct;


#define NMEA_RMC_SNT_ID (0x524D43)
#define NMEA_GGA_SNT_ID (0x474741)
#define NMEA_GLL_SNT_ID (0x474C4C)
#define NMEA_GSA_SNT_ID (0x475341)
#define NMEA_GSV_SNT_ID (0x475356)
#define NMEA_VTG_SNT_ID (0x565447)
#define NMEA_HDT_SNT_ID (0x484454)
#define NMEA_HDG_SNT_ID (0x484447)
#define NMEA_ZDA_SNT_ID (0x5A4441)
#define NMEA_MTW_SNT_ID (0x4D5457)

#define NMEA_IS_VALID_DATE(b)    (((b) >= 1) && ((b) <= 31))
#define NMEA_IS_VALID_MONTH(b)   (((b) >= 1) && ((b) <= 12))
#define NMEA_IS_VALID_YEAR(b)    (((b) >= 0) && ((b) <= 99))
#define NMEA_IS_VALID_HOUR(b)    (((b) >= 0) && ((b) <= 23))
#define NMEA_IS_VALID_MINSEC(b)  (((b) >= 0) && ((b) < 60))
#define NMEA_IS_VALID_LATDEG(l)  (((l) >= -90) && ((l) <= 90))
#define NMEA_IS_VALID_LONDEG(l)  (((l) >= -180) && ((l) <= 180))


void NMEA_InitStruct(NMEA_State_Struct* uState, uint8_t* buffer, uint8_t buffer_size, uint32_t* sntIDs, uint8_t sntIDs_size);
void NMEA_Release(NMEA_State_Struct* uState);

NMEA_Result_Enum NMEA_Process_Byte(NMEA_State_Struct* uState, uint8_t newByte);
bool             NMEA_Get_NextParam(const uint8_t* buffer, uint8_t fromIdx, uint8_t size, uint8_t* stIdx, uint8_t* ndIdx);
void             NMEA_CheckSum_Update(uint8_t* buffer, uint8_t size);

// Standard parsers
bool             NMEA_Parse_RMC(NMEA_RMC_RESULT_Struct* rdata, const uint8_t* buffer, uint8_t idx);
bool             NMEA_Parse_GGA(NMEA_GGA_RESULT_Struct* rdata, const uint8_t* buffer, uint8_t idx);
bool             NMEA_Parse_GLL(NMEA_GLL_RESULT_Struct* rdata, const uint8_t* buffer, uint8_t idx);
bool             NMEA_Parse_VTG(NMEA_VTG_RESULT_Struct* rdata, const uint8_t* buffer, uint8_t idx);
bool             NMEA_Parse_HDT(NMEA_HDT_RESULT_Struct* rdata, const uint8_t* buffer, uint8_t idx);
bool             NMEA_Parse_HDG(NMEA_HDG_RESULT_Struct* rdata, const uint8_t* buffer, uint8_t idx);
bool             NMEA_Parse_MTW(NMEA_MTW_RESULT_Struct* rdata, const uint8_t* buffer, uint8_t idx);
bool             NMEA_Parse_GSA(NMEA_GSA_RESULT_Struct* rdata, const uint8_t* buffer, uint8_t idx);
bool             NMEA_Parse_GSV(NMEA_GSV_RESULT_Struct* rdata, const uint8_t* buffer, uint8_t idx);
bool             NMEA_Parse_ZDA(NMEA_ZDA_RESULT_Struct* rdata, const uint8_t* buffer, uint8_t idx);

#endif
