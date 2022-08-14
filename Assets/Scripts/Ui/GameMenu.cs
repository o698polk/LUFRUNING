using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MathSolution;


public class GameMenu : MonoBehaviour
{

    [Header("Astraccion de Objetos")]
    Calculos math= new Calculos();
    // Start is called before the first frame update
    void Start()
    {
       Debug.Log(math.sum(1,2));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
