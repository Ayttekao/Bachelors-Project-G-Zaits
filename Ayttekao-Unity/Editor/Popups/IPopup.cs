using System.Collections.Generic;

namespace Ayttekao.Unity.Editor
{
    public interface IPopup
    {
        string Id { get; }

        string Title { get; }

        string Content { get; }

        List<PopupLink> Links { get; }
    }
}