using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Rigidbody2D rig2D;
    [SerializeField] float jumpForce = 7.5f;
    [SerializeField] private Animator animator;
    private const string IsJumpParaName = "jump";
    [SerializeField] private KeyCode upkey;
    bool ground;

    private void CheckUpInput()
    {
        if(Input.GetKey(upkey))
        {
            animator.SetTrigger(IsJumpParaName); 
            if(ground)
            {
                ground = false;
                rig2D.velocity = new Vector2(rig2D.velocity.x, jumpForce);
            }
        }
    }
    private void Update()
    {
        CheckUpInput();
        
    }
    private void OnCollisionEnter2D(Collision2D collision2)
    {
        if(collision2.gameObject.tag == "Ground")
        {
            ground = true;
        }
    }
}
