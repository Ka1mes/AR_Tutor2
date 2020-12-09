using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyController : MonoBehaviour
{
    
    public float bpm;
    public GameObject[] keys;
    
    
    private Program p;

    private float fallSpeedMod = 0.083362319f; // => 1bpm
    private float fallSpeed;
    private float quarterNoteLen = 1.0f;
    private bool spawnedKeys = false;
    private float spawntime = 0.0f;
    private float initialOffset = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        setBPM(bpm);
        initialOffset *= quarterNoteLen;
        p = new Program();
    }

    private void Update()
    {/*
        if (Time.time > spawntime)
        {
            if (!spawnedKeys)
            {
                for (int i = 0; i < 25; i++)
                {
                    SpawnKey(i, 1.0f, initialOffset + 1.0f*i);
                }
                spawnedKeys = true;
            }
            spawntime += 20.0f;
        }*/

    }
    // keyIndex from 0 to 24 (incl) going from C3 - C5
    // keyLength is the note length in quarter notes
    // height is the n-th quarter note to be played
    // this ensures standardized note height and spacing
    void SpawnKey(int keyIndex, float keyLength, float height)
    {
        // make key
        GameObject key = Instantiate(keys[keyIndex], this.transform);
        height = height + 0.5f * keyLength;
        // set shape and height
        key.transform.Translate(Vector3.up * height * quarterNoteLen * (0.05f));
       //key.transform.Translate(Vector3.up * 0.5f * keyLength);
        Vector3 keySize = key.transform.localScale;
        keySize.y = quarterNoteLen * keyLength * this.transform.localScale.y;
        key.transform.localScale = keySize;

        // set fallspeed
        key.GetComponent<fallingKey>().fallSpeed = fallSpeed;

    }

    void setBPM(float newbpm)
    {
        bpm = newbpm;
        fallSpeed = bpm * fallSpeedMod;
    }

    public void playDuckling()
    {
        for (int i = 0; i < p.duckling.Count; ++i)
        {
            SpawnKey(p.duckling[i].key, p.duckling[i].length / 480.0f, initialOffset + p.duckling[i].time / 480.0f);
        }  
    }

    public void playSong()
    {
        for (int i = 0; i < p.song.Count; ++i)
        {
            int key = p.song[i].key;
            if (key > 0)
            {
                while (key > 24)
                    key -= 12;
                SpawnKey(key, p.song[i].length / 480.0f, initialOffset + p.song[i].time / 480.0f);
            }
            Debug.Log("spawning key: " + p.song[i].key + " len " + p.song[i].length / 480 + " index " + initialOffset + p.song[i].time / 480);
        }
    }   
}
