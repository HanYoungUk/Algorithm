import java.io.*;
import java.util.StringTokenizer;

public class Main{
    public static void main(String[] args) throws IOException{
        
    	 BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        
         StringTokenizer st = new StringTokenizer(br.readLine());
         
         int king = 1;
         int queen = 1;
         int bishops = 2;
         int rooks = 2;
         int knights = 2;
         int pawns = 8;
        
         king = king - Integer.parseInt(st.nextToken());
         queen = queen - Integer.parseInt(st.nextToken());
         bishops = bishops - Integer.parseInt(st.nextToken());
         rooks = rooks - Integer.parseInt(st.nextToken());
         knights = knights - Integer.parseInt(st.nextToken());
         pawns = pawns - Integer.parseInt(st.nextToken());
         
         System.out.print(king + " ");
         System.out.print(queen + " ");
         System.out.print(bishops + " ");
         System.out.print(rooks + " ");
         System.out.print(knights + " ");
         System.out.print(pawns + " ");
        
    }
}