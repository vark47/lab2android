package md5a823a09e9dcde5d832a3c3652d4e0f9d;


public class Activity2
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("Lab_2.Activity2, Lab 2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", Activity2.class, __md_methods);
	}


	public Activity2 ()
	{
		super ();
		if (getClass () == Activity2.class)
			mono.android.TypeManager.Activate ("Lab_2.Activity2, Lab 2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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
