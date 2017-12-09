int arrayChange(int[] inputArray) {
    int r = 0;
    int ant = inputArray[0];
    for(int i=1;i<inputArray.Length;i++){
        if (inputArray[i]<=ant){
           r += (ant+1)-inputArray[i];
           ant = ant+1;
        }
        else
           ant = inputArray[i];
    }
    return r;
}
