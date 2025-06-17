using UnityEngine;
using TMPro;
public class Enemy : stats
{
    public Player player;
    public Canvas myCanvas;
    public TextMeshProUGUI textoFinal;
    public TextMeshProUGUI textoVida;


    public void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<Player>();
        vitalidade = 50;
        forca = 2;
    }

    public void dealAttack(int dano)
    {
        player.modStatus("vitalidade", dano);
    }

    void Update()
    {
        if (vitalidade <= 0)
        {
            myCanvas.enabled = true;
            Time.timeScale = 0;
            textoFinal.text = "Voce Venceu!";
        }
        textoVida.text = "Vida: " + vitalidade.ToString();  
    }

}
