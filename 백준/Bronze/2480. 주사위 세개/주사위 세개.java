import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        
        Scanner sc = new Scanner(System.in);
        
        int a = sc.nextInt();
        int b = sc.nextInt();
        int c = sc.nextInt();
        
        if(a == b && b == c){ System.out.println(10000 + a * 1000); }
        else if(a != b && b != c && a != c){
            if(a > b && a > c){ System.out.println(a * 100); }
            if(b > a && b > c){ System.out.println(b * 100); }
            if(c > a && b < c){ System.out.println(c * 100); }
        }
        else {
            int[] arr = {a , b, c};
            int count = 0;
            for(int i = 0; i < arr.length; i++){
                for(int j = i+1; j < arr.length; j++){
                    if(arr[i] == arr[j]){
                        count = arr[j];
                    }
                }
            }
            System.out.println(count * 100 + 1000);
        }
    }
}