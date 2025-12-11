/*
Copyright (C) 2017-25, Underwater communication & navigation laboratory
All rights reserved.

www.unavlab.com
hello@unavlab.com
*/

#include "ucnl_str.h"

void STR_WriterInit(uint8_t* buffer, uint8_t* srcIdx, uint8_t bufferSize) {
  if (!buffer || !srcIdx) return;

  *srcIdx = 0;
  uint8_t i;
  for (i = 0; i < bufferSize; i++)
    buffer[i] = 0;
}

void STR_WriteByte(uint8_t* buffer, uint8_t* srcIdx, uint8_t c) {
  if (!buffer || !srcIdx) return;
  buffer[*srcIdx] = c;
  (*srcIdx)++;
}

void STR_WriteIntDec(uint8_t* buffer, uint8_t* srcIdx, int32_t src, uint8_t zPad) {
  if (!buffer || !srcIdx) return;

  // Обработка специального случая: ноль
  if (src == 0) {
    STR_WriteByte(buffer, srcIdx, '0');
    return;
  }

  // Обработка отрицательных чисел
  if (src < 0) {
    STR_WriteByte(buffer, srcIdx, '-');
    src = -src;
  }

  // Вычисляем длину числа и степени 10
  int32_t temp = src;
  uint8_t len = 0;
  int32_t divisor = 1;

  while (temp > 0) {
    len++;
    temp /= 10;
    if (temp > 0) divisor *= 10;
  }

  // Определяем общее количество цифр для вывода
  uint8_t totalDigits = (zPad > 0 && zPad > len) ? zPad : len;

  // Выводим ведущие нули и цифры
  uint8_t i;
  for (i = 0; i < totalDigits; i++) {
    if (i < (totalDigits - len)) {
      STR_WriteByte(buffer, srcIdx, '0');
    } else {
      uint8_t digit = (uint8_t)(src / divisor);
      STR_WriteByte(buffer, srcIdx, (uint8_t)('0' + digit));
      src -= digit * divisor;
      divisor /= 10;
    }
  }
}

void STR_WriteFloat(uint8_t* buffer, uint8_t* srcIdx, float f, uint8_t dPlaces, uint8_t zPad) {
  if (!buffer || !srcIdx) return;

  // Ограничиваем количество знаков после запятой
  if (dPlaces > 10) dPlaces = 10;

  // Обработка отрицательных чисел
  if (f < 0) {
    STR_WriteByte(buffer, srcIdx, '-');
    f = -f;
  }

  // Извлекаем целую и дробную части
  int32_t integerPart = (int32_t)f;
  float fractional = f - (float)integerPart;

  // Вычисляем множитель для дробной части
  int64_t multiplier = 1;
  uint8_t i;
  for (i = 0; i < dPlaces; i++) {
    multiplier *= 10;
  }

  int32_t fractionalPart = (int32_t)(fractional * (float)multiplier + 0.5f); // Округление

  // Проверка на переполнение при округлении
  if (fractionalPart >= multiplier) {
    integerPart++;
    fractionalPart = 0;
  }

  // Выводим целую часть
  STR_WriteIntDec(buffer, srcIdx, integerPart, zPad);

  // Выводим дробную часть, если нужно
  if (dPlaces > 0) {
    STR_WriteByte(buffer, srcIdx, '.');
    STR_WriteIntDec(buffer, srcIdx, fractionalPart, dPlaces);
  }
}

void STR_WriteStr(uint8_t* buffer, uint8_t* srcIdx, uint8_t* src) {
  if (!buffer || !srcIdx || !src) return;

  uint8_t c;
  while ((c = *src++) != '\0') {
    STR_WriteByte(buffer, srcIdx, c);
  }
}

void STR_WriteHexByte(uint8_t* buffer, uint8_t* srcIdx, uint8_t c) {
  if (!buffer || !srcIdx) return;

  buffer[*srcIdx] = STR_DIGIT_2HEX((c >> 4) & 0x0F);
  (*srcIdx)++;
  buffer[*srcIdx] = STR_DIGIT_2HEX(c & 0x0F);
  (*srcIdx)++;
}

void STR_WriteHexArray(uint8_t* buffer, uint8_t* srcIdx, uint8_t* src, uint8_t srcSize) {
  if (!buffer || !srcIdx || !src) return;

  STR_WriteStr(buffer, srcIdx, (uint8_t*)STR_HEX_ARRAY_PFX);
  uint8_t i;
  for (i = 0; i < srcSize; i++)
    STR_WriteHexByte(buffer, srcIdx, src[i]);
}

void STR_WriteHexStr(uint8_t* buffer, uint8_t* srcIdx, uint8_t* src, uint8_t srcSize) {
  if (!buffer || !srcIdx || !src) return;

  uint8_t i;
  for (i = 0; i < srcSize; i++)
    STR_WriteHexByte(buffer, srcIdx, src[i]);
}

float STR_ParseFloat(const uint8_t* buffer, uint8_t stIdx, uint8_t ndIdx) {
  if (!buffer || stIdx > ndIdx) return 0.0f;

  float sign = 1.0f;
  int32_t dotIdx = -1;

  // Определяем знак и находим позицию точки
  uint8_t currentIdx = stIdx;
  if (buffer[currentIdx] == '-') {
    sign = -1.0f;
    currentIdx++;
  }

  // Ищем десятичную точку
  uint8_t i;
  for (i = currentIdx; i <= ndIdx; i++) {
    if (buffer[i] == '.') {
      dotIdx = i;
      break;
    }
  }

  // Если точка не найдена, парсим как целое число
  if (dotIdx == -1) {
    return (float)STR_ParseIntDec(buffer, stIdx, ndIdx);
  }

  // Парсим целую часть
  float integerPart = 0.0f;
  float multiplier = 1.0f;
  for (i = dotIdx - 1; i >= (int32_t)currentIdx; i--) {
    if (buffer[i] >= '0' && buffer[i] <= '9') {
      integerPart += (float)(buffer[i] - '0') * multiplier;
      multiplier *= 10.0f;
    }
  }

  // Парсим дробную часть
  float fractionalPart = 0.0f;
  multiplier = 0.1f;
  for (i = dotIdx + 1; i <= ndIdx; i++) {
    if (buffer[i] >= '0' && buffer[i] <= '9') {
      fractionalPart += (float)(buffer[i] - '0') * multiplier;
      multiplier *= 0.1f;
    }
  }

  return (integerPart + fractionalPart) * sign;
}

int32_t STR_ParseIntDec(const uint8_t* buffer, uint8_t stIdx, uint8_t ndIdx) {
  if (!buffer || stIdx > ndIdx) return 0;

  int32_t sign = 1;
  uint8_t currentIdx = stIdx;

  if (buffer[currentIdx] == '-') {
    sign = -1;
    currentIdx++;
  }

  int32_t result = 0;
  int32_t multiplier = 1;

  // Проходим от конца к началу для правильного вычисления разрядов
  uint8_t i;
  for (i = ndIdx; i >= currentIdx; i--) {
    if (buffer[i] >= '0' && buffer[i] <= '9') {
      result += (buffer[i] - '0') * multiplier;
      multiplier *= 10;
    }
  }

  return result * sign;
}

uint8_t STR_ParseHexByte(const uint8_t* buffer, uint8_t stIdx) {
  if (!buffer) return 0;

  uint8_t highNibble = STR_HEXDIGIT2B(buffer[stIdx]);
  uint8_t lowNibble = STR_HEXDIGIT2B(buffer[stIdx + 1]);
  return (highNibble << 4) | lowNibble;
}

int16_t STR_ReadHexStr(const uint8_t* buffer, uint8_t stIdx, uint8_t ndIdx,
                      uint8_t* out_buffer, uint8_t out_buffer_size, uint8_t* out_size) {
  if (!buffer || !out_buffer || !out_size) return -1;

  // Проверяем корректность индексов
  if (stIdx > ndIdx) return 1;

  // Вычисляем количество hex символов
  uint16_t hexCharsCount = ndIdx - stIdx + 1;

  // Проверяем префикс "0x"
  if (hexCharsCount < 2 || buffer[stIdx] != '0' || buffer[stIdx + 1] != 'x') {
    return 2;
  }

  // Проверяем, что количество hex символов после префикса четное
  uint16_t dataHexChars = hexCharsCount - 2;
  if (dataHexChars % 2 != 0) {
    return 3;
  }

  // Вычисляем количество байт
  *out_size = dataHexChars / 2;

  // Проверяем, что выходной буфер достаточно большой
  if (*out_size > out_buffer_size) {
    return 4;
  }

  // Парсим hex данные
  uint8_t i;
  for (i = 0; i < *out_size; i++) {
    uint8_t hexPos = stIdx + 2 + i * 2;
    out_buffer[i] = STR_ParseHexByte(buffer, hexPos);
  }

  return 0;
}

void STR_ReadString(const uint8_t* src_buffer, uint8_t* dst_buffer, uint8_t* bytesRead,
                   uint8_t stIdx, uint8_t ndIdx) {
  if (!src_buffer || !dst_buffer || !bytesRead || stIdx > ndIdx) {
    if (bytesRead) *bytesRead = 0;
    return;
  }

  *bytesRead = 0;
  uint8_t i;
  for (i = stIdx; i <= ndIdx; i++) {
    dst_buffer[i - stIdx] = src_buffer[i];
    (*bytesRead)++;
  }
}
