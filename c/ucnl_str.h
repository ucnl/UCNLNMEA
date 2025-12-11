/*
Copyright (C) 2017-25, Underwater communication & navigation laboratory
All rights reserved.

www.unavlab.com
hello@unavlab.com
*/


#ifndef _UCNL_STR_
#define _UCNL_STR_

#include "stdint.h"
#include "stdbool.h"

#define STR_HEXDIGIT2B(b)     ((b) >= 0x41 ? ((b) - 0x37) : ((b) - 0x30))
#define STR_DIGIT_2HEX(h)     ((h) > 9     ? ((h) + 0x37) : ((h) + 0x30))

#define STR_C2B(b)            ((b - '0'))
#define STR_CC2B(b1, b2)      ((10 * (b1 - '0') + (b2 - '0')))
#define STR_CCC2B(b1, b2, b3) ((100 * (b1 - '0') + 10 * (b2 - '0') + (b3 - '0')))

#define STR_HEX_ARRAY_PFX     ((uint8_t*)"0x\0")

void STR_WriterInit(uint8_t* buffer, uint8_t* srcIdx, uint8_t bufferSize);
void STR_WriteByte(uint8_t* buffer, uint8_t* srcIdx, uint8_t c);
void STR_WriteUIntDec(uint8_t* buffer, uint8_t* srcIdx, uint32_t src, uint8_t zPad);
void STR_WriteIntDec(uint8_t* buffer, uint8_t* srcIdx, int32_t src, uint8_t zPad);
void STR_WriteFloat(uint8_t* buffer, uint8_t* srcIdx, float f, uint8_t dPlaces, uint8_t zPad);
void STR_WriteHexByte(uint8_t* buffer, uint8_t* srcIdx, uint8_t c);
void STR_WriteHexArray(uint8_t* buffer, uint8_t* srcIdx, uint8_t* src, uint8_t srcSize);
void STR_WriteHexStr(uint8_t* buffer, uint8_t* srcIdx, uint8_t* src, uint8_t srcSize);
void STR_WriteStr(uint8_t* buffer, uint8_t* srcIdx, uint8_t* src);

float STR_ParseFloat(const uint8_t* buffer, uint8_t stIdx, uint8_t ndIdx);
int32_t STR_ParseIntDec(const uint8_t* buffer, uint8_t stIdx, uint8_t ndIdx);
uint8_t STR_ParseHexByte(const uint8_t* buffer, uint8_t stIdx);
int16_t STR_ReadHexStr(const uint8_t* buffer, uint8_t stIdx, uint8_t ndIdx, uint8_t* out_buffer, uint8_t out_buffer_size, uint8_t* out_size);
void  STR_ReadString(const uint8_t* src_buffer, uint8_t* dst_buffer, uint8_t* uint8_tsRead, uint8_t stIdx, uint8_t ndIdx);

#endif
