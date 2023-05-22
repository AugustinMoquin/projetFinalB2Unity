using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace littleDog
{
    // slap this on ennything you whant to intracat with
    public interface Iinteractable
    {
        void PlayAcation();
        void OnFocus(GameObject playerPos);
        void onDeFocus();
        string GetAcationString();
        float GetRadius();
    }
}