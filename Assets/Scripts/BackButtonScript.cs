using Unity.Burst.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class BackButtonScript : MonoBehaviour
{
    [SerializeField] GameObject warningPopUp;
    [SerializeField] GameObject canvas;

    public void TurnPopUpOn()
    {
        Instantiate(warningPopUp, canvas.transform);
    }

    public void TurnPopUpOff()
    {
        Destroy(transform.parent.gameObject);
    }
}
