using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChordScript : MonoBehaviour
{
    [SerializeField]
    SongTimer SongTimer;
    public LibPdInstance pdPatch;
    int count = 0;
    List<int> Major = new List<int> { 0, 4, 7, 12, 16 };
    List<int> Minor = new List<int> { 0, 3, 7, 12, 15 };
    Material mat;
    bool once = true;
    void Start()
    {
        mat = GetComponent<Renderer>().material;
    }

    
    void Update()
    {
        if (SongTimer.is_section_on[5])
        {
            pdPatch.SendFloat("root", 48);
            pdPatch.SendList("notes", Major);
            if (SongTimer.beattrig)
            {
                pdPatch.SendBang("noteon");
                //mat.SetFloat("_Gradient", RandomRange();
            }
        }
        if (SongTimer.is_section_on[8])
        {
            pdPatch.SendFloat("root", 48);
            pdPatch.SendList("notes", Major);
            if (SongTimer.beattrig)
            {
                pdPatch.SendBang("noteon");
                //mat.SetFloat("_Gradient", RandomRange();
            }
        }
        if (SongTimer.is_section_on[9])
        {
            pdPatch.SendFloat("root", 48);
            pdPatch.SendList("notes", Major);
            if (SongTimer.beattrig)
            {
                pdPatch.SendBang("noteon");
                //mat.SetFloat("_Gradient", RandomRange();
            }
        }
        if (SongTimer.is_section_on[10])
        {
            pdPatch.SendFloat("root", 48);
            pdPatch.SendList("notes", Major);
            if (SongTimer.beattrig)
            {
                pdPatch.SendBang("noteon");
                //mat.SetFloat("_Gradient", RandomRange();
            }

        }
        if (SongTimer.is_section_on[11])
        {
            if (once)
            {
                pdPatch.SendBang("Stop");
                once = false;
            }
        }
    }
}
