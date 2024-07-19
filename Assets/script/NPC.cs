using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    //variaveis
    public int saude = 5;
    public int level = 1;
    private float speed = 0.1f;
    //criando a variável do grupo vazio
    private GameObject group;

   

    // Start is called before the first frame update
    void Start()
    {
        //avisando que o grupo está vazio
        group = new GameObject("CubeGroup");

        //GameObject criar um novo objeto
        GameObject cube1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //adicionando posição
        cube1.transform.position = new Vector3(0, 0, 0);
        //adicionando objeto dentro do Grupo
        cube1.transform.parent = group.transform;

        GameObject cube2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube2.transform.position = new Vector3(-0.5f, 1, 0);
        cube2.transform.parent = group.transform;

        GameObject cube3 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube3.transform.position = new Vector3(0.5f, 1, 0);
        cube3.transform.parent = group.transform;

        GameObject cube4 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube4.transform.position = new Vector3(0.5f, 2, 0);
        cube4.transform.parent = group.transform;

        GameObject cube5 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube5.transform.position = new Vector3(-0.5f, 2, 0);
        cube5.transform.parent = group.transform;


        GameObject cube6 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube6.transform.position = new Vector3(0, 3, 0);
        cube6.transform.parent = group.transform;






        saude = saude + level;
        print("Vidas: " + saude);

        


    }

    // Update is called once per frame
    void Update()
    {
        //criando variavel de posição
        //vector3 jogos 3d/vector2 jogos 2d

        group.transform.position = group.transform.position + new Vector3(speed, 0, 0);


    }
}
