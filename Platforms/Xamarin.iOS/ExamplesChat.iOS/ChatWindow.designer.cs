// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace ExamplesChat.iOS
{
	[Register ("ChatWindow")]
	partial class ChatWindow
	{
		[Outlet]
		MonoTouch.UIKit.UITextView ChatHistory { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIBarButtonItem MessageBox { get; set; }

		[Action ("SendClick:")]
		partial void SendClick (MonoTouch.Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (ChatHistory != null) {
				ChatHistory.Dispose ();
				ChatHistory = null;
			}

			if (MessageBox != null) {
				MessageBox.Dispose ();
				MessageBox = null;
			}
		}
	}
}
