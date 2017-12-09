bool almostIncreasingSequence(int[] sequence) {
    double prev = Math.Pow(-10, 5);    
    double preprev = Math.Pow(-10, 5);    
    int count = 0;
    foreach (int item in sequence){
        if (prev >= item) {
            if (count == 1) return false;
            else {
                count++;
                if (preprev<item){
                    prev = item;
                }
            }
        }
        else{
            preprev = prev;            
            prev = item;
        }
    }
    return true;
}
