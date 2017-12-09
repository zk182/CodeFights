bool palindromeRearranging(string inputString) {
    int r=0;
    int i=0;
    char[] myList = new char[inputString.Length];
    foreach(char ch in inputString){
        if (!myList.Contains(ch)){
            r += (inputString.Count(x => x == ch)) % 2 ;
            myList[i] = ch;
            i++;
        }
    }
    return r<=1;
}
