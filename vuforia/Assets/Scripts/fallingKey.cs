using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallingKey : MonoBehaviour
{
    public string keyName;
    public int midiVal;

    [HideInInspector]
    public float fallSpeed;

    private ScoreKeeper sk;
    private NotePlayer np;
    private bool hasIncrementedScore = false;
    private bool colliding = false;
    private bool keyPressed = false;
    private bool canDestroy = false;

    // Start is called before the first frame update
    void Start()
    {
        sk = this.transform.parent.GetComponent<ScoreKeeper>();
        // np = this.transform.parent.GetComponent<NotePlayer>();
        np = this.transform.parent.GetComponentInChildren<NotePlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime * 0.01f, Space.Self);
        
        // this can be modified to reward longer keypresses for longer notes
        if (colliding && !hasIncrementedScore && keyPressed)
        {
            sk.incrementScore();
            hasIncrementedScore = true;
        }

    }

    private void LateUpdate()
    {
        if (canDestroy)
        {
            
            Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "keyboardSurface")
        {
            colliding = true;
            np.playBackgroundNote(midiVal);
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "keyboardSurface")
        {
            colliding = false;
            np.stopBackgroundNote(midiVal);
            canDestroy = true;
        }
    }

    // =================== Handle key events here ====================== //
    void OnPlayC3()
    {
        if (keyName.Equals("C3"))
        {
            if (keyPressed)
            {
                keyPressed = false;
                
            }
            else
            {
                keyPressed = true;
                
            }
        }
    }

    void OnPlayCs3()
    {
        if (keyName.Equals("C#3"))
        {
            if (keyPressed)
            {
                keyPressed = false;
                
            }
            else
            {
                keyPressed = true;
                
            }

        }
    }

    void OnPlayD3()
    {
        if (keyName.Equals("D3"))
        {
            if (keyPressed)
            {
                keyPressed = false;
                
            }
            else
            {
                keyPressed = true;
                
            }

        }
    }

    void OnPlayDs3()
    {
        if (keyName.Equals("D#3"))
        {
            if (keyPressed)
            {
                keyPressed = false;
                
            }
            else
            {
                keyPressed = true;
                
            }

        }
    }

    void OnPlayE3()
    {
        if (keyName.Equals("E3"))
        {
            if (keyPressed)
            {
                keyPressed = false;
                
            }
            else
            {
                keyPressed = true;
                
            }

        }
    }

    void OnPlayF3()
    {
        if (keyName.Equals("F3"))
        {
            if (keyPressed)
            {
                keyPressed = false;
                
            }
            else
            {
                keyPressed = true;
                
            }

        }
    }

    void OnPlayFs3()
    {
        if (keyName.Equals("F#3"))
        {
            if (keyPressed)
            {
                keyPressed = false;
                
            }
            else
            {
                keyPressed = true;
                
            }

        }
    }

    void OnPlayG3()
    {
        if (keyName.Equals("G3"))
        {
            if (keyPressed)
            {
                keyPressed = false;
                
            }
            else
            {
                keyPressed = true;
                
            }

        }
    }

    void OnPlayGs3()
    {
        if (keyName.Equals("G#3"))
        {
            if (keyPressed)
            {
                keyPressed = false;
                
            }
            else
            {
                keyPressed = true;
                
            }

        }
    }

    void OnPlayA3()
    {
        if (keyName.Equals("A3"))
        {
            if (keyPressed)
            {
                keyPressed = false;
                
            }
            else
            {
                keyPressed = true;
                
            }

        }
    }

    void OnPlayAs3()
    {
        if (keyName.Equals("A#3"))
        {
            if (keyPressed)
            {
                keyPressed = false;
                
            }
            else
            {
                keyPressed = true;
                
            }

        }
    }

    void OnPlayB3()
    {
        if (keyName.Equals("B3"))
        {
            if (keyPressed)
            {
                keyPressed = false;
                
            }
            else
            {
                keyPressed = true;
                
            }

        }
    }

    void OnPlayC4()
    {
        if (keyName.Equals("C4"))
        {
            if (keyPressed)
            {
                keyPressed = false;
                
            }
            else
            {
                keyPressed = true;
                
            }

        }
    }

    void OnPlayCs4()
    {
        if (keyName.Equals("C#4"))
        {
            if (keyPressed)
            {
                keyPressed = false;
                
            }
            else
            {
                keyPressed = true;
                
            }

        }
    }

    void OnPlayD4()
    {
        if (keyName.Equals("D4"))
        {
            if (keyPressed)
            {
                keyPressed = false;
                
            }
            else
            {
                keyPressed = true;
                
            }

        }
    }
    void OnPlayDs4()
    {
        if (keyName.Equals("D#4"))
        {
            if (keyPressed)
            {
                keyPressed = false;
                
            }
            else
            {
                keyPressed = true;
                
            }

        }
    }

    void OnPlayE4()
    {
        if (keyName.Equals("E4"))
        {
            if (keyPressed)
            {
                keyPressed = false;
                
            }
            else
            {
                keyPressed = true;
                
            }

        }
    }
    void OnPlayF4()
    {
        if (keyName.Equals("F4"))
        {
            if (keyPressed)
            {
                keyPressed = false;
                
            }
            else
            {
                keyPressed = true;
                
            }

        }
    }
    void OnPlayFs4()
    {
        if (keyName.Equals("F#4"))
        {
            if (keyPressed)
            {
                keyPressed = false;
                
            }
            else
            {
                keyPressed = true;
                
            }

        }
    }
    void OnPlayG4()
    {
        if (keyName.Equals("G4"))
        {
            if (keyPressed)
            {
                keyPressed = false;
                
            }
            else
            {
                keyPressed = true;
                
            }

        }
    }
    void OnPlayGs4()
    {
        if (keyName.Equals("Gs4"))
        {
            if (keyPressed)
            {
                keyPressed = false;
                
            }
            else
            {
                keyPressed = true;
                
            }

        }
    }
    void OnPlayA4()
    {
        if (keyName.Equals("A4"))
        {
            if (keyPressed)
            {
                keyPressed = false;
                
            }
            else
            {
                keyPressed = true;
                
            }

        }
    }
    void OnPlayAs4()
    {
        if (keyName.Equals("A#4"))
        {
            if (keyPressed)
            {
                keyPressed = false;
                
            }
            else
            {
                keyPressed = true;
                
            }

        }
    }
    void OnPlayB4()
    {
        if (keyName.Equals("B4"))
        {
            if (keyPressed)
            {
                keyPressed = false;
                
            }
            else
            {
                keyPressed = true;
                
            }

        }
    }
    void OnPlayC5()
    {
        if (keyName.Equals("C5"))
        {
            if (keyPressed)
            {
                keyPressed = false;
                
            }
            else
            {
                keyPressed = true;
                
            }

        }
    }

}
