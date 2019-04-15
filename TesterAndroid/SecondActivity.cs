using System;
using System.Collections.Generic;

using Android.App;
using Android.OS;
using Android.Support.V7.Widget;

namespace TesterAndroid
{
    [Activity(Label = "SecondActivity")]
    public class SecondActivity : Activity   {

        ItemAdapter mAdapter;
        //int[] image = {Resource.Drawable.abc_btn_radio_material,Resource.Drawable.abc_ic_star_black_16dp };
        string[] des = {"Java","CallBack_Url","Laravel","MongoDb","Django" };
        List<String> dataSet;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            //dataSet = new ArrayList();
            mAdapter = new ItemAdapter(this, des);

            // Create your application here
            SetContentView(Resource.Layout.activity_second);

            RecyclerView list = FindViewById<RecyclerView> (Resource.Id.list_cycle);
            list.SetAdapter(mAdapter);
            list.SetLayoutManager(new LinearLayoutManager(this, LinearLayoutManager.Vertical, false));
        }
    }
}