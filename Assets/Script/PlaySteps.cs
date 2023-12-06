using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class PlaySteps : MonoBehaviour
{
    PlayableDirector director;

    public List<Step> steps;

    // Start is called before the first frame update
    void Start()
    {
        director = GetComponent<PlayableDirector>();
    }

    [System.Serializable]
    public class Step
    {
        public string name;
        public float time;
        public bool hasplayed = false;
    }

    public void PlayStepsIndex(int index)
    {
        Step step = steps[index];

        if(!step.hasplayed)
        {
            step.hasplayed = true;

            director.Stop();
            director.time = step.time;
            director.Play();
        }
    }

}
