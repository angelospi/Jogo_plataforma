using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptMegaman : MonoBehaviour
{
    private Rigidbody2D rbd;
    public float velocidade; 
    private Animator anim;
    private bool dir=true;
    private bool chao = true;
    // Start is called before the first frame update
    void Start()
    {
        rbd=GetComponent<Rigidbody2D>();
        velocidade=10;
        anim=GetComponent<Animator>();

    }

    private void OnCollisionEnter2D(Collision2D collision){
        chao=true;
    }
    private void OnCollisionExit2D(Collision2D collision){
        chao=false;
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

        if(dir && x<0 || !dir && x>0 ){
            transform.Rotate(new Vector2(0,180));
            dir =!dir;
        }

        if(Input.GetKeyDown(KeyCode.Space) && chao){
            rbd.AddForce(new Vector2(0,250));
        }

    
    }
}
