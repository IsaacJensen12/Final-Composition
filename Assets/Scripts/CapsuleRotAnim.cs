using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleRotAnim : MonoBehaviour
{
    public Transform OscObj;
    [SerializeField]
    float speed;
    public LibPdInstance pdPatch;
    [SerializeField]
    SongTimer SongTimer;
    public Quaternion startQuaternion;
    bool once = true;
    bool twice = true;
    bool thrice = true;
    void Start()
    {
        startQuaternion = transform.rotation;
    }


    void Update()
    {
        
        if (SongTimer.is_section_on[3])
        {
            OscObj.transform.Rotate(0, 0, speed * Time.deltaTime, Space.Self);
            if (once)
            {
                pdPatch.SendBang("ArpOn");
                once = false;
            }
        }
        
        if (SongTimer.is_section_on[4])
        {
            OscObj.transform.Rotate(0, 0, speed * Time.deltaTime, Space.Self);
            if (twice)
            {
                pdPatch.SendBang("rev_bang");
                Debug.Log("REVBANG");
                twice = false;
            }
        }
        if (SongTimer.is_section_on[5])
        {
            OscObj.transform.rotation = startQuaternion;

            if (thrice)
            {
                pdPatch.SendBang("ArpOff");
                thrice = false;
                once = true;
                twice = true;
            }
        }
        if (SongTimer.is_section_on[9])
        {
            OscObj.transform.Rotate(0, 0, speed * Time.deltaTime, Space.Self);
            if (once)
            {
                pdPatch.SendBang("ArpOn");
                once = false;
                thrice = true;
            }
        }

        if (SongTimer.is_section_on[10])
        {
            OscObj.transform.Rotate(0, 0, speed * Time.deltaTime, Space.Self);
            if (twice)
            {
                pdPatch.SendBang("rev_bang");
                Debug.Log("REVBANG");
                twice = false;
            }
        }
        if (SongTimer.is_section_on[11])
        {
            OscObj.transform.rotation = startQuaternion;

            if (thrice)
            {
                pdPatch.SendBang("ArpOff");
                thrice = false;
            }
        }
    }
}
