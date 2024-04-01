using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sanji : MonoBehaviour
{
    public float tocdo;
    private bool isfacingRight = true;
    private Rigidbody2D rb;
    private Animator ani;
    private float trai_phai;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        trai_phai = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(trai_phai*tocdo,rb.velocity.y);
        flip();
        ani.SetFloat("run", Mathf.Abs(trai_phai));
    }
    void flip()
    {
        if(isfacingRight && trai_phai < 0 || !isfacingRight && trai_phai > 0)
        {
            isfacingRight = !isfacingRight;
            Vector3 kich_thuoc = transform.localScale;
            kich_thuoc.x = kich_thuoc.x * -1;
            transform.localScale = kich_thuoc;
        }
    }
}
