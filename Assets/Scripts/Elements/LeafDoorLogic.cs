using UnityEngine;

public class LeafDoorLogic : MonoBehaviour
{
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == ShubType.SHUB_PLAYER)
        {
            switch (collision.gameObject.GetComponent<ShubPlayerLogic>().playerStatus)
            {
                case Status.ON_FIRE:
                    Debug.Log("Player has destroyed the fire door.");
                    Destroy(gameObject);
                    Debug.Log("Player enter in status : " + Status.NONE);
                    collision.gameObject.GetComponent<ShubPlayerLogic>().playerStatus = Status.NONE;
                    break;
                case Status.NONE:
                    Debug.Log("Player can't pass through.");
                    var lastPlayerPosition = collision.gameObject.GetComponent<Controller>();
                    lastPlayerPosition.lastPlayerPosition.SetReversePosition(lastPlayerPosition.transform);
                    break;
                case Status.ON_WATER:
                    //TODO Création d'une classe de gameover.
                    Debug.Log("Player is dead");
                    Destroy(collision.gameObject);
                    break;
                default:
                    Debug.Log("Undefined collision.");
                    break;
            }
        }
    }
}
