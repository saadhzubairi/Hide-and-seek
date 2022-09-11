using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharController : MonoBehaviour
{
    private Animator animator;
    private int VertHash = Animator.StringToHash("Vertical");
    private int HorizHash = Animator.StringToHash("Horizontal");
    // Start is called before the first frame update
    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float Horz = Input.GetAxis("Horizontal");
        float Vert = Input.GetAxis("Vertical");

        animator.SetFloat(HorizHash, Horz, 0.1f, Time.deltaTime);
        animator.SetFloat(VertHash, Vert, 0.1f, Time.deltaTime);
    }
}
