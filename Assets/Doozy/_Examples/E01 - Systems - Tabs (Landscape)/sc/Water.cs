using Doozy.Runtime.Reactor;
using Michsky.MUIP;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Water : MonoBehaviour
{
    [SerializeField] TMP_Text setFWter;
    [SerializeField] GameObject pSB;
    [SerializeField] GameObject pSB2;
    [SerializeField] TMP_InputField addWaterTF;
    [SerializeField] TMP_InputField editWaterTF;

    public float fwater = 0.0f;
    public float ewater = 0.0f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (ewater <= 0.0f)
        {
            pSB2.GetComponent<Progressor>().SetProgressAt(0.0f);
            pSB.GetComponent<Progressor>().SetProgressAt(0.0f);
        }
        else
        {
            pSB2.GetComponent<Progressor>().SetProgressAt(ewater / fwater);
            pSB.GetComponent<Progressor>().SetProgressAt((ewater / fwater));
        }

    }

    public void addFWater()
    {
        this.fwater = float.Parse(addWaterTF.text);
        ewater = 0.0f;
        setFWter.text = addWaterTF.text;
        addWaterTF.text = ""; 
    }

    public void editWater()
    {
        this.ewater += float.Parse(editWaterTF.text);
        if (this.fwater >= 0.0f && this.ewater >= 0.0f && this.ewater < this.fwater) {
            pSB2.GetComponent<Progressor>().SetProgressAt(ewater / fwater);
            pSB.GetComponent<Progressor>().SetProgressAt((ewater / fwater));
            Debug.Log(ewater + "" + fwater);
        }
    }

   

}
