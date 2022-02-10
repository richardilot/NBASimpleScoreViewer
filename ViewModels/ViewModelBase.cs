using ReactiveUI;

namespace NBAScore.ViewModels
{
    public class ViewModelBase : ReactiveObject
    {
        public delegate void HandleNavigation(string view);

        public event HandleNavigation? Handler;

        public void NavigateTo(string view)
        {
            Handler?.Invoke(view);
        }
    }
}
