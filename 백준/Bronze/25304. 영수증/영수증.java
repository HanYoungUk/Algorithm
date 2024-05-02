import java.util.*;

public class Main{
    public static void main(String[] args){
        
        Scanner sc = new Scanner(System.in);
        
        long a = sc.nextLong();
        int b = sc.nextInt();
        long sum = 0;
        
        for(int i = 0; i < b; i++){
            int c = sc.nextInt();
            int d = sc.nextInt();
            sum += c * d;
        }
        
        if(sum == a){
            System.out.println("Yes");
        } else{
            System.out.println("No");
        }
    }
}