using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMeneger : MonoBehaviour
{
    [SerializeField] private Animator initiallyOpen;

    private Animator open;
    private int openParameterId;

    const string openTransitionName = "Open";
    const string closedStateName = "Close";

    public void Start()
    {
        openParameterId = Animator.StringToHash(openTransitionName);

        if (initiallyOpen == null)
            return;

        OpenPanel(initiallyOpen);
    }

    public void OpenPanel(Animator anim) 
    {
        if(open == anim)
            return ;

        anim.gameObject.SetActive(true);

        anim.transform.SetAsLastSibling();
        CloseCurrent();

        open = anim;
        open.SetBool(openParameterId, true);
    }

    public void CloseCurrent() 
    {
        if (open == null)
            return;

        open.SetBool(openParameterId, false);
        StartCoroutine(DisablePanelDeleyed(open));
        open = null;
    }

    IEnumerator DisablePanelDeleyed(Animator anim) 
    {
        bool closedStateReached = false;
        bool wantToClose = true;

        while(!closedStateReached && wantToClose) 
        {
            if (!anim.IsInTransition(0))
                closedStateReached = anim.GetCurrentAnimatorStateInfo(0).IsName(closedStateName);
            wantToClose = !anim.GetBool(openParameterId);

            yield return new WaitForEndOfFrame();
        }

        if(wantToClose)
            anim.gameObject.SetActive(false);
    }
}
