using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BassSequencer : MonoBehaviour
{
    [SerializeField]
    SongTimer SongTimer;
    public LibPdInstance pdPatch;
    List<int> VerseNotes = new List<int> { 24, 24, 24, 24, 24, 24, 24, 24, 31, 31, 26, 26, 29, 29, 19, 19, };
    List<int> PCNotes = new List<int> { 24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 31, 31, 31, 31, };
    List<bool> VerseTrig = new List<bool> { true, false, true, false, true, false, true, false, true, false, true, false, true, false, true, false };
    List<bool> PCTrig = new List<bool> { false, false, false, false, false, false, false, false, false, false, false, false, true, false, true, false };
    int count = 0;
    Material mat;
    bool once = true;
     void Start()
    {
        mat = GetComponent<Renderer>().material;
    }
    void Update()
    {
        if (SongTimer.is_section_on[1])
        {
            mat.SetFloat("_Speed", (VerseNotes[count] - 23.8f) / 2);
            if (SongTimer.beattrig)
            {
                pdPatch.SendMidiNoteOn(0, VerseNotes[count], 127);
                if (VerseTrig[count])
                {
                    pdPatch.SendBang("NoteOn");
                    Debug.Log("Bang");
                }
                count = (count + 1) % VerseNotes.Count;
            }
        }
        if (SongTimer.is_section_on[2])
        {
            mat.SetFloat("_Speed", (VerseNotes[count] - 23.8f) / 2);

            if (SongTimer.beattrig)
            {
                pdPatch.SendMidiNoteOn(0, VerseNotes[count], 127);
                if (VerseTrig[count])
                {
                    pdPatch.SendBang("NoteOn");
                    Debug.Log("Bang");
                }
                count = (count + 1) % VerseNotes.Count;
            }
        }
        if (SongTimer.is_section_on[3])
        {
            mat.SetFloat("_Speed", (VerseNotes[count] - 23.8f) / 2);

            if (SongTimer.beattrig)
            {
                pdPatch.SendMidiNoteOn(0, VerseNotes[count], 127);
                if (VerseTrig[count])
                {
                    pdPatch.SendBang("NoteOn");
                    Debug.Log("Bang");
                }
                count = (count + 1) % VerseNotes.Count;
            }
        }
        if (SongTimer.is_section_on[4])
        {
            mat.SetFloat("_Speed", (VerseNotes[count] - 23.8f) / 2);

            if (SongTimer.beattrig)
            {
                pdPatch.SendMidiNoteOn(0, VerseNotes[count], 127);
                if (VerseTrig[count])
                {
                    pdPatch.SendBang("NoteOn");
                    Debug.Log("Bang");
                }
                count = (count + 1) % VerseNotes.Count;
            }
        }
        if (SongTimer.is_section_on[5])
        {
            mat.SetFloat("_Speed", (PCNotes[count] - 23.8f) / 2);

            if (SongTimer.beattrig)
            {
                pdPatch.SendMidiNoteOn(0, PCNotes[count], 127);
                if (PCTrig[count])
                {
                    pdPatch.SendBang("NoteOn");
                    Debug.Log("Bang");
                }
                count = (count + 1) % VerseNotes.Count;
            }

        }
        if (SongTimer.is_section_on[6])
        {
            mat.SetFloat("_Speed", (VerseNotes[count] - 23.8f) / 2);
            if (SongTimer.beattrig)
            {
                pdPatch.SendMidiNoteOn(0, VerseNotes[count], 127);
                if (VerseTrig[count])
                {
                    pdPatch.SendBang("NoteOn");
                    Debug.Log("Bang");
                }
                count = (count + 1) % VerseNotes.Count;
            }
        }
        if (SongTimer.is_section_on[7])
        {
            mat.SetFloat("_Speed", (VerseNotes[count] - 23.8f) / 2);

            if (SongTimer.beattrig)
            {
                pdPatch.SendMidiNoteOn(0, VerseNotes[count], 127);
                if (VerseTrig[count])
                {
                    pdPatch.SendBang("NoteOn");
                    Debug.Log("Bang");
                }
                count = (count + 1) % VerseNotes.Count;
            }
        }
        if (SongTimer.is_section_on[9])
        {
            mat.SetFloat("_Speed", (VerseNotes[count] - 23.8f) / 2);

            if (SongTimer.beattrig)
            {
                pdPatch.SendMidiNoteOn(0, VerseNotes[count], 127);
                if (VerseTrig[count])
                {
                    pdPatch.SendBang("NoteOn");
                    Debug.Log("Bang");
                }
                count = (count + 1) % VerseNotes.Count;
            }
        }
        if (SongTimer.is_section_on[10])
        {
            mat.SetFloat("_Speed", (VerseNotes[count] - 23.8f) / 2);

            if (SongTimer.beattrig)
            {
                pdPatch.SendMidiNoteOn(0, VerseNotes[count], 127);
                if (VerseTrig[count])
                {
                    pdPatch.SendBang("NoteOn");
                    Debug.Log("Bang");
                }
                count = (count + 1) % VerseNotes.Count;
            }
        }
        if (SongTimer.is_section_on[11])
        {
            mat.SetFloat("_Speed", .1f);
            if (once)
            {
                pdPatch.SendBang("Stop");
                once = false;
            }
        }
    }
}
