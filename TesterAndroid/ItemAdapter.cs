using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;

namespace TesterAndroid
{
    class ItemAdapter : RecyclerView.Adapter
    {

        Context context;
        //int[] image;
        string[] des;

        public ItemAdapter(Context context, string[] des)
        {
            this.context = context;
            //this.image = image;
            this.des = des;
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View itemView = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.card_item, parent, false);
            MyHolder vh = new MyHolder(itemView);
            return vh;
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            MyHolder vh = holder as MyHolder;
            //vh.Image.SetImageResource(mPhotoAlbum[position].PhotoID);
            vh.Caption.Text = des[position];
        }

        public override int ItemCount
        {
            get { return des.Length; }
        }
    }

    class ItemAdapterViewHolder : Java.Lang.Object
    {
        //Your adapter views to re-use
        //public TextView Title { get; set; }
    }
}