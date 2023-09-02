//Biblioteca de funciones para el ejercicio p12-numeros-arreglo

public static class biblioteca {
  public static string Imprime1(double[] a) {
    return String.Join(",",a);
  }
   public static double Suma1(double[] a) {
    double suma=0;
    foreach(double elementos in a)
      suma += elementos;
    return suma;
  }
  public static double Suma2(double[] a) {
    double suma=0;
    foreach(double elementos in a)
      suma += elementos/2;
    return suma;
  }
  public static double Imprime2(double[] a) {
    double m=a.Length;
    foreach(double elementos in a)
       m=elementos;
       if(a.Length!=0)
        m=a.Length-1;
       return m;
  }
}

//return String.Join(",",a);