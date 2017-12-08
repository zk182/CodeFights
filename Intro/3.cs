bool checkPalindrome(string inputString) {
    char[] reverse = inputString.ToCharArray();
    Array.Reverse(reverse);
    
    for (int i=0; i<=inputString.Length/2; i++){
        if (inputString[i] != reverse [i])
            return false;
    };
    return true;
}
