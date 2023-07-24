using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground_Controller : MonoBehaviour
{

    [SerializeField] GameManager gameManager;
    [SerializeField] int _speed;
    

    void Update()
    {
        StartAndMover();
    }

    void StartAndMover()
    {
        if (gameManager._isStart == true)
        {
            transform.Translate(0f, _speed * Time.deltaTime, 0f);
        }
        
    }
}
