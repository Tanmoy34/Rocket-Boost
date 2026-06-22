using Unity.VisualScripting;
using UnityEngine;
using UnityEditor.Audio;
using UnityEngine.InputSystem;

public class MovemntSpeed : MonoBehaviour
{

    [SerializeField] InputAction trust;
    [SerializeField] InputAction Rotation;
    [SerializeField] float thrustStrenght = 10000.0f;
    [SerializeField] float rotationSrenght = 100.0f; 
    [SerializeField] ParticleSystem mainBoosterParticle;
    [SerializeField] ParticleSystem leftBoosterParticle;
    [SerializeField] ParticleSystem rightBoosterParticle;
    Rigidbody rb;

    GameAudioController SC;
    [SerializeField] AudioClip TrustAudio;


    void OnEnable()
    {
        trust.Enable();
        Rotation.Enable();
    }

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        SC = GetComponent<GameAudioController>();
    }


    void FixedUpdate()
    {
        ProcessTrust();
        ProcessRotation();
    }

    private void ProcessRotation()
    {
        float rotationInput = Rotation.ReadValue<float>();
        if (rotationInput > 0)
        {
            RotateLeft();
        }
        else if (rotationInput < 0)
        {
            RotateRight();
        }
        else
        {
            StopRotating();
        }
    }

    private void StopRotating()
    {
        rightBoosterParticle.Stop();
        leftBoosterParticle.Stop();
    }

    private void RotateLeft()
    {
        ApplyRotation(-rotationSrenght);
        rightBoosterParticle.Play();
    }

    private void RotateRight()
    {
        ApplyRotation(rotationSrenght);
        leftBoosterParticle.Play();
    }

    void ApplyRotation(float rotationThisFrame)
    {
        rb.freezeRotation = true;
        transform.Rotate(Vector3.forward * rotationThisFrame * Time.fixedDeltaTime);
        rb.freezeRotation =false;
    }




    //for Thruster process
    void ProcessTrust()
    {
        if (trust.IsPressed())
        {
            StartTrusting();

        }
        else
        {
            StopTrusting();
        }
    }

    void StopTrusting()
    {
        SC.StopSound();
        mainBoosterParticle.Stop();
    }

    void StartTrusting()
    {
        rb.AddRelativeForce(Vector3.up * thrustStrenght * Time.fixedDeltaTime);
        mainBoosterParticle.Play();
        if (!SC.IsPlayeing)
        {
            SC.PlayAudio(TrustAudio);
        }
    }

    void Update()
    {
        
        
    }
}
