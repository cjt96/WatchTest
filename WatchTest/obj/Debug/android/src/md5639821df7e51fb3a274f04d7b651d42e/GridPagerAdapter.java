package md5639821df7e51fb3a274f04d7b651d42e;


public class GridPagerAdapter
	extends android.support.wearable.view.FragmentGridPagerAdapter
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_getRowCount:()I:GetGetRowCountHandler\n" +
			"n_getColumnCount:(I)I:GetGetColumnCount_IHandler\n" +
			"n_getFragment:(II)Landroid/app/Fragment;:GetGetFragment_IIHandler\n" +
			"";
		mono.android.Runtime.register ("WatchTest.GridPagerAdapter, WatchTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", GridPagerAdapter.class, __md_methods);
	}


	public GridPagerAdapter (android.app.FragmentManager p0) throws java.lang.Throwable
	{
		super (p0);
		if (getClass () == GridPagerAdapter.class)
			mono.android.TypeManager.Activate ("WatchTest.GridPagerAdapter, WatchTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.App.FragmentManager, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}


	public int getRowCount ()
	{
		return n_getRowCount ();
	}

	private native int n_getRowCount ();


	public int getColumnCount (int p0)
	{
		return n_getColumnCount (p0);
	}

	private native int n_getColumnCount (int p0);


	public android.app.Fragment getFragment (int p0, int p1)
	{
		return n_getFragment (p0, p1);
	}

	private native android.app.Fragment n_getFragment (int p0, int p1);

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
