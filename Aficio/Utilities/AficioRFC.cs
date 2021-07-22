namespace Aficio                                          {      
public class RFC_AficioVersion                            {       //Rail Fence Cipher
   public static string Encode(string s, int n)           {       //Encoder(the string, the number of rails)
     string encodedString = string.Empty                  ;          
     if(n >= 2 && s.Length > 0)                           {
       char[,] rawCipher = new char[n , s.Length]         ;
       bool isInverted = false                            ;
       int r = 0, rDirection = -1                         ;        
       for (int c = 0; c < s.Length; c++)                 {         
        if(rDirection == n-1) isInverted = true           ;
        if (rDirection == 0) isInverted = false           ;
        r = isInverted ? --rDirection : ++rDirection      ;
        rawCipher[r, c] = s[c]                            ;}                               
        for (int i = 0; i < n; i++)                       {
          for (int j = 0; j < s.Length; j++)              {
            encodedString += rawCipher[i, j].ToString()    ;}}}
     return encodedString.Replace("\0", string.Empty)     ;}}}
