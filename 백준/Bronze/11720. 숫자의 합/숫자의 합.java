import java.io.*;

public class Main{
    public static void main(String[] args) throws IOException{

        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        BufferedWriter bw = new BufferedWriter(new OutputStreamWriter(System.out));
    	
    	int num = Integer.parseInt(br.readLine());
        String x = br.readLine();
        int sum = 0;
        
        
        for(int i = 0; i < num; i++) {
        	int n = x.charAt(i) - '0';
        	sum += n;
        }
        
        bw.write(String.valueOf(sum));
    	
        bw.close();
        br.close();
        
    }
}