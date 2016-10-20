/**
 * @(#)exchange3.java
 *
 *
 * @author 
 * @version 1.00 2016/9/20
 */

import javax.swing.JOptionPane;
public class exchange3 {
	public static void main(String [] args)
		{
		
		String euroAsString="",rateAsString;
		float euro,pounds=.86f ,amount,rate,diff;
	   // int i=0;
	rateAsString = JOptionPane.showInputDialog("Please enter the conversion rate");
	rate = Float.parseFloat(rateAsString);
	      
	euroAsString = JOptionPane.showInputDialog("Please enter the amount in euros you want to change to pounds");

	while(!euroAsString.equals("0"))
		{
		
		  euro = Float.parseFloat(euroAsString);
		  
		  pounds = euro*rate;
		  
			
	      String output = String.format( "The amount of euros is: %10.2f   \nThe rate is: %10.2f    \nThe amount of pounds recieved is: %10.2f" ,euro,rate,pounds);
	      JOptionPane.showMessageDialog(null,output,"Today's exchange rate is " + rate,JOptionPane.INFORMATION_MESSAGE);
	     
	     
	      euroAsString = JOptionPane.showInputDialog("Please enter another amount in euros you want to change to pounds");
		
		    
		}
	JOptionPane.showMessageDialog(null,"you entered 0 ");
	
	}
    
}
			
			
	    
		 
		 
	     
	
    	
	    
	    
	   
	