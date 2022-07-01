using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonDeclaration : MonoBehaviour
{

    #region Singleton Declaration
    public static SingletonDeclaration Instance { get; private set; }
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    #endregion Singleton Declaration

}
