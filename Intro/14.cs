int[] alternatingSums(int[] a) { 
return new int [] {a.Where((n,index) => index % 2 == 0).Sum(x => x),
                   a.Where((n,index) => index % 2 != 0).Sum(x => x)
                  }
}
