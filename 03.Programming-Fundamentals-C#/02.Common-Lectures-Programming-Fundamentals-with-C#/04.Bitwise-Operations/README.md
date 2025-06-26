# 🧮 Bits and Bitwise Operations

## 📖 Overview
This document covers the fundamental concepts of **bits**, **numeral systems**, and **bitwise operations**. You will learn how data is represented in computer memory, how bitwise operators work, and why they are essential for low-level programming and communication protocols.

---

## 📑 Table of Contents
1. What is a Bit, Byte, KB, MB?  
2. Numeral Systems  
3. Data Representation in Computer Memory  
4. Bitwise Operations: `&`, `|`, `^`, `~` and Bit Shifts  
5. Why Bitwise Operations Matter  
6. Summary  

---

## 1️⃣ What is a Bit, Byte, KB, MB?

- **Bit**  
  The smallest unit of data in computing, which can be either `0` or `1`.  
  Represents:  
  - Logical values (true/false)  
  - Algebraic signs (+/-)  
  - Activation states (on/off)  

- **Byte (Octet)**  
  A group of 8 bits — the smallest addressable unit in computer memory.

- **Data Size Units:**  
  - KB (Kilobyte) = 1024 bytes  
  - MB (Megabyte) = 1024 KB  
  - GB (Gigabyte) = 1024 MB  
  - TB (Terabyte) = 1024 GB  
  - PB (Petabyte) = 1024 TB  

---

## 2️⃣ Numeral Systems

- **Decimal (Base 10)**  
  Uses digits `0-9`. Each digit’s value depends on its position (powers of 10).  

- **Binary (Base 2)**  
  Uses digits `0` and `1`. The language of computers. Each digit represents a power of 2.  

- **Hexadecimal (Base 16)**  
  Uses digits `0-9` and letters `A-F`. Commonly prefixed with `0x`. Each digit represents a power of 16.

### 🔄 Conversion Examples
- **Binary to Decimal:** Multiply each bit by powers of 2 and sum.  
- **Decimal to Binary:** Divide by 2 repeatedly; collect remainders in reverse order.  
- **Hex to Decimal:** Multiply each digit by powers of 16 and sum.  
- **Decimal to Hex:** Divide by 16 repeatedly; collect remainders in reverse order.  
- **Binary to Hex:** Group bits into sets of 4; convert each to a hex digit.

---

## 3️⃣ Data Representation in Computer Memory

### Integers
- Stored as sequences of bits.  
- Can be **signed** (with a sign bit) or **unsigned**.  
- The Most Significant Bit (MSB) indicates the sign:  
  - `0` means positive  
  - `1` means negative (two’s complement form)

### Real Numbers (Floating-Point)
- Follow the **IEEE 754** standard.  
- Stored as sign bit, exponent, and mantissa.  
- Some decimal numbers (e.g., 0.3) cannot be represented exactly.

### Text
- Stored as unsigned integers representing characters.  
- **ASCII:** 8-bit encoding for 127 characters.  
- **Unicode:** Over 100,000 characters, supporting many alphabets.  
  - UTF-16 uses 2 bytes per character.  
  - UTF-8 uses 1 to 4 bytes per character.

### Strings
- Arrays of characters.  
- Can be **length-prefixed** or **null-terminated** (`\0`).  
- Use UTF-16 (e.g., C#, Java, JavaScript) or 8-bit encodings (e.g., C, C++).

---

## 4️⃣ Bitwise Operations: `&`, `|`, `^`, `~` and Bit Shifts

### Bitwise Operators
- Work on the binary representation of numbers, bit by bit.  
- `~` (NOT): flips all bits (0 → 1, 1 → 0).  
- `&` (AND), `|` (OR), `^` (XOR): perform logical operations bitwise.

| Operand1 | 0 | 0 | 1 | 1 | 0 | 0 | 1 | 1 |  
| -------- |---|---|---|---|---|---|---|---|  
| Operand2 | 0 | 1 | 0 | 1 | 0 | 1 | 0 | 1 |  
| Result & | 0 | 1 | 1 | 1 | 0 | 0 | 0 | 1 |  

### Bit Shifts
- Shift bits left (`<<`) or right (`>>`).  
- Bits shifted out are lost; zeros shifted in.

### Getting the Last Bit
```js
let lastBit = n & 1; // Extracts the rightmost bit of n
```

---

## 5️⃣ Why Bitwise Operations Matter

- Network protocols rely on bit-level flags (e.g., TCP SYN flag).  
- Browsers use bitwise operations to manage connections.  
- Binary file formats save space by encoding data as bits (e.g., PNG images).  
- Data compression algorithms (e.g., DEFLATE in ZIP) operate on bits.

---

## ✅ Summary

- Data in computers is stored using bits.  
- Signed integers use the leftmost bit as a sign.  
- Floating-point numbers follow IEEE-754.  
- Text uses ASCII and Unicode standards.  
- Binary and hexadecimal systems are fundamental to computing.  
- Bitwise operations allow efficient manipulation of data at the bit level.

---

> Made with ❤️ for anyone who loves low-level programming and computer fundamentals!
