using UnityEngine;

public class ShubPlayerLogic : MonoBehaviour
{
    // player actual state.
    public int playerStatus = Status.NONE;

    void Start()
    {
    }

    // Update is called once per frame.
    void Update()
    {

    }

    // Ici, on va gérer les contacts entre le joueur et les différents éléments du jeu.
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);

    }

}
