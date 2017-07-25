using System.Collections.ObjectModel;
using Android.Content;
using Android.Views;
using Android.Widget;
using WUG.Client.Shared.ViewModels.Entity;

namespace WUG.Client.Droid.Adapters
{
    public class EventInfosAdapter : BaseAdapter<EventInfoViewModel>
    {
        private readonly ObservableCollection<EventInfoViewModel> _eventInfos;
        private readonly LayoutInflater _inflater;

        public EventInfosAdapter(Context context, ObservableCollection<EventInfoViewModel> eventInfos)
        {
            _eventInfos = eventInfos;
            _inflater = LayoutInflater.From(context);
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView;
            if (_eventInfos != null)
            {
                EventInfoViewModel eventInfo = _eventInfos[position];

                view = _inflater.Inflate(Resource.Layout.EventInfoListViewItem, parent, false);

                view.FindViewById<TextView>(Resource.Id.EventInfoTitle).Text = eventInfo.Name;
                view.FindViewById<TextView>(Resource.Id.EventInfoBranch).Text = eventInfo.BranchName;
                view.FindViewById<TextView>(Resource.Id.EventInfoDate).Text = eventInfo.TakePlaceFromDay.ToString();
            }
            return view;
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override int Count => _eventInfos?.Count ?? 0;

        public override EventInfoViewModel this[int position] => _eventInfos[position];
    }
}