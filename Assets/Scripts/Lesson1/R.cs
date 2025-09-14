using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;

public class R : MonoBehaviour, IClickable
{
    private MeshRenderer m_Renderer;
    private Material m_Material;
    private void Awake()
    {
        m_Renderer = GetComponent<MeshRenderer>();
        m_Material = m_Renderer.material;
        
    }
    public void OnClick()
    {
        Sequence sequence = DOTween.Sequence();
        sequence.Append(m_Material.DOColor(Color.red, 2.0f));
        sequence.AppendInterval(1.0f);
        sequence.Append(m_Material.DOColor(Color.white, 2.0f));
        sequence.Play();
    }

    
}
