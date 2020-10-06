using UnityEngine;
using UnityEngine.UI;

namespace PaintbucketGames.Menu
{
    public interface IMenu
    {
        Canvas Canvas { get; }
        
        void Open();

        void Initialize();

        void Close();
    }
}
