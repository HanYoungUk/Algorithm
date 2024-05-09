import java.util.*;
import java.io.*;

    public class Main{
    public static void main(String[] args) throws IOException{

        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        BufferedWriter bw = new BufferedWriter(new OutputStreamWriter(System.out));
        StringTokenizer st = new StringTokenizer(br.readLine());
        
        int n = Integer.parseInt(st.nextToken());
        int m = Integer.parseInt(st.nextToken());
        
        st = new StringTokenizer(br.readLine());
        
        for(int i = 0; i < n; i++) {
        	int x = Integer.parseInt(st.nextToken());
        	if(m > x) {
        		bw.write(Integer.toString(x) + " ");
        	}
        }
        
        br.close();
        bw.close();
    }
}