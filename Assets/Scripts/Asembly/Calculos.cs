using System;
namespace MathSolution
{
   public class Calculos 
     {
       public int sum(int value1, int value2){

        if(value1<0||value2<0){
            throw new Exception();
        }
        return value1+value2;
       }
     } 
}


