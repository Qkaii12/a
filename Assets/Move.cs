using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Rigidbody2D rig2D;
    [SerializeField] private Vector2 moveDirection;
    [SerializeField] private Animator animator;
    private const string IsWalkingParaName = "run";
    [SerializeField] private KeyCode rightkey;
    [SerializeField] private KeyCode leftKey;

    private void CheckHorizontaInput()
    {
        var run = Input.GetKey(leftKey) || Input.GetKey(rightkey);
        var direction = moveDirection;
        direction.y = rig2D.velocity.y;
        if (run)
        {
            var isFlip = Input.GetKey(leftKey);
            var scale = transform.localScale;
            if (isFlip)
            {
                direction *= -1;
                scale.x = -4;
            }
            else
            {
                scale.x = 4;
            }
            transform.localScale = scale;
            rig2D.velocity = direction;
        }
        animator.SetBool(IsWalkingParaName, run);
        if (run)
            Debug.Log(IsWalkingParaName);
    }
    private void Update()
    {
        CheckHorizontaInput();
    }
}
