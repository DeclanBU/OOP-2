/**
 * @(#)cubed.java
 *
 *
 * @author 
 * @version 1.00 2016/9/27
 */


public class cubed {
	public static void main(String [] args)
	{
	
	  int ans;
	  String heading = String.format("%-10s%-13s%-10s%-13s","Number", "number Cubed\n","-------","------------"); 
	    System.out.print(heading + "\n");
	    for(int i = 1; i <= 15; i++)
	    {
	     ans = cube(i);	
	     	
	     System.out.print(String.format("%-10d%-10d",i ,ans) + "\n");
	    }
	
	    
	  
	  
	  
	   	
	}
	public static int cube(int n)
	{
	 return n*n*n;
	}
    
   
    
    
}