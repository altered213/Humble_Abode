using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateTowerButton : MonoBehaviour
{
    public GameObject TowerPrefab;

    public void OnClick()
    {
        GameObject tile = GameObject.Find("BuildMenu(Clone)").transform.parent;
        Instantiate(TowerPrefab, tile.position, tile.rotation, null);
        //add in destroy menu here ps. make othre buildmenu in build script a (clone)
    }
}
