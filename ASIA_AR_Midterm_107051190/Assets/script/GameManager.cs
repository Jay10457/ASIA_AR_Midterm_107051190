using UnityEngine;

public class GameManager : MonoBehaviour
{

    [Header("Girl1")]
    public Transform Girl1;
    [Header("Girl2")]
    public Transform Girl2;
    [Header("JoyStick")]
    public FixedJoystick JoyStick;
    public float Speed = 0f;
    public void Start()
    {
        Debug.Log("Start test");
    }

    public void Update()
    {
        Debug.Log(JoyStick.Vertical);
        Girl1.Rotate(0, JoyStick.Horizontal * Speed, 0);
        Girl1.localScale += new Vector3(1, 1, 1) * JoyStick.Vertical;
        Girl1.localScale = new Vector3(1, 1, 1) * Mathf.Clamp(Girl1.localScale.x, 0.5f, 3.5f);

        Girl2.Rotate(0, JoyStick.Horizontal * Speed, 0);
        Girl2.localScale += new Vector3(1, 1, 1) * JoyStick.Vertical;
        Girl2.localScale = new Vector3(1, 1, 1) * Mathf.Clamp(Girl2.localScale.x, 0.5f, 3.5f);

        Girl2.Rotate(0, JoyStick.Horizontal * Speed, 0);
    }
    [Header("Girl1Ani")]
    public Animator Girl1Ani;
    [Header("Girl2Ani")]
    public Animator Girl2Ani;
    public void PlayAnimation(string aniName)
    {
        Girl1Ani.SetTrigger(aniName);
        Girl2Ani.SetTrigger(aniName);
    }
}
