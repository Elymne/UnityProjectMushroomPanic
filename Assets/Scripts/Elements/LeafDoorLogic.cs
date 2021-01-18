using UnityEngine;

public class LeafDoorLogic : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // si le joueur à le bon état, on détruit la porte.
        if (collision.gameObject.name == ShubType.SHUB_PLAYER && collision.gameObject.GetComponent<ShubPlayerLogic>().playerStatus == Status.ON_FIRE)
        {
            Destroy(gameObject);
        }
    }
}
