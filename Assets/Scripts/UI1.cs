using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI1 : MonoBehaviour
{
    public InputField IP;

    public InputField Port;
    // Start is called before the first frame update
    void Start()
    {
        IP.onValueChanged.AddListener(newText =>
        {
            Debug.Log($"new value = {newText}");
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
