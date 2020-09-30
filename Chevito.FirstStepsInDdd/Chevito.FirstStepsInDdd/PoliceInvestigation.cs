using System;
using System.Collections.ObjectModel;

namespace Chevito.FirstStepsInDdd
{
    public class PoliceInvestigation
    {
        public Collection<Suspect> Suspects = new Collection<Suspect>();

        public PoliceInvestigation(PNCId pncId, Suspect suspect)
        {
            if (pncId == null)
                throw new ArgumentNullException(nameof(pncId));

            if (suspect == null)
                throw new ArgumentNullException(nameof(suspect));

            PNCId = pncId;
            Suspects.Add(suspect);
        }

        public PNCId PNCId { get; }
    }
}