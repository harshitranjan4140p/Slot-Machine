using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public ReelController[] reelControllers;

    public GameObject handle;
    public GameObject Pressedhandle;

    void Awake()
    {
        instance = this;
    }

    public void Spin()
    {
        StartCoroutine(WaitBeforeAgainSpin());
        
        foreach (ReelController reel in reelControllers)
        {
            reel.StartSpin();
        }
    }

    IEnumerator WaitBeforeAgainSpin()
    {
        handle.SetActive(false);
        Pressedhandle.SetActive(true);

        yield return new WaitForSeconds(3.5f); // Manual Hard coded 

        handle.SetActive(true);
        Pressedhandle.SetActive(false);

        CheckWin();
    }


    void CheckWin()
    {
        if (reelControllers == null || reelControllers.Length == 0)
            return;

        handle.SetActive(true);
        Pressedhandle.SetActive(false);

        int firstValue = reelControllers[0].RandomNumber;

        foreach (ReelController reel in reelControllers)
        {
            if (reel.RandomNumber != firstValue)
            {
                Debug.Log("LOSE");
                return;
            }
        }

        Debug.Log("WIN");
    }
}