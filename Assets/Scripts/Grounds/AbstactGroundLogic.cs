using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstactGroundLogic : MonoBehaviour
{
    // Status information of ground element.
    protected int status;

    // Current nature effect of the ground.
    protected int nature;

    // Current object posed on the ground (can be item, door, trap ect...).
    protected Object posedObject;

    // Define what's ahappen when character touch this ground.
    protected abstract void OnCharacterTouched(AbstractCharacterLogic character);

}
