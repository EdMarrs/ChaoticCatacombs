using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardModeCheck : MonoBehaviour
{
    public static void SetBool(string key, bool state)
    {
        PlayerPrefs.SetInt(key, state ? 1 : 0);
    }

    public static bool GetBool(string key)
    {
        int value = PlayerPrefs.GetInt(key);
        
        if (value == 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}