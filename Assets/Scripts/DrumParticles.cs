using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrumParticles : MonoBehaviour
{
    public LibPdInstance pdPatch;
    public ParticleSystem kickParticles;
    public ParticleSystem snareParticles;
    public ParticleSystem hihatParticles;
    public List<AudioClip> sounds;
    string[] drum_type = new string[] { "Kick", "Snare", "Hi-Hat" };
    [SerializeField]
    SongTimer SongTimer;
    float t;
    float ramp;
    [SerializeField]
    List<bool> kick;
    [SerializeField]
    List<bool> snare;
    [SerializeField]
    List<bool> hihat;

    /*List<bool> Kick0 = new List<bool> { true, false, true, false, true, false, true, false };
    List<bool> Kick1 = new List<bool> { true, false, false, false, true, false, false, false };
    List<bool> Kick2 = new List<bool> { true, false, false, false, true, false, false, true };
    List<bool> Snare0 = new List<bool> { true, false, true, false, true, false, true, false };
    List<bool> Snare1 = new List<bool> { false, false, true, false, false, false, true, false };
    List<bool> Snare2 = new List<bool> { true, true, true, true, true, true, true, true };
    List<bool> HiHat0 = new List<bool> { false, true, false, true, false, true, false, true };
    List<bool> HiHat1 = new List<bool> { false, true, false, true, false, true, false, false };
    List<bool> HiHat2 = new List<bool> { true, true, true, true, true, true, true, true };
    */
    int count = 0;
    bool was_section_on;
    bool once = true;
    void Start()
    {

        kickParticles.Stop();
        snareParticles.Stop();
        hihatParticles.Stop();
        for (int i = 0; i < sounds.Count; i++)
        {
            string name = sounds[i].name + ".wav";
            pdPatch.SendSymbol(drum_type[i], name);
        }


    }

    void Update()
    {

        if (SongTimer.is_section_on[0])
        {
            if (SongTimer.beattrig)
            {

                count = (count + 1) % SongTimer.timeSignature;
            }

        }
        if (SongTimer.is_section_on[1])
        {
            if (SongTimer.beattrig)
            {
                count = (count + 1) % SongTimer.timeSignature;
                if (kick[count])
                {
                    pdPatch.SendBang("kick_bang");
                    kickParticles.Play();
                }   

            }
        }
        if (SongTimer.is_section_on[2])
        {
            if (SongTimer.beattrig)
            {
                count = (count + 1) % SongTimer.timeSignature;
                if (kick[count])
                {
                    pdPatch.SendBang("kick_bang");
                    kickParticles.Play();
                    
                }
                if (snare[count])
                {
                    pdPatch.SendBang("snare_bang");
                    snareParticles.Play();
                }
            }
        }
        if (SongTimer.is_section_on[3])
        {
            if (SongTimer.beattrig)
            {
                count = (count + 1) % SongTimer.timeSignature;
                if (kick[count])
                {
                    pdPatch.SendBang("kick_bang");
                    kickParticles.Play();
                    
                }
                if (hihat[count])
                {
                    pdPatch.SendBang("Hi-Hat_bang");
                    hihatParticles.Play();
                }
                if (snare[count])
                {
                    pdPatch.SendBang("snare_bang");
                    snareParticles.Play();
                }

            }
            
        }
        if (SongTimer.is_section_on[4])
        {
            if (SongTimer.beattrig)
            {
                count = (count + 1) % SongTimer.timeSignature;
                if (kick[count])
                {
                    pdPatch.SendBang("kick_bang");
                    kickParticles.Play();

                }
                if (hihat[count])
                {
                    pdPatch.SendBang("Hi-Hat_bang");
                    hihatParticles.Play();
                }
                if (snare[count])
                {
                    pdPatch.SendBang("snare_bang");
                    snareParticles.Play();
                }

            }

        }
        if (SongTimer.is_section_on[5])
        {
            hihatParticles.Stop();
            snareParticles.Stop();
            if (SongTimer.beattrig)
            {
                count = (count + 1) % SongTimer.timeSignature;
                if (kick[count])
                {
                    pdPatch.SendBang("kick_bang");
                    kickParticles.Play();

                }
            }

        }
        if (SongTimer.is_section_on[6])
        {
            if (SongTimer.beattrig)
            {
                count = (count + 1) % SongTimer.timeSignature;
                if (kick[count])
                {
                    pdPatch.SendBang("kick_bang");
                    kickParticles.Play();
                }

            }
        }
        if (SongTimer.is_section_on[7])
        {
            if (SongTimer.beattrig)
            {
                count = (count + 1) % SongTimer.timeSignature;
                if (kick[count])
                {
                    pdPatch.SendBang("kick_bang");
                    kickParticles.Play();

                }
                if (snare[count])
                {
                    pdPatch.SendBang("snare_bang");
                    snareParticles.Play();
                }
            }
        }
        if (SongTimer.is_section_on[8])
        {
            kickParticles.Stop();
            hihatParticles.Stop();
            if (SongTimer.beattrig)
            {
                
                count = (count + 1) % SongTimer.timeSignature;
                if (snare[count])
                {
                    pdPatch.SendBang("snare_bang");
                    snareParticles.Play();
                }

            }

        }
        if (SongTimer.is_section_on[9])
        {
            if (SongTimer.beattrig)
            {
                count = (count + 1) % SongTimer.timeSignature;
                if (kick[count])
                {
                    pdPatch.SendBang("kick_bang");
                    kickParticles.Play();

                }
                if (hihat[count])
                {
                    pdPatch.SendBang("Hi-Hat_bang");
                    hihatParticles.Play();
                }
                if (snare[count])
                {
                    pdPatch.SendBang("snare_bang");
                    snareParticles.Play();
                }

            }

        }
        if (SongTimer.is_section_on[10])
        {
            if (SongTimer.beattrig)
            {
                count = (count + 1) % SongTimer.timeSignature;
                if (kick[count])
                {
                    pdPatch.SendBang("kick_bang");
                    kickParticles.Play();

                }
                if (hihat[count])
                {
                    pdPatch.SendBang("Hi-Hat_bang");
                    hihatParticles.Play();
                }
                if (snare[count])
                {
                    pdPatch.SendBang("snare_bang");
                    snareParticles.Play();
                }

            }

        }
        if (SongTimer.is_section_on[11])
        {
            kickParticles.Stop();
            hihatParticles.Stop();
            snareParticles.Stop();
            if (once)
            {
                pdPatch.SendBang("Stop");
                once = false;
            }
        }
    }
}
