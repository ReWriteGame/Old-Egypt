using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Move))]
public class Hero : MonoBehaviour
{
    public UnityEvent isTouchEnemyEvent;

    private Move move;
    private void Start()
    {
        move = GetComponent<Move>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Enemy>())
            isTouchEnemyEvent?.Invoke();
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Ground>())
            move.CanJump = true;
      
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Ground>())
            move.CanJump = false;
    }
}
