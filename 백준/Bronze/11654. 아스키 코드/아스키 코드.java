import java.io.*;

public class Main{
    public static void main(String[] args) throws IOException{
        
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
         BufferedWriter bw = new BufferedWriter(new OutputStreamWriter(System.out));
         
         String ch = br.readLine();
         int num = (int)ch.charAt(0);
         
         bw.write(String.valueOf(num));
         
         bw.close();
         br.close();
    }
}