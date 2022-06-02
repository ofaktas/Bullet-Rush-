using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] private EkranaDokunmaKontrol input;
    [SerializeField] private Rigidbody rgb;
    [SerializeField] private float HareketHızı;


    public void hareket(Vector3 Yön)
    {
        rgb.velocity = Yön * HareketHızı * Time.deltaTime;

    }

    public void FixedUpdate()
    {
        var Yön = new Vector3(input.Yön.x, 0, input.Yön.y);
        hareket(Yön);
    }

}
