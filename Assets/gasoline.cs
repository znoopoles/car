using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gasoline : MonoBehaviour
{
    public Image gas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gas.fillAmount -= Input.GetAxis("Horizontal") / 1500f;
    }

    public void AddFuel()
    {
        gas.fillAmount += 0.5f;
    }
}
