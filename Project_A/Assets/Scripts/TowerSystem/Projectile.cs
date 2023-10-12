using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Rigidbody rd;        //���ο��� ����� rd

    public float moveSpped;     //�̵��ӵ�
    public float damagedAmount;     //������ ��
    private bool hasDamaged;        //flag ����

    
    void Start()
    {
        rd = GetComponent<Rigidbody>();
        rd.velocity = transform.forward * moveSpped;        //rd�� ���� �������� �Ѿ� �̵��ӵ��� �Է�
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy" && !hasDamaged)
        {
            hasDamaged = true;
        }

        Destroy(gameObject);        //Trigger �浹�� �Ͼ�� �ı�
    }
}
