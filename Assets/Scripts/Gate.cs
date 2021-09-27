using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class Gate : MonoBehaviour
{
    [SerializeField] private Transform teleportPosition;
    [SerializeField] private bool isActive = true;

    public bool IsActive { get => isActive; set => isActive = value; }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (isActive) TeleportObject(collision.gameObject.transform);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isActive) TeleportObject(collision.gameObject.transform);
    }

    public void TeleportObject(Transform obj)
    {
        obj.position = teleportPosition.position;
    }
}
