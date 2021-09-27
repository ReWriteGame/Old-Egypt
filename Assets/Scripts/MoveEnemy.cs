using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Move))]
public class MoveEnemy : MonoBehaviour
{
    [SerializeField] private bool rightMove = true;

    private Move move;

    private void Start()
    {
        move = GetComponent<Move>();
    }

    private void FixedUpdate()
    {
        if (rightMove) move.rightMove();
        else move.leftMove();
    }
}
