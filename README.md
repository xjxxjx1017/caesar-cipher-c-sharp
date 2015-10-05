# caesar-cipher-c-sharp
This is a **caesar cipher API**, containing encrypt, decrypt, and cryptanalyse functions.<br>
A [**Caesar cipher**](https://en.wikipedia.org/wiki/Caesar_cipher) is a type of substitution cipher in which each letter in the plaintext is replaced by a letter some fixed number of positions down the alphabet.
### Sample (How to use)
````
// ** Test Encrypt
String rlt1 = CaesarAPI.encrypt( "I am currently studying Cyber Security module.", 16 );

// ** Test Decrypt
String rlt2 = CaesarAPI.decrypt( "Zbydomdsxq kx SD.", 10 );

// ** Test Cryptanalysis
List<String> rltList = CaesarAPI.cryptanalysis( "SHEM veskiui ed iyn cqzeh jxucui." );
````
