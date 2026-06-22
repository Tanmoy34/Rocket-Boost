using UnityEditor.Audio;

using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{

    [SerializeField] float ReloadDelay = 2f;
    [SerializeField] float NextLevelDelay = 4f;
    public AudioClip SucessSFX;
    public AudioClip CrashSFX;
    public ParticleSystem sucessParticle;
    public ParticleSystem crashParticle;
    [SerializeField] InputAction DebugNextLevel;


    bool IsControllable = true;
    bool IsCollideable = true;
    GameAudioController SC;


    void OnEnable()
    {
        DebugNextLevel.Enable();
    }

    void Awake()
    {
        SC = GetComponent<GameAudioController>();
    }




    void OnCollisionEnter(Collision Other)
    {
        if (!IsControllable || !IsCollideable )return;
        string Tag = Other.gameObject.tag;
        switch (Tag)
        {
            case "Friendly":
                Debug.Log("This is Launchpad");
                break;
            case "Fule":
                Debug.Log("Use Fule Content");
                break;
            case "Finish":
                StartSucessSequence();
                break;
            default:
                StartCrashSequence();
                break;

        }
         
    }

    private void StartSucessSequence()
    {
        IsControllable = false;
        GetComponent<MovemntSpeed>().enabled = false;
        SC.PlayAudio(SucessSFX);
        sucessParticle.Play();
        Invoke("LoadNextLevel",NextLevelDelay);
    }

    void StartCrashSequence()
    {
        
        IsControllable = false;
        GetComponent<MovemntSpeed>().enabled = false;
        SC.PlayAudio(CrashSFX);
        crashParticle.Play();   
        Invoke("ReloadLevel",ReloadDelay);
    }

    void ReloadLevel()
    {
        int CurrentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(CurrentScene);
        
    }

    void LoadNextLevel()
    {
        int CurrentScene = SceneManager.GetActiveScene().buildIndex;
        int NextScene = CurrentScene + 1;
        if(NextScene == SceneManager.sceneCountInBuildSettings)
        {
            NextScene = 0;
        }
        SceneManager.LoadScene(NextScene);
        
    }

    void RespopnceToDebugKeys()
    {
        if (DebugNextLevel.IsPressed())
        {
           Invoke("LoadNextLevel", 2f);
        }
        else if (Keyboard.current.cKey.wasPressedThisFrame)
        {
            IsCollideable = !IsCollideable;
            Debug.Log("Collision " + IsCollideable);
        }
    }

    void Update()
    {
        RespopnceToDebugKeys();
    }
}
