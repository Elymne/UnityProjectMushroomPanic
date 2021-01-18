using UnityEngine;

public class FireDoorLogic : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // si le joueur à le bon état, on détruit la porte.
        if(collision.gameObject.name == ShubType.SHUB_PLAYER)
        {

            switch(collision.gameObject.GetComponent<ShubPlayerLogic>().playerStatus)
            {
                case Status.ON_WATER:
                    Debug.Log("Destruction de la porte en feu.");
                    Destroy(gameObject);
                    Debug.Log("Player enter in status : " + Status.NONE);
                    collision.gameObject.GetComponent<ShubPlayerLogic>().playerStatus = Status.NONE;
                    break;
                case Status.ON_FIRE:
                    Debug.Log("Tu passeras pas mon gros.");
                    break;
                case Status.NONE:
                    Debug.Log("T'es mort brûlé ducoup haha..");
                    Destroy(collision.gameObject);
                    break;
                default:
                    Debug.Log("Alors là, wtf mon gars.");
                    break;
            }

        }
    }

    

}
