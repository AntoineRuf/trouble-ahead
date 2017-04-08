using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {

    public AudioClip[] audioclips;
    private AudioSource audsrc;
    private bool isLocked;
	// Use this for initialization

	void Start () {
        audsrc = GetComponent<AudioSource>();
        isLocked = false;
	}
	
    public void PlayPatternStart()
    {
        if (!isLocked) StartCoroutine(AudioCoroutine(1));
    }
    public void PlaySeize()
    {
        if (!isLocked) StartCoroutine(AudioCoroutine(3));
    }
    public void PlayExpand()
    {
        if (!isLocked) StartCoroutine(AudioCoroutine(4));

    }
    public void PlayDefrag()
    {
        if (!isLocked) StartCoroutine(AudioCoroutine(5));

    }
    public void PlayIsolate()
    {
        if (!isLocked) StartCoroutine(AudioCoroutine(6));

    }

    public void PlayGameEndWarning()
    {
        if (!isLocked) StartCoroutine(AudioCoroutine(7));

    }
    public void PlayGameEnd()
    {
        if (!isLocked) StartCoroutine(AudioCoroutine(8));

    }

    IEnumerator AudioCoroutine(int id)
    {
        isLocked = true;
        audsrc.clip = audioclips[id];
        audsrc.Play();
        yield return new WaitForSeconds(1.5f);
        isLocked = false;
    }
}
