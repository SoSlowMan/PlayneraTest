using UnityEngine;

public class BackButtonScript : MonoBehaviour
{
    [SerializeField] GameObject warningPopUp;

    public void TurnPopUpOn()
    {
        warningPopUp.SetActive(true);
    }

    public void TurnPopUpOff()
    {
        warningPopUp.SetActive(false);
    }
}
