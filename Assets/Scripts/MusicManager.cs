﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour {
	public AudioClip[] levelMusicChangeArray;

	private AudioSource audioSource;
	// Use this for initialization
	void Awake () {
		DontDestroyOnLoad (gameObject);
	}

	void Start()
	{
		audioSource = GetComponent<AudioSource>();
	}
	
	void OnLevelWasLoaded (int level) {
		AudioClip thisLevelsMusic = levelMusicChangeArray[level];
		if (thisLevelsMusic){
			audioSource.clip = thisLevelsMusic;
			audioSource.loop = true;
			audioSource.Play();
		}
	}
}
