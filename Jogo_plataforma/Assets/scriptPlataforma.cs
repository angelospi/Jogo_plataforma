using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptPlataforma : MonoBehaviour
{
    public float velocidade=1;
    private float cont=0;
    private float altura=1;
    private float largura=1;
    private Vector2 posInicial;
    // Start is called before the first frame update
    void Start()
    {
        posInicial=transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        cont+= (velocidade * Time.deltaTime);
        float posX= Mathf.Cos(cont)*altura;
        float posY= Mathf.Sin(cont)*largura;

        transform.position= new Vector2(posInicial.x+posX, posInicial.y+posY);

        if(cont>=2 * Mathf.PI){
            cont=cont-(2*Mathf.PI);
        }
        
    }
}
