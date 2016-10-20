/**
 * @(#)even.java
 *
 *
 * @author 
 * @version 1.00 2016/9/27
 */

import javax.swing.JOptionPane;
public class even {
	public static void main(String [] args){
		
		String numAsString;
		int num=0;
		
		while(num!=-1)
		{
			numAsString = JOptionPane.showInputDialog("Please enter a number:");
			num = Integer.parseInt(numAsString);
		 
		 
		 if(isEven(num))	
		 
		 JOptionPane.showMessageDialog(null,"The Integer " + num + " you entered is even");
	  
	     else
	  		 
		JOptionPane.showMessageDialog(null,"The Integer " + num + " you entered is NOT even");
		
		}
	  
	}
	 public static boolean isEven(int n)
	 {
	 	boolean ans = false;
	 	
	 	if(n%2 == 0)
	 	   
	 	   ans = true;	
	 	
	 	return ans;		
	 }	



	


    
    
}