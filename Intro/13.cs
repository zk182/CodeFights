string reverseParentheses(string s) {
    string s1,s2;
    while(s.Contains("(")){
        
        //Gets inner '( )'
        s1 = s.Substring(s.LastIndexOf('('),(s.IndexOf(')',s.LastIndexOf('('))+1)-(s.LastIndexOf('(')));
        //Reverses the data inside inner '( )'
        s2 = new string (s.Substring(s.LastIndexOf('(')+1,(s.IndexOf(')',s.LastIndexOf('('))-1)-(s.LastIndexOf('('))).ToCharArray().Reverse().ToArray());
        //Replaces the string
        s = s.Replace(s1,s2);
    }
    return s;
}