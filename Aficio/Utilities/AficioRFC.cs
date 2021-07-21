namespace Aficio                                          {      
public class RFC_AficioVersion                            {       //Rail Fence Cipher
   public static string Encode(string s, int n)           {       //Encoder(the string, the number of rails)
     string encodedString = string.Empty                  ;          
     if(n >= 2 && s.Length > 0)                           {
       char[,] rawCipher = new char[n , s.Length]         ;
       bool isInverted = false                            ;
       int place = 0, r = 0, rI = -1, c = 0               ;       
       while (place < s.Length)                           {
        if(rI == n-1)                                     {
          c++                                             ;
          isInverted = true                               ;}
        if (rI == 0)                                      { 
          c++                                             ; 
          isInverted = false                              ;}        
        r = isInverted ? --rI : ++rI                      ;        
        rawCipher[r, c] = s[place++]                      ;}       
        for (int i = 0; i < n; i++)                        {
          for (int j = 0; j < s.Length; j++)                {
            encodedString += rawCipher[i,j].ToString()     ;}}}
     return encodedString.Replace("\0", string.Empty)     ;}}}
     