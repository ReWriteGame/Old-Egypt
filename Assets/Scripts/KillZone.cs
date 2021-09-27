using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class KillZone : MonoBehaviour
{
    public UnityEvent isTouchKillZoneEvent;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Hero>())
            isTouchKillZoneEvent?.Invoke();
    }
}
