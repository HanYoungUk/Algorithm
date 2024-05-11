import java.io.*;

public class Main{
    public static void main(String[] args) throws IOException{
        
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
    		BufferedWriter bw = new BufferedWriter(new OutputStreamWriter(System.out));
    		
    		int count = 0;
    		int max = 0;
    		for(int i = 0; i < 9; i++) {
    			int x = Integer.parseInt(br.readLine());
    			
    			if(x > max) {
    				max = x;
    				count = i + 1;
    			}
    		}
    		
    		bw.write(String.valueOf(max) + "\n");
    		bw.write(String.valueOf(count));
    		
    		bw.close();
    		br.close();
    }
}