using UnityEngine;
using TMPro;
public class Player : stats
{
    public Enemy Enemy;
    public Canvas myCanvas;
    public TextMeshProUGUI textoFinal;
    public TextMeshProUGUI textoVida;

    public void Start()
    {
        Enemy = GameObject.FindWithTag("Enemy").GetComponent<Enemy>();
        vitalidade = 10;
        forca = 5;
    }

    public void dealAttack()
    {
        Enemy.modStatus("vitalidade", -forca);
        Debug.Log("Vida Inimigo: " + Enemy.Vitalidade);
    }

    void Update()
    {
        if (vitalidade <= 0)
        {
            myCanvas.enabled = true;
            Time.timeScale = 0;
            textoFinal.text = "Voce Perdeu.";
        }
        textoVida.text = "Vida: " + vitalidade.ToString();  
    }

}