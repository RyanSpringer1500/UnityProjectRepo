/** (Ryan Springer) * 
 * (Assignment6) * 
 * (code skeleton) */

using UnityEngine;
using System.Collections;

public class Sinlgeton<T>: MonoBehaviour where T : Sinlgeton<T>
{
    private static T instance;

    public static T Instance
    {

        get { return instance; }
    }
    public static bool IsIntitialized
    {
    get { return instance != null; }
    }


    private void Awake()
    {
        if(instance != null)
        {
            Debug.LogError("[singleton] Tyring to instatiate a second instance of a singleton class");
        }
        else
        {
            instance = (T)this;
        }
    }
    protected virtual void OnDestory()
    {
        if (instance == this)
        {
            instance = null;
        }
    }

}
