using UnityEngine;

public class FireGroundLogic : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == ShubType.SHUB_PLAYER)
        {
            collision.gameObject.GetComponent<ShubPlayerLogic>().playerStatus = Status.ON_FIRE;
            Debug.Log("Player enter in status : " + Status.ON_FIRE);
        }

        if (collision.gameObject.name == ShubType.SHUB_ENNEMY)
        {
            collision.gameObject.GetComponent<ShubEnnemyLogic>().ennemyStatus = Status.ON_FIRE;
            Debug.Log("Ennemy enter in status : " + Status.ON_FIRE);
        }
    }
}
