using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMultiplayerStats : MonoBehaviour
{
    public int phase = 1;

    void Start()
    {
        StartCoroutine("increaseDifficulty");
    }

    IEnumerator increaseDifficulty()
    {
        for (; ; )
        {
            phase++;
            yield return new WaitForSeconds(30f);
        }
    }
}
