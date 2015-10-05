using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar
{
    class CaesarAPI
    {
		// Sample input:
        // I am currently studying Cyber Security module.
        // 16
        static public String encrypt( String plaintext, int key )
        {
			if ( key < 0 )
				return null;
            String rlt = "";
			Char[] charArray = plaintext.ToCharArray( );
			// Loop through the string, encrypt each character
			for ( int i = 0; i < plaintext.Length; i++ )
			{
				int c = charArray[i];
				// Lower case characters
				if ( c >= 'a' && c <= 'z' )
				{
					// Encrypt by offset (key)
					c = c + ( key % 26 );
					// Check boundary
					if ( c > 'z' )
						c = c - 26;
				}
				// Higher case characters
				else if ( c >= 'A' && c <= 'Z' )
				{
					// Encrypt by offset (key)
					c = c + ( key % 26 );
					// Check boundary
					if ( c > 'Z' )
						c = c - 26;
				}
				// Other signs
				else { }
				rlt += (char) c;
			}
            return rlt;
        }

		// Sample input:
        // Zbydomdsxq kx SD.
        // 10
		static public String decrypt( String ciphertext, int key )
		{
			if ( key < 0 )
				return null;
            String rlt = "";
			Char[] charArray = ciphertext.ToCharArray( );
			// Loop through the string, decrypt each character
			for ( int i = 0; i < ciphertext.Length; i++ )
			{
				int c = charArray[i];
				// Lower case characters
				if ( c >= 'a' && c <= 'z' )
				{
					// Decrypt by offset (key)
					c = c - ( key % 26 );
					// Check boundary
					if ( c < 'a' )
						c = c + 26;
				}
				// Higher case characters
				else if ( c >= 'A' && c <= 'Z' )
				{
					// Decrypt by offset (key)
					c = c - ( key % 26 );
					// Check boundary
					if ( c < 'A' )
						c = c + 26;
				}
				// Other signs
				else { }
				rlt += (char) c;
			}

            return rlt;
        }

		// Sample input:
        // SHEM veskiui.
		static public List<String> cryptanalysis( String ciphertext )
        {
			List<String> rlt = new List<String>( );
			// Loop through all the possible keys
			for ( int i = 0; i < 26; i++ )
			{
				rlt.Add( decrypt( ciphertext, i ) );
			}
            return rlt;
        }
    }
}
