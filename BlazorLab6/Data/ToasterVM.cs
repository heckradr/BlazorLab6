namespace BlazorLab6.Data
{
    public class ToasterVM
    {
        public List<ToastItem> Toasts { get; set; }

        public event Action OnToastsUpdated;

        public ToasterVM()
        {
            Toasts = new List<ToastItem>();
        }

        public void Add(ToastItem _item)
        {
            Toasts.Add(_item);
            OnToastsUpdated?.Invoke();
        }

        public void Remove(ToastItem _item)
        {
            Toasts.Remove(_item);
            OnToastsUpdated?.Invoke();
        }
    }
}
