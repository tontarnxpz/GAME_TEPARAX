using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepManager : MonoBehaviour
{
    public GameObject[] items; //item �����ҡ obj

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
                GetComponent<Animator>().SetTrigger("die"); // animation ���
                Invoke("SpawnItem", 1f); // �� 1 �Թҷ� ������� obj ����
            }
        }
    }

    void SpawnItem() //����ͧ����ͷ������ѡ���ҧ�Ѻ obj
    {
        foreach (var item in items) // loop �ʴ�����
        {
            item.SetActive(true); //�ʴ���������ӹǹ����¹�����
        }

        Destroy(GetComponent<SphereCollider>()); // ź sphere 
        transform.Find("sheep_mesh").GetComponent<SkinnedMeshRenderer>().enabled = false; //���� sheep_mesh ������ model obj �͡
    }
}
