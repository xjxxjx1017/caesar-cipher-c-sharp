# caesar-cipher-c-sharp
This is a caesar cipher API, containing encrypt, decrypt, and cryptanalyse functions.

### Sample (How to use)
````

			String rlt = "";
			List<String> rltList = new List<String>( );
			// * Test Caesar API

			// ** Test Encrypt
			String plainText = "I am currently studying Cyber Security module at the Department of Computer Science, University of Waikato.";
			int keyForEncrypt = 16;
			rlt = CaesarAPI.encrypt( plainText, keyForEncrypt );
			Console.WriteLine( "Test Encrypt" );
			Console.WriteLine( rlt );
			Console.WriteLine( "" );

			// ** Test Decrypt
			String cypherText = "Zbydomdsxq kx SD sxpbkcdbemdebo sxmvenoc gsno bkxqo yp kmdsfsdsoc drkd rkfo dy lo zobpybwon sx cixm gsdr okmr ydrob. Sxd rsc vomdebo, go ohzvybo dro lkcsmc yp lesvnsxq kx SD cicdow drkd sc cdboxqdroxon dy lo k comebo. Dro cdboxqdroxsxq zbymocc boaesboc rkbnoxsxq nsppoboxd mywzyxoxdc yp dro SD sxpbkcdbemdebo sxmvensxq Yzobkdsxq Cicdowc, Xodgybuc kxn Kzzvsmkdsyxc.";
			int keyForDecrypt = 10;
			rlt = CaesarAPI.decrypt( cypherText, keyForDecrypt );
			Console.WriteLine( "Test Decrypt" );
			Console.WriteLine( rlt );
			Console.WriteLine( "" );

			// ** Test Cryptanalysis
			String cypherTextForAnalysis = "SHEM veskiui ed iyn cqzeh jxucui: Fheludqdsu, Kiuh-Sudjhysyjo, Lyikqbyiqjyed, Usedecysi, Xqhtmqhu, qdt Jeebi & Tqjqiuji. Jewujxuh, jxuiu iyn jxucui udqrbu jxu hujkhd ev sedjheb ev tqjq je kiuhi, jxuhuro hutksydw hubyqdsu ed jxyht-fqhjo ludtehi eh jhkij hubqjyedixyfi seccedbo vekdt yd ceij soruh iuskhyjo sedjhqsji jetqo.";
			rltList = CaesarAPI.cryptanalysis( cypherTextForAnalysis );
			Console.WriteLine( "Test Cryptanalysis" );
			foreach ( String r in rltList )
			{
				Console.WriteLine( r );
			}
			Console.WriteLine( "" );

			Console.ReadLine( );
			````
