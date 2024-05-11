using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongTimer : MonoBehaviour
{
    float t;
    [SerializeField]
    public int beatMS;
    [HideInInspector]
    public bool beattrig;
    public int timeSignature;
    int counterBeat;
    int counterBeatUnbound;
    int counterMeasure;
    float ramp;
    [SerializeField]
    List<int> sections;
    int Pause, Sect1, Sect2, Sect3, Sect4, Sect5, Sect6, Sect7, Sect8, Sect9, Sect10, Sect11;
    [HideInInspector]
    public bool[] is_section_on;

    float prev_gates;
    void Start()
    {
        Pause = sections[0];
        Sect1 = sections[0] + sections[1];
        Sect2 = sections[0] + sections[1] + sections[2];
        Sect3 = Sect2 + sections[3];
        Sect4 = Sect3 + sections[4];
        Sect5 = Sect4 + sections[5];
        Sect6 = Sect5 + sections[6];
        Sect7 = Sect6 + sections[7];
        Sect8 = Sect7 + sections[8];
        Sect9 = Sect8 + sections[9];
        Sect10 = Sect9 + sections[10];
        Sect11 = Sect10 + sections[11];
        is_section_on = new bool[sections.Count];
    }

    
    void Update()
    {
        t += Time.deltaTime;
        float gates = ControlFunctions.Squ(t, 1000f / beatMS, 0);
        beattrig = Mathf.Sign(gates) > 0 && Mathf.Sign(prev_gates) < 0;
        prev_gates = gates;

        if (beattrig)
        {
            counterBeatUnbound += 1;
        }
        counterBeat = counterBeatUnbound % timeSignature;
        counterMeasure = counterBeatUnbound / timeSignature;
        Debug.Log(counterMeasure);
        if (counterMeasure < Pause)
        {

            is_section_on[0] = true;

        }
        else if (counterMeasure >= Pause && counterMeasure < Sect1)
        {
            Debug.Log("Verse");
            is_section_on[1] = true;
            is_section_on[0] = false;
        }
        else if (counterMeasure >= Sect1 && counterMeasure < Sect2)
        {
            Debug.Log("Chorus");
            is_section_on[2] = true;
            is_section_on[1] = false;
        }
        else if (counterMeasure >= Sect2 && counterMeasure < Sect3)
        {
            is_section_on[3] = true;
            is_section_on[2] = false;
        }
        else if (counterMeasure >= Sect3 && counterMeasure < Sect4)
        {
            is_section_on[4] = true;
            is_section_on[3] = false;
        }
        else if (counterMeasure >= Sect4 && counterMeasure < Sect5)
        {
            is_section_on[5] = true;
            is_section_on[4] = false;
        }
        else if (counterMeasure >= Sect5 && counterMeasure < Sect6)
        {
            is_section_on[6] = true;
            is_section_on[5] = false;
        }
        else if (counterMeasure >= Sect6 && counterMeasure < Sect7)
        {
            is_section_on[7] = true;
            is_section_on[6] = false;
        }
        else if (counterMeasure >= Sect7 && counterMeasure < Sect8)
        {
            is_section_on[8] = true;
            is_section_on[7] = false;
        }
        else if (counterMeasure >= Sect8 && counterMeasure < Sect9)
        {
            is_section_on[9] = true;
            is_section_on[8] = false;
        }
        else if (counterMeasure >= Sect9 && counterMeasure < Sect10)
        {
            is_section_on[10] = true;
            is_section_on[9] = false;
        }
        else if (counterMeasure >= Sect10 && counterMeasure < Sect11)
        {
            is_section_on[11] = true;
            is_section_on[9] = false;
        }
    }
}
