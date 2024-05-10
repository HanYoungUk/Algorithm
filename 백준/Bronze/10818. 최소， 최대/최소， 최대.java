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
    	
    	long max = arr[0];
    	long min = arr[0];
    	
    	for(int i = 0; i < t; i++) {
    		if(arr[i] > max) {
    			max = arr[i];
    		}
    		if(arr[i] < min) {
    			min = arr[i];
    		}
    	}
    	
    	bw.write(String.valueOf(min) + " ");
    	bw.write(String.valueOf(max));
    	
        bw.close();
        br.close();
    }
}