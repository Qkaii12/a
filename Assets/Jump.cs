using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Rigidbody2D rig2D;
    [SerializeField] private Vector2 moveDirection;
    [SerializeField] private Animator animator;
    private const string IsJumpParaName = "jump";
    [SerializeField] private KeyCode upkey;

    private void CheckHorizontalInput()
    {
        var jump = Input.GetKey(upkey);
    }
}
