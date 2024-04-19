using UnityEngine;

public class StartButtonScript : MonoBehaviour
{
    [SerializeField] GameObject particles;
    [SerializeField] float cooldown;
    private Vector3 defaultScale = new Vector3(0.5f, 0.5f, 0.5f);

    public void Start()
    {
        TurnOnAnim();
    }

    public void TurnOffParticles()
    {
        particles.SetActive(false);
    }

    public void TurnOnParticles()
    {
        particles.SetActive(true);
        Invoke(nameof(TurnOffParticles), cooldown);
    }

    public void TurnOffAnim()
    {
        transform.localScale = defaultScale;
        GetComponent<Animation>().Stop();
        Invoke(nameof(TurnOnAnim), cooldown);
    }
    
    public void TurnOnAnim()
    {
        GetComponent<Animation>().Play();
    }


}
