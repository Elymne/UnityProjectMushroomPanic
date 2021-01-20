public class LastPlayerPosition
{
    public const int Z_LAST = 1;
    public const int S_LAST = 2;
    public const int Q_LAST = 3;
    public const int D_LAST = 4;

    public float positionX, positionZ = 0;

    public void SaveReservePosition(int position)
    {
        switch(position)
        {
            case Z_LAST:
                positionX = 0;
                positionZ = -5;
                break;
            case S_LAST:
                positionX = 0;
                positionZ = 5;
                break;
            case Q_LAST:
                positionX = 5;
                positionZ = 0;
                break;
            case D_LAST:
                positionX = -5;
                positionZ = 0;
                break;
            default:
                positionX = 5;
                positionZ = 0;
                break;
        }
    }

    public void SetReversePosition(UnityEngine.Transform transform)
    {
        transform.Translate(positionX, 0, positionZ);
    }


}
