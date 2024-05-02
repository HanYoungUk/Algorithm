import java.util.*;

public class Main{
    public static void main(String[] args){
        
        Scanner sc = new Scanner(System.in);
        
        int a = sc.nextInt();
        int b = sc.nextInt();
        int c = sc.nextInt();
        
        if(b + c >= 60){
            if(a + ((b + c) / 60) <= 23){
                System.out.println(((b + c) / 60 + a) + " " + ((b + c) % 60));
            } else {
                System.out.println((((b + c) / 60 + a) - 24) + " " + ((b + c) % 60));
            }
        } else{ // b + c가 60보다작을경우
            System.out.println(a + " " + (b + c));
        }
    }
}