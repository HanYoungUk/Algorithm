import java.io.*;
import java.util.*;

public class Main{
    public static void main(String[] args) throws IOException{
        
       BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        BufferedWriter bw = new BufferedWriter(new OutputStreamWriter(System.out));
        
      
        int t = Integer.parseInt(br.readLine());
        
        StringTokenizer st = new StringTokenizer(br.readLine());
        int[] arr = new int[t];
        
        for(int i = 0; i < t; i++) {
        	arr[i] = Integer.parseInt(st.nextToken());
        }
        
        int ele = Integer.parseInt(br.readLine());
        int count = 0;
        
        for(int i = 0; i < arr.length; i++) {
        	if(arr[i] == ele) {
        		count++;
        	}
        }
        
        bw.write(Integer.toString(count));
        
        bw.close();
        br.close();
        
    }
}