# caesar-cipher-c-sharp
This is a caesar cipher API, containing encrypt, decrypt, and cryptanalyse functions.

### Sample (How to use)
````
String rlt = "";
List<String> rltList = new List<String>( );
// * Test Caesar API

// ** Test Encrypt
String plainText = "I am currently studying Cyber Security module.";
int keyForEncrypt = 16;
rlt = CaesarAPI.encrypt( plainText, keyForEncrypt );
Console.WriteLine( "Test Encrypt" );
Console.WriteLine( rlt );
Console.WriteLine( "" );

// ** Test Decrypt
String cypherText = "Zbydomdsxq kx SD sxpbkcdbemdebo sxmvenoc gsno bkxqo yp kmdsfsdsoc drkd rkfo dy lo zobpybwon sx cixm gsdr okmr ydrob.";
int keyForDecrypt = 10;
rlt = CaesarAPI.decrypt( cypherText, keyForDecrypt );
Console.WriteLine( "Test Decrypt" );
Console.WriteLine( rlt );
Console.WriteLine( "" );

// ** Test Cryptanalysis
String cypherTextForAnalysis = "SHEM veskiui ed iyn cqzeh jxucui.";
rltList = CaesarAPI.cryptanalysis( cypherTextForAnalysis );
Console.WriteLine( "Test Cryptanalysis" );
foreach ( String r in rltList )
{
	Console.WriteLine( r );
}
Console.WriteLine( "" );

Console.ReadLine( );
````
