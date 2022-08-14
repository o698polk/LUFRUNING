using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.iOS;
using UnityEngine.UI;

public class CubeMotion : MonoBehaviour
{
    // Start is called before the first frame update
    
    [Header("Variables Vectoriales")]
     private Transform cubeTransfor;
     private Vector3 mPosition;
     private Vector2 pos;
     private Touch touch ;
    [Header("Variables Nuemricas")]
     private float width, height;
     private int i;
    [SerializeField] private float distancia;
    [SerializeField] private float recorrido;
    [SerializeField] private float puntoInicial;
    [Header("Variables UI")]
     public Text dataTxt;
   
    void Start()
    {
        this.cubeTransfor= GetComponent<Transform>();
        this.CalcularCentroPantalla();
    }

    
    void Update()
    {
        this.Control();
    }

    public void Control()
    {
        
        this.mPosition= Input.mousePosition; 
        this.pos = touch.position;
        if(Input.GetMouseButtonDown(0))
        {
             this.puntoInicial=mPosition.y; 

        }
        if(Input.touchCount > 0){
                this.touch = Input.GetTouch(0);
                if (touch.phase == TouchPhase.Began)
                {
                    this.puntoInicial=pos.y;
                }
                 if (touch.phase == TouchPhase.Moved)
                {
                this.recorrido=puntoInicial-pos.y;
                }
                 if (touch.phase == TouchPhase.Ended)
                {
                       if( recorrido>distancia)
                        {
                            this.i--;
                            this.dataTxt.text=i.ToString("0");
                        }
                        if(recorrido<-distancia)
                        {
                        
                            this.i++;
                            this.dataTxt.text=i.ToString("0");
                        }
                }
             
             

        }

        if(Input.GetMouseButton(0))
        {
             this.recorrido=puntoInicial-mPosition.y;
        }

         if(Input.GetMouseButtonUp(0))
        {
            
             if( recorrido>distancia)
             {
              this.i--;
              this.cubeTransfor.Rotate(0.0f, mPosition.y*Time.deltaTime, 0.0f, Space.World);
              this.dataTxt.text=i.ToString("0");
             }
              if(recorrido<-distancia)
             {
              
              this.i++;
              this.cubeTransfor.Rotate(0.0f, mPosition.y*Time.deltaTime, 0.0f, Space.World);
              this.dataTxt.text=i.ToString("0");
             }
        }

    }

    public void CalcularCentroPantalla()
    {
         
      this.width=(float)Screen.width/2f;
      this.height=(float)Screen.height/2f;
    }
}
