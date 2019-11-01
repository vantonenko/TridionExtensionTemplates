using Tridion.ContentManager.ContentManagement;
using Tridion.ContentManager.Extensibility;
using Tridion.ContentManager.Extensibility.Events;

namespace EventSystemExtension
{
    [TcmExtension("EventSystemExtension")]
    public class EventSystemExtension : TcmExtension
    {
        public EventSystemExtension()
        {
            Subscribe();
        }

        private void Handler(RepositoryLocalObject item, SaveEventArgs args, EventPhases phase)
        {
            // perform custom action when saving
            // in our case adding the suffix to the item title
            item.Title = $"{item.Title}_SampleExtensionSuffix";
        }

        public void Subscribe()
        {
            // subscribe for saving event
            EventSystem.Subscribe<RepositoryLocalObject, SaveEventArgs>(Handler, EventPhases.Initiated);
        }
    }
}