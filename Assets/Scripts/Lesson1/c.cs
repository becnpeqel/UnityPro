using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class c : MonoBehaviour, IClickable
{
    private MeshRenderer m_Renderer;
    private Material m_Material;
    private Color o;
    private Color t;
    private void Awake()
    {
        m_Renderer = GetComponent<MeshRenderer>();
        m_Material = m_Renderer.material;
        o = m_Material.color;
        t = m_Material.color;
        t.a = 0;
    }
    public void OnClick()
    {
        Sequence sequence = DOTween.Sequence();
        sequence.Append(m_Material.DOColor(t, 2.0f));
        sequence.AppendInterval(1.0f);
        sequence.Append(m_Material.DOColor(o, 2.0f));
        sequence.Play();
    }

}
