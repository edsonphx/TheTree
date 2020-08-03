//Game o que usa o script https://www.mediafire.com/file/g907c3oohxvvtd2/TheTree.rar
//Esse script quebra o gameObject clicado e gera um novo 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class DestroyOnClick : MonoBehaviour
{
    [SerializeField]
    private GameObject Tree;
    private float _xAxis;
    private float _yAxis;
    private Vector3 _randomPosition;
    public Text points;
    public AudioSource blop;

    void OnMouseUpAsButton()
    {
        _xAxis = UnityEngine.Random.Range(x.Min, x.Max); //limitando os valores de x e y
        _yAxis = UnityEngine.Random.Range(y.Min, y.Max);
        _randomPosition = new Vector3(_xAxis, _yAxis);
        Destroy(gameObject);
        blop.Play(); //Som ao quebrar o objeto
        int pointsInt = Convert.ToInt32(points.text) + 1; // adiciona 1 ponto ao placar iniciado em 0
        points.text = pointsInt.ToString();
        Instantiate(Tree, _randomPosition, Quaternion.identity);
    }
}
