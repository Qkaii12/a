using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack2 : MonoBehaviour
{
    private const string AttackParamName = "Attack2";
    [SerializeField] private Animator animator;
    [SerializeField] private KeyCode attackKey;

    [SerializeField] private Transform kickPoint;
    [SerializeField] private float kickRadius;
    private void CheckAttackInput()
    {
        if (Input.GetKeyDown(attackKey))
        {
            Debug.Log(AttackParamName);
            animator.SetTrigger(AttackParamName);

        }
    }

    public void OnAttackCallback()
    {
        Debug.Log("OnAttackCallback");
        var hit = Physics2D.CircleCast(kickPoint.position, kickRadius, transform.right);
        if (hit.transform != transform)
        {

        }
    }


    private void Update()
    {
        CheckAttackInput();
    }
}
