using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool maxiGay;
    public bool maxiLovesJon;
    GameObject maxi;
    GameObject jon;

    private void Update()
    {
        maxiGay = true;
        maxiLovesJon = true;

        if (maxiGay && maxiLovesJon)
        {
            Sex();
        }
    }

    public void Sex()
    {
        maxi.GetComponentInChildren<Rigidbody>();
    }
    //Maxi, te amo <3
}
