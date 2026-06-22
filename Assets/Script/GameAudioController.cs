using UnityEngine;

public class GameAudioController : MonoBehaviour
{
    AudioSource audioSource;
    public bool IsPlayeing;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void PlayAudio(AudioClip audio)
    {
       audioSource.PlayOneShot(audio);
    }
    public void StopSound()
    {
        audioSource.Stop();
    }

    public void DeactivateAudioSourceOnceCrash()
    {
        audioSource.enabled= false;
    }

    void Update()
    {
        IsPlayeing = audioSource.isPlaying;
    }
}