using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class oc : MonoBehaviour
{
 private Camera cam;
    void Start()
    {
        
    }
    private void Awake()
    {
        cam = GetComponent<Camera>();
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                if (hit.collider.TryGetComponent(out IClickable clickable))
                {
                    clickable.OnClick();
                }
            }
        }
    }
}
