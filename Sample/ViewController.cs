using System;
using Foundation;
using UIKit;
using System.Collections.Generic;
using CoreGraphics;
using MorphingLabel;

namespace MorphingView
{
    public partial class ViewController : UIViewController
    {
        public ViewController() : base("ViewController", null)
        {
        }

        public List<string> aaList = new List<string>
        {
            "asdas",
            "fjdgk g",
            "dgfsdghgf",
            "qqethgds",
            "hgf"
        };

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            var label = new TOMSMorphingLabel();
            label.MorphingEnabled = true;
            label.AnimationDuration = 1f;
            label.CharacterAnimationOffset = 5f;
            label.CharacterShrinkFactor = 2f;
            label.TextAlignment = UITextAlignment.Center;
            label.Frame = new CGRect(View.Bounds.GetMidX() - 100, View.Bounds.GetMidY() - 50, 200, 100);
            label.Text = "asdas";
            View.AddSubview(label);
            var b = 0;
            var tapGesture = new UITapGestureRecognizer(() =>
            {
                b++;
                label.Text = aaList[b];
            });

            this.View.AddGestureRecognizer(tapGesture);
        }
    }
}