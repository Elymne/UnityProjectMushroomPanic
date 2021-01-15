using UnityEngine;

public class WaterGroundLogic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == ShubType.SHUB_PLAYER)
        {
            collision.gameObject.GetComponent<ShubPlayerLogic>().playerStatus = Status.ON_WATER;
            Debug.Log("Player enter in status : " + Status.ON_WATER);
        }

        if(collision.gameObject.name == ShubType.SHUB_ENNEMY)
        {
            collision.gameObject.GetComponent<ShubEnnemyLogic>().ennemyStatus = Status.ON_WATER;
            Debug.Log("Ennemy enter in status : " + Status.ON_WATER);
        }
    }
}
