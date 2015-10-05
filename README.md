# caesar-cipher-c-sharp
This is a **caesar cipher API**, containing encrypt, decrypt, and cryptanalyse functions.<br>
A [**Caesar cipher**](https://en.wikipedia.org/wiki/Caesar_cipher) is a type of substitution cipher in which each letter in the plaintext is replaced by a letter some fixed number of positions down the alphabet.
### Sample (How to use)
````
String rlt = "";
List<String> rltList = new List<String>( );

// ** Test Encrypt
String plainText = "I am currently studying Cyber Security module.";
int keyForEncrypt = 16;
rlt = CaesarAPI.encrypt( plainText, keyForEncrypt );

// ** Test Decrypt
String cypherText = "Zbydomdsxq kx SD.";
int keyForDecrypt = 10;
rlt = CaesarAPI.decrypt( cypherText, keyForDecrypt );

// ** Test Cryptanalysis
String cypherTextForAnalysis = "SHEM veskiui ed iyn cqzeh jxucui.";
rltList = CaesarAPI.cryptanalysis( cypherTextForAnalysis );
````
