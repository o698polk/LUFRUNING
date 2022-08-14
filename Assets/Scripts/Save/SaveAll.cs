using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SystemSave
{
    public class SaveAll 
    {

// Functions for save in the system global variables
     //Functions GETTER
        public int GetLife(){
        if (PlayerPrefs.HasKey("Life"))
        {
          return  PlayerPrefs.GetInt("Life");
        }else{
          return 0;
        }
        }
        public int GetCoin(){
            if (PlayerPrefs.HasKey("Coin"))
        {
          return  PlayerPrefs.GetInt("Coin");
          }else{
          return 0;
        }
        }

//Functions SETTER
       public void SetLife(int value){
        try
        {
             PlayerPrefs.SetInt("Life",value);
        }
        catch (System.Exception)
        {
            
            throw;
        }
          
           
       }
         public void SetCoin(int value){
           try
           {
            PlayerPrefs.SetInt("Coin",value);
           }
           catch (System.Exception)
           {
            
            throw;
           } 

           

        }
    }
}