import java.util.*;
import java.io.*;

public class Main{
    public static void main(String[] args) throws IOException{


            BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
    		BufferedWriter bw = new BufferedWriter(new OutputStreamWriter(System.out));
    		StringTokenizer st = new StringTokenizer(br.readLine());
    		
    		String[] arr = new String[2];
    		
    		arr[0] = st.nextToken();
    		arr[1] = st.nextToken();
    		
    		// 요소를 어떻게 하면 바꿀까? 
    		for(int i = 0; i < arr.length; i++) {
    		StringBuffer str = new StringBuffer(arr[i]);
    		
    		arr[i] = str.reverse().toString();
    		}
    		
    		int x = 0;
    		
    		if(Integer.parseInt(arr[0]) > Integer.parseInt(arr[1])) {
    			x = Integer.parseInt(arr[0]);
    		} else if(Integer.parseInt(arr[0]) < Integer.parseInt(arr[1])) {
    			x = Integer.parseInt(arr[1]);
    		}
    		
    		bw.write(String.valueOf(x));
    		
    		bw.close();
    		br.close();
        
    }
}