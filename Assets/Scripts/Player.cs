using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Debug;

public class Player : MonoBehaviour
{
    private Broom _myBroom;
    private float _mySpeed;

    private void Awake()
    {
        _myBroom = FindObjectOfType<MarkerBroom>().GetComponent<Broom>();
    }

    public void Fly()
    {
        // метод полёта с учётом свойств Broom

    }
}
