namespace Aficio                                                        {            
    public static class AficioFinder                                    {
        public static string GetMissingLetters(this string value)       {
            const int EN_ALPHA_MAX = 26                                 ;
            bool[] isContained = new bool[EN_ALPHA_MAX]                 ;
            string missingLetters = null                                ;
            int beginWith = value[0]                                    ;
            int endsWith = value[value.Length - 1]                      ;
            for (int i = 0; i < value.Length; i++)                      {
                if ('A' <= value[i] && value[i] <= 'Z')                 {
                    isContained[value[i] - 'A'] = true                  ;}
                else if ('a' <= value[i] && value[i] <= 'z')            {
                    isContained[value[i] - 'a'] = true                  ;}
                beginWith = beginWith < value[i] ? beginWith : value[i] ;
                endsWith = endsWith > value[i] ? endsWith : value[i]    ;}
            for (int i = 0; i < EN_ALPHA_MAX; i++)                      {
                if (false == isContained[i] && 
                    (char)(i + 'a') >= (char)beginWith && 
                    (char)(i + 'a') <= (char)endsWith)                  {
                    missingLetters += (char)(i + 'a')                   ;}}
            return missingLetters ?? "NO MISSING LETTER"                ;}}}
