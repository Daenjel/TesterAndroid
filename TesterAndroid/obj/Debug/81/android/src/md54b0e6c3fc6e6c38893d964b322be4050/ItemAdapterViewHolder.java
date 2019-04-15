package md54b0e6c3fc6e6c38893d964b322be4050;


public class ItemAdapterViewHolder
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("TesterAndroid.ItemAdapterViewHolder, TesterAndroid", ItemAdapterViewHolder.class, __md_methods);
	}


	public ItemAdapterViewHolder ()
	{
		super ();
		if (getClass () == ItemAdapterViewHolder.class)
			mono.android.TypeManager.Activate ("TesterAndroid.ItemAdapterViewHolder, TesterAndroid", "", this, new java.lang.Object[] {  });
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
