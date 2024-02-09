using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loading : MonoBehaviour
{
    float speed = 100;
    [SerializeField]float loadings;
    [SerializeField] Transform loadingLogo;

    void Loading()
    {
        loadingLogo.Rotate(0f, 0f, speed * Time.deltaTime);
        if (speed.Equals(loadings))
        {

        }
    }
}
