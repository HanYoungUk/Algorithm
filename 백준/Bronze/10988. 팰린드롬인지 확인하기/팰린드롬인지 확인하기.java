import java.io.*;

public class Main{
    public static void main(String[] args) throws IOException{
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
    		BufferedWriter bw = new BufferedWriter(new OutputStreamWriter(System.out));
    		
    		String str = br.readLine();
    		
    		StringBuffer sb = new StringBuffer(str);
    		String rstr = sb.reverse().toString();
    		
    		if(str.equals(rstr)) {
    			System.out.println("1");
    		} else {
    			System.out.println("0");
    		}
    		
    }
}