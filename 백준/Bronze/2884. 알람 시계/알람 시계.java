import java.util.*;

public class Main{
    public static void main(String[] args){
        
        Scanner sc = new Scanner(System.in);
        
        int a = sc.nextInt();
        int b = sc.nextInt();
        
        if(b == 45){
            System.out.println(a + " " + 0);
        } else if(b < 45 && a >= 1){
            System.out.println(a - 1 + " " + ((60 + b) - 45));     
        } else if(b < 45 && a < 1){
               System.out.println(23 + " " + ((60 + b) - 45));
        }
        else {
            System.out.println(a + " " + (b - 45));
        }
    }
}