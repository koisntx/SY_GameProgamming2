using UnityEngine;

public interface Iinteractable
{
    //No public or private modifier is allowed here bc interface members are public by defenition
    void Interact(GameObject interactor);
}
