using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptMegaman : MonoBehaviour
{
    private Rigidbody2D rbd;
    public float velocidade; 
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        rbd=GetComponent<Rigidbody2D>();
        velocidade=10;
        anim=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        rbd.velocity=new Vector2(x*velocidade,rbd.velocity.y);

        if(x==0){
          anim.SetBool("move",false);
        }
        else{
            anim.SetBool("move",true);
        }

        if(Input.GetKeyDown(KeyCode.Space)){
            rbd.AddForce(new Vector2(0,250));
        }

    
    }
}
