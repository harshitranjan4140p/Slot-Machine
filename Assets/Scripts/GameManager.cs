using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public ReelController[] reelControllers;

    void Awake()
    {
        instance = this;
    }

    public void Spin()
    {
        foreach (ReelController reel in reelControllers)
        {
            reel.StartSpin();
        }
    }

    public void CheckWin()
    {
        if (reelControllers == null || reelControllers.Length == 0)
            return;

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