using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//namespace MidiFileTests
//{
    using System;

    //using MidiParser;
    //using System.Collections.Generic;
    
    

    public class Program : MonoBehaviour
{
    public List<note2bplayed> duckling;
    public List<note2bplayed> song;
    public Program()
    {
        //const string Path = "C:/MIDI/1.mid";
        const string Path = "Assets/Resources/Midis/1.mid";

        note2bplayed test = new note2bplayed(0,0,0);
        song = new List<note2bplayed>();            

        Debug.Log("Parsing: "+ Path);

        var midiFile = new MidiFile_2(Path);

        Debug.Log("Format: "+ midiFile.Format);
        Debug.Log("TicksPerQuarterNote: "+ midiFile.TicksPerQuarterNote);
        Debug.Log("TracksCount: "+ midiFile.TracksCount);

        int unresolved_nodes = 0;
        foreach (var track in midiFile.Tracks)
        {                
            //Debug.Log("\nTrack: {0}\n", track.Index);
        //var track = midiFile.Tracks[2];
            foreach (var midiEvent in track.MidiEvents)
            {
                
                const string Format = "{0} Channel {1} Time {2} Args {3} {4}\n";
                if (midiEvent.MidiEventType == MidiEventType.MetaEvent)
                {
                /*Debug.Log(midiEvent.Channel);
                    Debug.Log(
                        Format,
                        midiEvent.MetaEventType,
                        "-",
                        midiEvent.Time,
                        midiEvent.Arg2,
                        midiEvent.Arg3);*/                    
                }
                else
                {
                    if (midiEvent.Channel == 1)
                    {                        
                        note2bplayed tempnode = new note2bplayed(midiEvent.Time,midiEvent.Arg2,0);
                        if (midiEvent.MidiEventType == MidiEventType.NoteOn)
                        {
                                //Debug.Log("noteon");
                                unresolved_nodes++;
                                song.Add(tempnode);
                        }
                        else if (midiEvent.MidiEventType == MidiEventType.NoteOff)
                        {
                            //Debug.Log("noteoff");
                            bool found = false;
                            int counter = song.Count-1;
                            while ((!found)&&(counter>0))
                            {
                                if (song[counter].key == midiEvent.Arg2 && song[counter].length==0)
                                {
                                    song[counter].length = midiEvent.Time - song[counter].time;
                                    unresolved_nodes--;                                        
                                    song[counter].key = song[counter].key - 48;
                                        
                                    found = true;
                                }
                                counter--;
                            }
                        }
                        else
                        {
                            //do nothing
                        }

                    }
                        /*Debug.Log(
                            Format,
                            midiEvent.MidiEventType,
                            midiEvent.Channel,
                            midiEvent.Time,
                            midiEvent.Arg2,
                            midiEvent.Arg3);*/
                }
            }
        }
        song.Sort((p1, p2) => p1.time.CompareTo(p2.time));
            
        foreach (var note in song)
        {
            note.update_node(midiFile.TicksPerQuarterNote);
            if (note.key > 0)
            {
                //Debug.Log("Start: " + note.time + " Key: " + note.key + " Length: " + note.length + "Length: " + note.Length_abs);
            }
        }
        duckling = new List<note2bplayed>();
        duckling.Add(new note2bplayed(480 * 1, 12, 480));
        duckling.Add(new note2bplayed(480 * 2, 14, 480));
        duckling.Add(new note2bplayed(480 * 3, 16, 480));
        duckling.Add(new note2bplayed(480 * 4, 17, 480));
        duckling.Add(new note2bplayed((int)(480 * 5.0f), 19, 480 * 2));
        duckling.Add(new note2bplayed((int)(480 * 7.0f), 19, 480 * 2));
        duckling.Add(new note2bplayed(480 * 9, 21, 480));
        duckling.Add(new note2bplayed(480 * 10, 21, 480));
        duckling.Add(new note2bplayed(480 * 11, 21, 480));
        duckling.Add(new note2bplayed(480 * 12, 21, 480));
        duckling.Add(new note2bplayed(480 * 13, 19, 480 * 4));
        duckling.Add(new note2bplayed(480 * 17, 21, 480));
        duckling.Add(new note2bplayed(480 * 18, 21, 480));
        duckling.Add(new note2bplayed(480 * 19, 21, 480));
        duckling.Add(new note2bplayed(480 * 20, 21, 480));
        duckling.Add(new note2bplayed(480 * 21, 19, 480 * 4));
        duckling.Add(new note2bplayed(480 * 25, 17, 480));
        duckling.Add(new note2bplayed(480 * 26, 17, 480));
        duckling.Add(new note2bplayed(480 * 27, 17, 480));
        duckling.Add(new note2bplayed(480 * 28, 17, 480));
        duckling.Add(new note2bplayed(480 * 29, 16, 480 * 2));
        duckling.Add(new note2bplayed(480 * 31, 16, 480 * 2));
        duckling.Add(new note2bplayed(480 * 33, 19, 480));
        duckling.Add(new note2bplayed(480 * 34, 19, 480));
        duckling.Add(new note2bplayed(480 * 35, 19, 480));
        duckling.Add(new note2bplayed(480 * 36, 19, 480));
        duckling.Add(new note2bplayed(480 * 37, 12, 480 * 4));

        //Console.ReadLine();
    }

    }
    
//}