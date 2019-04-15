package mono.com.flaviofaria.kenburnsview;


public class KenBurnsView_TransitionListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.flaviofaria.kenburnsview.KenBurnsView.TransitionListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onTransitionEnd:(Lcom/flaviofaria/kenburnsview/Transition;)V:GetOnTransitionEnd_Lcom_flaviofaria_kenburnsview_Transition_Handler:ImageViews.KenBurns.KenBurnsView/ITransitionListenerInvoker, KenBurnsView\n" +
			"n_onTransitionStart:(Lcom/flaviofaria/kenburnsview/Transition;)V:GetOnTransitionStart_Lcom_flaviofaria_kenburnsview_Transition_Handler:ImageViews.KenBurns.KenBurnsView/ITransitionListenerInvoker, KenBurnsView\n" +
			"";
		mono.android.Runtime.register ("ImageViews.KenBurns.KenBurnsView+ITransitionListenerImplementor, KenBurnsView", KenBurnsView_TransitionListenerImplementor.class, __md_methods);
	}


	public KenBurnsView_TransitionListenerImplementor ()
	{
		super ();
		if (getClass () == KenBurnsView_TransitionListenerImplementor.class)
			mono.android.TypeManager.Activate ("ImageViews.KenBurns.KenBurnsView+ITransitionListenerImplementor, KenBurnsView", "", this, new java.lang.Object[] {  });
	}


	public void onTransitionEnd (com.flaviofaria.kenburnsview.Transition p0)
	{
		n_onTransitionEnd (p0);
	}

	private native void n_onTransitionEnd (com.flaviofaria.kenburnsview.Transition p0);


	public void onTransitionStart (com.flaviofaria.kenburnsview.Transition p0)
	{
		n_onTransitionStart (p0);
	}

	private native void n_onTransitionStart (com.flaviofaria.kenburnsview.Transition p0);

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
