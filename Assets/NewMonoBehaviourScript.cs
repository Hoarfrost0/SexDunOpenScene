using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public int a;
    public AudioSource f;
    public Animator AA;
    public GameObject B;

    public void Click()
    {
        f.Play();
        AA.Play("Camera2");
        Destroy (B);
        
    }
}
