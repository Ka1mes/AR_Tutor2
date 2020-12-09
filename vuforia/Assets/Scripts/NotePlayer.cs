using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CSharpSynth.Effects;
using CSharpSynth.Sequencer;
using CSharpSynth.Synthesis;
using CSharpSynth.Midi;

// BASED ON THE EXAMPLE PROVIDED BY https://github.com/kewlniss/CSharpSynthForUnity WHICH IS THE SOURCE OF THE MIDI LIBRARY
[RequireComponent(typeof(AudioSource))]
public class NotePlayer : MonoBehaviour
{
    //Try also: "FM Bank/fm" or "Analog Bank/analog" for some different sounds
    public string bankFilePath = "GMBank/gm";
    private int bufferSize = 1024;

    //Private 
    private float[] sampleBuffer;
    private float gain = 1f;
    private MidiSequencer midiSequencer;
    private StreamSynthesizer midiStreamSynthesizer;
    private bool[] isNotePlayed = new bool[25];

    void Awake()
    {
        midiStreamSynthesizer = new StreamSynthesizer(44100, 2, bufferSize, 40);
        sampleBuffer = new float[midiStreamSynthesizer.BufferSize];

        midiStreamSynthesizer.LoadBank(bankFilePath);

        midiSequencer = new MidiSequencer(midiStreamSynthesizer);
    }

    // foreground notes will be 'piano' and louder (volume 100), on channel 0
    public void playForegroundNote(int note)
    {
        midiStreamSynthesizer.NoteOn(0, note, 100, 0);
    }

    // background notes will be 'strings' and softer, on channel 1
    public void playBackgroundNote(int note)
    {
        midiStreamSynthesizer.NoteOn(1, note, 30, 49);
    }

    public void stopForegroundNote(int note)
    {
        midiStreamSynthesizer.NoteOff(0, note);
    }

    public void stopBackgroundNote(int note)
    {
        midiStreamSynthesizer.NoteOff(1, note);
    }



    private void OnAudioFilterRead(float[] data, int channels)
    {
        //This uses the Unity specific float method we added to get the buffer
        midiStreamSynthesizer.GetNext(sampleBuffer);

        for (int i = 0; i < data.Length; i++)
        {
            data[i] = sampleBuffer[i] * gain;
        }
    }

    void OnPlayC3()
    {
        if (isNotePlayed[0])
        {
            isNotePlayed[0] = false;
            stopForegroundNote(48);
        }
        else
        {
            isNotePlayed[0] = true;
            playForegroundNote(48);
        }
    }
    void OnPlayCs3()
    {
        if (isNotePlayed[1])
        {
            isNotePlayed[1] = false;
            stopForegroundNote(49);
        }
        else
        {
            isNotePlayed[1] = true;
            playForegroundNote(49);
        }
    }
    void OnPlayD3()
    {
        if (isNotePlayed[2])
        {
            isNotePlayed[2] = false;
            stopForegroundNote(50);
        }
        else
        {
            isNotePlayed[2] = true;
            playForegroundNote(50);
        }
    }
    void OnPlayDs3()
    {
        if (isNotePlayed[3])
        {
            isNotePlayed[3] = false;
            stopForegroundNote(51);
        }
        else
        {
            isNotePlayed[3] = true;
            playForegroundNote(51);
        }
    }
    void OnPlayE3()
    {
        if (isNotePlayed[4])
        {
            isNotePlayed[4] = false;
            stopForegroundNote(52);
        }
        else
        {
            isNotePlayed[4] = true;
            playForegroundNote(52);
        }
    }
    void OnPlayF3()
    {
        if (isNotePlayed[5])
        {
            isNotePlayed[5] = false;
            stopForegroundNote(53);
        }
        else
        {
            isNotePlayed[5] = true;
            playForegroundNote(53);
        }
    }
    void OnPlayFs3()
    {
        if (isNotePlayed[6])
        {
            isNotePlayed[6] = false;
            stopForegroundNote(54);
        }
        else
        {
            isNotePlayed[6] = true;
            playForegroundNote(54);
        }
    }
    void OnPlayG3()
    {
        if (isNotePlayed[7])
        {
            isNotePlayed[7] = false;
            stopForegroundNote(55);
        }
        else
        {
            isNotePlayed[7] = true;
            playForegroundNote(55);
        }
    }
    void OnPlayGs3()
    {
        if (isNotePlayed[8])
        {
            isNotePlayed[8] = false;
            stopForegroundNote(56);
        }
        else
        {
            isNotePlayed[8] = true;
            playForegroundNote(56);
        }
    }
    void OnPlayA3()
    {
        if (isNotePlayed[9])
        {
            isNotePlayed[9] = false;
            stopForegroundNote(57);
        }
        else
        {
            isNotePlayed[9] = true;
            playForegroundNote(57);
        }
    }
    void OnPlayAs3()
    {
        if (isNotePlayed[10])
        {
            isNotePlayed[10] = false;
            stopForegroundNote(58);
        }
        else
        {
            isNotePlayed[10] = true;
            playForegroundNote(58);
        }
    }
    void OnPlayB3()
    {
        if (isNotePlayed[11])
        {
            isNotePlayed[11] = false;
            stopForegroundNote(59);
        }
        else
        {
            isNotePlayed[11] = true;
            playForegroundNote(59);
        }
    }
    void OnPlayC4()
    {
        if (isNotePlayed[12])
        {
            isNotePlayed[12] = false;
            stopForegroundNote(60);
        }
        else
        {
            isNotePlayed[12] = true;
            playForegroundNote(60);
        }
    }
    void OnPlayCs4()
    {
        if (isNotePlayed[13])
        {
            isNotePlayed[13] = false;
            stopForegroundNote(61);
        }
        else
        {
            isNotePlayed[13] = true;
            playForegroundNote(61);
        }
    }
    void OnPlayD4()
    {
        if (isNotePlayed[14])
        {
            isNotePlayed[14] = false;
            stopForegroundNote(62);
        }
        else
        {
            isNotePlayed[14] = true;
            playForegroundNote(62);
        }
    }
    void OnPlayDs4()
    {
        if (isNotePlayed[15])
        {
            isNotePlayed[15] = false;
            stopForegroundNote(63);
        }
        else
        {
            isNotePlayed[15] = true;
            playForegroundNote(63);
        }
    }
    void OnPlayE4()
    {
        if (isNotePlayed[16])
        {
            isNotePlayed[16] = false;
            stopForegroundNote(64);
        }
        else
        {
            isNotePlayed[16] = true;
            playForegroundNote(64);
        }
    }
    void OnPlayF4()
    {
        if (isNotePlayed[17])
        {
            isNotePlayed[17] = false;
            stopForegroundNote(65);
        }
        else
        {
            isNotePlayed[17] = true;
            playForegroundNote(65);
        }
    }
    void OnPlayFs4()
    {
        if (isNotePlayed[18])
        {
            isNotePlayed[18] = false;
            stopForegroundNote(66);
        }
        else
        {
            isNotePlayed[18] = true;
            playForegroundNote(66);
        }
    }
    void OnPlayG4()
    {
        if (isNotePlayed[19])
        {
            isNotePlayed[19] = false;
            stopForegroundNote(67);
        }
        else
        {
            isNotePlayed[19] = true;
            playForegroundNote(67);
        }
    }
    void OnPlayGs4()
    {
        if (isNotePlayed[20])
        {
            isNotePlayed[20] = false;
            stopForegroundNote(68);
        }
        else
        {
            isNotePlayed[20] = true;
            playForegroundNote(68);
        }
    }
    void OnPlayA4()
    {
        if (isNotePlayed[21])
        {
            isNotePlayed[21] = false;
            stopForegroundNote(69);
        }
        else
        {
            isNotePlayed[21] = true;
            playForegroundNote(69);
        }
    }
    void OnPlayAs4()
    {
        if (isNotePlayed[22])
        {
            isNotePlayed[22] = false;
            stopForegroundNote(70);
        }
        else
        {
            isNotePlayed[22] = true;
            playForegroundNote(70);
        }
    }
    void OnPlayB4()
    {
        if (isNotePlayed[23])
        {
            isNotePlayed[23] = false;
            stopForegroundNote(71);
        }
        else
        {
            isNotePlayed[23] = true;
            playForegroundNote(71);
        }
    }
    void OnPlayC5()
    {
        if (isNotePlayed[24])
        {
            isNotePlayed[24] = false;
            stopForegroundNote(72);
        }
        else
        {
            isNotePlayed[24] = true;
            playForegroundNote(72);
        }
    }

}
