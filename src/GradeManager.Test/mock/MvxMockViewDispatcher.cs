using MvvmCross.Base;
using MvvmCross.ViewModels;
using MvvmCross.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GradeManager.Test
{
    /// <summary>
    /// When creating ViewModel or Service test objects, one common requirement is to
    /// provide a mock object which implements both IMvxViewDispatcher and
    /// IMvxMainThreadDispatcher. These interfaces are required for MvvmCross UI thread
    /// marshalling and for MvvmCross ViewModel navigation.
    /// </summary>
    /// <seealso cref="MvvmCross.Base.MvxMainThreadDispatcher" />
    /// <seealso cref="MvvmCross.Views.IMvxViewDispatcher" />
    public class MvxMockViewDispatcher : MvxMainThreadDispatcher, IMvxViewDispatcher
    {
        public readonly List<MvxPresentationHint> Hints = new List<MvxPresentationHint>();
        public readonly List<MvxViewModelRequest> Requests = new List<MvxViewModelRequest>();

        public override bool IsOnMainThread => throw new NotImplementedException();

        public Task<bool> ChangePresentation(MvxPresentationHint hint)
        {
            Hints.Add(hint);
            return Task.FromResult(true);
        }

        public Task ExecuteOnMainThreadAsync(Action action, bool maskExceptions = true)
        {
            action();
            return Task.FromResult(true);
        }

        public Task ExecuteOnMainThreadAsync(Func<Task> action, bool maskExceptions = true)
        {
            action();
            return Task.FromResult(true);
        }

        public override bool RequestMainThreadAction(Action action, bool maskExceptions = true)
        {
            action();
            return true;
        }

        public Task<bool> ShowViewModel(MvxViewModelRequest request)
        {
            Requests.Add(request);
            return Task.FromResult(true);
        }
    }
}