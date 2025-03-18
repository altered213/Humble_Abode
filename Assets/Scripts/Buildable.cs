using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buildable : MonoBehaviour
{
    // Start is called before the first frame update
    public Material BaseMaterial;
    public Material HighlightMaterial;
    public GameObject BuildMenu;
    public void OnMouseOver()
    {
        gameObject.GetComponent<MeshRenderer>().material = HighlightMaterial;

    }
    public void OnMouseExit()
    {
        gameObject.GetComponent<MeshRenderer>().material = BaseMaterial;
    }
    public void OnMouseDown()
    {
        Instantiate(BuildMenu, transform);
    }
}
