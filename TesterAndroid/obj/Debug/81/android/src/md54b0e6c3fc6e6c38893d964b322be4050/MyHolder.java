package md54b0e6c3fc6e6c38893d964b322be4050;


public class MyHolder
	extends android.support.v7.widget.RecyclerView.ViewHolder
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("TesterAndroid.MyHolder, TesterAndroid", MyHolder.class, __md_methods);
	}


	public MyHolder (android.view.View p0)
	{
		super (p0);
		if (getClass () == MyHolder.class)
			mono.android.TypeManager.Activate ("TesterAndroid.MyHolder, TesterAndroid", "Android.Views.View, Mono.Android", this, new java.lang.Object[] { p0 });
	}

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
