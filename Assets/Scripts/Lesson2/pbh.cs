using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pbh : MonoBehaviour, IClickable
{
    [SerializeField] private GameObject _portal;
    public void OnClick()
    {
        _portal.SetActive(true);   
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
