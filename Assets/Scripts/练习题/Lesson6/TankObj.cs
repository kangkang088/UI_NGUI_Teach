using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankObj : MonoBehaviour
{
    public Transform shootPos;
    private AudioClip clip;
    private float nowTime;
    public int nowHP = 100;
    public void Fire()
    {

        AudioSource source = this.gameObject.AddComponent<AudioSource>();
        if (clip == null)
            source.clip = Resources.Load<AudioClip>("Sound/AOE_Effect");
        source.mute = !MusicData.isOpenSound;
        source.volume = MusicData.intensity;
        source.Play();

        Destroy(source, 2);
        GameObject obj = Instantiate(Resources.Load<GameObject>("Obj/Bullet"), shootPos.position, shootPos.rotation);
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GamePanel.Instance.ShowHPProgress();
            nowTime = 0;
            GamePanel.Instance.UpdateHPProgress(nowTime, 5);
        }
        else if (Input.GetMouseButtonUp(0))
        {
            GamePanel.Instance.HideHPProgress();
        }
        else if (Input.GetMouseButton(0))
        {
            nowTime += Time.deltaTime;
            GamePanel.Instance.UpdateHPProgress(nowTime, 5);
            if (nowTime >= 5)
            {
                nowTime = 0;
                nowHP += 5;
                print("当前血量:" + nowHP);
            }
        }
        if (isMoving)
        {
            this.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
            this.transform.rotation = Quaternion.Lerp(this.transform.rotation, Quaternion.LookRotation(moveDir, Vector3.up), roundSpeed * Time.deltaTime);
        }
    }
    public float moveSpeed = 10;
    public float roundSpeed = 10;
    private bool isMoving = false;
    public Vector3 moveDir;
    public void Move(Vector3 dir)
    {
        moveDir.x = dir.x;
        moveDir.z = dir.y;
        isMoving = true;
    }
    public void Stop()
    {
        isMoving = false;
    }
}
