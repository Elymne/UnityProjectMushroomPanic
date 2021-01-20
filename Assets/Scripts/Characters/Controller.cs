using UnityEngine;

public class Controller : MonoBehaviour
{
    // player displacement.
    public float playerDisplacement = UnitDisplacement.BASIC_UNIT_DISPLACEMENT;
    public float playerSpeed = UnitDisplacement.SPEED_UNIT_DISPLACEMENT;

    // position status.
    public LastPlayerPosition lastPlayerPosition = new LastPlayerPosition();

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Q))
        {
            transform.Translate(-playerDisplacement, 0, 0);
            lastPlayerPosition.SaveReservePosition(LastPlayerPosition.Q_LAST);
        }

        if (Input.GetKeyUp(KeyCode.Z))
        {   
            transform.Translate(0, 0, playerDisplacement);
            lastPlayerPosition.SaveReservePosition(LastPlayerPosition.Z_LAST);
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            transform.Translate(playerDisplacement, 0, 0);
            lastPlayerPosition.SaveReservePosition(LastPlayerPosition.D_LAST);
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            transform.Translate(0, 0, -playerDisplacement);
            lastPlayerPosition.SaveReservePosition(LastPlayerPosition.S_LAST);
        }
    }

}
