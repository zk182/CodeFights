bool isLucky(int n) {
    string number = n.ToString();
    if (number.Length % 2 == 0){
        int s1=0,s2=0;
        for (int i=0;i<=(number.Length/2)-1;i++){
            s1+=number[i];
        }
        for (int j=number.Length/2;j<number.Length && s2<=s1;j++){
            s2+=number[j];
        }
        return s1 == s2;
    }
    return false;
}
