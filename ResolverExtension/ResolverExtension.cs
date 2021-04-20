using Tridion.ContentManager;
using Tridion.ContentManager.Publishing;
using Tridion.ContentManager.Publishing.Resolving;
using Tridion.Collections;

namespace ResolverExtension
{
    public class ResolverExtension : IResolver
    {
        #region IResolver Members
        // This Resolve method executes after the default resolver has done its job and produced a set of resolved items.
        public void Resolve(IdentifiableObject item, ResolveInstruction instruction, PublishContext context, ISet<ResolvedItem> resolvedItems)
        {
            //resolvedItems.Add(...);
        }
        #endregion
    }
}
