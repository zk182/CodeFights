int adjacentElementsProduct(int[] inputArray) {
    var resu = -2001;
    for (int i=0; i<inputArray.Length-1;i++){
        if (inputArray[i]*inputArray[i+1] > resu)
            resu = inputArray[i]*inputArray[i+1];
    }
    return resu;
}
