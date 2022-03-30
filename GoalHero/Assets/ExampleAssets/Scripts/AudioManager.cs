using UnityEngine.Audio;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioClip audioClip;
    static AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioClip = Resources.Load<AudioClip>("Audio/SuccessGoal");
        audioSource = GetComponent<AudioSource>();
        Debug.Log("loaded");
    }

    public static void PlaySound()
    {
        audioSource.Play();
        Debug.Log("played");
    }
}
