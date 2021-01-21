using UnityEngine;

public class BarrierLogic : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == ShubType.SHUB_PLAYER)
        {
            Debug.Log("Player can't pass through.");
            var lastPlayerPosition = collision.gameObject.GetComponent<Controller>();
            lastPlayerPosition.lastPlayerPosition.SetReversePosition(lastPlayerPosition.transform);
        }
    }
}
