using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using UnityEngine;

//namespace MidiParser
//{
    public class note2bplayed
    {
        int when2bplayed = 0;
        int length_of_note = 0;
        int key2bpressed = 0;
        float length_abs = 0;

        public note2bplayed(int When2bplayed, int Key2bpressed, int Length)
        {
            this.when2bplayed = When2bplayed;
            this.length_of_note = Length;
            this.key2bpressed = Key2bpressed;
        }
        public int time
        {
            get { return when2bplayed; }
            set { when2bplayed = value; }
        }
        public int length
        {
            get { return length_of_note; }
            set { length_of_note = value; }
        }
        public int key
        {
            get { return key2bpressed; }
            set { key2bpressed = value; }
        }
        public float Length_abs
        {
            get { return length_abs; }
            set { length_abs = value; }
        }
        public void update_node(int tpq)
        {
            length_abs = (float)this.length_of_note / (float)(tpq);
        }
    }
//}
