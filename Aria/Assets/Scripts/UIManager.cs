using UnityEngine;
using System.Collections;
using VIDE_Data;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    public GameObject container_NPC;
    public GameObject container_PLAYER;
    public Text text_NPC;
    public Text[] text_Choices;

    void Start () {
    
    }

    void Update () {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (!VD.isActive)
            {
                Begin();
            }
        }
    }

    void Begin()
    {
        VD.OnNodeChange += UpdateUI;
        VD.OnEnd += End;
        VD.BeginDialogue(GetComponent<VIDE_Assign>());
    }

    void UpdateUI(VD.NodeData data)
    {
    
    }

    void End(VD.NodeData data)
    {
        VD.OnNodeChange -= UpdateUI;
        VD.OnEnd -= End;
        VD.EndDialogue();
    }

    void OnDisable()
    {
        if (container_NPC != null)
            End(null);
    }
}
