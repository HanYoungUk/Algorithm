import java.io.*;

public class Main{
    public static void main(String[] args)throws IOException{


            BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
    		BufferedWriter bw = new BufferedWriter(new OutputStreamWriter(System.out));
    		
    		
    		
    		int t = Integer.parseInt(br.readLine());
    	
    		
    		for(int i = 0; i < t; i++) {
    			String[] arr = br.readLine().split(" ");
    			
    			for(int j = 0; j < arr[1].length(); j++) {
    				for(int k = 0; k < Integer.parseInt(arr[0]); k++) {
    					bw.write(arr[1].charAt(j));
    				}
    				
    			}
    			bw.write("\n");
    		}
    		
    		bw.close();
    		br.close();
        
    }
}