using UnityEngine;

public abstract class stats : MonoBehaviour
{
    protected int vitalidade;
    public int Vitalidade
    {
        get { return vitalidade; } 
    }

    protected int constituicao;
    public int Constituicao
    {
        get { return constituicao;}
    }

    protected int forca;
    public int Forca
    {
        get { return forca; }
    }

    protected int inteligencia;
    public int Inteligencia
    {
        get { return inteligencia; }
    }


    public void addStatus(string status, int valor)
    {
        if (status == "vitalidade")
        {
            vitalidade += valor;
        }
        else if (status == "forca")
        {
            forca += valor;
        }
        else if (status == "inteligencia")
        {
            inteligencia += valor;
        }
        else if (status == "constituicao")
        {
            constituicao += valor;
        }
    }
    
}
