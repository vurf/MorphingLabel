
using System;

using Foundation;
using UIKit;
using System.Collections.Generic;
using CoreGraphics;
using MorphingToDo;

namespace MorphingView
{
	public partial class ViewController : UIViewController
	{
		public ViewController () : base ("ViewController", null)
		{
		}

		public List<string> aaList = new List<string>{
			"asdas",
			"fjdgk g",
			"dgfsdghgf",
			"qqethgds",
			"hgf"
		};
		private TOMSMorphingLabel aa;
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			aa = new TOMSMorphingLabel ();
			aa.MorphingEnabled = true;
			aa.AnimationDuration = 1f;
			aa.CharacterAnimationOffset = 5f;
			aa.CharacterShrinkFactor = 2f;

			aa.TextAlignment = UITextAlignment.Center;

			aa.Frame = new CGRect (View.Bounds.GetMidX ()-100, View.Bounds.GetMidY ()-50, 200, 100);
			aa.Text = "asdas";
			View.AddSubview (aa);

			var b = 0;

			var gest = new UITapGestureRecognizer (() => {
				b++;
				aa.Text = aaList[b];
			});
			View.AddGestureRecognizer (gest);

		}
	}
}

