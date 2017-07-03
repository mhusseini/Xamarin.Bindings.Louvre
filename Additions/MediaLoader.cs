
namespace Com.Andremion.Louvre.Data
{
    public partial class MediaLoader
    {
        public void OnLoadFinished(Android.Support.V4.Content.Loader loader, Java.Lang.Object data)
        {
            this.OnLoadFinished(loader, (Android.Database.ICursor)data);
        }
    }
}