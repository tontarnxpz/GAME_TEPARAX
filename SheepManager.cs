using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepManager : MonoBehaviour
{
    public GameObject[] items; //item ที่ได้จาก obj

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Axe")
        {
            if (PlayerMovement.instance.isAttack == true)
            {
                GetComponent<Animator>().SetTrigger("die"); // animation ตาย
                Invoke("SpawnItem", 1f); // รอ 1 วินาที แล้วให้ obj หายไป
            }
        }
    }

    void SpawnItem() //จะได้ของเมื่อทำอะไรสักอย่างกับ obj
    {
        foreach (var item in items) // loop แสดงไอเทม
        {
            item.SetActive(true); //แสดงไอเทมตามจำนวนที่โยนเข้ามา
        }

        Destroy(GetComponent<SphereCollider>()); // ลบ sphere 
        transform.Find("sheep_mesh").GetComponent<SkinnedMeshRenderer>().enabled = false; //ค้นหา sheep_mesh และเอา model obj ออก
    }
}
