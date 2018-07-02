using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private List<AudioSource> _bgmList;
    private AudioSource _currentBgm;

    private static AudioManager _instance;

    public static AudioManager Instance
    {
        get
        {
            if (_instance != null) return _instance;
            _instance = FindObjectOfType<AudioManager>();
            if (_instance == null)
            {
                Debug.LogError(typeof(AudioManager) + " is none");
            }
            return _instance;
        }
    }

    void Start()
    {
        _currentBgm = _bgmList[0];
    }
    
    public void PlayBgm(int index)
    {
        _currentBgm.Stop();
        _currentBgm = _bgmList[index];
        _currentBgm.time = 0.0f;
        _currentBgm.Play();
    }

    public void StopBgm()
    {
        _currentBgm.Stop();
        _currentBgm.clip = null;
    }
}