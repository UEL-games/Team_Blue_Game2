using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ABW_Flashlight_Click : MonoBehaviour
// This script should activate a "click (long)" audio activate when the "E" key is pressed
// Clciking noise should activate along with the Light from the phone's Flashlight

// This script allows you to toggle music to play and stop.
// Assign an AudioSource to a GameObject and attach an Audio Clip in the Audio Source. Attach this script to the GameObject.
// Sould be able to use with other Audio files

// source:
// docs.unity3d.com/ScriptReference/AudioSource .html


{

    AudioSource fl_click;
    public GameObject go_phone;

        // Play "click (long)" / Play the music
        bool m_Play;
        // Ensures music isn't being looped
        bool m_ToggleChange;

    void Start ()
    {
        // Fetch AudioSource from GameObject
        fl_click = GetComponent<AudioSource>();
        // Ensure the toggle is set to true so music plays at the start
        m_Play = true;
	}

    void Update()
    {
        if (m_Play == true && m_ToggleChange == true)
        {
            // Play the audio you attached to the Audio Source
            // Hopefully this should make "click (long)" once it's set in unity
            fl_click.Play();
            // Ensures audio doesn't play more than once
            m_ToggleChange = false;
        }

        if (m_Play == false && m_ToggleChange == true)
        {
            //Stop Audio
            fl_click.Stop();
            // Ensures audio doesn't play more than once
            m_ToggleChange = false;
        }
    }

        void OnGUI()
            {
            // Switch this toggle to activate and deactivate the parent GameObject
            m_Play = GUI.Toggle(new Rect(10, 10, 100, 30), m_Play, "Play Msuic");

                // Dectect if there is a change with the toggle
                if (GUI.changed)
            {
                // Change to true to show that there was just a change in the toggle state
                m_ToggleChange = true;
            }
        }
}
