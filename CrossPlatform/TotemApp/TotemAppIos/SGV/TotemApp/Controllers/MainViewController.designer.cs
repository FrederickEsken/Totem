// WARNING
//
// This file has been generated automatically by Xamarin Studio Community to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace TotemAppIos
{
	[Register ("MainViewController")]
	partial class MainViewController
	{
		[Outlet]
		UIKit.UIButton btnClick { get; set; }

		[Outlet]
		UIKit.UILabel lblClicked { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (btnClick != null) {
				btnClick.Dispose ();
				btnClick = null;
			}

			if (lblClicked != null) {
				lblClicked.Dispose ();
				lblClicked = null;
			}
		}
	}
}
