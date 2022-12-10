namespace Lab02_Recursividad;
class Program
{
     static int FibonacciRecursivo(int n){
        if(n < 2){
            return n;
        }else{
            return FibonacciRecursivo(n-2)+FibonacciRecursivo(n-1);
        }
    }
    static void FibonacciIterativo(int n){
        int i;
     int ant1=1,ant2=1;
        Console.Write("0 1 1 ");
        for(i = 1;i < (n-2);i++){
         int actual = ant1 + ant2;
            Console.Write(actual+" ");
            ant2 = ant1;
            ant1 = actual;
        }
    }
    static void Main(string[] args)
    {
        int n,k;
        do{
            Console.WriteLine("Introduzca el número de términos");
            n = Convert.ToInt32(Console.ReadLine());
        }while(n <= 1);
        
        Console.WriteLine("Serie numeros de fibonacci recursivo: ");
        DateTime start1 = DateTime.Now;
        for(k = 0; k < n; k++){
            Console.Write(FibonacciRecursivo(k)+" ");
        }
        DateTime end1 = DateTime.Now;
        TimeSpan ts1 = (end1 - start1);
        Console.WriteLine("Tiempo de ejecucion recursivo {0} ms", ts1.TotalMilliseconds);
        Console.WriteLine();
        Console.WriteLine("Serie numeros de fibonacci iterativo: ");
        DateTime start2 = DateTime.Now;
        FibonacciIterativo(n);
        DateTime end2 = DateTime.Now;
        TimeSpan ts2 = (end2 - start2);
        Console.WriteLine("Tiempo de ejecucion iterativo {0} ms", ts2.TotalMilliseconds);
    }
}
