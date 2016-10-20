/**
 * @(#)cattleMart.java
 *
 *
 * @author 
 * @version 1.00 2016/9/27
 */
import java.util.Arrays;
import javax.swing.JOptionPane;
public class cattleMart {
   public static void main(String [] args){
   	
   	float weight[] = new float[5];
   	
   	float averageWeight=0,lightest=weight[0],largest=weight[0];
   	int perOver400=0,over250=0,i,total=0;
   	String weightAsString;
   	
     	for(i=0;i<weight.length;i++)
   	    {
   		weightAsString  = JOptionPane.showInputDialog("Enter weight of animal:");
   		weight[i] = Float.parseFloat(weightAsString);
   		
   		total+=weight[i];
        
   	    
   	    //for(i=0;i<weight.length;i++)
   	    
   	    
   	     if(i==0)
   	         {
   	           lightest = weight[i];
   	           largest = weight[i];
   	         }    
   	      else
   	        
   	         {
            	if(weight[i]<lightest) 
   	      	       lightest = weight[i];
   	      	    
   	      	    if(weight[i]>largest)
   	      	    	largest = weight[i];
         	 
   	         }
   	         
   	       if(weight[i]>250)
   	       	over250++;
   	       	
   	       if(weight[i]>400)
   	       	  perOver400++;	 
   	       	  
   	       	   
   	    }
   	     averageWeight = total/5f;
   	     perOver400 = (int) (perOver400/5f*100);
   	     
   	     String output = String.format ("Weights %s \n Number over 250kg: %2d  \nAverageWeights %.2f  \nPercentage over 400kg: %2d%% \nLightest Animal %.2f",Arrays.toString(weight),over250,averageWeight,perOver400,lightest);
         JOptionPane.showMessageDialog(null,output,"Details",JOptionPane.INFORMATION_MESSAGE);
    }
    
}

